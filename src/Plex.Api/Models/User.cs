﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Plex.Api.Helpers;

namespace Plex.Api.Models
{
    public class PlexAccount
    {
        [JsonProperty("user")]
        public User User { get; set; }
    }

    /// <summary>
    /// Attributes:
    /// SIGNIN (str): 'https://plex.tv/users/sign_in.xml'
    ///     key (str): 'https://plex.tv/users/account.json'
    ///     authenticationToken (str): Unknown.
    ///     certificateVersion (str): Unknown.
    ///     cloudSyncDevice (str): Unknown.
    ///     email (str): Your current Plex email address.
    ///     entitlements (List&lt;str&gt;): List of devices your allowed to use with this account.
    ///     guest (bool): Unknown.
    ///     home (bool): Unknown.
    ///     homeSize (int): Unknown.
    ///     id (str): Your Plex account ID.
    ///     locale (str): Your Plex locale
    ///     mailing_list_status (str): Your current mailing list status.
    ///     maxHomeSize (int): Unknown.
    ///     queueEmail (str): Email address to add items to your `Watch Later` queue.
    ///     queueUid (str): Unknown.
    ///     restricted (bool): Unknown.
    ///     roles: (List&lt;str&gt;) Lit of account roles. Plexpass membership listed here.
    ///     scrobbleTypes (str): Description
    ///     secure (bool): Description
    ///     subscriptionActive (bool): True if your subsctiption is active.
    ///     subscriptionFeatures: (List&lt;str&gt;) List of features allowed on your subscription.
    ///     subscriptionPlan (str): Name of subscription plan.
    ///     subscriptionStatus (str): String representation of `subscriptionActive`.
    ///     thumb (str): URL of your account thumbnail.
    ///     title (str): Unknown. - Looks like an alias for `username`.
    ///     username (str): Your account username.
    ///     uuid (str): Unknown.
    /// </summary>
    public class User
    {
        //[JsonConverter(typeof(IntValueConverter))]
        public int Id { get; set; }

        public string Email { get; set; }
        
        public string Uuid { get; set; }
        
        [JsonProperty("joined_at")]
        public DateTime JoinedAt { get; set; }
        
        public string Username { get; set; }
        
        public string Title { get; set; }
        
        public string Thumb { get; set; }
        
        public bool HasPassword { get; set; }

        [JsonProperty("authentication_token")]
        public string AuthenticationToken { get; set; }
        
        public DateTime? ConfirmedAt { get; set; }
        
        public int? ForumId { get; set; }
        
        public bool RememberMe { get; set; }
        
        [JsonProperty("subscription")]
        public Subscription Subscription { get; set; }
        
        [JsonProperty("roles")]
        public UserRole Roles { get; set; }
        
        [JsonProperty("entitlements")]
        public List<string> Entitlements { get; set; }
    }
}
