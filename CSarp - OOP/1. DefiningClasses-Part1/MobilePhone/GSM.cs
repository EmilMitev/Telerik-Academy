namespace MobilePhone
{
    using System;
    using System.Collections.Generic;

    public class GSM
    {
        // const
        private const int MaxModelLength = 30;
        private const int MaxManufacturerLength = 30;
        private const int MinStringLength = 2;

        // static fields
        private static readonly string IPhone4SValue = @"The iPhone 4S (retroactively stylized with a lowercase 's' as iPhone 4s as of September 2013) is a touchscreen-based smartphone developed, manufactured, and released by Apple Inc. It is the fifth generation of the iPhone,[8] succeeding the iPhone 4 and preceding the iPhone 5. Announced on October 4, 2011 at Apple's Cupertino campus, its media coverage was accompanied by the death of former Apple CEO and co-founder Steve Jobs on the following day.";

        // fields
        private string model;
        private string manufacturer;
        private double? price;
        private string owner;
        private List<Call> historyCall = new List<Call>();

        // instances
        private Battery battery;
        private Display display;

        // static properties
        public static string IPhone4S
        {
            get
            {
                return IPhone4SValue;
            }
        }

        // properties
        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                if (this.IsValidLength(value, MaxModelLength))
                {
                    this.model = value;
                }
                else
                {
                    throw new ArgumentException(string.Format("Invalid model! Model length must be between {0} and {1}", MinStringLength, MaxModelLength));
                }
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
                if (this.IsValidLength(value, MaxManufacturerLength))
                {
                    this.manufacturer = value;
                }
                else
                {
                    throw new ArgumentException(string.Format("Invalid manufacturer! Manufacturer length must be between {0} and {1}", MinStringLength, MaxManufacturerLength));
                }
            }
        }

        public double? Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value >= 0)
                {
                    this.price = value;
                }
                else
                {
                    throw new ArgumentException(string.Format("Invalid price! Price must non negative number"));
                }
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

        public List<Call> HistoryCall
        {
            get
            {
                return this.historyCall;
            }

            set
            {
                this.historyCall = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }

            set
            {
                this.display = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }

            set
            {
                this.battery = value;
            }
        }

        // Constructor
        public GSM()
        {
        }

        public GSM(string model, string manufacturer, Battery bat, Display dis, double? price = null, string owner = null)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = bat;
            this.Display = dis;
        }

        // overrude ToString()
        public override string ToString()
        {
            return string.Format(
                @"Model: {0}, Manufacturer: {1}, Price: {2}, Owner: {3}
                Battery: {4}
                Display: {5}",
                this.Model, this.Manufacturer, this.Price, this.Owner, this.Battery.ToString(), this.Display.ToString());
        }

        // Methods
        public void AddCalls(Call call)
        {
            this.HistoryCall.Add(call);
        }

        public void DeleteCalls(int index)
        {
            if (index != -1)
            {
                this.HistoryCall.RemoveAt(index);
            }
        }

        public void ClearCallHistory()
        {
            this.HistoryCall.Clear();
        }

        public decimal TotalPriceOfTheCallHistory(decimal callPrice)
        {
            decimal entireDuration = 0;
            decimal totalPrice = 0;
            foreach (var item in this.HistoryCall)
            {
                entireDuration += item.Duration;
            }

            totalPrice = (entireDuration / 60) * callPrice;
            return totalPrice;
        }

        private bool IsValidLength(string str, int maxLength)
        {
            if (str.Length > maxLength || str.Length < MinStringLength)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}