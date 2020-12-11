
using System;
using System.Collections.Generic;
using System.IO;

namespace Frozen
{
    class Program
    {
        class Characters
        {
            class FrozenCharacters
            {
                string character;
                string title;
                public FrozenCharacters(string _title, string _character)
                {
                    character = _character;
                    title = _title;
                }
                public string Character { get { return character; } }
                public string Title { get { return title; } }
            }
            class FrozenList
            {
                List<FrozenCharacters> frozens;
                public FrozenList()
                {
                    frozens = new List<FrozenCharacters>();
                }
                public void AddFrozentoList(string title, string character)
                {
                    FrozenCharacters newFrozen = new FrozenCharacters(title, character);
                    frozens.Add(newFrozen);
                }
                public void PrintAllFrozen()
                {
                    foreach (FrozenCharacters character in frozens)
                    {
                        Console.WriteLine($"{character.Character} wants {character.Title} for christmas ");
                    }
                }
            }
            static void Main(string[] args)
            {
                string filePath = @"C:\Users\opilane\samples";
                string fileName = @"Frozen.txt";
                string fullFilePath = Path.Combine(filePath, fileName);
                string[] linesFromfile = File.ReadAllLines(fullFilePath);            
                FrozenList myFrozens = new FrozenList();
                foreach (string line in linesFromfile)
                {
                    string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                    string frozenTitle = tempArray[1];
                    string frozenCharacter = tempArray[0];

                    myFrozens.AddFrozentoList(frozenTitle, frozenCharacter);
                }
                myFrozens.PrintAllFrozen();

            }
        }
    }
}