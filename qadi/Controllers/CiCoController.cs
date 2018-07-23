using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using qadi.Models;

namespace qadi.Controllers
{
    public class CiCoController : Controller
    {
        DeviceViewModel deviceViewModel = new DeviceViewModel();
        string path = Path.GetFullPath("wwwroot/Inventory.csv");
        string tempPath = Path.GetFullPath("wwwroot/tempStorage.csv");

        // constructor
        public CiCoController()
        {
            GetInventory();
            GetUsers();
        }

        [HttpGet]
        public IActionResult Prologue()
        {

            return View(deviceViewModel);
        }

        [HttpPost]
        public IActionResult Prologue(string name)
        {
            if (name == null || name == "Choose Name")
            {
                return RedirectToAction(nameof(Prologue));//View(deviceViewModel);
            }
            deviceViewModel.name = name;
            GetCheckedIn();
            GetCheckedOut();
            return View("CiCo", deviceViewModel);
        }

        [HttpPost]
        public IActionResult CheckedIn(DeviceViewModel checkedDeviceViewModel)
        {
            if (checkedDeviceViewModel == null) { return View("CiCo"); }
            if (checkedDeviceViewModel.SelectedDevices == null)
            {
                GetCheckedIn(checkedDeviceViewModel);
                GetCheckedOut(checkedDeviceViewModel);
                return View("CiCo", checkedDeviceViewModel);
                //return RedirectToAction("CiCo", new { id = -2 });
            }

            GetInventory();
            foreach (Device item in deviceViewModel.Inventory)
            {
                if (checkedDeviceViewModel.SelectedDevices != null && checkedDeviceViewModel.SelectedDevices.Contains(item.id.ToString()))
                {
                    item.user = checkedDeviceViewModel.name;
                    item.availability = Availability.Unavailable;
                }
            }

            StreamWriter tempSW = new StreamWriter(tempPath);
            foreach (Device item in deviceViewModel.Inventory)
            {
                tempSW.WriteLine(item.ToString());
            }

            tempSW.Close();

            CopyTempToInventory();

            deviceViewModel.name = checkedDeviceViewModel.name;
            GetCheckedIn();
            GetCheckedOut();
            return View("Cico", deviceViewModel);

        }

        [HttpPost]
        public IActionResult CheckedOut(DeviceViewModel checkedDeviceViewModel)
        {
            if (checkedDeviceViewModel == null) { return View(nameof(Prologue)); }
            if (checkedDeviceViewModel.SelectedDevices == null)
            {
                GetCheckedIn(checkedDeviceViewModel);
                GetCheckedOut(checkedDeviceViewModel);
                return View("CiCo", checkedDeviceViewModel);
            }

            GetInventory();


            foreach (Device item in deviceViewModel.Inventory)
            {
                if (checkedDeviceViewModel.SelectedDevices.Contains(item.id.ToString()))
                {
                    item.availability = Availability.Available;
                    item.user = "";
                }
            }

            StreamWriter tempSW = new StreamWriter(tempPath);
            foreach (Device item in deviceViewModel.Inventory)
            {
                tempSW.WriteLine(item.ToString());
            }

            tempSW.Close();

            CopyTempToInventory();
            deviceViewModel.name = checkedDeviceViewModel.name;
            GetCheckedIn();
            GetCheckedOut();
            return View("CiCo", deviceViewModel);
        }


        private void GetInventory()
        {
            deviceViewModel.Inventory = new List<Device>();

            string path = Path.GetFullPath("wwwroot/Inventory.csv");
            StreamReader SR = new StreamReader(path);
            string line = SR.ReadLine();

            while (line != null && line != "")
            {
                deviceViewModel.Inventory.Add(Device.FromString(line));
                line = SR.ReadLine();
            }
        }
        /*============================================================================*/
        private void GetUsers()
        {
            deviceViewModel.users = new List<User>();
            deviceViewModel.usersStr = new List<string>();

            string path = Path.GetFullPath("wwwroot/users.csv");
            StreamReader SR = new StreamReader(path);
            string line = SR.ReadLine();
            while (line != null && line != "")
            {
                deviceViewModel.usersStr.Add(line.Split(',')[1]);
                //deviceViewModel.users.Add(Models.User.FromString(line));
                line = SR.ReadLine();
            }

            deviceViewModel.usersEnum = new SelectList(deviceViewModel.usersStr);
        }

