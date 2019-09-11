using System.Security.AccessControl;
using System.Web.UI.WebControls;
using RestSharp;
using TechTalk.SpecFlow;

namespace APIFramework.Steps
{
    public class RestSession
    {
        private readonly SpecFlowContext scenarioContext;

        private RestSession(IRestClient client, IRestRequest request, SpecFlowContext scenarioContext)
        {
            this.Client = client;
            this.Request = Request;
            this.scenarioContext = scenarioContext;
        }

        public IRestClient Client { get; }

        public IRestRequest Request { get; }

        public IRestResponse Response => this.scenarioContext.Get<IRestResponse>();

        public void Execute()
        {
            this.scenarioContext.Set(this.Client.Execute(this.Request));
        }
    }
}
