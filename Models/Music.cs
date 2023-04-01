namespace CatolicoCantorWeb.Models
{
    public class Music
    {
        
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cantor { get; set; }
        public List<string> Categorias { get; set; }
        public string Letra { get; set; }
        public string Cifra { get; set; }
        public string Youtube { get; set; }
        public string Tags { get; set; }
    }
}
