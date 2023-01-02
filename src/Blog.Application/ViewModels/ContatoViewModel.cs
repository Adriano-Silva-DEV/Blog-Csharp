using Blog.Core.Entities;

namespace Blog.Application.ViewModels
{
    public class ContatoViewModel
    {
        public List<TelefoneViewModel> Telefones { get; set; }
        public String Email { get; set; }
        public String Facebook { get; set; }
        public String Instagram { get; set; }
        public String Youtube { get; set; }
        public String Twitter { get; set; }
        public String Linkedin { get; set; }
        public DateTime HorarioAbertura { get; set; }
        public DateTime HorarioFechamento { get; set; }
    }
}
