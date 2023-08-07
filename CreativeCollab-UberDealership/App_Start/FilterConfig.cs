using System.Web;
using System.Web.Mvc;

namespace CreativeCollab_UberDealership
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
