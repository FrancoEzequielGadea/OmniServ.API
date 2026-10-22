using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmniServ.DataLayer.Entities
{
    public class ServiceAppointment
    {
        public int Id { get; set; }
        public DateTime AppointmentScheduleDate { get; set; }
        public string AppointmentDescription { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public int AssetId { get; set; }
        public Asset Asset { get; set; } = null!;
    }
}
