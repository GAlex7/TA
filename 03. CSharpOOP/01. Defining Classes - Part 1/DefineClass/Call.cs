namespace DefineClass
{
    using System;  
    class Call
    {
        #region Fields

        private DateTime dayAndTime;
        private string dialledPN;
        private uint duration;

        #endregion

        #region Constructors

        public Call(DateTime date, string phoneNumb, uint duration)
        {
            this.DayAndTime = date;
            //this.Time = DateTime.Parse(time).ToLocalTime();
            this.DialledPN = phoneNumb;
            this.Duration = duration;
        }

        #endregion

        #region Properties
        
        public string Day
        {
            get { return string.Format("{0:d}", this.dayAndTime); }
        }

        public string Time
        {
            get { return string.Format("{0:t}", this.dayAndTime); }
        }

        public DateTime DayAndTime
        {
            get { return this.dayAndTime; }
            set { this.dayAndTime = value; }
        }

        public string DialledPN
        {
            get { return this.dialledPN; }
            set
            {
                int start = value[0] == '+' ? 1 : 0;
                for (int i = start; i < value.Length; i++)
                {
                    if (!Char.IsDigit(value[i]))
                        throw new ArgumentException("It's not a valid phone number!");
                }
                this.dialledPN = value;
            }
        }

        public uint Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }
        
        #endregion
        
    }
}
