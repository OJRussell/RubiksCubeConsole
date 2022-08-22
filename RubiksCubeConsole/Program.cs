using System;
using RubiksCubeConsole.Controllers;
using RubiksCubeConsole.Models;

namespace RubiksCubeConsole 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**------------------------**");
            Console.WriteLine("Welcome to The Rubik's Cube!");
            Console.WriteLine("Press enter to start");
            Console.WriteLine("**------------------------**");
            Console.ReadLine();
            Console.WriteLine("**------------------------**");
            Console.WriteLine("Setting up Ribik's Cube");
            Console.WriteLine("**------------------------**");

            RubkisCubeController rubiksCubeController = new RubkisCubeController();

            Console.WriteLine(rubiksCubeController.RubiksCube.ToString());

            bool run = true;

            while (run)
            {
                Console.WriteLine("**------------------------**");
                Console.Write("Enter face to rotate: ");
                string rotateCubeBy = Console.ReadLine();
                Console.WriteLine("**------------------------**");
                try
                {
                    if(rotateCubeBy.Trim().ToLower() == "quit")
                    {
                        run = false;
                        continue;
                    }

                    if (rotateCubeBy.Trim().ToLower() == "reset")
                    {
                        rubiksCubeController.RubiksCube = new RubiksCube();
                        Console.WriteLine(rubiksCubeController.RubiksCube.ToString());
                        continue;
                    }

                    rubiksCubeController.RotateFace(rotateCubeBy);
                    Console.WriteLine(rubiksCubeController.RubiksCube.ToString());
                } catch (NotImplementedException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.WriteLine("**------------------------**");
            Console.WriteLine("Thank you for playing with The Rubik's Cube.");
            Console.WriteLine("**------------------------**");

            Console.ReadLine();
        }
    }
}