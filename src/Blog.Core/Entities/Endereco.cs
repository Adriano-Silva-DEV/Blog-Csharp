using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core.Entities
{
   public class Endereco
    {
        public String Rua { get; set;}
        public String Numero { get; set; }
        public String Bairro { get; set; }
        public String Cidade { get; set; }
        public String Estado { get; set; }
        public double Longitude { get; set; }
        public double Latidude { get; set; }
    }
}
