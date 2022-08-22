using System;
using System.Linq;
using System.Text;
using RubiksCubeConsole.Controllers;
using RubiksCubeConsole.Enums;
using RubiksCubeConsole.Models.Faces;

namespace RubiksCubeConsole.Models
{
    public class RubiksCube
    {
        public List<Face> Faces { get; set; }

        public RubiksCube()
        {
            InitializeFaces();
        }

        void InitializeFaces()
        {
            Faces = new List<Face>()
            {
                new FrontFace(),
                new BackFace(),
                new LeftFace(),
                new RightFace(),
                new UpFace(),
                new DownFace(),
            };
        }

        #region Rotate Cube

        Face _currentFace;
        RotateTypes _currentRotateType;

        public void RotateCube(FacePositions facePosition, RotateTypes rotateType)
        {
            _currentRotateType = rotateType;

            _currentFace = GetFace(facePosition);
            _currentFace.RotateFace(rotateType);
            
            RotateConnectedCubes();
        }

        void RotateConnectedCubes()
        {
            var connections = _currentFace.GetConnections();

            if (_currentRotateType == RotateTypes.AntiClockwise)
                connections.Reverse();

            List<List<Colours>> conncetedColours = GetConnectedCubesColours(connections);

            for (int i = 0; i < connections.Count; i++)
            {
                var nextConnection = connections[i == connections.Count - 1 ? 0 : i + 1];

                var currentColours = conncetedColours[i];

                for (int x = currentColours.Count - 1; x > -1 ; x--)
                {
                    (ColumnPositions column, RowPositions row) newPosition = GetNewPosition(nextConnection, connections[i], x);

                    GetFace(nextConnection.FacePosition).SetNewCubeColour(newPosition.column, newPosition.row, currentColours[Math.Abs(x - 2)]);
                }
            }
        }

        (ColumnPositions, RowPositions) GetNewPosition(FaceConnection nextConnection, FaceConnection currentConnection, int index)
        {
            var reverseIndex = Math.Abs(index - 2);

            if (nextConnection.ColumnPosition.HasValue)
            {
                int rowIndex;
                if(_currentRotateType == RotateTypes.Clockwise)
                    rowIndex = nextConnection.ColumnPosition == ColumnPositions.Right ? reverseIndex : index;
                else
                    rowIndex = nextConnection.ColumnPosition == ColumnPositions.Right ? index : reverseIndex;

                return (nextConnection.ColumnPosition.Value, (RowPositions)(rowIndex));
            }

            return ((ColumnPositions)(_currentRotateType == RotateTypes.Clockwise ? reverseIndex : index ), nextConnection.RowPosition.Value);
        }

        List<List<Colours>> GetConnectedCubesColours(List<FaceConnection> connections)
        {
            List<List<Colours>> connectedCubesColours = new List<List<Colours>>();

            foreach (var connection in connections)
            {
                var connectedFace = GetFace(connection.FacePosition);

                var cubes = connection.ColumnPosition.HasValue ? connectedFace.GetCubesByPosition(connection.ColumnPosition.Value) : connectedFace.GetCubesByPosition(connection.RowPosition.Value);

                var colours = cubes.Select(c => c.Colour).ToList();

                if (_currentRotateType == RotateTypes.AntiClockwise)
                    colours.Reverse();

                connectedCubesColours.Add(colours);
            }

            return connectedCubesColours;
        }

        #endregion

        public Face GetFace(FacePositions facePosition) =>
            Faces.Where(f => f.Position == facePosition).Single();

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"\t\t\t|{Faces[4].Cubes[0].Colour} {Faces[4].Cubes[1].Colour} {Faces[4].Cubes[2].Colour}|");
            stringBuilder.AppendLine($"\t\t\t|{Faces[4].Cubes[3].Colour} {Faces[4].Cubes[4].Colour} {Faces[4].Cubes[5].Colour}|");
            stringBuilder.AppendLine($"\t\t\t|{Faces[4].Cubes[6].Colour} {Faces[4].Cubes[7].Colour} {Faces[4].Cubes[8].Colour}|");

            stringBuilder.AppendLine($"|{Faces[2].Cubes[0].Colour} {Faces[2].Cubes[1].Colour} {Faces[2].Cubes[2].Colour}|{Faces[0].Cubes[0].Colour} {Faces[0].Cubes[1].Colour} {Faces[0].Cubes[2].Colour}|{Faces[3].Cubes[0].Colour} {Faces[3].Cubes[1].Colour} {Faces[3].Cubes[2].Colour}|{Faces[1].Cubes[0].Colour} {Faces[1].Cubes[1].Colour} {Faces[1].Cubes[2].Colour}|");
            stringBuilder.AppendLine($"|{Faces[2].Cubes[3].Colour} {Faces[2].Cubes[4].Colour} {Faces[2].Cubes[5].Colour}|{Faces[0].Cubes[3].Colour} {Faces[0].Cubes[4].Colour} {Faces[0].Cubes[5].Colour}|{Faces[3].Cubes[3].Colour} {Faces[3].Cubes[4].Colour} {Faces[3].Cubes[5].Colour}|{Faces[1].Cubes[3].Colour} {Faces[1].Cubes[4].Colour} {Faces[1].Cubes[5].Colour}|");
            stringBuilder.AppendLine($"|{Faces[2].Cubes[6].Colour} {Faces[2].Cubes[7].Colour} {Faces[2].Cubes[8].Colour}|{Faces[0].Cubes[6].Colour} {Faces[0].Cubes[7].Colour} {Faces[0].Cubes[8].Colour}|{Faces[3].Cubes[6].Colour} {Faces[3].Cubes[7].Colour} {Faces[3].Cubes[8].Colour}|{Faces[1].Cubes[6].Colour} {Faces[1].Cubes[7].Colour} {Faces[1].Cubes[8].Colour}|");

            stringBuilder.AppendLine($"\t\t\t|{Faces[5].Cubes[0].Colour} {Faces[5].Cubes[1].Colour} {Faces[5].Cubes[2].Colour}|");
            stringBuilder.AppendLine($"\t\t\t|{Faces[5].Cubes[3].Colour} {Faces[5].Cubes[4].Colour} {Faces[5].Cubes[5].Colour}|");
            stringBuilder.AppendLine($"\t\t\t|{Faces[5].Cubes[6].Colour} {Faces[5].Cubes[7].Colour} {Faces[5].Cubes[8].Colour}|");

            return stringBuilder.ToString();
        }
    }
}

