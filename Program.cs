using System;
using System.Collections.Generic;
namespace Tree_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare goal state, fringe, and visited list
            int goalstate = 43;
            List<int> fringe = new List<int>();
            List<int> visited = new List<int>();

            // Loop to generate the tree with state 1
            Console.WriteLine("Generating Tree Traversal for " + goalstate);
            int state = 1;
            fringe.Add(state);
            while (state <= goalstate)
            {
                // Show Tree
                Console.WriteLine("Tree Traversal:");
                visited.ForEach(item => Console.Write(item + ", "));
                Console.WriteLine();

                // Add children
                int lastnode = fringe[fringe.Count-1];
                fringe.Add(lastnode + 1);
                fringe.Add(lastnode + 2);
                fringe.Add(lastnode + 3);

                // Change to new state
                int visitednode = fringe[0];
                visited.Add(visitednode);
                
                // Show Fringe
                Console.WriteLine("Fringe:");
                fringe.ForEach(item => Console.Write(item + ", "));
                Console.WriteLine();

                // Remove fringe and
                fringe.RemoveAt(0);
                state = fringe[0];
                
                
            }    
            // Print Final Output:
            // Console.WriteLine("Fringe:");
            // fringe.ForEach(item => Console.Write(item + ", "));
            // Console.WriteLine();
            // Console.WriteLine("Tree Traversal:");
            // visited.ForEach(item => Console.Write(item + ", "));
            // Console.WriteLine();

            // Generate Tree
            // int count = 0;
            // while (state <= visited.Count)
            // {
            //     if (state == 1)
            //     {
            //         Console.Write(state);
            //         if (count )
            //     }
            //     else
            //     {
                    
            //     }
            // }
        }
    }
}
