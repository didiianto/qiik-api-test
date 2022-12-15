using qiik_api_test.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using static qiik_api_test.Controllers.HashController;

namespace xApi.Test
{
    public class TriangleControllerTest
    {
        TriangleController _triangleController;

        public TriangleControllerTest()
        {
            _triangleController = new TriangleController();
        }

        [Fact]
        public void GetCategoryTriangle()
        {
            //arrange
            int side1 = 4;
            int side2 = 5;
            int side3 = 6;

            //Act
            var result = _triangleController.GetCategoryTriangle(side1, side2, side3);

            //Assert
            Assert.IsType<string>(result);
            Assert.Equal("Scalene Triangle", result);
        }

    }
    
}
