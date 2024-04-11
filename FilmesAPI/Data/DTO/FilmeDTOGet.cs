using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.DTO;

public class FilmeDTOGet
{
    public string Titulo { get; set; }
    public string Genero { get; set; }
    public int Duracao { get; set; }
    public DateTime DataDaConsulta { get; set; } = DateTime.Now;
}
