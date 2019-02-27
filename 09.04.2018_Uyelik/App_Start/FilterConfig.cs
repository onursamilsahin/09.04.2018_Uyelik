using System.Web;
using System.Web.Mvc;

namespace _09._04._2018_Uyelik
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
