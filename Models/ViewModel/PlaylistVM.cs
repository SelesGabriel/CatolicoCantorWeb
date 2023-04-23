namespace CatolicoCantorWeb.Models.ViewModel
{
    public class PlaylistVM
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public int IdUsuario { get; set; }
        public bool Publica { get; set; }
        public DateTime DataCriacao { get; set; }

        public List<Music> Musics { get; set; }
    }
}
