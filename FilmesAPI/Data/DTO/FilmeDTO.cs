using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.DTO;

public class FilmeDTO
{
    [Required(ErrorMessage = "O titulo do filme é obrigatório")]
    public string Titulo { get; set; }
    [Required(ErrorMessage = "O genero do filme é obrigatório")]
    [StringLength(50, ErrorMessage = "O genero nao pode conter mais do que 50 caracteres")]
    public string Genero { get; set; }
    [Required(ErrorMessage = "A duração do filme é obrigatória")]
    [Range(60, 600, ErrorMessage = "A duracao deve ser de no mínimo 1 hora e no máximo 6 horas")]
    public int Duracao { get; set; }
}
