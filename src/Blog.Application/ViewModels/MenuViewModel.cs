namespace Blog.Application.ViewModels
{
    public class MenuViewModel
    {
        public int Id { get; set; }
        public int Pai { get; set; }
        public int Ordem { get; set; }
        public string Descricao { get; set; }
        public string Titulo { get; set; }
    }
}
