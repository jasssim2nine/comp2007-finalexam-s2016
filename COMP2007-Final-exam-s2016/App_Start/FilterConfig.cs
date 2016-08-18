using System.Web;
using System.Web.Mvc;

namespace COMP2007_Final_exam_s2016
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
