using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Clockwork.Web.Models
{
    public class HomeViewModel
    {
        public HomeViewModel()
        {
            var timeZones = new List<SelectListItem>
            {
                new SelectListItem{ Value="", Text="Select timezone...", Selected = false },
            };

            foreach (TimeZoneInfo timezone in TimeZoneInfo.GetSystemTimeZones())
            {
                timeZones.Add(new SelectListItem { Value = timezone.Id, Text = timezone.DisplayName, Selected = false });
            }

            TimeZones = timeZones;
        }

        public string SelectedTimeZone { get; set; }
        public IEnumerable<SelectListItem> TimeZones { get; set; }
    }
}