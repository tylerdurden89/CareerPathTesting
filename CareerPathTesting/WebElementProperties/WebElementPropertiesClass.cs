using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WebElementProperties
{
    public class WebElementPropertiesClass
    {
        [FindsBy(How = How.LinkText, Using = "Careers")]
        public IWebElement LinkToCareersPage { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/nav/a[1]/img")]
        public IWebElement ReferralPageToHomePageLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "How it Works")]
        public IWebElement ReferralPageToHowItWorksLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "Brands")]
        public IWebElement ReferralPageToBrandsLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "Rewards")]
        public IWebElement ReferralPageToRewardsLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "About Us")]
        public IWebElement ReferralPageToAboutUsLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "Stores")]
        public IWebElement ReferralPageToStoresLink { get; set; }

        [FindsBy(How = How.LinkText, Using = "Press")]
        public IWebElement ReferralPageToPressLink { get; set; }
    }
}
