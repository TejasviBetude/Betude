using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIDemo01.Models;


namespace WebAPIDemo01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        static List<UserModel> UsersList;
        public UsersController()
        {
            UsersList = new List<UserModel>()
            {
                new UserModel(){UserId=1,UserName="Peter",Password="testpeter"},
                new UserModel(){UserId=2,UserName="Customer",Password="testCustomer"},
                new UserModel(){UserId=3,UserName="User",Password="Testuser"}

            };
        }
        [HttpGet]
        public IEnumerable<UserModel> Get()

        {
            return UsersList;
        }
        [HttpGet("{id}")]
        public UserModel GetUserById(int id)
        {
            UserModel user = UsersList.FirstOrDefault(u => u.UserId == id);

            return user;
        }

        [HttpPost]
        public IEnumerable<UserModel> PostUser(UserModel model)
        {
            UsersList.Add(model);
            return UsersList;
        }
        [HttpPut]
        public IEnumerable<UserModel> PutUser(UserModel model)
        {
            int index = UsersList.FindIndex(u => u.UserId == model.UserId);
            UserModel newuser = UsersList.FirstOrDefault(u => u.UserId == model.UserId);
            newuser.UserName = model.UserName;
            newuser.Password = model.Password;
            UsersList.Add(model);
            UsersList[index] = model;
            return UsersList;   
        }

        [HttpDelete]
        public void DeleteUser (UserModel model)
        {
            UserModel user = UsersList.FirstOrDefault(u => u.UserId == model.UserId);
            UsersList.Remove(user);
                       
        }
    }
}
