﻿using System.Web;
using System.Web.Mvc;

namespace PhamNgocHai_2090694876
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
