using System;
using RubiksCubeConsole.Enums;

namespace RubiksCubeConsole.Models.Faces
{
    public class RightFace : Face
    {
        private const Colours _colour = Colours.Red;
        private const FacePositions _position = FacePositions.Right;

        public RightFace() : base(_colour, _position)
        {
        }

        public override List<FaceConnection> GetConnections() =>
           new List<FaceConnection>()
           {
                new FaceConnection(FacePositions.Up, ColumnPositions.Right, null),
                new FaceConnection(FacePositions.Back, ColumnPositions.Left, null),
                new FaceConnection(FacePositions.Down, ColumnPositions.Right, null),
                new FaceConnection(FacePositions.Front, ColumnPositions.Right, null)
           };
    }
}

