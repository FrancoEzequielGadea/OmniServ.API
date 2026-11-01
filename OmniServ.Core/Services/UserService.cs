using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using OmniServ.Core.Interfaces;
using OmniServ.DataLayer.Data;
using OmniServ.DataLayer.Entities;

namespace OmniServ.Core.Services
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _context;

        public UserService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<User> CreateAsync(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task UpdateAsync(int id, User user)
        {
            User? originalUser = await _context.Users.FindAsync(id);

            if (originalUser == null)
            {
                throw new KeyNotFoundException($"User with ID {user.Id} was not found.");
            }

            originalUser.Email = user.Email;
            originalUser.Name = user.Name;

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync (int id)
        {
            User? userToDelete = await _context.Users.FindAsync(id);
            if (userToDelete != null)
            {
                _context.Remove(userToDelete);
                await _context.SaveChangesAsync();
            }
        }
    }
}
