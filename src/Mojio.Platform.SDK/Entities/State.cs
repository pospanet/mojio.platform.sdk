﻿using Mojio.Platform.SDK.Contracts.Entities;
using System;

namespace Mojio.Platform.SDK.Entities
{
    public class State : IState
    {
        public DateTimeOffset Timestamp { get; set; }
        public bool Value { get; set; }
    }
}