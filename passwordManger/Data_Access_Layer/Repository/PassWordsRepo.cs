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

        public   void CreatePassword(passwords password)
        {
             
             _db.passwords.Add(password);
             _db.SaveChanges();

        }

        public  void   DeletePassword(int passwordId)
        {

            var password =   _db.passwords.Find(passwordId);

            _db.passwords.Remove(password);
            _db.SaveChanges();
        }

        public  List<passwords>  GetAllPasswords()
        {
            return   _db.passwords.ToList();
        }

        public  passwords  GetAPassword(int passwordID)
        {
            return   _db.passwords.Find(passwordID);
        }

        public  void UpdatePassword(passwords password)
        {
            _db.passwords.Update(password);
             _db.SaveChanges();
        }
    }
}
