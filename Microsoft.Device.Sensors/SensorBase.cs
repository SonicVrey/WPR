﻿using System;

namespace Microsoft.Devices.Sensors
{
    public abstract class SensorBase<TSensorReading> where TSensorReading : ISensorReading
    {
        public event EventHandler<SensorReadingEventArgs<TSensorReading>> CurrentValueChanged;
    }
}
