﻿using System;
using System.Net;
using eZet.EveLib.Core.Util;

namespace eZet.EveLib.EveOnline.Util {
    public class WebClientRequestHandler : RequestHandlerBase {
        public WebClientRequestHandler(ISerializer serializer) : base(serializer) {
        }

        public override T Request<T>(Uri uri) {
            DateTime cachedUntil;
            if (CacheExpirationRegister.TryGetValue(uri, out cachedUntil)) {
            }

            var client = new WebClient();

            string data = client.DownloadString(uri);

            throw new NotImplementedException();
        }

        public override void SaveCacheState() {
            throw new NotImplementedException();
        }
    }
}