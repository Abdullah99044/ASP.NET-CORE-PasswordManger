using Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.Services
{
    public interface IPassWordsServics
    {

        public Task<List<passwords>> GetPasswords();

        public Task<passwords> GetAPassword(int passwordID);
        public Task CreatePassword(passwords password);

        public Task DeletePassword(int password);
       
        public Task UpdatePassword(passwords password);

    }
}
