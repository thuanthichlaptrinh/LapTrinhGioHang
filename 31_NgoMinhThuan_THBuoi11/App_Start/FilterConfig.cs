﻿using System.Web;
using System.Web.Mvc;

namespace _31_NgoMinhThuan_THBuoi11
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
