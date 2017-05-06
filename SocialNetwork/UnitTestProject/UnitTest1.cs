using System;
using System.Threading.Tasks;
using BLL.DTO;
using BLL.Infrastructure;
using BLL.Services;
using DAL.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL.Repositories;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task TestMethod1()
        {
            UserIdentityService userService = new UserIdentityService(new UnitOfWork("DefaultConnection"));
            UserDTO userDto = new UserDTO()
            {
                Email = "a@gmail.com",
                LastName = "B",
                FirstName = "A",
                Password = "qwerty",
                Role = "user",

            };
            //try
            //{
            //    OperationDetails operationDetails = await userService.Create(userDto);
            //}
            //catch (Exception e)
            //{
                
            //}
            
        }
    }
}
