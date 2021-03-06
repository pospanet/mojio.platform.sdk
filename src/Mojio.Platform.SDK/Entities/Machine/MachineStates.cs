﻿using Mojio.Platform.SDK.Contracts.Entities;
using Mojio.Platform.SDK.Contracts.Machine;
using System;
using System.Collections.Generic;

namespace Mojio.Platform.SDK.Entities.Machine
{
    public class MachineStates : IMachineStates
    {
        public string Title { get; set; }
        public int Duration { get; set; }
        public IMinMax DurationLimit { get; set; }
        public int NoOfVehicleStates { get; set; }
        public IMinMax RPM { get; set; }
        public IMinMax Speed { get; set; }
        public IMinMax Fuel { get; set; }
        public IMinMax FuelEfficiency { get; set; }
        public IMinMax Battery { get; set; }
        public IPoints Points { get; set; }
        public bool CircularTrip { get; set; }
        public IList<IVehicleState> VehicleStates { get; set; }
    }

    public class MinMax : IMinMax
    {
        public int Min { get; set; }
        public int Max { get; set; }
    }

    public class Points : IPoints
    {
        public float[] Start { get; set; }
        public float[] End { get; set; }
        public float[] WayPoint { get; set; }
    }

    public class VehicleState : IVehicleState
    {
        public Guid MessageId { get; set; }
        public IVehicle Vehicle { get; set; }
        public IMachineTelematicDevice TelematicDevice { get; set; }
    }
}