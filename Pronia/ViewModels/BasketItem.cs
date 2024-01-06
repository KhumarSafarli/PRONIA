﻿namespace Pronia.ViewModels
{
    public class BasketItem
    {
        public List<CookieItem> CookieItems { get; set; } = null!;
        public int Count { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
