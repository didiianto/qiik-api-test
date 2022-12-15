using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;

namespace qiik_api_test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HashController : ControllerBase
    {
        public class ApiResponse
        {
            public string Algorithm { get; set; }
            public string Value { get; set; }
        }

        [HttpPost]
        public ApiResponse getHash([BindRequired] string input)
        {
            ApiResponse response = new ApiResponse();
            var res = CreateMD5(input);
            response.Algorithm = "MD5";
            response.Value = res;

            return response;
        }

        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                return Convert.ToHexString(hashBytes);
            }
        }
    }
}
