using System;
using RubiksCubeConsole.Enums;

namespace RubiksCubeConsole.Models.Faces
{
    public class DownFace : Face
    {
        private const Colours _colour = Colours.Yellow;
        private const FacePositions _position = FacePositions.Down;

        public DownFace() : base(_colour, _position)
        {
        }

        public override List<FaceConnection> GetConnections() =>
            new List<FaceConnection>()
            {
                new FaceConnection(FacePositions.Front, null, RowPositions.Bottom),
                new FaceConnection(FacePositions.Right, null, RowPositions.Bottom),
                new FaceConnection(FacePositions.Back, null, RowPositions.Bottom),
                new FaceConnection(FacePositions.Left, null, RowPositions.Bottom)
            };
    }
}

