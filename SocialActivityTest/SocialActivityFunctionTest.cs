using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SocialActivity
{
    [TestClass]
    public class SocialActivityFunctionTest
    {
        [ClassCleanup]
        public static void tearDown()
        {
            ArgumentLogger.createLogFile();
        }

        //-------------------------------------------------
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Invalid arguments supplied!")]
        public void OMaxFollow()
        {
            double result = SocialActivityFunction.getSocialActivityFactor(21, 100, 6);
        }

        [TestMethod]
        public void MaxFollow()
        {
            double result = SocialActivityFunction.getSocialActivityFactor(20, 100, 6);
            Assert.IsTrue(result <= 100 && result >= 0);
        }

        [TestMethod]
        public void UMaxFollow()
        {
            double result = SocialActivityFunction.getSocialActivityFactor(19, 100, 6);
            Assert.IsTrue(result <= 100 && result >= 0);
        }

        [TestMethod]
        public void MiddleFollow()
        {
            double result = SocialActivityFunction.getSocialActivityFactor(10, 100, 6);
            Assert.IsTrue(result <= 100 && result >= 0);
        }

        [TestMethod]
        public void OMinFollow()
        {
            double result = SocialActivityFunction.getSocialActivityFactor(1, 100, 6);
            Assert.IsTrue(result <= 100 && result >= 0);
        }

        [TestMethod]
        public void MinFollow()
        {
            double result = SocialActivityFunction.getSocialActivityFactor(0, 100, 6);
            Assert.IsTrue(result <= 100 && result >= 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Invalid arguments supplied!")]
        public void UMinFollow()
        {
            double result = SocialActivityFunction.getSocialActivityFactor(-1, 100, 6);
        }

        //-------------------------------------------------
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Invalid arguments supplied!")]
        public void OMaxLikes()
        {
            double result = SocialActivityFunction.getSocialActivityFactor(10, 210, 6);
        }

        [TestMethod]
        public void MaxLikes()
        {
            double result = SocialActivityFunction.getSocialActivityFactor(10, 200, 6);
            Assert.IsTrue(result <= 100 && result >= 0);
        }

        [TestMethod]
        public void UMaxLikes()
        {
            double result = SocialActivityFunction.getSocialActivityFactor(10, 190, 6);
            Assert.IsTrue(result <= 100 && result >= 0);
        }

        [TestMethod]
        public void OMinLikes()
        {
            double result = SocialActivityFunction.getSocialActivityFactor(10, 10, 6);
            Assert.IsTrue(result <= 100 && result >= 0);
        }

        [TestMethod]
        public void MinLikes()
        {
            double result = SocialActivityFunction.getSocialActivityFactor(10, 0, 6);
            Assert.IsTrue(result <= 100 && result >= 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Invalid arguments supplied!")]
        public void UMinLikes()
        {
            double result = SocialActivityFunction.getSocialActivityFactor(10, -10, 6);
        }

        //-------------------------------------------------
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Invalid arguments supplied!")]
        public void OMaxPosts()
        {
            double result = SocialActivityFunction.getSocialActivityFactor(10, 100, 14);
        }

        [TestMethod]
        public void MaxPosts()
        {
            double result = SocialActivityFunction.getSocialActivityFactor(10, 100, 13);
            Assert.IsTrue(result <= 100 && result >= 0);
        }

        [TestMethod]
        public void UMaxPosts()
        {
            double result = SocialActivityFunction.getSocialActivityFactor(10, 100, 12);
            Assert.IsTrue(result <= 100 && result >= 0);
        }

        [TestMethod]
        public void OMinPosts()
        {
            double result = SocialActivityFunction.getSocialActivityFactor(10, 100, 1);
            Assert.IsTrue(result <= 100 && result >= 0);
        }

        [TestMethod]
        public void MinPosts()
        {
            double result = SocialActivityFunction.getSocialActivityFactor(10, 100, 0);
            Assert.IsTrue(result <= 100 && result >= 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Invalid arguments supplied!")]
        public void UMinPosts()
        {
            double result = SocialActivityFunction.getSocialActivityFactor(10, 100, -1);
        }
    }
}