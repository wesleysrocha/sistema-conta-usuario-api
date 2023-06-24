namespace SistemaContaUsuario.Models
{
 public class ContaUsuario
 {
 public long id { get; set; }
 public string? titular { get; set; }
 public string? email { get; set; }
 public int agencia { get; set; }
 public string? numero { get; set; }
 public string? tipoConta { get; set; }
 public double saldo { get; set; }
 }
}