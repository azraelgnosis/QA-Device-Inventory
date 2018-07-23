using System;
using System.ComponentModel.DataAnnotations;
namespace qadi.Models
{
    public class Device : IComparable
    {
        [Key, Range(0, int.MaxValue)]
        public int id { get; set; }
        public string deviceID { get; set; }
        public string serialNo { get; set; }
        public string make { get; set; }
        public string model { get; set; }
        public OS os { get; set; }
        public DeviceType type { get; set; }
        public Availability availability { get; set; }
        public string user { get; set; }
        public bool IsSelected { get; set; }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            Device otherDevice = obj as Device;
            return this.id.CompareTo(otherDevice.id);
        }

        override public string ToString() {
            String[] arr = {
                this.id.ToString(),
                deviceID,
                serialNo,
                make,
                model,
                os.ToString(),
                type.ToString(),
                availability.ToString(),
                availability == Availability.Unavailable ? user:"",
            };
            return String.Join(',', arr);
        }


        public static Device FromString(string str) {
            string[] arr = str.Split(',');
            int idNum;
            int.TryParse(arr[0], out idNum); // converts first value into an int and assigns it to "num"

            Device dev = new Device
            {
                id = idNum,
                deviceID = arr[1],
                serialNo = arr[2],
                make = arr[3],
                model = arr[4],
                os = (OS)(arr[5] == "Android" ? 0 : 1),
                type = (DeviceType)(arr[6] == "Mobile" ? 0 : 1),
                availability = (Availability)(arr[7] == "Available" ? 0 : 1),
                user = arr[8]
            };

            return dev;
        }
    }
}
