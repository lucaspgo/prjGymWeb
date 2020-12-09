using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace prjCapeloWeb.Models
{
    public class Pessoa : IdentityUser
    {
        public Pessoa() => CriadoEm = DateTime.Now;

        public DateTime CriadoEm { get; set; }
    }
}
