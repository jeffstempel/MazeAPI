using MazeAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MazeAPI.Controllers
{
    public class SolveMazeController : ApiController
    {
        // POST api/solveMaze
        public MazeSolution Post( string maze )
        {
            if (String.IsNullOrEmpty(maze))
            {
                return new MazeSolution { Solution = "Invalid maze object passed.", Steps = 0 };
            }
            return SolveMaze(maze);
        }

        private MazeSolution SolveMaze(string maze)
        {
            MazeSolution solvedMaze = new MazeSolution();
            maze = "########## #A...#...# #.#.##.#.# #.#.##.#.# #.#....#B# #.#.##.#.# #....#...# ########## ";

            var mazeArray = MazeArray( maze );

            // Need to find the start space by going through each row and column by column

            // Once that is figured out, that is where the start square is.

            // Begin traversing through the array to find next step and increment counter and replace . with @

            // Will probably require recursion.

            solvedMaze.Solution = mazeArray.ToString();
            solvedMaze.Steps = 0; // this will need to be replaced once traversed and found optimal solution
            return solvedMaze;
        }

        private static int[][] MazeArray(string maze)
        {
            string[] mazeLines = maze.Split( new char[] { '\n', '\r', ' ' }, StringSplitOptions.RemoveEmptyEntries );

            int[][] mazeArray = new int[ mazeLines.Length ][];
            for ( int i = 0; i < mazeLines.Length; i++ )
            {
                var line = mazeLines[ i ];
                var row = new int[ line.Length ];
                for (int j = 0; j < line.Length; j++ )
                {
                    switch (line[j])
                    {
                        case '#':
                            row[ j ] = -1;
                            break;
                        case 'A':
                            row[ j ] = 1;
                            break;
                        case 'B':
                            row[ j ] = -3;
                            break;
                        default:
                            row[ j ] = 0;
                            break;
                    }
                }
                mazeArray[ i ] = row;
            }
            return mazeArray;
        }
    }
}
