using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using Template.Business.Services;
using Template.Interface.Repositories;
using Template.Model.Users;

namespace Template.Business.Test.Services
{
    [TestClass]
    public class UserServiceTest
    {
        private Mock<IUserRepository> userRepositoryMock;

        [TestInitialize]
        public void Initialize()
        {
            userRepositoryMock = new Mock<IUserRepository>();
        }

        [TestMethod, TestCategory("Business"), TestCategory("Business Service")]
        public void Business_UserService_GetUser_Should_Return_User()
        {
            userRepositoryMock.Setup(x => x.GetUser(It.IsAny<string>())).Returns(new User());
            var userService = new UserService(userRepositoryMock.Object);

            var user = userService.GetUser("test");

            Assert.IsNotNull(user, "Expected user object to be returned");
        }

        [TestMethod, TestCategory("Business"), TestCategory("Business Service")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Business_UserService_GetUser_Should_Throw_Error_On_Invalid_Input()
        {
            userRepositoryMock.Setup(x => x.GetUser(It.IsAny<string>())).Returns(new User());
            var userService = new UserService(userRepositoryMock.Object);

            userService.GetUser(string.Empty);
        }
    }
}