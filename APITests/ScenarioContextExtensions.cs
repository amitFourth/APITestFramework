using System;
using System.Configuration;
using TechTalk.SpecFlow;

namespace APITests
{
    public static class ScenarioContextExtensions
    {
        public static void AddAppConfigValues(ScenarioContext scenarioContext)
        {
            foreach (var key in ConfigurationManager.AppSettings)
            {
                scenarioContext.Set(ConfigurationManager.AppSettings[key.ToString()], key.ToString());
            }
        }
    }
}
