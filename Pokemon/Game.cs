using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class Game
    {
        static int Main()
        {
            Console.WriteLine("Hello World!");

            var game = new Game();
            game.Play();

            return 0;
        }

        public Game()
        {
            //Initialize Vars here
            Globals.TypeDictionary = LoadTypeDictionary();
        }

        public Dictionary<PokemonType, float[]> LoadTypeDictionary()
        {
            var typesDictionary = new Dictionary<PokemonType, float[]>();
            const string filePath = "../../../Documents/Types.txt";

            var reader = new StreamReader(filePath);

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var list = line.Split(' ').ToList();
                var multiplierList = new float[list.Count];
                for (var i = 1; i < list.Count; i++)
                {
                    multiplierList[i - 1] = float.Parse(list[i]);
                }
                var type = new PokemonType(list[0], multiplierList);

                typesDictionary.Add(type, multiplierList);
            }

            return typesDictionary;
        }

        ///  Main play routine.  Loops until end of play.
        public void Play()
        {
            //printWelcome();
            // Enter the main command loop.  Here we repeatedly read commands and
            // Execute them until the game is over.
            //while (!ProcessCommand(Command.GetCommand())) {}

            Console.WriteLine("Thank you for playing!");
        }
    }
}
