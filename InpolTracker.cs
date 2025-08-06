using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace MyProject
{
    public class InpolTracker
    {
        private IWebDriver driver;
        private FirefoxOptions options;
        private void InitOptions()
        {

            string profilePath = "/home/oleg/.mozilla/firefox/inpol-profile";

            var profile = new FirefoxProfile(profilePath);

            profile.SetPreference("general.useragent.override",
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:115.0) Gecko/20100101 Firefox/115.0");

            options = new FirefoxOptions
            {
                Profile = profile
            };
        }

        public InpolTracker()
        {
            InitOptions();
            driver = new FirefoxDriver(options);
        }

        public void Test(string url_site)
        {
            driver.Navigate().GoToUrl(url_site);

            Console.WriteLine("Press any key in order to stop program...");
            Console.ReadKey();

            driver.Quit();
        }

        public void ClearCache()
        {
            if (driver != null)
            {
                driver.Manage().Cookies.DeleteAllCookies();
                Console.WriteLine("Cookies cleared.");
            }
        }
    }
}
