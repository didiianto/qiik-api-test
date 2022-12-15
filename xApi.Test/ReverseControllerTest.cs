using qiik_api_test.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace xApi.Test
{
    public class ReverseControllerTest
    {
        ReverseController _reverseController;

        public ReverseControllerTest()
        {
            _reverseController = new ReverseController();
        }

        [Fact]
        public void getHash()
        {
            //arrange
            string word = "Yogi";

            //Act
            var result = _reverseController.ReverseWord(word);

            //Assert
            Assert.IsType<string>(result);
            Assert.Equal("igoY", result);
        }

    }
    
}
