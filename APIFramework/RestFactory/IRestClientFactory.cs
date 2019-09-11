using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace APIFramework.RestFactory
{
    public interface IRestClientFactory
    {
        IRestClient Create();
    }
}
