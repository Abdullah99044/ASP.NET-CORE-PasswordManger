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
        public async Task<List<passwords>> GetPasswords()
        {
            return await _repo.GetAllPasswords();
        }

        //This method insert user password

        public async Task CreatePassword(passwords password)
        {
            
            await _repo.CreatePassword(password);
        }

        //This method delete user password

        public async Task DeletePassword(int password)
        {
           
            await _repo.DeletePassword(password);

        }

        //This method get the details of a password for updating
        public async Task<passwords> GetAPassword(int passwordID)
        {

            return await _repo.GetAPassword(passwordID);

        }

        //This method updatae user password
        public async Task UpdatePassword(passwords password)
        {

              await _repo.UpdatePassword(password);
        }

        
    }
}
