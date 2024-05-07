using System.Web;
using System.Web.Mvc;

namespace Lession02_LHL_Controllers_Lab2_1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
