﻿using System;
using eZet.EveLib.EveMarketData.Model;
using Newtonsoft.Json;

namespace eZet.EveLib.EveMarketData.JsonConverter {
    public class ItemHistoryJsonConverter : Newtonsoft.Json.JsonConverter {
        public override void WriteJson(JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer) {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
            Newtonsoft.Json.JsonSerializer serializer) {
            var result = new ItemHistory();
            serializer.Converters.Add(new RowCollectionJsonConverter<ItemHistory.ItemHistoryEntry>());
            result.History = serializer.Deserialize<RowCollection<ItemHistory.ItemHistoryEntry>>(reader);
            return result;
        }

        public override bool CanConvert(Type objectType) {
            throw new NotImplementedException();
        }
    }
}