using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OmniServ.DataLayer.Entities;

namespace OmniServ.Core.Interfaces
{
    public interface IRentalOrderService
    {
        Task<IEnumerable<RentalOrder>> GetAllAsync();
        Task<RentalOrder?> GetByIdAsync(int id);
        Task<RentalOrder> CreateAsync(RentalOrder rentalOrder);
        Task UpdateAsync(RentalOrder rentalOrder);
        Task DeleteAsync(int id);
    }
}
