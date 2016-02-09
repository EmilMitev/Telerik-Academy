namespace MobilePhone
{
    using System;

    public class Battery
    {
        // enum
        private BatteryType batteryType;

        // fields
        private string model;
        private int? hoursIdle;
        private int? hoursTalk;

        // properties
        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                this.model = value;
            }
        }

        public int? HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }

            set
            {
                if (value >= 0 || value == null)
                {
                    this.hoursIdle = value;
                }
                else
                {
                    throw new ArgumentException(string.Format("Invalid hoursIdle! HoursIdle must non negative number"));
                }
            }
        }

        public int? HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }

            set
            {
                if (value >= 0 || value == null)
                {
                    this.hoursTalk = value;
                }
                else
                {
                    throw new ArgumentException(string.Format("Invalid hoursTalk! hoursTalk must non negative number"));
                }
            }
        }

        // Constructor
        public Battery()
        {
        }

        public Battery(BatteryType batteryType, int? hoursIdle = null, int? hoursTalk = null)
        {
            this.Model = batteryType.ToString();
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.batteryType = batteryType;
        }

        // override ToString
        public override string ToString()
        {
            return string.Format("Model: {0}, HoursIdle: {1}, HoursTalk: {2}", this.Model, this.HoursIdle, this.HoursTalk);
        }
    }
}