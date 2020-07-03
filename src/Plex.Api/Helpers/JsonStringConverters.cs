using System;
using System.Buffers;
using System.Buffers.Text;
using Newtonsoft.Json;
using UnityEngine;

namespace Plex.Api.Helpers
{
    // I think Newtonsoft will handle all of these by default, but let's see...

    //public class LongValueConverter : JsonConverter
    //{
    //    public override bool CanConvert(Type objectType) => throw new NotImplementedException();

    //    public override long Read(ref Utf8JsonReader reader, Type type, JsonSerializerOptions options)
    //    {
    //        if (reader.TokenType == JsonToken.String)
    //        {
    //            // try to parse number directly from bytes
    //            ReadOnlySpan<byte> span = reader.HasValueSequence ? reader.ValueSequence.ToArray() : reader.ValueSpan;
    //            if (Utf8Parser.TryParse(span, out long number, out int bytesConsumed) && span.Length == bytesConsumed)
    //                return number;

    //            // try to parse from a string if the above failed, this covers cases with other escaped/UTF characters
    //            if (Int64.TryParse(reader.GetString(), out number))
    //                return number;
    //        }

    //        // fallback to default handling
    //        return reader.GetInt64();
    //    }

    //    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) => throw new NotImplementedException();

    //    public override void Write(Utf8JsonWriter writer, long value, JsonSerializerOptions options)
    //    {
    //        writer.WriteStringValue(value.ToString());
    //    }

    //    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) => throw new NotImplementedException();
    //}

    //public class DoubleValueConverter : JsonConverter<double>
    //{
    //    public override double Read(ref Utf8JsonReader reader, Type type, JsonSerializerOptions options)
    //    {
    //        if (reader.TokenType == JsonToken.String)
    //        {
    //            // try to parse number directly from bytes
    //            ReadOnlySpan<byte> span = reader.HasValueSequence ? reader.ValueSequence.ToArray() : reader.ValueSpan;
    //            if (Utf8Parser.TryParse(span, out double number, out int bytesConsumed) && span.Length == bytesConsumed)
    //                return number;

    //            // try to parse from a string if the above failed, this covers cases with other escaped/UTF characters
    //            if (double.TryParse(reader.GetString(), out number))
    //                return number;
    //        }

    //        // fallback to default handling
    //        return reader.GetDouble();
    //    }

    //    public override void Write(Utf8JsonWriter writer, double value, JsonSerializerOptions options)
    //    {
    //        writer.WriteStringValue(value.ToString());
    //    }
    //}
    
    //public class IntValueConverter : JsonConverter<int>
    //{
    //    public override int Read(ref Utf8JsonReader reader, Type type, JsonSerializerOptions options)
    //    {
    //        if (reader.TokenType == JsonToken.String)
    //        {
    //            // try to parse number directly from bytes
    //            ReadOnlySpan<byte> span = reader.HasValueSequence ? reader.ValueSequence.ToArray() : reader.ValueSpan;
    //            if (Utf8Parser.TryParse(span, out int number, out int bytesConsumed) && span.Length == bytesConsumed)
    //                return number;

    //            // try to parse from a string if the above failed, this covers cases with other escaped/UTF characters
    //            if (int.TryParse(reader.GetString(), out number))
    //                return number;
    //        }

    //        // fallback to default handling
    //        return reader.GetInt32();
    //    }

    //    public override void Write(Utf8JsonWriter writer, int value, JsonSerializerOptions options)
    //    {
    //        writer.WriteStringValue(value.ToString());
    //    }
    //}
    
    //public class BooleanValueConverter : JsonConverter<bool>
    //{
    //    public override bool Read(ref Utf8JsonReader reader, Type type, JsonSerializerOptions options)
    //    {
    //        if (reader.TokenType == JsonTokenType.String)
    //        {
    //            if (string.Equals("1", reader.GetString(), StringComparison.OrdinalIgnoreCase) ||
    //                string.Equals("0", reader.GetString(), StringComparison.OrdinalIgnoreCase))
    //            {
    //                return Convert.ToBoolean(Convert.ToInt16(reader.GetString()));
    //            }
                
    //            // try to parse number directly from bytes
    //            ReadOnlySpan<byte> span = reader.HasValueSequence ? reader.ValueSequence.ToArray() : reader.ValueSpan;
    //            if (Utf8Parser.TryParse(span, out bool boolean, out int bytesConsumed) && span.Length == bytesConsumed)
    //                return boolean;

    //            // try to parse from a string if the above failed, this covers cases with other escaped/UTF characters
    //            if (bool.TryParse(reader.GetString(), out boolean))
    //                return boolean;
    //        }

    //        // fallback to default handling
    //        return reader.GetBoolean();
    //    }

    //    public override void Write(Utf8JsonWriter writer, bool value, JsonSerializerOptions options)
    //    {
    //        writer.WriteStringValue(value.ToString());
    //    }
    //}
}