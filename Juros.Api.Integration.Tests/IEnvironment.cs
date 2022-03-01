using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Juros.Api.Integration.Tests
{
    public interface IEnvironment
    {
        HttpClient Client { get; }
    }
}
