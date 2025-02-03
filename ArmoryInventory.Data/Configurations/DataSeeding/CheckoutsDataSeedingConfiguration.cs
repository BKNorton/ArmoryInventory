using ArmoryInventory.Domain.Enums;
using ArmoryInventory.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmoryInventory.Data.Configurations.DataSeeding
{
    internal class CheckoutsDataSeedingConfiguration : IEntityTypeConfiguration<Checkout>
    {
        public void Configure(EntityTypeBuilder<Checkout> builder)
        {
            builder.HasData(
                    new Checkout()
                    {
                        Id = 1,
                        ItemId = new Guid("C7BB57A3-F967-47F8-A4A4-D4529E898C25"),
                        DateCheckedOut = new DateTime(2019, 05, 09, 9, 15, 0),
                        DateCheckedIn = null,
                        CheckedOutTo = "Captain",
                        DefectsBefore = new List<string>(),
                        DefectsAfter = new List<string>(),
                    },
                    new Checkout()
                    {
                        Id = 2,
                        ItemId = new Guid("C7BB57A3-F967-47F8-A4A4-D4529E898C25"),
                        DateCheckedOut = new DateTime(2020, 05, 09, 9, 15, 0),
                        DateCheckedIn = null,
                        CheckedOutTo = "Captain",
                        DefectsBefore = new List<string>(),
                        DefectsAfter = new List<string>(),
                    }
            );
        }
    }
}
