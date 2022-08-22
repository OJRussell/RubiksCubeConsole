using System;
using RubiksCubeConsole.Enums;

namespace RubiksCubeConsole.Models
{
    public class FaceConnection
    {
        public FacePositions FacePosition { get; set; }
        public ColumnPositions? ColumnPosition { get; set; }
        public RowPositions? RowPosition { get; set; }

        public FaceConnection(FacePositions position, ColumnPositions? column, RowPositions? row)
        {
            FacePosition = position;
            ColumnPosition = column;
            RowPosition = row;
        }
    }
}

