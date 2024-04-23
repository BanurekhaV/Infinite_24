using System.Web;
using System.Web.Mvc;
using Exceptions_n_FiltersPrj.Models;

namespace Exceptions_n_FiltersPrj
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            // filters.Add(new HandleErrorAttribute()); //temporarily commented
            filters.Add(new LogCustomExceptionFilter());
        }
    }
}
