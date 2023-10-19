using MSTestPorject_1.PageObjects;
using MSTestPorject_1.Usefull;
using OpenQA.Selenium.DevTools.V104.Runtime;
using SeleniumExtras.PageObjects;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestPorject_1.Workflows
{
    internal class Workflow
    {
        public Workflow()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        public void NavigateToGame()
        {
            ///Instantiate Classes
            LandingPageObject landingPageObject = new LandingPageObject();
            ManagePageInteractions pageInteractions = new ManagePageInteractions();

            ///Add Test Steps
            pageInteractions.ClickAgreeButton();
            landingPageObject.ClickPlayButton();       
            Thread.Sleep(40000);
            pageInteractions.SwitchToGamePageiFrame();
            landingPageObject.ClickLeftArrowButton();
            Thread.Sleep(500);
            landingPageObject.ClickRightArrowButton();
            Thread.Sleep(500);
            landingPageObject.SelectPlayEvent();
            Thread.Sleep(1000);

            //Assert for Top Ribon
            var assertGamePage = landingPageObject.assertGamePage;
            assertGamePage.Should().NotBeNull();
        }

    public void PlayGame()
        {
            ///Instantiate Classes
            ManagePageInteractions pageInteractions = new ManagePageInteractions();
            GamePageObject gamePageObject = new GamePageObject();

            ///Add Test Steps
            Thread.Sleep(1000);
            gamePageObject.FirstAccross();
            Thread.Sleep(10000);

        }

    }
}
