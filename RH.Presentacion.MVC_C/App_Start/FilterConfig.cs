﻿using System.Web;
using System.Web.Mvc;

namespace RH.Presentacion.MVC_C
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
