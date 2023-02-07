using NUnitt_Test_Crud;
using NUnitt_Test_Crud.Data;
using NUnitt_Test_Crud.Model;
using NUnitt_Test_Crud.Controllers;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Nunit_TestAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Web.Http;

namespace Nunit_TestAPI
{

    [TestFixture]
    public class Tests
    {

        public DBContextClass _context;
        private DBContextClass repository;
        public static DbContextOptions<DBContextClass> dbContextOptions { get; }
        public static string connectionString = "Data Source=DESKTOP-QEIH22N;Initial Catalog=NunitTest;Integrated Security=True;Trust Server Certificate=true;";

            static Tests()
            {
               dbContextOptions = new DbContextOptionsBuilder<DBContextClass>()
                   .UseSqlServer(connectionString)
                   .Options;
        }
        
        //TestClass testClass;

        [SetUp]
        public void Setup()

        {

           // DbContext _context;
        _context = new DBContextClass(dbContextOptions);
        }

        [Test]
        public async Task  Test1()
        {
           
            int postId = 3;
            var controller = new TestClassesController(_context);

            //var controller = new TestClassesController(context);
            //Act  
            var data = await controller.GetTestClass(postId);
            //Assert.IsInstanceOf<OkResult>;
            //IsType<OkObjectResult>(data);
            //Assert.IsInstanceOf<BadRequestObjectResult>(data);
            //this.mockRepository.Verify();
            Assert.IsInstanceOf<OkResult>(data.Result);

            ////Assert  
            //Assert.IsType<OkObjectResult>(data);

            //var okResult = data.Should().BeOfType<OkObjectResult>().Subject;
            //var post = okResult.Value.Should().BeAssignableTo<PostViewModel>().Subject;

            //Assert.Equal("Test Title 1", post.Title);
            //Assert.Equal("Test Description 1", post.Description);

            //var controller = new TestClassesController(dbContextClass);
            //var postId = 2;

            //Act  
            //var data =  await controller.PostTestClass(testClass);

            //Assert  
            ////Assert.Is<OkObjectResult>(data);
            ////Assert
        }
    }
}