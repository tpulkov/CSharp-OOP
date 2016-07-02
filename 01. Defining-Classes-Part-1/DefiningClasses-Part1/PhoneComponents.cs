namespace DefiningClasses_Part1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PhoneComponents
    {
        private static readonly PhoneComponents iPhone4s = new PhoneComponents(
            Manufacturer.APPLE, "iPhone 4s",
            new Battery(BatteryType.Li_Poly, 2915, 384, 24),
            new Display(DisplayType.LCD, 3.5, TouchScreenType.CAPACITIVE, 16000000),
            OS.IOS);
        private string model;
        private Manufacturer manufacturer;
        private Display display;
        private bool displaySet = false;
        private Battery battery;
        private bool batterySet = false;
        private OS oS;
        private bool OSSet = false;
        private List<Call> calls = new List<Call>();

        public PhoneComponents(Manufacturer manufacturer, string model)
            : base()
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
        }
        public PhoneComponents(Manufacturer manufacturer, string model, OS os)
            : this(manufacturer, model)
        {
            this.OSSet = true;
            this.OS = os;
        }
        public PhoneComponents(Manufacturer manufacturer, string model, Battery battery)
            : this(manufacturer, model)
        {
            this.Battery = battery;
        }
        public PhoneComponents(Manufacturer manufacturer, string model, Display display)
            : this(manufacturer, model)
        {
            this.Display = display;
        }
        public PhoneComponents(Manufacturer manufacturer, string mode, Battery battery, Display display, OS os)
            : this(manufacturer, mode)
        {
            this.Display = display;
            this.Battery = battery;
            this.OS = os;
        }
        public Manufacturer Manufacturer
        {
            get
            {
                if (this.manufacturer.Equals(null))
                {
                    throw new NullReferenceException();
                }
                return this.manufacturer;
            }
            private set
            {
                this.manufacturer = value;
            }
        }
        public string Model
        {
            get
            {
                if (String.IsNullOrEmpty(this.model))
                {
                    throw new NullReferenceException();
                }
                return this.model;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Model");
                }
                this.model = value;
            }
        }
        public OS OS
        {
            get
            {
                if (this.oS.Equals(null))
                {
                    throw new NullReferenceException();
                }
                return this.oS;
            }
            private set
            {
                this.oS = value;
                this.OSSet = true;
            }
        }
        public Battery Battery
        {
            get
            {
                if (this.battery.Equals(null))
                {
                    throw new NullReferenceException();
                }
                return this.battery;
            }
            private set
            {
                this.battery = value;
                this.batterySet = true;
            }
        }
        public Display Display
        {
            get
            {
                if (this.display.Equals(null))
                {
                    throw new NullReferenceException();
                }
                return this.display;
            }
            private set
            {
                this.display = value;
                this.displaySet = true;
            }
        }

        public static PhoneComponents IiPhone4s
        {
            get
            {
                return iPhone4s;
            }
        }

        public decimal GetTottalPriceCalls(decimal pricePerMinute)
        {
            decimal allCallsInSeconds = (decimal)(this.calls.Select
                (x => x.Duration).Sum());
            return pricePerMinute * (allCallsInSeconds / 60.0m);
        }

        public List<Call> CallHistory
        {
            get
            {
                return new List<Call>(this.calls);
            }
        }
        public void AddCalls(Call call)
        {
            this.calls.Add(call);
        }
        public void DeleteCall(Call call)
        {
            this.calls.Add(call);
        }
        public void DeleteCallHistory()
        {
            this.calls.Clear();
        }
        public override string ToString()
        {
            return String.Format(@"
{0} {1} {2} {3} {4}", this.Manufacturer, this.Model,
            this.OSSet ? String.Format("{1}\t(OS: {0})", this.OS, Environment.NewLine) : String.Empty,
            !this.batterySet ? String.Empty : String.Format("{0}{0}{1}", Environment.NewLine, this.Battery.ToString()),
            !this.displaySet ? String.Empty : String.Format("{0}{0}{1}", Environment.NewLine, this.Display.ToString()))
            .Trim();
        }
    }
    public enum OS
    {
        ANDROID,
        IOS,
        SYMBIAN,
        WINDOWS,
        OTHER
    }
    public enum Manufacturer
    {
        ACER,
        ALCATEL,
        APPLE,
        ASUS,
        BLACKBERRY,
        CAT,
        GOOGLE,
        HTC,
        HUAWEI,
        LENOVO,
        LG,
        NOKIA,
        MICROSOFT,
        MOTOROLA,
        SAMSUNG,
        SONY,
        XIAOMI,
        Other
    }
}
