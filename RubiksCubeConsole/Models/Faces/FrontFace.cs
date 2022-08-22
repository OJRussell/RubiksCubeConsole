using System;
using RubiksCubeConsole.Enums;

namespace RubiksCubeConsole.Models.Faces
{
    public class FrontFace : Face
    {
        private const Colours _colour = Colours.Green;
        private const FacePositions _position = FacePositions.Front;

        public FrontFace() : base(_colour, _position)
        {
        }

        public override List<FaceConnection> GetConnections() =>
            new List<FaceConnection>()
            {
                new FaceConnection(FacePositions.Up, null, RowPositions.Bottom),
                new FaceConnection(FacePositions.Right, ColumnPositions.Left, null),
                new FaceConnection(FacePositions.Down, null, RowPositions.Top),
                new FaceConnection(FacePositions.Left, ColumnPositions.Right, null)
            };
    }
}

