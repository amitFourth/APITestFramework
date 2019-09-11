using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace APIFramework.RestFactory
{
    public interface IRestRequestFactory
    {
        IRestRequest Create(string resource, Method method);
    }
}
