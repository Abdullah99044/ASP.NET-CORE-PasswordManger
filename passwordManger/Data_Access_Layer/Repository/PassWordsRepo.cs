using Data_Access_Layer.Data;
using Data_Access_Layer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repository
{
    public class PassWordsRepo : IPassWordsRepo
    {

        private readonly ApplicationDbContext _db;

        public PassWordsRepo(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task CreatePassword(passwords password)
        {
             
            await _db.passwords.AddAsync(password);
            await _db.SaveChangesAsync();

        }

        public async Task DeletePassword(int passwordId)
        {

            var password = await _db.passwords.FindAsync(passwordId);

            _db.passwords.Remove(password);
            _db.SaveChangesAsync();
        }

        public async Task<List<passwords>> GetAllPasswords()
        {
            return await _db.passwords.ToListAsync();
        }

        public async Task<passwords> GetAPassword(int passwordID)
        {
            return await _db.passwords.FindAsync(passwordID);
        }

        public async Task UpdatePassword(passwords password)
        {
            _db.passwords.Update(password);
            await _db.SaveChangesAsync();
        }
    }
}
