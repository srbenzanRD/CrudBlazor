using CrudBlazor.Shared.Wrapper;
using Newtonsoft.Json;

namespace CrudBlazor.Client.Extensions;

internal static class ResultExtension
{
    internal static async Task<Result<T>> ToResult<T>(this HttpResponseMessage response)
    {
        var respuesta_a_texto = await response.Content.ReadAsStringAsync();
        var objeto = JsonConvert.DeserializeObject<Result<T>>(respuesta_a_texto);
        return objeto!;
    }
    internal static async Task<ResultList<T>> ToResultList<T>(this HttpResponseMessage response)
    {
        var respuesta_a_texto = await response.Content.ReadAsStringAsync();
        var objeto = JsonConvert.DeserializeObject<ResultList<T>>(respuesta_a_texto);
        return objeto!;
    }
}