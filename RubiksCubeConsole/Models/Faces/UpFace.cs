using System;
using RubiksCubeConsole.Enums;

namespace RubiksCubeConsole.Models.Faces
{
    public class UpFace : Face
    {
        private const Colours _colour = Colours.White;
        private const FacePositions _position = FacePositions.Up;

        public UpFace() : base(_colour, _position)
        {
        }

        public override List<FaceConnection> GetConnections() =>
           new List<FaceConnection>()
           {
                new FaceConnection(FacePositions.Back, null, RowPositions.Top),
                new FaceConnection(FacePositions.Right, null, RowPositions.Top),
                new FaceConnection(FacePositions.Front, null, RowPositions.Top),
                new FaceConnection(FacePositions.Left, null, RowPositions.Top)
           };
    }
}

