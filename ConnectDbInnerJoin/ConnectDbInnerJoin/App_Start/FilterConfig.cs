using System.Web;
using System.Web.Mvc;

namespace ConnectDbInnerJoin
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
