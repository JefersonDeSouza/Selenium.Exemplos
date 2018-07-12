using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace WebDriverDemo
{
    public static class Basico
    {
        public static void Go_To_Google_Firefox_Test()
        {
            IWebDriver driver = new FirefoxDriver(@"C:\Libraries\");
            driver.Url = "http://www.google.com.br";
        }

        public static void Go_To_Google_Chrome_Test()
        {
            IWebDriver driver = new ChromeDriver(@"C:\Libraries\");
            driver.Url = "http://www.google.com.br";
        }

        public static void Go_To_Google_Ie_Test()
        {
            IWebDriver driver = new InternetExplorerDriver(@"C:\Libraries\");
            driver.Url = "http://www.google.com.br";
        }
    }
}
