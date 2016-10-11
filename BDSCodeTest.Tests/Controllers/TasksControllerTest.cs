using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BDSCodeTest;
using BDSCodeTest.Controllers;

namespace BDSCodeTest.Tests.Controllers
{
    
    [TestClass]
    public class TasksControllerTest
    {
        private static bool _isSetup = false;

        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
            //do any global test setup here
            _isSetup = true;
        }

        [ClassCleanup()]
        public static void ClassCleanup()
        {
            //clean up any global setup
            _isSetup = false;
        }

        [TestMethod]
        public void ClassInitialize()
        {
            //Confirm that the initializer was run
            Assert.IsTrue(_isSetup);
        }

        //RFB3: TODO - fillout tests for all these actions
        [TestMethod]
        public void Index()
        {
            // Arrange
            TasksController controller = new TasksController();

            // Act
            ViewResult result = controller.Index(null) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        //[TestMethod]
        //public void Create()
        //{
        //    // Arrange
        //    TasksController controller = new TasksController();

        //    // Act
        //    ViewResult result = controller.Create() as ViewResult;

        //    // Assert
        //    Assert.IsNotNull(result);
        //}

        //[TestMethod]
        //public void Edit()
        //{
        //    // Arrange
        //    TasksController controller = new TasksController();

        //    // Act
        //    ViewResult result = controller.Edit() as ViewResult;

        //    // Assert
        //    Assert.IsNotNull(result);
        //}

        [TestMethod]
        public void Details()
        {
            // Arrange
            TasksController controller = new TasksController();

            // Act
            ViewResult result = controller.Details(1) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }


        //[TestMethod]
        //public void Delete()
        //{
        //    // Arrange
        //    TasksController controller = new TasksController();

        //    // Act
        //    ViewResult result = controller.Delete() as ViewResult;

        //    // Assert
        //    Assert.IsNotNull(result);
        //}

        [TestMethod]
        public void TaskCalendar()
        {
            // Arrange
            TasksController controller = new TasksController();

            // Act
            ViewResult result = controller.TaskCalendar() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
