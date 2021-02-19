using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Domain
{
    public class Item : BaseEntity
    {
        public string ItemName { get; set; }
        public int ItemNo { get; set; }
    }
}
