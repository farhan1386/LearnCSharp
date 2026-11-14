using System;
using System.Collections.Generic;
using System.Text;

namespace Phase_5_Design_Patterns.Week_6_Creational_Design_Patterns.Builder.Contracts
{
    public class OrderManifest
    {
        public string OrderId { get; internal set; } = string.Empty;
        public string CustomerId { get; internal set; } = string.Empty;
        public string Sku { get; internal set; } = string.Empty;
        public int Quantity { get; internal set; } = 1;
        public string PromoCode { get; internal set; } = "None";
        public bool IsGiftWrapped { get; internal set; } = false;
        public string Notes { get; internal set; } = string.Empty;
    }
}
