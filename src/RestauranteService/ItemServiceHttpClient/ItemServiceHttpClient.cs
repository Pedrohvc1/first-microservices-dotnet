using RestauranteService.Dtos;

namespace RestauranteService.ItemServiceHttpClient;

public class ItemServiceHttpClient : IItemServiceHttpClient
{
    public ItemServiceHttpClient(HttpClient client)
    {
        
    }
    public void EnviaRestauranteParaItemService(RestauranteReadDto readDto)
    {
        throw new NotImplementedException();
    }
}
