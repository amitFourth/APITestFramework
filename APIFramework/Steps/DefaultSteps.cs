using APIFramework.Variables;
using RestSharp;
using TechTalk.SpecFlow;

namespace APIFramework.Steps
{
    [Binding]
    public sealed class DefaultSteps
    {
        private readonly RestSession restSession;
        private readonly ScenarioContext scenarioContext;

        public DefaultSteps(RestSession restSession, ScenarioContext scenarioContext)
        {
            this.restSession = restSession;
            this.scenarioContext = scenarioContext;
        }

        [StepDefinition(@"the /(.*)/ resource")]
        public void GivenThe_Endpoint(string resourceValue)
        {
            this.restSession.Request.Resource = resourceValue;
        }

        [StepDefinition(@" a (POST|GET|PUT|DELETE) request is executed")]
        public void WhenARequestIsExecuted(Method method)
        {
            this.restSession.Request.Method = method;
            this.restSession.Execute();
        }

        [StepDefinition(@"a (POST|GET|PUT|DELETE) request using \{(.*)\} = (.*) is executed")]
        public void WhenARequestUsingIsExecuted(Method method, string placeholder, Variable value)
        {
            this.restSession.Request.AddUrlSegment(placeholder, value);
            this.WhenARequestIsExecuted(method);
        }

    }
}
