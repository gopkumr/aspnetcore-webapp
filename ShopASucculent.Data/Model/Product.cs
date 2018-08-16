using System;
using System.Collections.Generic;
using System.Text;

namespace ShopASucculent.Data.Model
{
    public class Product:AuditTrail
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int Quantity { get; set; }
        public virtual ProductCategory Category { get; set; }
        
    }
}
