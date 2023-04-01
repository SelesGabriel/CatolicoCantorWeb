namespace CatolicoCantorWeb.Models
{
    public class Playlist
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<int> IdMusicas { get; set; }
        public int IdUsuario { get; set; }
        public bool Publica { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
