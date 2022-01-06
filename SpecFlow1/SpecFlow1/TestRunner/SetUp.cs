using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using SpecFlow1.Steps;
using System;
using System.Linq;
using TechTalk.SpecFlow;

namespace SpecFlowTask3.TestRun
{
    [Binding]
    public class SetUp : BaseStep
    {

        [AfterScenario]
        public void AfterScenario()
        {
            webDriver.Close();
        }
    }
}




