namespace GSMTest
{
    using System;
    using System.Linq;
    using System.Text;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using DefiningClasses_Part1;

    public class PhoneTest
    {
        private PhoneComponents iPhone4s = new PhoneComponents(
            Manufacturer.APPLE, "iPhone 4S",
            new Battery(BatteryType.Li_Ion, 1430, 200, 14),
            new Display(DisplayType.LED, 3.5, TouchScreenType.CAPACITIVE, 16000000),
            OS.IOS);
        public string TestPhoneCreation()
        {
            StringBuilder testResult = new StringBuilder();

            testResult.AppendLine(String.Format("Manufacturer: {0}", TestManufacturer()));
            testResult.AppendLine(String.Format("Model: {0}", TestModel()));
            testResult.AppendLine(String.Format("Battery: \n{0}", TestBattery()));
            testResult.AppendLine(String.Format("Display: \n{0}", TestDisplay()));
            testResult.AppendLine(String.Format("OS: {0}", TestOS()));

            return testResult.ToString();
        }
        private string TestManufacturer()
        {
            string result = "Passed";
            try
            {
                Assert.AreEqual(Manufacturer.APPLE, iPhone4s.Manufacturer);
            }
            catch(AssertFailedException exp)
            {
                result = exp.Message;
            }
            return result;
        }
        private string TestOS()
        {
            string result = "Passed";
            try
            {
                Assert.AreEqual(OS.IOS, iPhone4s.OS);
            }
            catch (AssertFailedException exp)
            {
                result = exp.Message;
            }
            return result;
        }
        private string TestDisplay()
        {
            StringBuilder batteryTest = new StringBuilder();

            string result = "Passed";
            try
            {
                Assert.AreEqual(DisplayType.LCD, iPhone4s.Display.DisplayType);
            }
            catch (AssertFailedException exception)
            {
                result = exception.Message;
            }
            batteryTest.AppendLine("\tDisplay type: " + result);

            result = "Passed";
            try
            {
                Assert.AreEqual(TouchScreenType.CAPACITIVE, iPhone4s.Display.TouchScreenType);
            }
            catch (AssertFailedException exception)
            {
                result = exception.Message;
            }
            batteryTest.AppendLine("\tTouchscreen type: " + result);

            result = "Passed";
            try
            {
                Assert.AreEqual(3.5, iPhone4s.Display.Inches);
            }
            catch (AssertFailedException exception)
            {
                result = exception.Message;
            }
            batteryTest.AppendLine("\tDisplay inches: " + result);

            result = "Passed";
            try
            {
                Assert.AreEqual(16000000, iPhone4s.Display.Colors);
            }
            catch (AssertFailedException exception)
            {
                result = exception.Message;
            }

            batteryTest.AppendLine("\tDisplay colors: " + result);

            return batteryTest.ToString().TrimEnd();
        }
        private string TestBattery()
        {
            StringBuilder batteryTest = new StringBuilder();
            string result = "Passed";
            try
            {
                Assert.AreEqual(BatteryType.Li_Ion, iPhone4s.Battery.BatteryType);
            }
            catch (AssertFailedException exception)
            {
                result = exception.Message;
            }

            batteryTest.AppendLine("\tBattery type: " + result);

            result = "Passed";
            try
            {
                Assert.AreEqual(1430, iPhone4s.Battery.MAh);
            }
            catch (AssertFailedException exception)
            {
                result = exception.Message;
            }

            batteryTest.AppendLine("\tBattery mAh: " + result);

            result = "Passed";
            try
            {
                Assert.AreEqual(200.0, iPhone4s.Battery.HoursIdle);
            }
            catch (AssertFailedException exception)
            {
                result = exception.Message;
            }

            batteryTest.AppendLine("\tBattery idle hours: " + result);

            result = "Passed";
            try
            {
                Assert.AreEqual(14.0, iPhone4s.Battery.HoursTalk);
            }
            catch (AssertFailedException exception)
            {
                result = exception.Message;
            }

            batteryTest.AppendLine("\tBattery talk hours: " + result);

            return batteryTest.ToString().TrimEnd();
        }
        private string TestModel()
        {
            string result = "Passed";
            try
            {
                Assert.AreEqual("4 S", iPhone4s.Model);
            }
            catch (AssertFailedException exception)
            {
                result = exception.Message;
            }

            return result;
        }

        [TestMethod]
        public string TestCalls()
        {
            StringBuilder testResult = new StringBuilder();

            iPhone4s.AddCalls(new Call(new DateTime(2016, 06, 08), new ContactInformation("Gosho", "+359 882"), 366));
            iPhone4s.AddCalls(new Call(new DateTime(2016, 06, 09), new ContactInformation("Mary", "+359 883"), 101));
            iPhone4s.AddCalls(new Call(new DateTime(2016, 06, 10), new ContactInformation("Penka", "+359 884"), 244));
            iPhone4s.AddCalls(new Call(new DateTime(2016, 06, 11), new ContactInformation("Toshko", "+359 882"), 12));

            testResult.AppendLine(String.Format("Adding calls: {0}", TestAddingCalls()));
            testResult.AppendLine(String.Format("\t\tTotal call price: {0:C}", iPhone4s.GetTottalPriceCalls(0.37m)));
            testResult.AppendLine(String.Format("Find longest call: {0}", TestLongestCall()));
            testResult.AppendLine(String.Format("Remove longest call: {0}", TestRemovingLongestCall()));
            testResult.AppendLine(String.Format("\t\tTotal call price: {0:C}", iPhone4s.GetTottalPriceCalls(0.37m)));
            testResult.AppendLine(String.Format("Remove all calls: {0}", TestRemoveAllCall()));
            testResult.AppendLine(String.Format("\t\tTotal call price: {0:C}", iPhone4s.GetTottalPriceCalls(0.37m)));

            return testResult.ToString();
        }

        private string TestRemoveAllCall()
        {
            string result = "Passed";
            iPhone4s.CallHistory.Clear();

            try
            {
                Assert.AreEqual(0, iPhone4s.CallHistory.Count);
            }
            catch (AssertFailedException exp)
            {
                result = exp.Message;
            }

            return result;
        }
        private string TestRemovingLongestCall()
        {
            string result = "Passed";

            Call longest = iPhone4s.CallHistory
                .OrderByDescending(x => x.Duration)
                .FirstOrDefault();
            iPhone4s.CallHistory.Remove(longest);

            var longestDuration = iPhone4s.CallHistory.Max(x => x.Duration);

            try
            {
                Assert.AreEqual(244.0, longestDuration, "longest call removed");
            }
            catch (AssertFailedException exp)
            {
                result = exp.Message;
            }

            return result;
        }
        private string TestLongestCall()
        {
            string result = "Passed";

            var callDuration = iPhone4s.CallHistory.Max(x => x.Duration);

            try
            {
                Assert.AreEqual(200.0, callDuration, "longest call duration");
            }
            catch (AssertFailedException exp)
            {
                result = exp.Message;
            }

            return result;
        }
        private string TestAddingCalls()
        {
            string result = "Passed";

            try
            {
                Assert.AreEqual(4, iPhone4s.CallHistory.Count, "added calls count");
            }
            catch (AssertFailedException exp)
            {
                result = exp.Message;
            }

            return result;
        }
        
    }
}
