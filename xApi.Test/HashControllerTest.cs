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
    public class HashControllerTest
    {
        HashController _hashController;

        public HashControllerTest()
        {
            _hashController = new HashController(); 
        }

        [Fact]
        public void getHash()
        {
            //arrange
            string input = "Yogi";

            //Act
            var result = _hashController.getHash(input);

            //Assert
            Assert.IsType<ApiResponse>(result);
            Assert.Equal("MD5", result.Algorithm);
        }

    }
    
}
