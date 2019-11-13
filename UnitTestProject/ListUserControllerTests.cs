using BLL;
using BlogPostApp.Controllers;
using BOL;
using Moq;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Xunit;

namespace UnitTestProject
{
    public class ListUserControllerTests
    {
        private Mock<IUserBS> _UserBSMock;
        tbl_user user = new tbl_user();
        List<tbl_user> users = new List<tbl_user>();

        [Fact]
        public void Index_List_Users_Success()
        {
            _UserBSMock = new Mock<IUserBS>();
             users.Add(user);
            _UserBSMock.Setup(x => x.GetALL()).Returns(users);
            var controller = new ListUserController(_UserBSMock.Object);
            var result = controller.Index() as ViewResult;
            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void Index_List_Users_ThrowsError()
        {
            _UserBSMock = new Mock<IUserBS>();
            users.Add(user);
            _UserBSMock.Setup(x => x.GetALL()).Throws(new Exception());
            var controller = new ListUserController(_UserBSMock.Object);
            // Assert
            Assert.ThrowsAny<Exception>(() => controller.Index());
        }
    }
}
