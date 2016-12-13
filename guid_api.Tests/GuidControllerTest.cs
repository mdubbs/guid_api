using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using guid_api.Controllers;
using guid_api.Models;

namespace guid_api.Tests
{
    [TestClass]
    public class GuidControllerTest
    {
        [TestMethod]
        public void Get_ShouldReturnANewGuid()
        {
            var controller = new GuidController();
            var result = controller.Get() as GuidResponse;
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Guid);
        }
    }
}
