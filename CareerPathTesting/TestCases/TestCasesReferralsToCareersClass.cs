using InitializationPage;
using WebDriverPage;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.PageObjects;
using WebElementProperties;
using MethodsForTestCases;

namespace TestCasesReferralsPgToCareersPg
{
    [TestClass]
    public class TestCasesReferralsToCareersClass : InitilizationClass
    {
        WebElementPropertiesClass ToWebElementProperties = new WebElementPropertiesClass();
        MethodsForTestCasesClass ToTestCaseMethods = new MethodsForTestCasesClass();

        [TestMethod]
        public void ReferralsPageToCareersLink()
        {
            PageFactory.InitElements(Driver.Instance, ToWebElementProperties);
            ToWebElementProperties.LinkToCareersPage.Click();
            ToTestCaseMethods.VerifyCareerPageTitle();
        }

        [TestMethod]
        public void HomePageToCareersLink()
        {
            PageFactory.InitElements(Driver.Instance, ToWebElementProperties);
            ToWebElementProperties.ReferralPageToHomePageLink.Click();
            ToWebElementProperties.LinkToCareersPage.Click();
            ToTestCaseMethods.VerifyCareerPageTitle();
        }

        [TestMethod]
        public void HowItWorksToCareersLink()
        {
            PageFactory.InitElements(Driver.Instance, ToWebElementProperties);
            ToWebElementProperties.ReferralPageToHowItWorksLink.Click();
            ToWebElementProperties.LinkToCareersPage.Click();
            ToTestCaseMethods.VerifyCareerPageTitle();
        }

        [TestMethod]
        public void BrandsPageToCareersLink()
        {
            PageFactory.InitElements(Driver.Instance, ToWebElementProperties);
            ToWebElementProperties.ReferralPageToBrandsLink.Click();
            ToWebElementProperties.LinkToCareersPage.Click();
            ToTestCaseMethods.VerifyCareerPageTitle();
        }

        [TestMethod]
        public void RewardsPageToCareersLink()
        {
            PageFactory.InitElements(Driver.Instance, ToWebElementProperties);
            ToWebElementProperties.ReferralPageToRewardsLink.Click();
            ToWebElementProperties.LinkToCareersPage.Click();
            ToTestCaseMethods.VerifyCareerPageTitle();
        }

        [TestMethod]
        public void AboutUsPageToCareersLink()
        {
            PageFactory.InitElements(Driver.Instance, ToWebElementProperties);
            ToWebElementProperties.ReferralPageToAboutUsLink.Click();
            ToWebElementProperties.LinkToCareersPage.Click();
            ToTestCaseMethods.VerifyCareerPageTitle();
        }

        [TestMethod]
        public void StoresPageToCareersLink()
        {
            PageFactory.InitElements(Driver.Instance, ToWebElementProperties);
            ToWebElementProperties.ReferralPageToStoresLink.Click();
            ToWebElementProperties.LinkToCareersPage.Click();
            ToTestCaseMethods.VerifyCareerPageTitle();
        }

        [TestMethod]
        public void PressPageToCareersLink()
        {
            PageFactory.InitElements(Driver.Instance, ToWebElementProperties);
            ToWebElementProperties.ReferralPageToPressLink.Click();
            ToWebElementProperties.LinkToCareersPage.Click();
            ToTestCaseMethods.VerifyCareerPageTitle();
        }
    }
}
