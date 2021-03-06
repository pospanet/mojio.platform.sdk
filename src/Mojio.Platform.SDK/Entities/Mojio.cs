﻿using Mojio.Platform.SDK.Contracts.Entities;
using System;
using System.Collections.Generic;

namespace Mojio.Platform.SDK.Entities
{
    public class Mojio : IMojio
    {
        public string Name { get; set; }
        public string IMEI { get; set; }
        public DateTimeOffset LastContactTime { get; set; }
        public DateTimeOffset GatewayTime { get; set; }
        public Guid VehicleId { get; set; }
        public IList<string> Tags { get; set; }
        public string ICCID { get; set; }
        public Guid OwnerId { get; set; }
        public Guid Id { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public DateTimeOffset LastModified { get; set; }
        public IDictionary<string, string> Links { get; set; }
    }
}