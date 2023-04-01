namespace CatolicoCantorWeb.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string NomeCompleto { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
