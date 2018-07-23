using System;
namespace qadi.Models
{
    public class User : IComparable
    {
        public int id { get; set; }
        public string name { get; set; }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            User otherUser = obj as User;
            return this.name.CompareTo(otherUser.name);
        }

        public static User FromString(string str) {
            string[] arr = str.Split(',');
            int idNum;
            int.TryParse(arr[0], out idNum);
            User user = new User {
                id = idNum,
                name = arr[1]
            };
            return user;
        }

        override public string ToString()
        {
            return $"{this.id},{this.name}";
        }
    }
}
