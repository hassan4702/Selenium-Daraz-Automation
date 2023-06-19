using Microsoft.VisualBasic;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {

            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("-start-maximized");
            chromeOptions.AddArguments("disable-extensions");
            chromeOptions.AddArguments("--disable-popup-blocking");
            IWebDriver driver= new ChromeDriver(chromeOptions);
            Actions actions = new Actions(driver);

            driver.Url = "https://www.daraz.pk/";
            //Opens mart page 
            driver.FindElement(By.LinkText("LOGIN")).Click();
            //driver.FindElement(By.CssSelector("#container > div > div:nth-child(2) > form > div > div.mod-login-col1 > div.mod-input.mod-login-input-loginName.mod-input-loginName > input[type=text]")).SendKeys("muhammadhassanshakil35066" +
            //    "@gmail.com");
            //driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[2]/form/div/div[1]/div[2]/input")).SendKeys("altergate123");
            //driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div/div[2]/form/div/div[2]/div[1]/button")).Click();
            //Thread.Sleep(10000);
            //driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[1]/div/div/div[1]/div/div[6]/span")).Click();
            //Thread.Sleep(1000);   
            //driver.FindElement(By.XPath("//*[@id=\"lzdMyAccountPop\"]/div/ul/li[6]/a")).Click();
            //driver.FindElement(By.LinkText("LOGIN")).Click();
            //driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div/div[2]/form/div/div[2]/div[2]/div/div[2]/button[2]")).Click();
            //driver.SwitchTo().Window(driver.WindowHandles[1]);
            //IWebElement google_email=driver.FindElement(By.Id("identifierId"));
            //google_email.SendKeys("muhammadhassanshakil35066@gmail.com");
            //google_email.SendKeys(Keys.Enter);
            //Thread.Sleep(3000);
            //driver.SwitchTo().Window(driver.WindowHandles[0]);
            driver.FindElement(By.CssSelector("#container > div > div:nth-child(2) > form > div > div.mod-login-col1 > div.mod-input.mod-login-input-loginName.mod-input-loginName > input[type=text]")).SendKeys("muhammadhassanshakil35066" +
                "@gmail.com");
            driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[2]/form/div/div[1]/div[2]/input")).SendKeys("altergate123");
            driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div/div[2]/form/div/div[2]/div[1]/button")).Click();
            Thread.Sleep(1000);
            //driver.FindElement(By.Name("q")).SendKeys("Toyota");
            //driver.FindElement(By.ClassName("search-box__button--1oH7")).Click();

            //driver.FindElement(By.XPath("/html/body/div[3]/div/div[2]/div/div/div[1]/div[2]/div[1]/div/div/div[2]/div[2]/a")).Click();
            //driver.FindElement(By.XPath("//*[@id=\"module_add_to_cart\"]/div/button[2]")).Click();
            //Thread.Sleep(2000);
            //driver.FindElement(By.XPath("/html/body/div[7]/div/div[2]/div/div/div[1]/div/div[2]/div/div/div/div[2]/button")).Click();
            //driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div/div/div/div[1]/div[2]/div[2]/div/div/div[3]/div/div/div[1]/a[1]")).Click();
            //Thread.Sleep(2000);
            //driver.FindElement(By.XPath("//*[@id=\"shop-title-wrap\"]/div[1]/div/label/input")).Click();
            //driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div/div/div/div[1]/div[1]/div/div/div[2]/div")).Click();
            //Thread.Sleep(2000);
            //driver.FindElement(By.ClassName("ok")).Click();
            //Thread.Sleep(5000);

            driver.FindElement(By.LinkText("DARAZ AFFILIATE PROGRAM")).Click();
            Thread.Sleep(2000);
            actions.SendKeys(Keys.PageDown).Build().Perform();
            Thread.Sleep(1000);

            actions.SendKeys(Keys.PageDown).Build().Perform();
            Thread.Sleep(1000);

            actions.SendKeys(Keys.PageDown).Build().Perform();
            Thread.Sleep(1000);

            actions.SendKeys(Keys.PageDown).Build().Perform();
            Thread.Sleep(1000);

            Thread.Sleep(1000);


            actions.SendKeys(Keys.PageUp).Build().Perform();
            Thread.Sleep(1000);
            actions.SendKeys(Keys.PageUp).Build().Perform();
            Thread.Sleep(1000);
            actions.SendKeys(Keys.PageUp).Build().Perform();
            Thread.Sleep(1000);
            actions.SendKeys(Keys.PageUp).Build().Perform();
            



        }
    }
}
