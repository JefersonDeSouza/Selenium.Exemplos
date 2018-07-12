using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using Xunit;

namespace WebDriverDemo
{
    public static class Basico3
    {
        [Fact]
        public static void Set_RadionButton_Time()
        {
            IWebDriver driver = new ChromeDriver(@"C:\Libraries\");
            driver.Url = "file:///C:/Users/Jeferson/source/repos/WebDriverDemo/WebDriverDemo/RadioButtons.html";

            var elementsRadion = driver.FindElements(By.Name("time"));
            elementsRadion[1].Click();

            foreach (var radio in elementsRadion)
            {
                if (radio.Selected)
                    Assert.Equal("palmeiras", radio.GetAttribute("value"));
            }
        }

        [Fact]
        public static void Set_SelectList_Devs()
        {
            IWebDriver driver = new ChromeDriver(@"C:\Users\Jeferson\source\repos\WebDriverDemo\WebDriverDemo\bin\Debug\netcoreapp2.0\");
            driver.Url = @"file:///C:/Users/Jeferson/source/repos/WebDriverDemo/WebDriverDemo/Select.html";

            IWebElement elementSelectList = driver.FindElement(By.Id("sel_devsFodas"));
            var optionsSelectList = elementSelectList.FindElements(By.TagName("option"));
            optionsSelectList[5].Click();

            foreach (var item in optionsSelectList)
            {
                if (item.Selected)
                    Assert.Equal("jeferson", item.GetAttribute("value"));
            }
        }

        [Fact]
        public static void Set_SelectList_SelectElement_Devs()
        {
            IWebDriver driver = new ChromeDriver(@"C:\Users\Jeferson\source\repos\WebDriverDemo\WebDriverDemo\bin\Debug\netcoreapp2.0\");
            driver.Url = @"file:///C:/Users/Jeferson/source/repos/WebDriverDemo/WebDriverDemo/Select.html";

            IWebElement elementSelectList = driver.FindElement(By.Id("sel_devsFodas"));
            var element = new SelectElement(elementSelectList);
            element.SelectByText("Jonatan");

            Assert.Equal("jonatan", element.SelectedOption.GetAttribute("value"));
        }

        [Fact]
        public static void Get_Table()
        {
            IWebDriver driver = new ChromeDriver(@"C:\Users\Jeferson\source\repos\WebDriverDemo\WebDriverDemo\bin\Debug\netcoreapp2.0\");
            driver.Url = @"file:///C:/Users/Jeferson/source/repos/WebDriverDemo/WebDriverDemo/Table.html";

            IWebElement outerTable = driver.FindElement(By.TagName("table"));
            var innerTable = outerTable.FindElement(By.TagName("table"));
            var row = innerTable.FindElements(By.TagName("td"))[1];
            Console.WriteLine(row.Text);
            Console.ReadLine();
        }

        [Fact]
        public static void Get_Table_XPath()
        {
            IWebDriver driver = new ChromeDriver(@"C:\Users\Jeferson\source\repos\WebDriverDemo\WebDriverDemo\bin\Debug\netcoreapp2.0\");
            driver.Url = @"file:///C:/Users/Jeferson/source/repos/WebDriverDemo/WebDriverDemo/Table.html";

            IWebElement outerTable = driver.FindElement(By.XPath("/html/body/table/tbody/tr/td[2]/table/tbody/tr[2]/td"));
            Console.WriteLine(outerTable.Text);
            Console.ReadLine();
        }
    }
}
