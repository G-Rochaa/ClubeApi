using System.ComponentModel.DataAnnotations;

namespace ClubesApi.Models;

public class Clube
{
    public int Id { get; set; }     //ID não é required pois o sistema passará ele, não o usuário!

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
