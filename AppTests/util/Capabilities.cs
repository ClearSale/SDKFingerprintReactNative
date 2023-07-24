using Microsoft.Extensions.Configuration;
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppTests.util
{
    class Capabilities
    {

        public static IConfiguration configuration;
        public static string userName = Environment.GetEnvironmentVariable("BROWSERSTACK_USERNAME");
        public static string accessKey = Environment.GetEnvironmentVariable("BROWSERSTACK_ACCESS_KEY");
        public static string browserstackLocal = Environment.GetEnvironmentVariable("BROWSERSTACK_LOCAL");
        public static string browserstackLocalIdentifier = Environment.GetEnvironmentVariable("BROWSERSTACK_LOCAL_IDENTIFIER");
        public static string app = Environment.GetEnvironmentVariable("BROWSERSTACK_APP_ID");


        public Capabilities()
        {
            configuration = InitConfiguration();

            //userName = configuration.GetSection("Browserstack:Username").Value;
            //accessKey = configuration.GetSection("Browserstack:AutomateKey").Value;
            //app = configuration.GetSection("App:SDKReactiOS").Value;
        }
        private static IConfiguration InitConfiguration()
        {
            IConfiguration config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();
            return config;
        }

       
        public AppiumOptions GetIOSOptions(String device, String osVersion, String buildName)
        {
            AppiumOptions caps = GetGenericOptions(device, osVersion, buildName);

            caps.AddAdditionalCapability("app", configuration.GetSection("App:SDKiOS").Value);
            caps.PlatformName = "iOS";

            return caps;
        }

        public AppiumOptions GetReactOptions(String device, String osVersion, String buildName, String platform)
        {
            AppiumOptions caps = GetGenericOptions(device, osVersion, buildName);

            caps.PlatformName = platform;
            
            
            return caps;
        }

     
        private static AppiumOptions GetGenericOptions(String device, String osVersion, String buildName)
        {
            AppiumOptions caps = new AppiumOptions();
            //caps.AddAdditionalCapability("browserstack.appium_version", "1.8.0");
            caps.AddAdditionalCapability("browserstack.user", userName);
            caps.AddAdditionalCapability("browserstack.key", accessKey);
            caps.AddAdditionalCapability("app", app);
            caps.AddAdditionalCapability("browserstack.local", browserstackLocal);
            caps.AddAdditionalCapability("browserstack.localIdentifier", browserstackLocalIdentifier);
            caps.AddAdditionalCapability("autoDismissAlerts", true);
            caps.AddAdditionalCapability("device", device);
            caps.AddAdditionalCapability("os_version", osVersion);
            caps.AddAdditionalCapability("name", device);
            caps.AddAdditionalCapability("build", buildName);

            return caps;
        }
    }
}
