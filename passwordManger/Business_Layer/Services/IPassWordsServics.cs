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

        public  List<passwords>  GetPasswords();

        public  passwords  GetAPassword(int passwordID);
        public void CreatePassword(passwords password);

        public void DeletePassword(int password);
       
        public void UpdatePassword(passwords password);

    }
}
