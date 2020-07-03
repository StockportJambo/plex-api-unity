plex-api-unity
==============

![.NET Core](https://github.com/jensenkd/plex-api/workflows/.NET%20Core/badge.svg)

Why this fork?
--------------
The purpose of this fork is to utilise this excellent library within Unity 3D. There are a number of issues
with using external .NET assemblies within Unity, and this fork is intended to solve all of them and create
a new NuGet package which targets Unity directly.

I got fed up with Plex not supporting VR headsets besides toy ones like GearVR and Oculus Go, so this is
intended to be used in a larger project to create a fully featured Plex client for Rift/Quest/Vive etc.


Overview
--------
Unofficial c# bindings for the Plex Media Server API. Our goal is to match all capabilities of the official
Plex Web Client. A few of the many features we currently support are:

* Navigate local or remote shared libraries.
* Perform library actions such as scan, analyze, empty trash.
* Remote control and play media on connected clients.
* Listen in on all Plex Server notifications.


Installation & Documentation
----------------------------

From Powershell
```c#
    Nuget-Install 'Plex.Api'
```

Dotnet Cli
```c#
    dotnet add package 'Plex.Api'
```

Documentation can be found at Read the Docs.

<coming soon>

Getting a PlexClient Instance
-----------------------------

There are two types of authentication. If you are running on a separate network
or using Plex Users you can log into MyPlex to get a PlexServer instance. An
example of this is below. NOTE: Servername below is the name of the server (not
the hostname and port).  If logged into Plex Web you can see the server name in
the top left above your available libraries.

```c#

    // Create Client Options
    var apiOptions = new ClientOptions
    {
        Product = "API_UnitTests",
        DeviceName = "API_UnitTests",
        ClientId = "MyClientId",
        Platform = "Web",
        Version = "v1"
    };

    // Create DI Provider
    var services = new ServiceCollection();
    services.AddLogging();
    services.AddSingleton(apiOptions);
    services.AddTransient<IPlexClient, PlexClient>();
    services.AddTransient<IApiService, ApiService>();
    services.AddTransient<IPlexRequestsHttpClient, PlexRequestsHttpClient>();
    ServiceProvider = services.BuildServiceProvider();
```    

If you want to avoid logging into MyPlex and you already know your auth token
string, you can use the PlexServer object directly as above, but passing in
the baseurl and auth token directly.

Server

```c#

    var plexApi = ServiceProvider.GetService<IPlexClient>();
    
    var user = plexApi
        .SignIn(login, password).Result;
        
    // Get Account
    var user = plexApi.GetAccount(string authToken).Result;
          
    // Get Servers
    var servers = plexApi.GetServers(string authToken).Result;
    
    // Get Friends
    var friends = plexApi.GetFriends(string authToken).Result;
    
    // Get Resources
    var resources = plexApi.GetResources(string authToken).Result;
    
```

Libraries

```c#

    var plexApi = ServiceProvider.GetService<IPlexClient>();
    
    // Get Recently Added for Library
    var recentlyAdded = plexApi.GetRecentlyAdded(string authToken, string plexServerHost, string libraryKey).Result;
    
    // Get Libraries
    var libraries = plexApi.GetLibraries(string authToken, string plexServerHost).Result;
    
    // Get Library
    var library = plexApi.GetLibrary(string authToken, string plexServerHost, string libraryKey).Result;

```

Metadata

```c#

    var plexApi = ServiceProvider.GetService<IPlexClient>();
         
    // Get Metadata for Library
    var metadatas = plexApi.MetadataForLibrary(string authToken, string plexServerHost, string libraryKey).Result;
  
    // Get Children for Metadata by Metadata Key
    var metadatas = plexApi.GetChildrenMetadata(string authToken, string plexServerHost, int metadataKey).Result;

    // Get Metadata by Key
    var metadata = plexApi.GetMetadata(string authToken, string plexServerHost, int metadataKey).Result;    
```

Sessions

```c#

    var plexApi = ServiceProvider.GetService<IPlexClient>();
    
    // Get All Sessions on Server
    var sessions = plexApi.GetSessions(string authToken, string plexServerHost).Result;
    
    // Get Session for Player Machine Id
    var session = plexApl.GetSessionByPlayerId(string authToken, string plexServerHost, string playerKey).Result;
```


Collections

```c#

    var plexApi = ServiceProvider.GetService<IPlexClient>();
    
    // Get Collections for Library
    var collections = plexApi
        .GetCollections(authKey, plexServerUrl, libraryKey).Result;
        
    // Get Collection Tags for Movie
    var collectionTags = plexApi.GetCollectionTagsForMovie(authKey, plexServerUrl, movieKey).Result;
        
    // Get Collection
    var collection = plexApi.GetCollection(authKey, plexServerUrl, collectionKey).Result;    
    
    // Get Collection Movies
    var movies = plexApi.GetCollectionMovies(authKey, plexServerUrl, collectionKey).Result;

    // Delete Collection from Movie
    plexApi.DeleteCollectionFromMovie(authKey, plexServerUrl, libraryKey, movieKey, collectionName);
    
    // Add Collection to Movie
    plexApi.AddCollectionToMovie(authKey, plexServerUrl, libraryKey, movieKey, collectionName);

    // Update Collection
    var collection = plexApi.GetCollection(authKey, fullUri, collectionRatingKey).Result;
    collection.Title = "New Title for Collection";
    plexApi.UpdateCollection(authKey, plexServerUrl, libraryKey, collection);

```

OAuth Implementation Example

```c#

    public class PlexLoginController : Controller
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private readonly PlexOAuthClient _plexOAuthClient;
        private readonly IPlexClient _plexClient;

        public PlexLoginController(PlexOAuthClient plexOAuthClient, IPlexClient plexClient)
        {
            _plexOAuthClient = plexOAuthClient;
            _plexClient = plexClient;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var redirectUrl = Url.Action("PlexReturn", "PlexLogin", null, Request.Scheme);
            var oauthUrl = await _plexClient.CreateOAuthPin(redirectUrl);
            HttpContext.Session.SetString("PlexOauthId", oauthUrl.Id.ToString());
            return Redirect(oauthUrl.Url);
        }

        public async Task<IActionResult> PlexReturn()
        {
            var oauthId = HttpContext.Session.GetString("PlexOauthId");
            var oAuthPin = await _plexClient.GetAuthTokenFromOAuthPin(oauthId);

            if (string.IsNullOrEmpty(oAuthPin.AuthToken))
                throw new Exception("Plex auth failed.");
            HttpContext.Session.Remove("PlexOauthId");
            HttpContext.Session.SetString("PlexKey", oAuthPin.AuthToken);

            return Redirect("/plex");
        }
    }
```
