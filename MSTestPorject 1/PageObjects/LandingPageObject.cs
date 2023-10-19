using MSTestPorject_1.Usefull;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTestPorject_1.PageObjects
{
    class LandingPageObject
    {
        public LandingPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }
        #region Locators
        /// <summary>
        /// Locators for the Landing Page
        /// </summary>
        //Play Button
        [FindsBy(How = How.ClassName, Using = "ark-ad-button-text")]
        public IWebElement playButton { get; set; }

        //Left Arrow Button
        [FindsBy(How = How.XPath, Using = "//*[@id=\"gameContainer\"]/article/section/section/section/ul/button[1]")]
        public IWebElement leftArrow { get; set; }

        //Right Arrow Button
        [FindsBy(How = How.XPath, Using = "//*[@id=\"gameContainer\"]/article/section/section/section/ul/button[2]")]
        public IWebElement rightArrow { get; set; }
        
        //Select Play Puzzle
        [FindsBy(How = How.XPath, Using = "//*[@id=\"gameContainer\"]/article/section/section/section/ul/li[17]/div[2]")]
        public IWebElement selectPlay { get; set; }
        
        //Assert Game Page
        [FindsBy(How = How.ClassName, Using = "game_inlineClue__21fK2")]
        public IWebElement assertGamePage { get; set; }
        #endregion

        #region Actions
        /// <summary>
        /// Define Actions
        /// </summary>
        public void ClickPlayButton()
        {
            playButton.Click();
        }

        public void ClickLeftArrowButton()
        {
            leftArrow.Click();
        }

        public void ClickRightArrowButton()
        {
            rightArrow.Click();
        }
        
        public void SelectPlayEvent()
        {
            selectPlay.Click();
        }
        #endregion

    }
}
