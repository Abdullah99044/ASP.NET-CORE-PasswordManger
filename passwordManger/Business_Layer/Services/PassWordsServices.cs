using AutoMapper;

using Data_Access_Layer.Models;
using Data_Access_Layer.Repository;
 
 

namespace Business_Layer.Services
{
    public class PassWordsServices : IPassWordsServics
    {

        private readonly IPassWordsRepo _repo;

        private readonly IMapper _mapper;
        public PassWordsServices(IPassWordsRepo repo , IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

 


        //This method get all user passwords
        public pageResponse GetPasswords(int page , string? search)
        {
            return    _repo.GetAllPasswords(page , search);  

        }

        //This method insert user password

        public  void CreatePassword(passwords password)
        {
            
              _repo.CreatePassword(password);
        }

        //This method delete user password

        public void DeletePassword(int password)
        {
           
              _repo.DeletePassword(password);

        }

        //This method get the details of a password for updating
        public  passwords  GetAPassword(int passwordID)
        {

            return   _repo.GetAPassword(passwordID);

        }

        //This method updatae user password
        public void UpdatePassword(passwords password)
        {

               _repo.UpdatePassword(password);
        }

        
    }
}
