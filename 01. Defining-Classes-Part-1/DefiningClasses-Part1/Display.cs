namespace DefiningClasses_Part1
{
    using System;
    // Inches and Colors ArgumentException
    public class Display
    {
        private DisplayType displayType;
        private TouchScreenType touchScreenType;
        private int colors;
        private double inches;
        private bool colorSet = false;
        private bool screenTypeSet = false;

        public Display(DisplayType displayType, double inches)
            : base()
        {
            this.DisplayType = displayType;
            this.Inches = inches;
        }

        public Display(DisplayType displayType, double inches, int colors)
            : this(displayType, inches)
        {
            this.Colors = colors;
            this.colorSet = true;
        }
        public Display(DisplayType displayType, double inches, TouchScreenType touchScreenType, int colors)
            : this(displayType, inches, colors)
        {
            this.TouchScreenType = touchScreenType;
            this.screenTypeSet = true;
        }
        public double Inches
        {
            get
            {
                return this.inches;
            }
            private set
            {
                if (value <= 0.0)
                {
                    throw new ArgumentException("Inches are too out of range");
                }
                this.inches = value;
            }
        }
        public int Colors
        {
            get
            {
                if (!this.colorSet)
                {
                    throw new NullReferenceException();
                }
                return this.colors;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("No Colors");
                }
                this.colors = value;
            }
        }
        public TouchScreenType TouchScreenType
        {
            get
            {
                if (!this.screenTypeSet)
                {
                    throw new NullReferenceException();
                }
                return this.touchScreenType;
            }
            private set
            {
                this.touchScreenType = value;
            }
        }
        public DisplayType DisplayType
        {
            get
            {
                return this.displayType;
            }
            private set
            {
                this.displayType = value;
            }
        }
        public override string ToString()
        {
            return String.Format(@"Display: {0}, {1} inches
{2}
{3}", this.DisplayType, this.Inches,
    this.screenTypeSet ? String.Format("Touch screen type: {0}", this.TouchScreenType) : String.Empty,
    this.colorSet ? String.Format("Colors: {0}", this.Colors) : String.Empty).Trim();
        }
    }

    public enum TouchScreenType
    {
        CAPACITIVE,
        RESISTIVE
    }
    public enum DisplayType
    {
        AMOLED,
        CSTN,
        OLED,
        LCD,
        LED,
        TFT,
        TFD
    }
}
