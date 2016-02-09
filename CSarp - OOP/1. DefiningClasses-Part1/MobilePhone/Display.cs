namespace MobilePhone
{
    using System;

    public class Display
    {
        // fields
        private double? size;
        private int? numberOfColors;

        // properties
        public double? Size
        {
            get
            {
                return this.size;
            }

            set
            {
                if (value >= 0 || value == null)
                {
                    this.size = value;
                }
                else
                {
                    throw new ArgumentException(string.Format("Invalid size! size must non negative number"));
                }
            }
        }

        public int? NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }

            set
            {
                if (value >= 0 || value == null)
                {
                    this.numberOfColors = value;
                }
                else
                {
                    throw new ArgumentException(string.Format("Invalid number Of Colors! Number Of Colors must non negative number"));
                }
            }
        }

        // Constructors
        public Display()
        {
        }

        public Display(double? size = null, int? numberOfColors = null)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }

        // override ToString()
        public override string ToString()
        {
            return string.Format("Size: {0}, NumberOfColors: {1}", this.Size, this.NumberOfColors);
        }
    }
}