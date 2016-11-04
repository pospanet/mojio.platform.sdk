﻿using System.Collections.Generic;
using Mojio.Platform.SDK.Contracts.Push;

namespace Mojio.Platform.SDK.Entities.Observers
{
    public class GetPushObserversResponse : IGetPushObserversResponse
    {
        public int CurrentResults { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }
        public int Offset { get; set; }
        public int Limit { get; set; }
        public string Query { get; set; }
        public IList<IPushObserverResponse> Data { get; set; }
        public IDictionary<string, string> Links { get; set; }
    }
}