//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace netcentric.AdventureGame
//{
//    internal class AdventureGame
//    {
//        static void Main(string[] args)
//        {
//            Game game = new Game();
//            game.Start();
//        }

//        public class Game
//        {
//            private List<Room> rooms;
//            private int currentRoomIndex;
//            private bool isRunning;

//            public Game()
//            {
//                rooms = new List<Room>
//                    {
//                        new Room("You are in a dark cave. There is a path leading north.", new List<string> { "go north" }),
//                        new Room("You find yourself in a forest. There is a path leading south and east.", new List<string> { "go south", "go east" }),
//                        new Room("You are at the edge of a cliff. The path leads west.", new List<string> { "go west" })
//                    };

//                currentRoomIndex = 0;
//                isRunning = true;
//            }

//            public void Start()
//            {
//                Console.WriteLine("Welcome to the Adventure Game!");

//                while (isRunning)
//                {
//                    ShowCurrentRoom();
//                    Console.Write("What do you want to do? ");
//                    string action = Console.ReadLine();
//                    HandleAction(action);
//                }

//                Console.WriteLine("Thank you for playing the Adventure Game!");
//            }

//            private void ShowCurrentRoom()
//            {
//                Room currentRoom = rooms[currentRoomIndex];
//                Console.WriteLine(currentRoom.Description);

//                Console.WriteLine("Possible actions:");
//                foreach (var action in currentRoom.Actions)
//                {
//                    Console.WriteLine($"- {action}");
//                }
//            }

//            private void HandleAction(string action)
//            {
//                Room currentRoom = rooms[currentRoomIndex];

//                switch (action.ToLower())
//                {
//                    case "go north":
//                        if (currentRoomIndex == 0)
//                        {
//                            currentRoomIndex = 1;
//                        }
//                        else
//                        {
//                            InvalidAction();
//                        }
//                        break;

//                    case "go south":
//                        if (currentRoomIndex == 1)
//                        {
//                            currentRoomIndex = 0;
//                        }
//                        else
//                        {
//                            InvalidAction();
//                        }
//                        break;

//                    case "go east":
//                        if (currentRoomIndex == 1)
//                        {
//                            currentRoomIndex = 2;
//                        }
//                        else
//                        {
//                            InvalidAction();
//                        }
//                        break;

//                    case "go west":
//                        if (currentRoomIndex == 2)
//                        {
//                            currentRoomIndex = 1;
//                        }
//                        else
//                        {
//                            InvalidAction();
//                        }
//                        break;

//                    case "quit":
//                        isRunning = false;
//                        break;

//                    default:
//                        InvalidAction();
//                        break;
//                }
//            }

//            private void InvalidAction()
//            {
//                Console.WriteLine("Invalid action. Please try again.");
//            }
//        }

//        public class Room
//        {
//            public string Description { get; }
//            public List<string> Actions { get; }

//            public Room(string description, List<string> actions)
//            {
//                Description = description;
//                Actions = actions;
//            }
//        }
//    }
//}



