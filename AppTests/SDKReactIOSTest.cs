using AppTests.api;
using AppTests.pages;
using AppTests.util;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.iOS;
using System;
using System.Threading;

namespace AppTests
{
    [TestFixture]
    public class SDKReactIOSTest
    {
        private readonly Capabilities capabilities = new Capabilities();
        private readonly ReactPage reactPage = new ReactPage();
        private readonly Devices devices = new Devices();
        private string buildName;

        [OneTimeSetUp]
        public void GlobalSetup()
        {
            buildName = DateTime.Now.ToString() + " - React - iOS";
        }

        private JObject CollectVariablesAndGenerateDevice(string deviceName, string osVersion, string buildName)
        {
            AppiumOptions options = capabilities.GetReactOptions(deviceName, osVersion, buildName, "iOS");
            
            IOSDriver<IOSElement> driver = new IOSDriver<IOSElement>(new Uri("http://hub-cloud.browserstack.com/wd/hub"), options);
            
            string sessionId = reactPage.GetSession(driver);
            
            //close test
            if (driver != null)
            {
                driver.Quit();
            }

            Thread.Sleep(3000);
            
            JObject response = devices.GenerateDevice(sessionId);

            return response ?? null;
        }

        [Test]
        [TestCase("iPhone 6", "11", TestName = "iPhone 6 (ios 11)")]
        [TestCase("iPhone 6S", "11", TestName = "iPhone 6S (ios 11)")]
        [TestCase("iPhone 6S", "12", TestName = "iPhone 6S (ios 12)")]
        [TestCase("iPhone 6S Plus", "11", TestName = "iPhone 6S Plus (ios 11)")]
        [TestCase("iPhone 7", "10", TestName = "iPhone 7 (ios 10)")]
        [TestCase("iPhone 7", "12", TestName = "iPhone 7 (ios 12)")]
        [TestCase("iPhone 7 Plus", "10", TestName = "iPhone 7 Plus (ios 10)")]
        [TestCase("iPhone 8", "11", TestName = "iPhone 8 (ios 11)")]
        [TestCase("iPhone 8", "12", TestName = "iPhone 8 (ios 12)")]
        [TestCase("iPhone 8", "13", TestName = "iPhone 8 (ios 13)")]
        [TestCase("iPhone 8 Plus", "11", TestName = "iPhone 8 Plus (ios 11)")]
        [TestCase("iPhone 8 Plus", "12", TestName = "iPhone 8 Plus (ios 12)")]
        [TestCase("iPhone X", "11", TestName = "iPhone X (ios 11)")]
        [TestCase("iPhone XS", "12", TestName = "iPhone XS (ios 12)")]
        [TestCase("iPhone XS", "13", TestName = "iPhone XS (ios 13)")]
        [TestCase("iPhone XS", "14", TestName = "iPhone XS (ios 14)")]
        [TestCase("iPhone XS Max", "12", TestName = "iPhone XS Max (ios 12)")]
        [TestCase("iPhone SE 2020", "13", TestName = "iPhone SE 2020 (iOS 13")]
        [TestCase("iPhone SE", "11", TestName = "iPhone SE (ios 11)")]
        [TestCase("iPhone XR", "12", TestName = "iPhone XR (ios 12)")]
        [TestCase("iPhone 11", "13", TestName = "iPhone 11 (ios 13)")]
        [TestCase("iPhone 11", "14", TestName = "iPhone 11 (ios 14)")]
        [TestCase("iPhone 11 Pro", "13", TestName = "iPhone 11 Pro (ios 13)")]
        [TestCase("iPhone 11 Pro Max", "13", TestName = "iPhone 11 Pro Max (ios 13)")]
        [TestCase("iPhone 11 Pro Max", "14", TestName = "iPhone 11 Pro Max (ios 14)")]
        [TestCase("iPhone 12", "14", TestName = "iPhone 12 (ios 14)")]
        [TestCase("iPhone 12 Mini", "14", TestName = "iPhone 12 Mini (ios 14)")]
        [TestCase("iPad 5th", "11", TestName = "iPad 5th (ios 11)")]
        [TestCase("iPad 6th", "11", TestName = "iPad 6th (ios 11)")]
        [TestCase("iPad 7th", "13", TestName = "iPad 7th (ios 13)")]
        [TestCase("iPad 8th", "14", TestName = "iPad 8th (ios 14)")]
        [TestCase("iPad Mini 4", "11", TestName = "iPad Mini 4 (ios 11)")]
        [TestCase("iPad Mini 2019", "12", TestName = "iPad Mini 2019 (ios 12)")]
        [TestCase("iPad Mini 2019", "13", TestName = "iPad Mini 2019 (ios 13)")]
        [TestCase("iPad Pro 9.7 2016", "11", TestName = "iPad Pro 97 2016 (ios 11)")]
        [TestCase("iPad Pro 11 2018", "12", TestName = "iPad Pro 11 2018 (ios 12)")]
        [TestCase("iPad Pro 11 2020", "13", TestName = "iPad Pro 11 2020 (ios 13)")]
        [TestCase("iPad Pro 12.9", "11", TestName = "iPad Pro 129 (ios 11)")]
        [TestCase("iPad Pro 12.9 2018", "12", TestName= "iPad Pro 129 2018 (ios 12)")]
        [TestCase("iPad Pro 12.9 2018", "13", TestName= "iPad Pro 129 2018 (ios 13)")]
        [TestCase("iPad Pro 12.9 2020", "13", TestName= "iPad Pro 129 2020 (ios 13)")]
        [TestCase("iPad Pro 12.9 2020", "14", TestName= "iPad Pro 129 2020 (ios 14)")]
        [TestCase("iPad Air 4", "14", TestName = "iPad Air 4 (ios 14)")]
        [TestCase("iPad Air 2019", "12", TestName = "iPad Air 2019 (ios 12)")]
        [TestCase("iPad Air 2019", "13", TestName = "iPad Air 2019 (ios 13)")]
        public void Test_DeviceAndOSVersion(string deviceName, string osVersion)
        {
            JObject response = CollectVariablesAndGenerateDevice(deviceName, osVersion, buildName);

            Assert.IsNotNull(response);
            Assert.IsNotNull(response["requestId"]);
            Assert.IsNotNull(response["device"]["deviceId"]);
            Assert.IsNotNull(response["hashes"]["advertisingId"]);
            Assert.IsNotNull(response["hashes"]["deviceGeneratedId"]);
        }
    }
}