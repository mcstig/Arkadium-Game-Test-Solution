using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTestPorject_1.Usefull
{
    internal class ManagePageInteractions
    {
        public ManagePageInteractions()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }
        #region Locators
        //Agree Button for Privacy statement
        [FindsBy(How = How.CssSelector, Using = "#qc-cmp2-ui > div.qc-cmp2-footer.qc-cmp2-footer-overlay.qc-cmp2-footer-scrolled > div > button.css-47sehv")]
        public IWebElement agreeButton { get; set; }

        //Game Page iFrame
        [FindsBy(How = How.Id, Using = "game-canvas")]
        public IWebElement iFrameGame { get; set; }

        //Ad iFrame
        [FindsBy(How = How.Id, Using = "game-canvas")]
        public IWebElement iFrameAd { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[3]/div[1]/div[2]/button")]
        public IWebElement skipAddButton { get; set; }
        #endregion

        #region Actions
        public void ClickAgreeButton()
        {
            agreeButton.Click();
        }

        public void SwitchToGamePageiFrame()
        {
            PropertiesCollection.driver.SwitchTo().Frame(iFrameGame);
        }

        public void SwitchToAdiFrame()
        {
            PropertiesCollection.driver.SwitchTo().Frame(iFrameAd);
        }

        public void ClickSkipAdButton()
        {
            skipAddButton.Click();
        }
        #endregion
    }
}
