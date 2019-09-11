using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace APIFramework.Steps
{
    [Binding]
    public class ValidationSteps
    {
        private readonly RestSession restSession;

        public ValidationSteps(RestSession restSession)
        {
            this.restSession = restSession;
        }

        [StepDefinition(@"HTTP Code is (.*)")]
        public void ThenHttpCodeIs(HttpStatusCode code)
        {
            Assert.AreEqual(code, this.restSession.Response.StatusCode, this.restSession.Response.Content);
        }
    }
}
