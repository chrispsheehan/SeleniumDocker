using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;

namespace Sandpit
{
    class Program
    {
        static void Main(string[] args)
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--no-sandbox");
            chromeOptions.AddArgument("--headless");
            chromeOptions.AddArgument("--window-size=1920,1080");
            chromeOptions.AddArgument("--start-maximized");

            IWebDriver driver = new ChromeDriver(chromeOptions);

            driver.Url = "https://www.bbc.co.uk/";

            Console.WriteLine($"the page title is: {driver.Title}");

            driver.FindElement(By.LinkText("Sport")).Click();

            driver.FindElement(By.LinkText("Rugby Union")).Click();

            Console.WriteLine($"the page title is now badgers: {driver.Title}");

            driver.Quit();
        }
    }
}
