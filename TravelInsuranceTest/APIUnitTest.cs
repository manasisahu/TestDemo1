using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using TravelInsurance;

namespace TravelInsuranceTest
{
    [TestClass]
    public class APIUnitTest
    {
        [TestMethod]
        public void WelcomeNameTest()
        {
            var getData = new GetData();
            var response = getData.getInsuranceData();
            Assert.AreEqual("Carbon credits", response.Name);
        }

        [TestMethod]
        public void WelcomeCanRelistTest()
        {
            var getData = new GetData();
            var response = getData.getInsuranceData();
            Assert.IsTrue(response.CanRelist);
        }
        [TestMethod]
        public void PromotionGalleryDescriptionTest()
        {
            var getData = new GetData();
            var response = getData.getInsuranceData();
            response.Promotions.Where(promotion =>promotion.Name == "Gallery").ToList().ForEach(delegate(Promotion promo) {
                Assert.AreEqual("Good position in category", promo.Description);
            });
        }
    }
}
