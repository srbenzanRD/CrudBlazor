
using System.ComponentModel.DataAnnotations;

namespace CrudBlazor.Server.Models;

public class Usuario
{
    [Key]
    public int Id { get; set; }
    public int UsuarioRolId { get; set; }
    public virtual UsuarioRol UsuarioRol { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Nickname { get; set; } = null!;
    public string Password { get; set; } = null!;
}