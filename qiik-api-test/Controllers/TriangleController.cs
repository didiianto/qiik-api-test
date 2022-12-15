using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace qiik_api_test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TriangleController : ControllerBase
    {

        enum CategoryTriangle
        {
            Isosceles,
            Scalene,
            Equilateral
        }

        [HttpPost]
        public string GetCategoryTriangle([BindRequired] int side1, [BindRequired] int side2, [BindRequired] int side3)
        {
            string result = "unknown";
            if (side1 > 0 && side2 > 0 && side3 > 0)
            {
                if (side1 == side2 && side2 == side3)
                    result = CategoryTriangle.Equilateral.ToString() + " Triangle";
                else if (side1 == side2 || side1 == side3 || side2 == side3)
                    result = CategoryTriangle.Isosceles.ToString() + " Triangle";
                else
                    result = CategoryTriangle.Scalene.ToString() + " Triangle";
            }

            return result;
        }

    }
}
