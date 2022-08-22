using System;
using RubiksCubeConsole.Enums;

namespace RubiksCubeConsole.Models.Faces
{
    public class LeftFace : Face
    {
        private const Colours _colour = Colours.Orange;
        private const FacePositions _position = FacePositions.Left;

        public LeftFace() : base(_colour, _position)
        {
        }

        public override List<FaceConnection> GetConnections() =>
           new List<FaceConnection>()
           {
                new FaceConnection(FacePositions.Up, ColumnPositions.Left, null),
                new FaceConnection(FacePositions.Front, ColumnPositions.Left, null),
                new FaceConnection(FacePositions.Down, ColumnPositions.Left, null),
                new FaceConnection(FacePositions.Back, ColumnPositions.Right, null)
           };
    }
}

