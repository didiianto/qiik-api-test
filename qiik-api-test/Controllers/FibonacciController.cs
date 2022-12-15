using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;

namespace qiik_api_test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FibonacciController : ControllerBase
    {
        [HttpPost]
        public List<int> GetListFibonacci([BindRequired]int n)
        {
            int a = 0;
            int b = 1;
            var list = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
                list.Add(a);
            }

            return list;
        }
    }
}
