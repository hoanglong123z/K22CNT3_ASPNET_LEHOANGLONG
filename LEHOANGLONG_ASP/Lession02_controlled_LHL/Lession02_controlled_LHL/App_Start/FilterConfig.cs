using System.Web;
using System.Web.Mvc;

namespace Lession02_controlled_LHL
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
