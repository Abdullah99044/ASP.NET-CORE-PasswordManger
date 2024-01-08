using Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repository
{
    public interface IPassWordsRepo
    {

        public Task<List<passwords>> GetAllPasswords();

        public Task<passwords> GetAPassword(int passwordID);
        public Task CreatePassword(passwords password);

        public Task DeletePassword(int passwordId);

        public Task UpdatePassword(passwords passwordId);



    }
}
