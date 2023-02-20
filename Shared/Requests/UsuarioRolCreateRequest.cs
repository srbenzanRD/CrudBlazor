
using System.ComponentModel.DataAnnotations;

namespace CrudBlazor.Shared.Requests;

public class UsuarioRolCreateRequest
{
    [
        Required(ErrorMessage = "Se debe proporcionar el nombre del rol"),
        MinLength(5, ErrorMessage ="El nombre debe superar los 5 caracteres."), 
        MaxLength(100,ErrorMessage ="El nombre no debe superar los 100 caracteres.")
    ]
    public string Nombre { get; set; } = null!;
    public bool PermisoParaCrear { get; set; }
    public bool PermisoParaEditar{ get; set; }
    public bool PermisoParaEliminar{ get; set; }
}
