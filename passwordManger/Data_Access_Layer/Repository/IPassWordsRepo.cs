
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

        public pageResponse GetAllPasswords(int page  , string? search);

        public  passwords  GetAPassword(int passwordID);
        public void CreatePassword(passwords password);

        public void DeletePassword(int passwordId);

        public void UpdatePassword(passwords passwordId);



    }
}
