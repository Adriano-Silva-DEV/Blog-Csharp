using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core.Entities
{
    public class Menu
    {
        public int Id { get; set; }
        public int Pai { get; set; }
        public int Ordem { get; set; }
        public string Descricao { get; set; }
        public string Titulo { get; set; }
    }
}
