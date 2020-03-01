using WebDriverPage;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InitializationPage
{
    public class InitilizationClass

    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
            Driver.Instance.Url = "https://www.fetchrewards.com/referrals";
        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Instance.Close();
        }
    }
}