        /*============================================================================*/
        private void GetCheckedIn()
        {
            deviceViewModel.CheckedIn = new List<Device>();
            foreach (Device item in deviceViewModel.Inventory)
            {
                if (item.availability == Availability.Available)
                {
                    deviceViewModel.CheckedIn.Add(item);
                }
            }



            deviceViewModel.CheckedInSelectList = new List<SelectListItem>();
            foreach (Device item in deviceViewModel.CheckedIn)
            {
                SelectListItem selectListItem = new SelectListItem()
                {
                    Text = $"{item.deviceID} | {item.os} | {item.make} | {item.model}",
                    Value = item.id.ToString(),
                    Selected = item.IsSelected
                };
                deviceViewModel.CheckedInSelectList.Add(selectListItem);
            }
        }

        // GetCheckedIn(DVM)
        private void GetCheckedIn(DeviceViewModel dvm)
        {
            dvm.CheckedIn = new List<Device>();
            foreach (Device item in deviceViewModel.Inventory)
            {
                if (item.availability == Availability.Available)
                {
                    dvm.CheckedIn.Add(item);
                }
            }

            dvm.CheckedInSelectList = new List<SelectListItem>();
            foreach (Device item in dvm.CheckedIn)
            {
                SelectListItem selectListItem = new SelectListItem()
                {
                    Text = $"{item.deviceID} | {item.os} | {item.make} | {item.model}",
                    Value = item.id.ToString(),
                    Selected = item.IsSelected
                };
                dvm.CheckedInSelectList.Add(selectListItem);
            }
        }

        private void GetCheckedOut()
        {
            deviceViewModel.CheckedOut = new List<Device>();
            foreach (Device item in deviceViewModel.Inventory)
            {
                if (item.availability == Availability.Unavailable && item.user == deviceViewModel.name)
                {
                    deviceViewModel.CheckedOut.Add(item);
                }
            }

            deviceViewModel.CheckedOutSelectList = new List<SelectListItem>();
            foreach (Device item in deviceViewModel.CheckedOut)
            {
                SelectListItem selectListItem = new SelectListItem()
                {
                    Text = $"{item.deviceID} | {item.os} | {item.make} | {item.model}",
                    Value = item.id.ToString(),
                    Selected = item.IsSelected
                };
                deviceViewModel.CheckedOutSelectList.Add(selectListItem);
            }
        }


        private void GetCheckedOut(DeviceViewModel dvm)
        {
            dvm.CheckedOut = new List<Device>();
            foreach (Device item in deviceViewModel.Inventory)
            {
                if (item.availability == Availability.Unavailable && item.user == dvm.name)
                {
                    dvm.CheckedOut.Add(item);
                }
            }

            dvm.CheckedOutSelectList = new List<SelectListItem>();
            foreach (Device item in dvm.CheckedOut)
            {
                SelectListItem selectListItem = new SelectListItem()
                {
                    Text = $"{item.deviceID} | {item.os} | {item.make} | {item.model}",
                    Value = item.id.ToString(),
                    Selected = item.IsSelected
                };
                dvm.CheckedOutSelectList.Add(selectListItem);
            }
        }

        private void CopyTempToInventory()
        {
            // copies temp file to inventory file
            StreamReader tempSR = new StreamReader(tempPath);
            StreamWriter invSW = new StreamWriter(path);
            string line = tempSR.ReadLine();
            while (line != null)
            {
                invSW.WriteLine(line);
                line = tempSR.ReadLine();
            }
            tempSR.Close();
            invSW.Close();
        }

        [HttpGet]
        public IActionResult login()
        {
            return View(new login());
        }

        [HttpPost]
        public IActionResult login(login login, int id)
        {
            string path = Path.GetFullPath("LeadAuthentication");
            StreamReader SR = new StreamReader(path);
            string username = SR.ReadLine();
            string password = SR.ReadLine();
            SR.Close();

            if (login.username == username && login.password == password)
            {
                if (id == 1){ return RedirectToAction("Index", "Home"); }
                if (id == 2){ return RedirectToAction("UserList", "User"); }
            }
            return View("login", login); 
        }
    }
}
