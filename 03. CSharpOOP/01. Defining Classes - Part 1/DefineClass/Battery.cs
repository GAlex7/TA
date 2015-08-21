namespace DefineClass
{
    using System;

    public enum BatteryType
    {
        LiPol,
        LiIon,
        NiMH,
        NiCd,
    }

    class Battery
    {
        public const uint minHour = 1;
        public const uint maxTalkHour = 50;
        public const string unknown = "unknown";

        private string model;
        private BatteryType type;
        private uint hoursIdle;
        private uint hoursTalk;

        // Parameterless constructor
        public Battery()
            : this(unknown, BatteryType.NiMH, minHour, minHour)
        {
        }

        // Constructor with parameters
        public Battery(string battModel)
            : this(battModel, BatteryType.NiMH, minHour, minHour)
        {
            this.Model = battModel;
        }

        public Battery(string battModel, BatteryType battType, uint idleTime, uint talkTime)
        {
            this.Model = battModel;
            this.type = battType;
            this.HoursIdle = idleTime;
            this.HoursTalk = talkTime;
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public BatteryType Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public uint HoursIdle
        {
            get { return this.hoursIdle; }
            set { this.hoursIdle = value; }
        }

        public uint HoursTalk
        {
            get { return this.hoursTalk; }
            set 
            {
                if (value>maxTalkHour)
                {
                    throw new ArgumentOutOfRangeException("No way! Talk time can't be more than "+ maxTalkHour+" hours.");
                }
                this.hoursTalk = value; 
            }
        }
    }
}
