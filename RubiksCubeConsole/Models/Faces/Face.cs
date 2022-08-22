using System;
using System.Drawing;
using System.Reflection;
using RubiksCubeConsole.Enums;

namespace RubiksCubeConsole.Models.Faces
{
    public abstract class Face
    {
        public List<Cube> Cubes { get; set; } = new List<Cube>();

        public FacePositions Position { get; set; }

        public Face(Colours colour, FacePositions position)
        {
            Position = position;

            InitializeCubes(colour);
        }

        public void InitializeCubes(Colours colour)
        {
            for (int i = 0; i < 9; i++)
            {
                (RowPositions row, int column) position = GetPosition(i);
                Cubes.Add(new Cube(colour, (ColumnPositions)position.column, position.row));
            }
        }

        (RowPositions, int) GetPosition(int i)
        {
            if (i < 3)
                return (RowPositions.Top, i);

            if (i < 6)
                return (RowPositions.Middle, i - 3);

            return (RowPositions.Bottom, i - 6);
        }

        public void RotateFace(RotateTypes rotateType)
        {
            var colours = Cubes.Select(c => c.Colour).ToList();

            for (int i = 0; i < Cubes.Count; i++)
            {
                var cube = Cubes[i];

                var newRowPosition = cube.GetNewRowPosition();
                var newColumnPosition = cube.GetNewColumnPosition();

                if(rotateType == RotateTypes.AntiClockwise)
                {
                    newRowPosition = ReverseRowPosition(newRowPosition);
                    newColumnPosition = ReverseColumnPosition(newColumnPosition);
                }

                SetNewCubeColour(newColumnPosition, newRowPosition, colours[i]);
            }
        }

        private ColumnPositions ReverseColumnPosition(ColumnPositions columnPosition) =>
            columnPosition == ColumnPositions.Right ? ColumnPositions.Left : columnPosition != ColumnPositions.Middle ? ColumnPositions.Right : ColumnPositions.Middle;

        private RowPositions ReverseRowPosition(RowPositions rowPosition) =>
            rowPosition == RowPositions.Top ? RowPositions.Bottom : rowPosition != RowPositions.Middle ? RowPositions.Top : RowPositions.Middle;

        public abstract List<FaceConnection> GetConnections();

        public void SetNewCubeColour(ColumnPositions columnPosition, RowPositions rowPosition, Colours colour)
        {
            Cubes.Where(c => c.RowPosition == rowPosition && c.ColumnPosition == columnPosition).Single().Colour = colour;
        }

        public List<Cube> GetCubesByPosition(ColumnPositions columnPosition) =>
            Cubes.Where(c => c.ColumnPosition == columnPosition).ToList();

        public List<Cube> GetCubesByPosition(RowPositions rowPosition) =>
            Cubes.Where(c => c.RowPosition == rowPosition).ToList();
    }
}

