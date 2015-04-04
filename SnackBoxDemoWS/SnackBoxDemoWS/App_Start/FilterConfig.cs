using System.Web;
using System.Web.Mvc;

namespace SnackBoxDemoWS
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
