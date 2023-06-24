using Microsoft.EntityFrameworkCore;
namespace SistemaContaUsuario.Models
{
 public class ContaUsuarioContext : DbContext
 {
 public ContaUsuarioContext(DbContextOptions<ContaUsuarioContext> options)
 : base(options)
 {
 }
 public DbSet<ContaUsuario> ContasUsuarios { get; set; } = null!;
 }
}
