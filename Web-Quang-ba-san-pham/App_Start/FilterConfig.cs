using System.Web;
using System.Web.Mvc;

namespace Web_Quang_ba_san_pham
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
