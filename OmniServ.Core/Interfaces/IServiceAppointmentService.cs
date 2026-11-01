using OmniServ.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmniServ.Core.Interfaces
{
    public interface IServiceAppointmentService
    {
        Task<IEnumerable<ServiceAppointment>> GetAllAsync();
        Task<ServiceAppointment?> GetByIdAsync(int id);
        Task<ServiceAppointment> CreateAsync(ServiceAppointment serviceAppointment);
        Task UpdateAsync(ServiceAppointment serviceAppointment);
        Task DeleteAsync(int id);

    }
}
