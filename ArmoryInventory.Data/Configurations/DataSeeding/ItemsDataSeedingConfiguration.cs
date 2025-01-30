using ArmoryInventory.Domain.Enums;
using ArmoryInventory.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = ArmoryInventory.Domain.Enums.Type;

namespace ArmoryInventory.Data.Configurations.DataSeeding
{
    internal class ItemsDataSeedingConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.HasData(

                new Item()
                {
                    Id = new Guid("C7BB57A3-F967-47F8-A4A4-D4529E898C25"),
                    SerialNumber = "111N5",
                    HasAllComponents = TrueOrFalse.True,
                    MissionCapable = TrueOrFalse.True,
                    CheckedOut = TrueOrFalse.False,
                    ItemType = Type.Radio,
                    Defects = new List<string>() { "Back connectors bent", "Front Light doesn't work" },
                    MissingComponents = new List<string>()
                },
                new Item()
                {
                    Id = new Guid("D507734C-1D27-438C-8CF9-7560E1AA329C"),
                    SerialNumber = "222NF",
                    HasAllComponents = TrueOrFalse.True,
                    MissionCapable = TrueOrFalse.True,
                    CheckedOut = TrueOrFalse.False,
                    ItemType = Type.Antenna,
                    Defects = new List<string>(),
                    MissingComponents = new List<string>() { "Missing 2 stakes", "Missing one blue pole" }
                },
                new Item()
                {
                    Id = new Guid("465EFD68-C55D-4F49-96F0-1C7E0228C805"),
                    SerialNumber = "272N8",
                    HasAllComponents = TrueOrFalse.True,
                    MissionCapable = TrueOrFalse.True,
                    CheckedOut = TrueOrFalse.False,
                    ItemType = Type.Antenna,
                    Defects = new List<string>(),
                    MissingComponents = new List<string>() { "Missing 1 stake", "Missing 2 blue pole", "Missing Hammer" }
                },
                new Item()
                {
                    Id = new Guid("D441A0DB-DFC7-460F-BFC5-44136DBC6A03"),
                    SerialNumber = "342N7",
                    HasAllComponents = TrueOrFalse.False,
                    MissionCapable = TrueOrFalse.False,
                    CheckedOut = TrueOrFalse.False,
                    ItemType = Type.HandMic,
                    Defects = new List<string>() { "Mic key does not work" },
                    MissingComponents = new List<string>()
                },
                new Item()
                {
                    Id = new Guid("672DC07C-16E2-4871-B5CE-8C590C816F0A"),
                    SerialNumber = "233N7",
                    HasAllComponents = TrueOrFalse.True,
                    MissionCapable = TrueOrFalse.True,
                    CheckedOut = TrueOrFalse.True,
                    ItemType = Type.Radio,
                    Defects = new List<string>() { "Back connectors bent", "Front Light does'nt work" },
                    MissingComponents = new List<string>()
                },
                new Item()
                {
                    Id = new Guid("C7A072E9-9175-4403-8C64-BE4BB8D7BB3B"),
                    SerialNumber = "522F4",
                    HasAllComponents = TrueOrFalse.True,
                    MissionCapable = TrueOrFalse.True,
                    CheckedOut = TrueOrFalse.False,
                    ItemType = Type.Antenna,
                    Defects = new List<string>(),
                    MissingComponents = new List<string>() { "Missing 2 stakes", "Missing one blue pole" }
                },
                new Item()
                {
                    Id = new Guid("98CE6FB5-9AB6-4466-B1DA-2D9D2568E1A3"),
                    SerialNumber = "442F4",
                    HasAllComponents = TrueOrFalse.True,
                    MissionCapable = TrueOrFalse.True,
                    CheckedOut = TrueOrFalse.False,
                    ItemType = Type.Antenna,
                    Defects = new List<string>(),
                    MissingComponents = new List<string>() { "Missing 1 stake", "Missing 2 blue pole", "Missing Hammer" }
                },
                new Item()
                {
                    Id = new Guid("CC97F041-7BFB-4D12-AF53-7BCD8AE2B7A2"),
                    SerialNumber = "523F5",
                    HasAllComponents = TrueOrFalse.True,
                    MissionCapable = TrueOrFalse.True,
                    CheckedOut = TrueOrFalse.False,
                    ItemType = Type.HandMic,
                    Defects = new List<string>() { "Mic key does not work" },
                    MissingComponents = new List<string>()
                },
                new Item()
                {
                    Id = new Guid("54B85A9F-7B8D-4AED-AD46-28EFDF0D85B4"),
                    SerialNumber = "372F4",
                    HasAllComponents = TrueOrFalse.True,
                    MissionCapable = TrueOrFalse.True,
                    CheckedOut = TrueOrFalse.True,
                    ItemType = Type.Radio,
                    Defects = new List<string>() { "Back connectors bent", "Front Light does'nt work" },
                    MissingComponents = new List<string>()
                },
                new Item()
                {
                    Id = new Guid("E30F58FF-46EB-452D-827C-F7AF3F5A74DB"),
                    SerialNumber = "522N4",
                    HasAllComponents = TrueOrFalse.True,
                    MissionCapable = TrueOrFalse.True,
                    CheckedOut = TrueOrFalse.False,
                    ItemType = Type.Antenna,
                    Defects = new List<string>(),
                    MissingComponents = new List<string>() { "Missing 2 stakes", "Missing one blue pole" }
                },
                new Item()
                {
                    Id = new Guid("8589C1B6-86D2-4202-92C9-688370F7A3B0"),
                    SerialNumber = "624N2",
                    HasAllComponents = TrueOrFalse.True,
                    MissionCapable = TrueOrFalse.True,
                    CheckedOut = TrueOrFalse.False,
                    ItemType = Type.Antenna,
                    Defects = new List<string>(),
                    MissingComponents = new List<string>() { "Missing 1 stake", "Missing 2 blue pole", "Missing Hammer" }
                },
                new Item()
                {
                    Id = new Guid("3C3DB93C-BA89-4EC7-87B5-02D377BFA7B1"),
                    SerialNumber = "623N5",
                    HasAllComponents = TrueOrFalse.True,
                    MissionCapable = TrueOrFalse.True,
                    CheckedOut = TrueOrFalse.True,
                    ItemType = Type.HandMic,
                    Defects = new List<string>() { "Mic key does not work" },
                    MissingComponents = new List<string>()
                },
                new Item()
                {
                    Id = new Guid("94368184-0101-4E9F-B9DE-A8F3900D415A"),
                    SerialNumber = "124N8",
                    HasAllComponents = TrueOrFalse.True,
                    MissionCapable = TrueOrFalse.True,
                    CheckedOut = TrueOrFalse.True,
                    ItemType = Type.HandMic,
                    Defects = new List<string>() { "Mic key does not work" },
                    MissingComponents = new List<string>()
                },
                new Item()
                {
                    Id = new Guid("24CAA1B3-9433-4883-AD2A-CED8EE8443EF"),
                    SerialNumber = "367N2",
                    HasAllComponents = TrueOrFalse.True,
                    MissionCapable = TrueOrFalse.True,
                    CheckedOut = TrueOrFalse.True,
                    ItemType = Type.Radio,
                    Defects = new List<string>() { "Back connectors bent", "Front Light does'nt work" },
                    MissingComponents = new List<string>()
                },
                new Item()
                {
                    Id = new Guid("05EB7F71-CC56-48C9-B886-2D3A9352057C"),
                    SerialNumber = "355N3",
                    HasAllComponents = TrueOrFalse.False,
                    MissionCapable = TrueOrFalse.False,
                    CheckedOut = TrueOrFalse.False,
                    ItemType = Type.Antenna,
                    Defects = new List<string>(),
                    MissingComponents = new List<string>() { "Missing 2 stakes", "Missing one blue pole" }
                },
                new Item()
                {
                    Id = new Guid("9497AD4E-6814-4350-93DB-D7AD6B700562"),
                    SerialNumber = "557N2",
                    HasAllComponents = TrueOrFalse.True,
                    MissionCapable = TrueOrFalse.True,
                    CheckedOut = TrueOrFalse.False,
                    ItemType = Type.Antenna,
                    Defects = new List<string>(),
                    MissingComponents = new List<string>() { "Missing 1 stake", "Missing 2 blue pole", "Missing Hammer" }
                },
                new Item()
                {
                    Id = new Guid("84AF1935-628B-4203-B782-D9E9A56554D9"),
                    SerialNumber = "363S2",
                    HasAllComponents = TrueOrFalse.True,
                    MissionCapable = TrueOrFalse.True,
                    CheckedOut = TrueOrFalse.False,
                    ItemType = Type.HandMic,
                    Defects = new List<string>() { "Mic key does not work" },
                    MissingComponents = new List<string>()
                },
                new Item()
                {
                    Id = new Guid("D3465F1A-3E4B-4A85-9CDE-8FDC156885AC"),
                    SerialNumber = "867N2",
                    HasAllComponents = TrueOrFalse.True,
                    MissionCapable = TrueOrFalse.True,
                    CheckedOut = TrueOrFalse.False,
                    ItemType = Type.Radio,
                    Defects = new List<string>() { "Back connectors bent", "Front Light does'nt work" },
                    MissingComponents = new List<string>()
                },
                new Item()
                {
                    Id = new Guid("53D080D3-6EBC-4B97-ABD4-E0E3DAEBBD26"),
                    SerialNumber = "865N3",
                    HasAllComponents = TrueOrFalse.True,
                    MissionCapable = TrueOrFalse.True,
                    CheckedOut = TrueOrFalse.False,
                    ItemType = Type.Antenna,
                    Defects = new List<string>(),
                    MissingComponents = new List<string>() { "Missing 2 stakes", "Missing one blue pole" }
                },
                new Item()
                {
                    Id = new Guid("A1CA67D1-265E-473C-8087-E33660DE8CAE"),
                    SerialNumber = "637N2",
                    HasAllComponents = TrueOrFalse.True,
                    MissionCapable = TrueOrFalse.True,
                    CheckedOut = TrueOrFalse.False,
                    ItemType = Type.SKL,
                    Defects = new List<string>(),
                    MissingComponents = new List<string>() { "Missing 1 stake", "Missing 2 blue pole", "Missing Hammer" }
                },
                new Item()
                {
                    Id = new Guid("FB9540A3-33B8-4D0A-8D06-6FF3946BEFD6"),
                    SerialNumber = "467N9",
                    HasAllComponents = TrueOrFalse.True,
                    MissionCapable = TrueOrFalse.True,
                    CheckedOut = TrueOrFalse.False,
                    ItemType = Type.HandMic,
                    Defects = new List<string>() { "Mic key does not work" },
                    MissingComponents = new List<string>()
                }

            );
        }
    }
}
