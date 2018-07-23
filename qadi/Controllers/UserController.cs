using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using qadi.Models;

namespace qadi.Controllers
{
    public class UserController : Controller
    {
        public UserViewModel userViewModel = new UserViewModel();
        public string userPath = Path.GetFullPath("wwwroot/users.csv");
        public string tempPath = Path.GetFullPath("wwwroot/tempStorage.csv");
        public string devicePath = Path.GetFullPath("wwwroot/Inventory.csv");
        public string tempInventory = Path.GetFullPath("wwwroot/tempInventory.csv");

        public UserController()
        {
            userViewModel.users = new List<User>();
            userViewModel.userIDs = new List<int>();
            StreamReader SR = new StreamReader(userPath);
            string line = SR.ReadLine();

            while (line != null & line != "") {
                User newUser = Models.User.FromString(line);
                userViewModel.users.Add(newUser);
                userViewModel.userIDs.Add(newUser.id);
                line = SR.ReadLine();
            }
            SR.Close();
        }

        [HttpGet]
        public IActionResult UserList() {
            userViewModel.users.Sort();
            return View(userViewModel);
        }

        [HttpPost]
        public IActionResult Add(UserViewModel newUserViewmodel) {
            if (userViewModel.users.Exists(u => u.name == newUserViewmodel.user.name)) {
                return RedirectToAction("UserList", new { id = -2 });
            }

            //foreach (User user in userViewModel.users) {
            //    if (newUserViewmodel.user.name == user.name) {
            //        return RedirectToAction("UserList", new { id = -2});
            //    }
            //}

            for (int i = 0; i <= userViewModel.userIDs.Count; i++) {
                if (!userViewModel.userIDs.Contains(i)) {
                    newUserViewmodel.user.id = i;
                    break;
                }
            }

            StreamWriter SW = new StreamWriter(userPath, true);
            SW.WriteLine(newUserViewmodel.user.ToString());
            SW.Close();

            return RedirectToAction(nameof(UserList));
        }
/*-------------------------------------------------------*/

        [HttpPost]
        public IActionResult Edit(UserViewModel editUserViewModel) {
            if (userViewModel.users.Exists(u => u.name == editUserViewModel.user.name)) {
                return RedirectToAction("userList", new { id = -2 });
            }

            //foreach (User user in userViewModel.users) {
            //    if (user.name == editUserViewModel.user.name) {
            //        return RedirectToAction("UserList", new { id = -2 });
            //    }
            //}


            StreamReader SR = new StreamReader(userPath);
            StreamWriter SW = new StreamWriter(tempPath);
            string line = SR.ReadLine();

            while (line != null && line != "") {
                if (editUserViewModel.user.id.ToString() == line.Split(',')[0]) {
                    
                    SW.WriteLine(editUserViewModel.user.ToString());
                    line = SR.ReadLine();
                }
                SW.WriteLine(line);
                line = SR.ReadLine();
            }
            SR.Close();
            SW.Close();
            CopyTempToUsers();

            StreamReader deviceSR = new StreamReader(devicePath);
            StreamWriter deviceSW = new StreamWriter(tempInventory);
            User temp = new User();

            foreach(User user in userViewModel.users){
                if(editUserViewModel.user.id == user.id){
                    temp = user;
                    break;
                }
            }
            string dLine = deviceSR.ReadLine();

            while(dLine != null && dLine != ""){
                string[] current = dLine.Split(',');

                if(current[8] == temp.name){
                    current[8] = editUserViewModel.user.name;
                    deviceSW.WriteLine(String.Join(',', current)); //creates string out of array
                    dLine = deviceSR.ReadLine();
                }
                else{
                    deviceSW.WriteLine(dLine);
                    dLine = deviceSR.ReadLine();
                }
            }
            deviceSR.Close();
            deviceSW.Close();


            StreamReader tempSR = new StreamReader(tempInventory);
            StreamWriter tempSW = new StreamWriter(devicePath);
            string tempLine = tempSR.ReadLine();

            while (tempLine != null && tempLine != "")
            {
                tempSW.WriteLine(tempLine);
                tempLine = tempSR.ReadLine();
            }
            tempSR.Close();
            tempSW.Close();

            /*-------------------------------------------------------*/

            return RedirectToAction(nameof(UserList));
        }
/*-------------------------------------------------------*/
        public IActionResult Remove(int id) {
            StreamReader deviceSR = new StreamReader("wwwroot/Inventory.csv");
            string row = deviceSR.ReadLine();
            User tempUser = null;
            foreach (User user in userViewModel.users)
            {
                if (user.id == id) { 
                    tempUser = user; 
                    break;
                }
            }

            while (row != null && row != "") {
                if (row.Split(',')[7] == Availability.Available.ToString()) { row = deviceSR.ReadLine(); }
                if (row.Split(',')[8] == tempUser.name) {
                    return RedirectToAction("UserList", new {id = -1});
                }
                row = deviceSR.ReadLine();
            }
                
            StreamReader SR = new StreamReader(userPath);
            StreamWriter SW = new StreamWriter(tempPath);
            string line = SR.ReadLine();

            while (line != null && line != "") {
                if (id.ToString() == line.Split(',')[0]) {
                    line = SR.ReadLine();
                    if (line == null || line == "") { break; }
                }
                SW.WriteLine(line);
                line = SR.ReadLine();
            }
            SR.Close();
            SW.Close();
            CopyTempToUsers();




            return RedirectToAction(nameof(UserList));
        } 

        private void CopyTempToUsers() {
            StreamReader SR = new StreamReader(tempPath);
            StreamWriter SW = new StreamWriter(userPath);
            string line = SR.ReadLine();

            while(line != null && line != "") {
                SW.WriteLine(line);
                line = SR.ReadLine();
            }
            SR.Close();
            SW.Close();
        }
    }
}
