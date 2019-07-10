using System;
using System.Collections.Generic;
namespace Tree_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tree Traversal Exercise by Luis Cajucom, Carlo Ferrer, Mika Yap

            // Declare goal state, fringe, and visited list
            // Console.Write("Enter number of goalstate: ");
            // int goalstate = int.Parse(Console.ReadLine());
            // int goalstate = 40;

            // Goal State == NAME
            Console.Write("Enter name of goalstate: ");
            string goalstate = Console.ReadLine();


            List<int> fringe = new List<int>();
            List<int> visited = new List<int>();
            List<string> names = new List<string>();

            // Name List Creation
            names.Add("Mika");
            names.Add("Luis");
            names.Add("Carlo");
            names.Add("Zach");
            names.Add("Erin");
            names.Add("Josh");
            names.Add("Hannah");

            // Name Tracker
            string nameTracker = "";

            // Loop to generate the tree with state 1
            Console.WriteLine("Generating Tree Traversal for " + goalstate);
            int state = 1; 
            fringe.Add(state);

            // Get type of search
            // Console.WriteLine("1. BFS ");
            // Console.WriteLine("2. DFS ");
            // Console.Write("Choose one: ");
            // string choice = Console.ReadLine();

            // if (choice == "1")
            // {

            // BFS Tree Traversal
            while (nameTracker != goalstate)
            {

                // Add children
                if (state == 1)
                {
                    fringe.Add(2);
                    fringe.Add(3);
                    fringe.Add(4);
                }
                else
                {
                    int lastnode = fringe[fringe.Count-1];
                    // V2: int lastnode = visited[visited.Count - 1];
                    fringe.Add(lastnode + 1);
                    fringe.Add(lastnode + 2);
                    fringe.Add(lastnode + 3);
                }

                // Change to new state
                visited.Add(fringe[0]);
                // V2: visited.Add(fringe[1]);
                // V2: visited.Add(fringe[2]);
                    
                // Show Fringe
                Console.WriteLine("Fringe:");
                fringe.ForEach(item => Console.Write(item + ", "));
                Console.WriteLine();

                // Remove fringe
                fringe.RemoveAt(0);
                state = fringe[0];
                    
                // V2: state = fringe[fringe.Count - 1];
                // V2: fringe.Clear();

                // Show Tree
                Console.WriteLine("Tree Traversal:");
                visited.ForEach(item => Console.Write(item + ", "));
                Console.WriteLine();

                // Show Tree of Names
                Console.WriteLine("Tree Traversal of Names");
                for(int x = 0; x <= visited.Count-1; x++)
                {
                    Console.Write(names[x] + ", ");
                }
                Console.WriteLine();

                // Check Name
                nameTracker = names[visited.Count-1];
                if (goalstate == nameTracker)
                {
                    Console.WriteLine("Goalstate Reached. Current Name: " + nameTracker);
                }
            }    

            // --- LUIS PRINT CODE ---
            List<string> treePrint = new List<string>();
            List<string> namePrint = new List<string>();
            for (int x = 0; x <= 4; x++)
            {
                treePrint.Add("");
                namePrint.Add("");
            }
            string printHolder = "";
            string namePrintHolder = "";
            for (int x = 0; x <= visited.Count-1; x++)
            {
                if (x == 0)
                {
                    printHolder = (visited[x]).ToString();
                    treePrint[0] = printHolder;
                    namePrintHolder = (names[x]).ToString();
                    namePrint[0] = namePrintHolder;
                }
                else if (x > 0 && x <= 3)
                {
                    printHolder = treePrint[1];
                    printHolder += (visited[x]).ToString() + " ";
                    treePrint[1] = printHolder;
                    namePrintHolder = namePrint[1];
                    namePrintHolder += (names[x]).ToString() + " ";
                    namePrint[1] = namePrintHolder;
                }
                else if (x > 3 && x <= 12)
                {
                    printHolder = treePrint[2];
                    printHolder += (visited[x]).ToString() + " ";
                    treePrint[2] = printHolder;
                    namePrintHolder = namePrint[2];
                    namePrintHolder += (names[x]).ToString() + " ";
                    namePrint[2] = namePrintHolder;
                }
                else if (x > 12 && x <= 39)
                {
                    printHolder = treePrint[3];
                    printHolder += (visited[x]).ToString() + " ";
                    treePrint[3] = printHolder;
                    namePrintHolder = namePrint[3];
                    namePrintHolder += (names[x]).ToString() + " ";
                    namePrint[3] = namePrintHolder;
                }
                else if (x > 39 && x <= 120)
                {
                    printHolder = treePrint[4];
                    printHolder += (visited[x]).ToString() + " ";
                    treePrint[4] = printHolder;
                    namePrintHolder = namePrint[4];
                    namePrintHolder += (names[x]).ToString() + " ";
                    namePrint[4] = namePrintHolder;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Final Tree Output:");
            for (int x = 0; x <= 4; x++)
            {
                Console.WriteLine(treePrint[x]);
            }
            Console.WriteLine("Final Tree Traversal of Names Output:");
            for (int x = 0; x <= 4; x++)
            {
                Console.WriteLine(namePrint[x]);
            }
            // }
            // else if (choice == "2")
            // {
            //     // DFS Tree Traversal
            //     while (state <= goalstate)
            //     {
            //         // Show Tree
            //         Console.WriteLine("Tree Traversal:");
            //         visited.ForEach(item => Console.Write(item + ", "));
            //         Console.WriteLine();

            //         // Add children
            //         if (state == 1)
            //         {
            //             fringe.Add(2);
            //             fringe.Add(3);
            //             fringe.Add(4);
            //         }
            //         else
            //         {
            //             int lastnode = visited[visited.Count-1];                        
            //             fringe.Add((lastnode * 3)-1);
            //             fringe.Add((lastnode * 3));
            //             fringe.Add((lastnode * 3)+1);
            //         }


            //         // Change to new state
            //         int visitednode = fringe[fringe.Count-1];
            //         visited.Add(visitednode);

            //         // Show Fringe
            //         Console.WriteLine("Fringe:");
            //         fringe.ForEach(item => Console.Write(item + ", "));
            //         Console.WriteLine();

            //         // Remove fringe
            //         state = fringe[fringe.Count-1];
            //         fringe.Clear();
            //     }
            // }
            // else
            // {
            //     Console.WriteLine("Invalid choice.");
            // }
        }
    }
}
