using System;
using RubiksCubeConsole.Enums;

namespace RubiksCubeConsole.Models.Faces
{
    public class BackFace : Face
    {
        private const Colours _colour = Colours.Blue;
        private const FacePositions _position = FacePositions.Back;

        public BackFace() : base(_colour, _position)
        {
        }

        public override List<FaceConnection> GetConnections() =>
            new List<FaceConnection>()
            {
                new FaceConnection(FacePositions.Up, null, RowPositions.Top),
                new FaceConnection(FacePositions.Left, ColumnPositions.Left, null),
                new FaceConnection(FacePositions.Down, null, RowPositions.Bottom),
                new FaceConnection(FacePositions.Right, ColumnPositions.Right, null)
            };
    }
}

