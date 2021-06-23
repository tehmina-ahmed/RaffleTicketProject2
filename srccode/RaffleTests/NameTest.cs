using Microsoft.AspNetCore.Mvc;
using Name.Controllers;
//using RaffleTests.NameController;
using System;
using Xunit;

namespace RaffleTests.Controller
{
    public class NameTest
    {
        [Fact]
        public void GetTest()
        {
            //Arrange 
            NameController nameController = new NameController();
            var nameControllerResult = nameController.Get();

            Assert.NotNull(nameControllerResult);
            Assert.IsType<ActionResult<string>>(nameControllerResult);
               

            
            //Act 

            //Assert 
        }
        //[Fact]
        //public void GetNameControllers()
        //{

        //}
    }
}
