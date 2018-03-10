using System;
using System.Collections.Generic;

namespace Services.Models
{
    public class ShoppingCart
    {
        public long ShoppingCartId
        {
            get;set;
        }

        public long UserId
        {
            get;set;
        }

        public DateTime CreatedOn
        {
            get;set;
        }

        public DateTime LastUpdatedOn
        {
            get;set;
        }

        public List<ProductItem> Items
        {
            get;set;
        }
    }
}
