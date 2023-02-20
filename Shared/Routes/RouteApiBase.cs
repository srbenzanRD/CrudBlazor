
namespace CrudBlazor.Shared.Routes;

public class RouteApiBase
{
    public const string API = "/api";
    public int Id { get; set; }
    public const string IdParameter = "{Id:int}";

}

public class UsuarioRolRouteManager:RouteApiBase
{
   public const string BASE = $"{API}/roles"; 
   public const string GetById = $"{BASE}/{IdParameter}";// /api/roles/{Id:int}
   public static string BuildRoute(int Id) => GetById.Replace(IdParameter,Id.ToString());
}
public class UsuarioRouteManager:RouteApiBase
{
   public const string BASE = $"{API}/users"; 
   public const string GetById = $"{BASE}/{IdParameter}";// /api/roles/{Id:int}
   public static string BuildRoute(int Id) => GetById.Replace(IdParameter,Id.ToString());
}