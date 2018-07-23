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
    public class HomeController : Controller
    {
        DeviceViewModel deviceViewModel = new DeviceViewModel();
        string path = System.IO.Path.GetFullPath("wwwroot/Inventory.csv");
        string tempPath = System.IO.Path.GetFullPath("wwwroot/tempStorage.csv");

        public HomeController() {
            deviceViewModel.Inventory = new List<Device>();
            deviceViewModel.idList = new List<int>();
            StreamReader SR = new StreamReader(path); // creates a StreamReader for the Inventory.csv file
            string line = SR.ReadLine();

            while (line != null && line != "")
            {
                Device dev = Device.FromString(line); // converts line to a Device
                deviceViewModel.Inventory.Add(dev); // adds the Device to the Device List
                deviceViewModel.idList.Add(dev.id); // adds the id of the Device to the ID List
                line = SR.ReadLine(); // continues reading to the next line
            }
            SR.Close();

            GetUsers();
        }

        public IActionResult Index()
        {

            //deviceViewModel.Inventory.Sort();
            return View(deviceViewModel);
        }


// Edit
        public IActionResult Edit(DeviceViewModel editDeviceViewModel) {
            if (deviceViewModel.Inventory.Exists(d => d.deviceID == editDeviceViewModel.device.deviceID)) {
                return RedirectToAction(nameof(Index), new { id = -1 });
            }
            //if (deviceViewModel.idList.Contains(editDeviceViewModel.device.id)) { return RedirectToAction(nameof(Index), new { id = -1 }); }
            //if (editDeviceViewModel.device.id < 0) { return RedirectToAction(nameof(Index), new { id = -2 }); }

            string editLine = editDeviceViewModel.device.ToString(); // DevToStr(editDevice);

            // copies inventory to edited device line, writes edited device, then continues
            StreamReader invSR = new StreamReader(path);
            StreamWriter tempSW = new StreamWriter(tempPath);
            string line = invSR.ReadLine();

            while (line != null) {
                if (editDeviceViewModel.device.id.ToString() == line.Split(',')[0]) {
                    tempSW.WriteLine(editLine);
                    line = invSR.ReadLine();
                }
                tempSW.WriteLine(line);
                line = invSR.ReadLine();
            }

            invSR.Close();
            tempSW.Close();

            CopyTempToInventory();
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult Add(DeviceViewModel newDeviceViewModel) {
            if (deviceViewModel.Inventory.Exists(d => d.deviceID == newDeviceViewModel.device.deviceID)) {
                return RedirectToAction(nameof(Index), new { id = -1 });
            }

            int min = 0;
            for (int i = 0; i <= deviceViewModel.idList.Count(); i++)
            {
                if (!deviceViewModel.idList.Contains(i))
                {
                    min = i;
                    break;
                }
            }
            newDeviceViewModel.device.id = min;


            if (deviceViewModel.idList.Contains(newDeviceViewModel.device.id)) {return RedirectToAction(nameof(Index), new {id = -1});}
            if (newDeviceViewModel.device.id < 0) { return RedirectToAction(nameof(Index), new { id = -2 }); }

            StreamWriter SW = new StreamWriter(path, true);
            string line = newDeviceViewModel.device.ToString();
            SW.WriteLine(line);
            SW.Close();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Remove(int id) {
            StreamReader invSR = new StreamReader(path);
            StreamWriter tempSW = new StreamWriter(tempPath);
            string line = invSR.ReadLine();
            while (line != null && line != "") { 
                if (line.Split(',')[0] == id.ToString()) {
                    line = invSR.ReadLine();
                    if (line == null || line == "") { break; }
                }
                tempSW.WriteLine(line);
                line = invSR.ReadLine();
            }
            invSR.Close();
            tempSW.Close();

            CopyTempToInventory();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Users() {
            return View();
        }

        private void CopyTempToInventory() { // copies temp file to inventory file
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
    }
}