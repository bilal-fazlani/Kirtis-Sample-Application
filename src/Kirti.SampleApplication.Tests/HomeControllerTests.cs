using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using Kirti.SampleApplication.Controllers;
using Microsoft.AspNet.Mvc;
using Xunit;

namespace Kirti.SampleApplication.Tests
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class HomeControllerTests
    {
        [Fact]
        public void CanReturnIndexView()
        {
            HomeController controller = new HomeController();

            var response = controller.Index();

            response.ExecuteResultAsync(new ActionContext());

            response.Should().BeOfType<ViewResult>();
        }
    }
}
