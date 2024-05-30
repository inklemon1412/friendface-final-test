using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace friendface_final_test
{
    internal class SystemInterface
    {
        public List<User> Users;
        public User CurrentUser;

        public SystemInterface() 
        {
            Users = new List<User>()
            {
                new("Jonas", 27),
                new("Per", 22),
                new("Ann", 30),
                new("Ida", 20),
                
            };

            CurrentUser = Users[0];
        }
        public void GetUsers()
        {
            Console.Clear();
            foreach (var user in Users)
            {
                if (CurrentUser == user || CurrentUser.SearchFriend(user.Name) == user) continue;
                Console.WriteLine($"Name: {user.Name}, Age: {user.Age}");
                Console.WriteLine();
            }
            Console.WriteLine("Write an users name to add as friend");
             var userInput = Console.ReadLine();
            var friendInput   = GetUserByName(userInput);
            if (friendInput != null)
            {
                CurrentUser.AddFriend(friendInput);
                Console.WriteLine($"Added {friendInput.Name} as a friend");
            }
            else GetUsers(); 
        }
        public User GetUserByName(string userName)
        {
            foreach (var user in Users)
            {
                if (userName == user.Name) return user;
            }
            return null;
        }
    }
}
