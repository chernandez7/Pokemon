using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Pokemon
{
    public class Game
    {
        private static int Main() {
            Console.WriteLine("Hello World!");

            var game = new Game();
            game.Play();

            return 0;
        }

        public Game() {
            //Initialize Vars here
            Globals.TypeDictionary = LoadTypeDictionary(); // Loads in types and multipliers
        }

        // Loads in Types from "Types.txt" into Dictionary<name, multipliers>
        public Dictionary<PokemonType, float[]> LoadTypeDictionary() {
            var typesDictionary = new Dictionary<PokemonType, float[]>();
            const string filePath = "../../../Documents/Types.txt";

            var reader = new StreamReader(filePath);

            while (!reader.EndOfStream) {
                var line = reader.ReadLine();
                if (line == null) continue;
                var list = line.Split(' ').ToList(); // Name and Multipliers
                var multiplierList = new float[list.Count]; // Multipliers without type name
                for (var i = 1; i < list.Count; i++)
                    multiplierList[i - 1] = float.Parse(list[i]);
                
                var type = new PokemonType(list[0], multiplierList); // Creates type

                typesDictionary.Add(type, multiplierList);
            }
            Console.WriteLine("Types Loaded...");
            return typesDictionary;
        }

        ///  Main play routine.  Loops until end of play.
        public void Play()  {
            //printWelcome();
            // Enter the main command loop.  Here we repeatedly read commands and
            // Execute them until the game is over.
            //while (!ProcessCommand(Command.GetCommand())) {}

            Console.WriteLine("Thank you for playing!");
        }
    }
}
