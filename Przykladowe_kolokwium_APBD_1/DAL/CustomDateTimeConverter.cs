﻿using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Przykladowe_kolokwium_APBD_1.DAL
{
    public class CustonDateTimeConverter : JsonConverter<DateTime>
    {
        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return DateTime.Parse(reader.GetString());
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToLocalTime().ToString("yyyy-MM-dd"));
        }
    }
}