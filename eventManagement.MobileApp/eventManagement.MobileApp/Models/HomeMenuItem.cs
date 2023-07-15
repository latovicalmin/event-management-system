using System;
using System.Collections.Generic;
using System.Text;

namespace eventManagement.MobileApp.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        EventPage,
        Organizations,
        Signup,
        Speakers,
        Profile,
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
