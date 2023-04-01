using Blazorise;
using CatolicoCantorWeb.Models;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;

namespace CatolicoCantorWeb.Mock
{
    public class Mocks
    {
        public Mocks() { }

        public async Task <List<Music>> GetMusics()
        {
            return new List<Music>
            {
                new Music{
                    Id= 1,
                    Cantor= "PADRE MARCELO ROSSI",
                    Nome= "DEUS É DEZ",
                    Categorias = new List<string>{"comunhão / ","pós comunhão"},
                    Letra= "https://www.letras.mus.br/eliana-ribeiro/783808/",
                    Cifra="https://www.cifraclub.com.br/eliana-ribeiro/gloria-deus-nas-alturas/",
                    Youtube= "http://www.youtube.com/embed/-y79-W318Gs",
                    Tags= "padre marcelo rossi deus é dez deus é 10",
                },
                new Music{
                    Id= 2,
                    Cantor= "COLO DE DEUS",
                    Nome= "DESPERTA",
                    Categorias = new List<string>{"comunhão / ","pós comunhão"},
                    Letra= "https://www.letras.mus.br/eliana-ribeiro/783808/",
                    Cifra="https://www.cifraclub.com.br/eliana-ribeiro/gloria-deus-nas-alturas/",
                    Youtube= "http://www.youtube.com/embed/XtrBoeXXpu8",
                    Tags= "padre marcelo rossi deus é dez deus é 10",
                },
                new Music{
                    Id= 3,
                    Cantor= "PADRE MARCELO ROSSI",
                    Nome= "NOITES TRAIÇOEIRAS",
                    Categorias = new List<string>{"comunhão / ","pós comunhão"},
                    Letra= "https://www.letras.mus.br/eliana-ribeiro/783808/",
                    Cifra="https://www.cifraclub.com.br/eliana-ribeiro/gloria-deus-nas-alturas/",
                    Youtube= "http://www.youtube.com/embed/7w83Qn-Tlm8",
                    Tags= "padre marcelo rossi deus é dez deus é 10",
                },
                new Music{
                    Id= 4,
                    Cantor= "PADRE MARCELO ROSSI",
                    Nome= "DEUS É DEZ",
                    Categorias = new List<string>{"comunhão / ","pós comunhão"},
                    Letra= "https://www.letras.mus.br/eliana-ribeiro/783808/",
                    Cifra="https://www.cifraclub.com.br/eliana-ribeiro/gloria-deus-nas-alturas/",
                    Youtube= "http://www.youtube.com/embed/Wj2ByWbya9g",
                    Tags= "padre marcelo rossi deus é dez deus é 10",
                },
            };
        }

        public async Task<List<Playlist>> GetPlaylists()
        {
            return new List<Playlist>
            {
                new Playlist
                {
                    Id = 1,
                    DataCriacao = DateTime.UtcNow,
                    IdMusicas = new List<int> { 1, 2, 3, 4},
                    IdUsuario = 1,
                    Nome = "Missa",
                    Publica = true
                },
                new Playlist
                {
                    Id = 2,
                    DataCriacao = DateTime.UtcNow,
                    IdMusicas = new List<int> { 3, 2, 4,},
                    IdUsuario = 1,
                    Nome = "Adoração",
                    Publica = true
                }
            };
        }
    }
}
