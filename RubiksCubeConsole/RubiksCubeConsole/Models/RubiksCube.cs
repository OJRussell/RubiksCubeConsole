using System;
using System.Linq;
using RubiksCubeConsole.Enums;

namespace RubiksCubeConsole.Models
{
    public class RubiksCube
    {
        public List<Face> Faces { get; set; } = new List<Face>();

        public RubiksCube()
        {
            InitializeRubiksCube();
        }

        private void InitializeRubiksCube()
        {
            var values = Enum.GetValues(typeof(Positions));

            for (int i = 0; i < values.Count(); i++)
            {

            }
            foreach (var position in Enum.GetValues(typeof(Positions)))
            {

            }
            throw new NotImplementedException();
        }
    }
}

