using System.ComponentModel.DataAnnotations;

namespace CatolicoCantorWeb.Models
{
    public class Music
    {
        
        public int Id { get; set; }
        [Required(ErrorMessage ="Nome é obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage ="Cantor é obrigatório")]
        public string Cantor { get; set; }
        //[Required(ErrorMessage ="Categoria é obrigatório")]
        [Required(ErrorMessage ="Letra é obrigatório")]
        public string Letra { get; set; }
        [Required(ErrorMessage ="Cifra é obrigatório")]
        public string Cifra { get; set; }
        [Required(ErrorMessage ="Youtube é obrigatório")]
        public string Youtube { get; set; }
        //[Required(ErrorMessage ="Tags é obrigatório")]
        public string Tags { get; set; }
        public List<Category> Categories { get; set; } = new List<Category> { };

    }
}
