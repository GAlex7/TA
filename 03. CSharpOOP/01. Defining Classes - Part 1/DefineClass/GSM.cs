namespace DefineClass
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class GSM
    {
        private const decimal PricePerMinute = 0.37M;

        #region Fields

        private static readonly GSM iPhone4S = new GSM(
             "iPhone 4S", "Apple", 500, "Me!",
            new Battery("Non-removable", BatteryType.LiPol, 200, 8),
            new Display(3.5f, 16000000));

        private string model;
        private string manufacturer;
        private decimal price;
        private string owner = "No name";
        private Battery batteryCharacteristics;
        private Display displayCharacteristics;
        private List<Call> callHistory;

        #endregion

        #region Constructors

        public GSM(string modelGSM, string manifactGSM)
        {
            this.Model = modelGSM;
            this.Manufacturer = manifactGSM;
            this.batteryCharacteristics = new Battery();
            this.displayCharacteristics = new Display();
            this.callHistory = new List<Call>();
        }

        public GSM(string modelGSM, string manifactGSM, decimal priceGSM, string ownerGSM, Battery batt, Display displ)
            : this(modelGSM, manifactGSM)
        {
            this.Price = priceGSM;
            this.Owner = ownerGSM;
            this.batteryCharacteristics = batt;
            this.displayCharacteristics = displ;
            this.callHistory = new List<Call>();
        }

        #endregion

        #region Properties

        public static GSM IPhone4S
        {
            get
            {
                return iPhone4S;
            }
        }

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

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                this.manufacturer = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("It can't be... or it's a gift?!");
                }
                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                this.owner = value;
            }
        }

        public List<Call> CallHistory
        {
            get { return this.callHistory; }
        }

        #endregion

        #region Methods

        public void AddCall(Call call)
        {
            this.callHistory.Add(call);
        }

        public void DeleteCall(int index)
        {
            if (index > this.callHistory.Count || index < 0)
                throw new ArgumentOutOfRangeException();
            this.callHistory.RemoveAt(index);
        }

        public void ClearCalls()
        {
            this.callHistory.Clear();
        }

        public override string ToString()
        {
            var str = new StringBuilder();
            str.AppendFormat("{0} - {1}", manufacturer, model); str.AppendLine();
            str.AppendFormat("Price: {0}", price); str.AppendLine();
            str.AppendFormat("Owner: {0}", owner); str.AppendLine();
            str.AppendFormat("Battery: {0}, {1}, Idle: {2}, Talk: {3}", batteryCharacteristics.Model, batteryCharacteristics.Type,
                batteryCharacteristics.HoursIdle, batteryCharacteristics.HoursTalk); str.AppendLine();
            str.AppendFormat("Display: {0} inches - {1} colors", displayCharacteristics.Size, displayCharacteristics.Colors);
            return str.ToString();
        }

        public decimal TotalPrice()
        {
            decimal sum = 0;
            foreach (var call in this.CallHistory)
            {
                sum += call.Duration / 60.0M * PricePerMinute;
            }
            return sum;
        }

        public void PrintCallsHistory()
        {
            Console.WriteLine("History:");
            if (this.CallHistory.Count == 0)
            {
                Console.WriteLine("The call history is empty.");
            }
            else
            {
                foreach (var call in this.CallHistory)
                {
                    Console.WriteLine("{0,15} / {1,5} -> {2,15} - {3,5}", call.Day, call.Time, call.DialledPN, call.Duration);
                }
            }
        }

        #endregion
    }
}