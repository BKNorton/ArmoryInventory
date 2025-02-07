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
                        DateCheckedOut = new DateOnly(2019, 05, 09),
                        DateCheckedIn = null,
                        CheckedOutTo = "Captain",
                        DefectsBefore = new List<string>(),
                        DefectsAfter = new List<string>(),
                    },
                    new Checkout()
                    {
                        Id = 2,
                        ItemId = new Guid("C7BB57A3-F967-47F8-A4A4-D4529E898C25"),
                        DateCheckedOut = new DateOnly(2020, 05, 09),
                        DateCheckedIn = null,
                        CheckedOutTo = "Captain",
                        DefectsBefore = new List<string>(),
                        DefectsAfter = new List<string>(),
                    },
                    new Checkout()
                    {
                        Id = 2,
                        ItemId = new Guid("05EB7F71-CC56-48C9-B886-2D3A9352057C"),
                        DateCheckedOut = new DateOnly(2018, 07, 20),
                        DateCheckedIn = null,
                        CheckedOutTo = "Alpha Battery",
                        DefectsBefore = new List<string>(),
                        DefectsAfter = new List<string>(),
                    },
                    new Checkout()
                    {
                        Id = 2,
                        ItemId = new Guid("05EB7F71-CC56-48C9-B886-2D3A9352057C"),
                        DateCheckedOut = new DateOnly(2018, 10, 12),
                        DateCheckedIn = null,
                        CheckedOutTo = "Alpha Battery",
                        DefectsBefore = new List<string>(),
                        DefectsAfter = new List<string>(),
                    },
                    new Checkout()
                    {
                        Id = 2,
                        ItemId = new Guid("05EB7F71-CC56-48C9-B886-2D3A9352057C"),
                        DateCheckedOut = new DateOnly(2019, 07, 20),
                        DateCheckedIn = null,
                        CheckedOutTo = "Charlie Battery",
                        DefectsBefore = new List<string>(),
                        DefectsAfter = new List<string>(),
                    },
                    new Checkout()
                    {
                        Id = 2,
                        ItemId = new Guid("05EB7F71-CC56-48C9-B886-2D3A9352057C"),
                        DateCheckedOut = new DateOnly(2019, 05, 10),
                        DateCheckedIn = null,
                        CheckedOutTo = "Alpha Battery",
                        DefectsBefore = new List<string>(),
                        DefectsAfter = new List<string>(),
                    },
                    new Checkout()
                    {
                        Id = 2,
                        ItemId = new Guid("05EB7F71-CC56-48C9-B886-2D3A9352057C"),
                        DateCheckedOut = new DateOnly(2019, 02, 05),
                        DateCheckedIn = null,
                        CheckedOutTo = "Alpha Battery",
                        DefectsBefore = new List<string>(),
                        DefectsAfter = new List<string>(),
                    },
                    new Checkout()
                    {
                        Id = 2,
                        ItemId = new Guid("05EB7F71-CC56-48C9-B886-2D3A9352057C"),
                        DateCheckedOut = new DateOnly(2020, 07, 20),
                        DateCheckedIn = null,
                        CheckedOutTo = "First Sergeant",
                        DefectsBefore = new List<string>(),
                        DefectsAfter = new List<string>(),
                    }, new Checkout()
                    {
                        Id = 2,
                        ItemId = new Guid("05EB7F71-CC56-48C9-B886-2D3A9352057C"),
                        DateCheckedOut = new DateOnly(2021, 07, 20),
                        DateCheckedIn = null,
                        CheckedOutTo = "TOC",
                        DefectsBefore = new List<string>(),
                        DefectsAfter = new List<string>(),
                    }, new Checkout()
                    {
                        Id = 2,
                        ItemId = new Guid("05EB7F71-CC56-48C9-B886-2D3A9352057C"),
                        DateCheckedOut = new DateOnly(2022, 07, 20),
                        DateCheckedIn = null,
                        CheckedOutTo = "Bravo Battery",
                        DefectsBefore = new List<string>(),
                        DefectsAfter = new List<string>(),
                    }
            );
        }
    }
}
