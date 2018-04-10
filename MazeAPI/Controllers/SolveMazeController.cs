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
                return new MazeSolution();
            }
            return SolveMaze(maze);
        }

        private MazeSolution SolveMaze(string maze)
        {
            MazeSolution solvedMaze = new MazeSolution();

            return solvedMaze;
        }
    }
}
