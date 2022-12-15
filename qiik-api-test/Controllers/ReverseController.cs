using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;

namespace qiik_api_test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReverseController : ControllerBase
    {
        [HttpPost]
        public string ReverseWord([BindRequired] string word)
        {
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);

            return new string(charArray);
        }
    }
}
