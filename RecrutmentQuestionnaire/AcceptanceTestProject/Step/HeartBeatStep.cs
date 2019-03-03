using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace AcceptanceTestProject.Step
{
    [Binding]
    public sealed class HeartBeatStep
    {
        bool beat;

        [When("I call my HeartBeat")]
        public void WhenIPressAdd()
        {
            beat = RecrutmentQuestionnaire.HeartBeat.Beat();
        }

        [Then("my heart beat")]
        public void ThenTheResultShouldBe()
        {
            Assert.IsTrue(beat);
        }
    }
}
