using System.Web;
using System.Web.Mvc;

namespace Village_Project_MVC_LinqToSQL_EF
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
