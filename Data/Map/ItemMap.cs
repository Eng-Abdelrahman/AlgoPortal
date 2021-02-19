using Data.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Map
{
    public class ItemMap
    {
        public ItemMap(EntityTypeBuilder<Item> entityBuilder)
        {
            entityBuilder.HasKey(p => p.Id);
            entityBuilder.Property(p => p.Id).IsRequired();
        }
    }
}
