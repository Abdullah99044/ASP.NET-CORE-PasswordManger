using Azure;
using Data_Access_Layer.Data;
using Data_Access_Layer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

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

        public pageResponse GetAllPasswords(int page , string? search)
        {


            IQueryable<passwords> query = _db.passwords;

            
            if(!string.IsNullOrEmpty(search))
            {
                 query = query.Where(u => u.Name.Contains(search));
            }


            //When you finished the users table , get the just users passwords
            //else
            //{
            //    query = query;
            //}
            

            var pageRsults = 3f;
            var pageCount = Math.Ceiling(query.Count() / pageRsults);
            var paginatedQuery = query.Skip((page - 1) * (int)pageRsults).Take((int)pageRsults).ToList();



            var response = new pageResponse()
            {
                userPasswords = paginatedQuery,
                currentPage = page,
                pages = pageCount
            };

            return response;

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
