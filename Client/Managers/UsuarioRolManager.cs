using CrudBlazor.Shared.Wrapper;
using CrudBlazor.Shared.Records;
using CrudBlazor.Shared.Routes;
using CrudBlazor.Client.Extensions;

namespace CrudBlazor.Client.Managers;

public interface IUsuarioRolManager
{
    Task<ResultList<UsuarioRolRecord>> GetAsync();
}

public class UsuarioRolManager : IUsuarioRolManager
{
    private readonly HttpClient httpClient;

    public UsuarioRolManager(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }

    public async Task<ResultList<UsuarioRolRecord>> GetAsync()
    {
        try
        {
            var response = await httpClient.GetAsync(UsuarioRolRouteManager.BASE);
            var resultado = await response.ToResultList<UsuarioRolRecord>();
            return resultado;
        }
        catch (Exception e)
        {
            return ResultList<UsuarioRolRecord>.Fail(e.Message);
        }
    }
}