namespace MobilePhone
{
    using System;
    using System.Globalization;

    public class Call
    {
        private DateTime date;
        private DateTime time;
        private string dialledPhoneNumber;
        private int duration;

        public Call(string date, string time, string dialledPhoneNumber, int duration)
        {
            this.Date = DateTime.ParseExact(date, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            this.Time = DateTime.ParseExact(time, "HH:mm:ss", CultureInfo.InvariantCulture);
            this.DialledPhoneNumber = dialledPhoneNumber;
            this.Duration = duration;
        }

        public override string ToString()
        {
            return string.Format("Date: {0}.{1}.{2}, Time: {3}:{4}:{5}, DialledPhoneNumber: {6}, Duration: {7}", this.Date.Day, this.Date.Month, this.Date.Year, this.Time.Hour, this.Time.Minute, this.Time.Second, this.DialledPhoneNumber, this.Duration);
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }

            set
            {
                this.date = value;
            }
        }

        public DateTime Time
        {
            get
            {
                return this.time;
            }

            set
            {
                this.time = value;
            }
        }

        public string DialledPhoneNumber
        {
            get
            {
                return this.dialledPhoneNumber;
            }

            set
            {
                this.dialledPhoneNumber = value;
            }
        }

        public int Duration
        {
            get
            {
                return this.duration;
            }

            set
            {
                this.duration = value;
            }
        }
    }
}