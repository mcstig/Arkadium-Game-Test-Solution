using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTestPorject_1.PageObjects;
using MSTestPorject_1.Usefull;
using MSTestPorject_1.Workflows;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V104.Page;

namespace MSTestPorject_1.Z_Tests
{
    [TestClass]
    public class SmokeTests
    {

        [TestInitialize]
        public void Initialize()
        {
            //ChromeDriver Initiation
            PropertiesCollection.driver = new ChromeDriver();
            //Navigate to URL
            PropertiesCollection.driver.Navigate().GoToUrl("https://www.gamelab.com/games/daily-quick-crossword");
            Console.WriteLine("Setup Cpmplete.");
        }

        [TestMethod]
        public void FirstTest()
        {
            //Start the Application
            Workflow workflow = new Workflow();
            workflow.NavigateToGame();
            //workflow.PlayGame();

        }

        [TestCleanup]
        public void Cleanup()
        {
            //Close Browser
            PropertiesCollection.driver.Quit();
            Console.WriteLine("Browser Closed.");
        }
    }
}