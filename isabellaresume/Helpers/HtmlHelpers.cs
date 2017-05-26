using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace isabellaresume.Helpers
{
    public static class HtmlHelpers
    {
        public static string GetTotalTime(this HtmlHelper helper, DateTime startDate, DateTime endDate)
        {
            var days = endDate.Subtract(startDate).Days;
            var years = days / 365;
            var months = (days % 365) / 30;

            string total;

            if (years == 0)
            {
                total = $"{months} månader";
            }
            else if (months == 0)
            {
                total = $"{years} år";
            }
            else
            {
                total = $"{years} år och {months} månader";
            }
            return total;
        }
    }
}