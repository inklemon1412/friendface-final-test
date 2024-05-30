using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace friendface_final_test
{
    internal class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        private List<User> _friends;

        

        public User(string name, int age)
        {
            Name = name;
            Age = age;
            _friends = new List<User>();
        }
       
        public void AddFriend(User user) 
        {
            _friends.Add(user);
        }
        public void RemoveFriend(User user)
        {
            foreach (User friend in _friends)
            {
                if(friend == user)_friends.Remove(friend);
            }
        }

        public void ShowFriends()
        {
            Console.Clear();
            if (_friends.Count > 0 )
            {
                foreach (var friend in _friends)
                {
                    Console.WriteLine($"Name: {friend.Name}, Age: {friend.Age}");
                }

            }
            else
            {
                Console.WriteLine("You have no friends :(");
            }
        }
        public User SearchFriend(string userName) 
        {
            foreach(var friend in _friends)
            {
                if (friend.Name == userName) return friend;
            }
            return null;
        }
     
    }
}

   

