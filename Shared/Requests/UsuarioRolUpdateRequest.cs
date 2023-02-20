
using System.ComponentModel.DataAnnotations;

namespace CrudBlazor.Shared.Requests;

public class UsuarioRolUpdateRequest : UsuarioRolCreateRequest
{
    [Required(ErrorMessage = "Se debe proporcionar el Id del rol a modificar")]
    public int Id { get; set; }
}