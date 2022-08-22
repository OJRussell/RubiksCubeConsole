using System;
using RubiksCubeConsole.Enums;
using RubiksCubeConsole.Models;
using RubiksCubeConsole.Models.Faces;

namespace RubiksCubeConsole.Controllers
{
    public class RubkisCubeController
    {

        public RubiksCube RubiksCube { get; set; }

        public RubkisCubeController()
        {
            RubiksCube = new RubiksCube();
        }

        public void RotateFace(string input)
        {
            (FacePositions facePosition, RotateTypes rotateType) rotateCubeBy = GetRotateBy(input);

            RubiksCube.RotateCube(rotateCubeBy.facePosition, rotateCubeBy.rotateType);
        }

        (FacePositions, RotateTypes) GetRotateBy(string input)
        {
            switch (input.Trim().ToLower())
            {
                case "f":
                    return (FacePositions.Front, RotateTypes.Clockwise);
                case "b":
                    return (FacePositions.Back, RotateTypes.Clockwise);
                case "l":
                    return (FacePositions.Left, RotateTypes.Clockwise);
                case "r":
                    return (FacePositions.Right, RotateTypes.Clockwise);
                case "u":
                    return (FacePositions.Up, RotateTypes.Clockwise);
                case "d":
                    return (FacePositions.Down, RotateTypes.Clockwise);
                case "f'":
                    return (FacePositions.Front, RotateTypes.AntiClockwise);
                case "b'":
                    return (FacePositions.Back, RotateTypes.AntiClockwise);
                case "l'":
                    return (FacePositions.Left, RotateTypes.AntiClockwise);
                case "r'":
                    return (FacePositions.Right, RotateTypes.AntiClockwise);
                case "u'":
                    return (FacePositions.Up, RotateTypes.AntiClockwise);
                case "d'":
                    return (FacePositions.Down, RotateTypes.AntiClockwise);
                default:
                    throw new NotImplementedException("Invalid input. Please enter a valid input.");
            }
        }

        
    }
}

