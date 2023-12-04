using System.Web;
using System.Web.Mvc;

namespace FA2_Caitlin_Hermanus_20232198
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
