using System.ComponentModel.DataAnnotations;

namespace ClubesApi.Models;

public class Clube
{

    [Required(ErrorMessage = "O nome é obrigatório!")] 
    public string Nome { get; set; }
    [Required]
    public int Idade { get; set; }
    [Required]
    public string PresidenteAtual { get; set; }
    [Required]
    public int QntdTitulosNacionais { get; set; }
    [Required]
    public int QntdTitulosInternacionais { get; set; }
}
