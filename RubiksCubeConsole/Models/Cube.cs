using System;
using RubiksCubeConsole.Enums;

namespace RubiksCubeConsole.Models
{
    public class Cube
    {
        public Colours Colour { get; set; }

        public ColumnPositions ColumnPosition { get; set; }

        public RowPositions RowPosition { get; set; }

        public Cube(Colours colour, ColumnPositions columnPosition, RowPositions rowPosition)
        {
            Colour = colour;
            ColumnPosition = columnPosition;
            RowPosition = rowPosition;
        }

        public RowPositions GetNewRowPosition()
        {
            switch (ColumnPosition)
            {
                case ColumnPositions.Left:
                    return RowPositions.Top;
                case ColumnPositions.Middle:
                    return RowPositions.Middle;
                case ColumnPositions.Right:
                    return RowPositions.Bottom;
                default:
                    throw new NotImplementedException($"Invalid Column Position {ColumnPosition}");
            }
        }

        public ColumnPositions GetNewColumnPosition()
        {
            switch (RowPosition)
            {
                case RowPositions.Top:
                    return ColumnPositions.Right;
                case RowPositions.Middle:
                    return ColumnPositions.Middle;
                case RowPositions.Bottom:
                    return ColumnPositions.Left;
                default:
                    throw new NotImplementedException($"Invalid Row Poswwition {RowPosition}");
            }
        }
    }
}

