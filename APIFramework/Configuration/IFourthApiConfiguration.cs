using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIFramework.Configuration
{
    public interface IFourthApiConfiguration
    {
        string BaseUrl { get; }

        IDictionary<string, string> DefaultHeaders { get; }

        string Password { get; }

        string Username { get; }
    }
}
