using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmoryInventory.Domain.Models
{
    public class Checkout
    {
        public int Id { get; set; }
        public Guid ItemId { get; set; }
        public Item Item { get; set; }
        public DateOnly DateCheckedOut { get; set; }
        public DateOnly? DateCheckedIn { get; set; }
        public string CheckedOutTo { get; set; }
        public List<string> DefectsBefore { get; set; }
        public List<string>? DefectsAfter { get; set; }
    }
}
