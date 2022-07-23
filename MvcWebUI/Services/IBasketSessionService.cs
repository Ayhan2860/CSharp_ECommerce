using Entities.Concrete;

namespace MvcWebUI.Services
{
    public interface IBasketSessionService
    {
        Basket GetBasket();
        void SetBasket(Basket basket);
    }
}