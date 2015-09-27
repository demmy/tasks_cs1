using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Taisiya
{
    interface IInternetShop
    {
        event NewGoods goodsArrived;

        string Title { get; }

        List<IGoods> GoodsList { get; }
        List<IGoods> FavouritesList { get; }
        Dictionary<IGoods, double> BasketList { get; }

        void AddToShop(IGoods product);
        void NewAddToShop(IGoods product);

        void NewGoodsArrived();

        void ShowGoods();
        void ShowBasket();
        void ShowFavourites();

        void IsGoodsAvailable(string product);
        void AddToBasket(IGoods product, double quantity);
        void AddToFavourites(IGoods product);
        void RemoveFromBasket(IGoods product);
        void RemoveFromFavourites(IGoods product);
        void Buy();        
    }
}
