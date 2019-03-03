using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecrutmentQuestionnaire;
using Useful;

namespace UnitTestProject
{
    [TestClass]
    public class HeartBeat_TST
    {

        [TestMethod]
        public void TestOurHeartBeat()
        {
            bool response = HeartBeat.Beat();

            Assert.AreEqual(Constant.Beat, response);
        }
    }
}
