using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Xunit;

namespace WebDriverDemo
{
    public static class Basico2
    {
        [Fact]
        public static void Go_To_Google_Find_Element_Firefox()
        {
            IWebDriver driver = new FirefoxDriver(@"C:\Libraries\");
            driver.Url = "http:\\www.google.com.br";

            IWebElement elementInput = driver.FindElement(By.Id("lst-ib"));
            elementInput.SendKeys("Banco Daycoval");

            IWebElement elementMain = driver.FindElement(By.Id("main"));
            elementMain.Click();

            IWebElement elementButton = driver.FindElement(By.Name("btnK"));
            elementButton.Click();

            var elementMenuImagem = driver.FindElements(By.CssSelector("div.hdtb-mitem:nth-child(4) > a:nth-child(1)"))[0];
            elementMenuImagem.Click();

            var elementImgs = driver.FindElements(By.ClassName("rg_l"))[2];
            elementImgs.Click();

            Assert.True(elementImgs != null);

            //var elementImagens = driver.FindElements(By.CssSelector("div.rg_bx:nth-child(3) > a:nth-child(1)"))[0];
            //elementImagens.Click();

            //Em alguns caso será necessário adicionar um timeout para esperar o elemento ser renderizado.
            //Para que possamos manipulá-lo via webElement.
            //driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(10));
        }
    }
}
