using TechTalk.SpecFlow;

namespace APITests
{
    [Binding]
    public sealed class Hooks
    {
        private readonly ScenarioContext scenarioContext;

        public Hooks(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void BeforeFeature()
        {
           ScenarioContextExtensions.AddAppConfigValues(this.scenarioContext);
        }
    }
}
