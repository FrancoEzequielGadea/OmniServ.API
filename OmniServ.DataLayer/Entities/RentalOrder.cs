using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmniServ.DataLayer.Entities
{
    public class RentalOrder
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public decimal TotalCost { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public int AssetId { get; set; }
        public Asset Asset { get; set; } = null!;
    }
}
