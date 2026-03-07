using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace typing_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loading");
            Random random = new Random();
            string[] wordsArray;
            StreamReader streamReader;
            List<string> wordsList = new List<string>();
            string currentWord = "";
            // Read and display lines from the file until the end of
            // the file is reached.
            Console.Clear();
            Console.WriteLine($"1 for CS sentences\n2 for common list of words\n3 for uncommon list of words");
            switch (Console.ReadLine())
            {
                case "1":
                    streamReader = new StreamReader("listOfSentencesCompSci.txt");
                    break;
                case "2":
                    streamReader = new StreamReader("listOfWordsCommon.txt");
                    break;

                case "3":
                    streamReader = new StreamReader("listOfWordsUncommon.txt");
                    break;

                default:
                    streamReader = new StreamReader("listOfWordsCommon.txt");
                    break;
            }
            while ((currentWord = streamReader.ReadLine()) != null)
            {
                //Console.WriteLine(currentWord);
                wordsList.Add(currentWord);
            }
            wordsArray = wordsList.ToArray();

            //int TEMP = 0;
            //foreach(string word in wordsArray)
            //{
            //    if (wordsArray.Contains("a") || wordsArray.Contains("s") || wordsArray.Contains("d") || wordsArray.Contains("f") || wordsArray.Contains("j") || wordsArray.Contains("k") || wordsArray.Contains("l"))
            //    {
            //        TEMP++;
            //    }
            //}
            //Console.Write($"{TEMP} many words\n{TEMP/(wordsArray.Length)}%");


            //Console.WriteLine("File info: ");
            //Console.WriteLine($"Entries: {wordsArray.Length}");
            //Console.WriteLine($"Randon word: {wordsArray[random.Next(wordsArray.Length)]}");

            //1.0 allow user to input the letters to use
            // 1.1 option for home row

            //2.0 create list of words than ONLY have those letters possibly using negative validation
            //2.1 create array from the list

            //3.0 prompt user with a word from the array
            //3.1 let them fill in the word 
            //3.2 allow the user to quit or reset to state 1

            RunGame(wordsArray, random);
            streamReader.Close();
            //Console.ReadLine();
        }

        static void RunGame(string[] wordsArray, Random random)
        {
            do
            {
                char[] validLetters = ValidLetters();
                //Console.WriteLine($"Valid letters: {validLetters.Length}");
                char[] invalidLetters = InValidLetters(validLetters);
                //Console.WriteLine($"Invalid letters: {invalidLetters.Length}");
                string[] validWords = ValidWords(validLetters, invalidLetters, wordsArray);
                //Console.WriteLine($"Valid words: {validWords.Length}");
                int sentenceLength = 10;
                string[] sentence = new string[sentenceLength];

                string wordToSpell;
                do
                {
                    Console.Clear();
                    /*for(int i = 0; i < sentenceLength; i++)
                    {
                        sentence[i] = validWords[random.Next(validWords.Length)];
                    }
                    foreach (string word in sentence)
                    {
                        Console.Write($"{word} ");
                    }
                    Console.WriteLine();
                    */
                    Console.WriteLine(validWords[random.Next(validWords.Length)]);
                    while (Console.ReadKey().Key != ConsoleKey.Enter)
                    {
                        
                    } 
                    Console.WriteLine("Well done");

                } while (true);


            } while (true);


        }
        static char[] ValidLetters()
        {
            //1.0 allow user to input the letters to use
            // 1.1 option for home row
            Console.Clear();
            List<char> validLetterList = new List<char>();
            Console.WriteLine("Full alphabet used");
            /*Console.WriteLine("Enter the letters you want to use or enter: \n1: home row + top row\n2: all letters");
            string userInput = Console.ReadLine();
            if (userInput.Equals("1"))
            {
            
                //home row
                validLetterList.Add('a');
                validLetterList.Add('s');
                validLetterList.Add('d');
                validLetterList.Add('f');
                validLetterList.Add('g');
                validLetterList.Add('h');
                validLetterList.Add('j');
                validLetterList.Add('k');
                validLetterList.Add('l');
                validLetterList.Add(';');

                //top row
                validLetterList.Add('q');
                validLetterList.Add('w');
                validLetterList.Add('e');
                validLetterList.Add('r');
                validLetterList.Add('t');
                validLetterList.Add('y');
                validLetterList.Add('u');
                validLetterList.Add('i');
                validLetterList.Add('o');
                validLetterList.Add('p');
            }
            if (userInput.Equals("2")){
            */
                validLetterList.Add('a');
                validLetterList.Add('b');
                validLetterList.Add('c');
                validLetterList.Add('d');
                validLetterList.Add('e');
                validLetterList.Add('f');
                validLetterList.Add('g');
                validLetterList.Add('h');
                validLetterList.Add('i');
                validLetterList.Add('j');
                validLetterList.Add('k');
                validLetterList.Add('l');
                validLetterList.Add('m');
                validLetterList.Add('n');
                validLetterList.Add('o');
                validLetterList.Add('p');
                validLetterList.Add('q');
                validLetterList.Add('r');
                validLetterList.Add('s');
                validLetterList.Add('t');
                validLetterList.Add('u');
                validLetterList.Add('v');
                validLetterList.Add('w');
                validLetterList.Add('x');
                validLetterList.Add('y');
                validLetterList.Add('z');
            /*
            }
            else
            {
                userInput = userInput.ToLower();
                foreach (char letter in userInput)
                {
                    validLetterList.Add(letter);
                }
            }
            */
            //foreach (char letter in validLetterList)
            //{
            //    Console.Write(letter + ", ");
            //}
            return validLetterList.ToArray();
        }
        static char[] InValidLetters(char[] validLetters)
        {
            List<string> inValidLetters = new List<string>();
            {    inValidLetters.Add("a");
            inValidLetters.Add("b");
            inValidLetters.Add("c");
            inValidLetters.Add("d");
            inValidLetters.Add("e");
            inValidLetters.Add("f");
            inValidLetters.Add("g");
            inValidLetters.Add("h");
            inValidLetters.Add("i");
            inValidLetters.Add("j");
            inValidLetters.Add("k");
            inValidLetters.Add("l");
            inValidLetters.Add("m");
            inValidLetters.Add("n");
            inValidLetters.Add("o");
            inValidLetters.Add("p");
            inValidLetters.Add("q");
            inValidLetters.Add("r");
            inValidLetters.Add("s");
            inValidLetters.Add("t");
            inValidLetters.Add("u");
            inValidLetters.Add("v");
            inValidLetters.Add("w");
            inValidLetters.Add("x");
            inValidLetters.Add("y");
            inValidLetters.Add("z");
        }
            foreach (char c in validLetters)
            {
                if (inValidLetters.Contains(Convert.ToString(c))){
                    inValidLetters.Remove(Convert.ToString(c));
                }
            }
            //Console.WriteLine($"Expected answer: {26 - validLetters.Length}\nActual answer: {inValidLetters.Count}");
            
            //foreach (string word in inValidLetters)
            //{
            //    Console.Write(word + "");
            //}
            char[] inValidLettersArray = new char[inValidLetters.Count];
            for (int i = 0; i < inValidLettersArray.Length; i++)
            {
                inValidLettersArray[i] = Convert.ToChar(inValidLetters[i]);
            }

            return inValidLettersArray;
        }
        static string[] ValidWords(char[] validLetters, char[] invalidLetters, string[] wordsArray)
        {
            //2.0 create list of words than ONLY have those letters possibly using negative validation
            //2.1 create array from the list

            //foreach word in wordsArray
            //foreach char in word
            //if invalidchar contains char then move on 

            List<string> validWords = new List<string>();
            bool validWord = true;
            foreach (string word in wordsArray)
            {
                foreach (char c in word)
                {
                    if (invalidLetters.Contains(c)){
                        validWord = false;
                        continue;
                    }
                }
                if (validWord)
                {
                    validWords.Add(word);
                }
                validWord = true;
            }

            //Console.WriteLine(validWords.Count);
            //foreach(string word in validWords)
            //{
            //    Console.WriteLine(word);
            //}

            return validWords.ToArray();

        }

    }

}
