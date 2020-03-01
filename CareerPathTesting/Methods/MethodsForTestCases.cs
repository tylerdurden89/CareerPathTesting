using System;
using System.Text;
using System.Collections.Generic;
using WebDriverPage;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MethodsForTestCases
{
    public class MethodsForTestCasesClass
    {
        public void VerifyCareerPageTitle()
        {
            string ExpectedTitle = "Careers | Fetch Rewards";
            string ActualTitle = Driver.Instance.Title;
            Assert.AreEqual(ExpectedTitle, ActualTitle, "Title Page mismatch, failed to reach Careers page");
        }
    }
}
