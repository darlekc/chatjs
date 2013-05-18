using System.Web.Mvc;

namespace ChatJsSample.App_Start
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new ValidateInputAttribute(false));
        }
    }
}