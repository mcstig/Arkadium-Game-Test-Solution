
using java.awt;
using java.awt.@event;
using MSTestPorject_1.Usefull;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WindowsInput;

namespace MSTestPorject_1.PageObjects
{
    class GamePageObject
    {
        public GamePageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }
        #region Locators
        /// <summary>
        /// Locators for the Landing Page
        /// </summary>
        //Play Button
        [FindsBy(How = How.XPath, Using = "//*[@id=\"gameContainer\"]/article/section/section/section[2]/section[2]/section[1]/ul/li[1]/section/div")]
        public IWebElement firstAccross { get; set; }
        #endregion

        #region Actions
        /// <summary>
        /// Define Actions
        /// </summary>
        public void FirstAccross()
        {            
            firstAccross.Click();
            Thread.Sleep(1000);

            Robot robot = new Robot();

            robot.keyPress(KeyEvent.VK_Y);
            robot.keyPress(KeyEvent.VK_O);
            robot.keyPress(KeyEvent.VK_Y);
            robot.keyPress(KeyEvent.VK_O);

            //InputSimulator sim = new InputSimulator();
            //sim.Keyboard.TextEntry("YOYO");

        }
        #endregion

    }
}
