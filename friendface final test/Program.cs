namespace friendface_final_test
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var systemInterface = new SystemInterface();
            
                Console.WriteLine("Hello, and welcome to FriendFace!");
                Console.Write("Enter your name here: ");
                var userName = Console.ReadLine();

                while (true) {

                    Console.WriteLine($"Welcome {userName}!");
                    Console.WriteLine("What would you like to do?");

               
                    Console.WriteLine("1) Friend List");
                    Console.WriteLine("2) Add friend");


                    Menu();
                }

                void Menu()
                {
                    var userInputStr = Console.ReadLine();
                    if (Int32.TryParse(userInputStr, out int userInput))
                    {
                        switch (userInput)
                        {
                            case 1:
                                systemInterface.CurrentUser.ShowFriends();
                                break;
                            case 2:
                                systemInterface.GetUsers();
                                break;
                        }
                    }
                }
            }
        }
    }



                         
