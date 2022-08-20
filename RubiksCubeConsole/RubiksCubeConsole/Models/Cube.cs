using System;
using RubiksCubeConsole.Enums;

namespace RubiksCubeConsole.Models
{
    public class Cube
    {
        public Colours Colour { get; set; }

        public Cube(Colours colour)
        {
            Colour = colour;
        }
    }
}

