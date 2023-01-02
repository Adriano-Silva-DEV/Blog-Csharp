using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core.Entities
{
    public class Contato
    {
        public List<Telefone> Telefones { get; set; }
        public String Email { get; set; }
        public String Facebook { get; set; }
        public String Instagram { get; set; }
        public String Youtube { get; set; }
        public String twitter { get; set; }
        public String Linkedin { get; set; }
        public DateTime HorarioAbertura { get; set; }
        public DateTime HorarioFechamento { get; set; }
    }
}
