using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace ClassLibrary1.steps
{
    [Binding]
    public sealed class Hooks1
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            Browser.InitDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Browser.Close();
        }
    }
}
