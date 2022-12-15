using qiik_api_test.Controllers;
using System;
using System.Collections.Generic;
using Xunit;

namespace xApi.Test
{
    public class FibonacciControllerTest
    {
        FibonacciController _fibonacciController;

        public FibonacciControllerTest()
        {
            _fibonacciController = new FibonacciController();
        }

        [Fact]
        public void GetListFibonacci()
        {
            //arrange

            //Act
            var result = _fibonacciController.GetListFibonacci(5);

            //Assert
            Assert.IsType<List<int>>(result);
        }
    }
}
