
namespace CrudBlazor.Shared.Records;

public class UsuarioRecord
{
    public UsuarioRecord()
    {
        
    }
    public UsuarioRecord(int id, UsuarioRolRecord usuarioRol, string name, string nickname, string password)
    {
        Id = id;
        UsuarioRol = usuarioRol;
        Name = name;
        Nickname = nickname;
        Password = password;
    }

    public int Id { get; set; }
    public virtual UsuarioRolRecord UsuarioRol { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Nickname { get; set; } = null!;
    public string Password { get; set; } = null!;
}