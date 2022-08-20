using System;
using RubiksCubeConsole.Enums;

namespace RubiksCubeConsole.Models
{
    public class Face
    {
        public List<Cube> Cubes { get; set; } = new List<Cube>();

        public Face(Colours colour)
        {
            for (int i = 0; i < 9; i++)
            {
                Cubes.Add(new Cube(colour));
            }
        }
    }
}

