using Newtonsoft.Json;
using Pronia.ViewModels;

namespace Pronia.Services
{
    public class LayoutService
        {
            private readonly IHttpContextAccessor _http;

            public LayoutService(IHttpContextAccessor http)
            {
                _http = http;

            }
            public BasketItem GetBasket()
            {
                string basketStr = _http.HttpContext.Request.Cookies["basket"] ?? "";

                BasketItem basket = JsonConvert.DeserializeObject<BasketItem>(basketStr)!;
                return basket;
            }
        }
    }

