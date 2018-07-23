using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace qadi.Models
{
    public class DeviceViewModel
    {
        public List<Device> Inventory { get; set; }
        public List<int> idList { get; set; }
        public Device device { get; set; }

        public string name { get; set; }
        public IEnumerable<string> SelectedDevices { get; set; }

        public List<Device> CheckedIn { get; set; }
        public List<SelectListItem> CheckedInSelectList { get; set; }
        public List<Device> CheckedOut { get; set; }
        public List<SelectListItem> CheckedOutSelectList { get; set; }

        public List<User> users { get; set; }
        public List<string> usersStr { get; set; }
        public IEnumerable<SelectListItem> usersEnum { get; set; }
    }
}
