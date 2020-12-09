using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjCapeloWeb.Utils
{
    public class Sessao
    {
        private readonly IHttpContextAccessor _http;

        public Sessao(IHttpContextAccessor http) => _http = http;    
    }
}
