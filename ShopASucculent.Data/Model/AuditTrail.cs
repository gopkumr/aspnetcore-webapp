using System;

namespace ShopASucculent.Data.Model
{
    public class AuditTrail
    {
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}

