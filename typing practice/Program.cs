//Basic typing practice console app

//1.0 allow user to select their list of words, those being CS related sentences, common words or uncommon words

//2.0 create list of words than ONLY have those letters possibly using negative validation
//2.1 create array from the list

//3.0 prompt user with a word from the array
//3.1 let them fill in the word 
//3.2 allow the user to quit or reset to state 1

using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace typing_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program start
            Console.WriteLine("Loading");
            Random random = new Random();
            string[] wordsArray;
            StreamReader streamReader;
            List<string> wordsList = new List<string>();
            string currentWord = "";
            // Read and display lines from the file until the end of
            // the file is reached.
            Console.Clear();

            //1.0 allow user to select their list of words, those being CS related sentences, common words or uncommon words
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

            RunGame(wordsArray, random);
            streamReader.Close();
            //Console.ReadLine();
        }

        static void RunGame(string[] wordsArray, Random random)
        {
            string exitWord = "QUIT";
            string resetWord = "RESET";
            char[] validLetters = ValidLetters();
            char[] invalidLetters = InValidLetters(validLetters);
            string[] validWords = ValidWords(validLetters, invalidLetters, wordsArray);
            string inputWord;

            //3.0 prompt user with a word from the array
            //3.1 let them fill in the word 
            //3.2 allow the user to quit or reset to state 1
            do
            {
                Console.Clear();
                Console.WriteLine($"Hit enter to generate new word/sentece.\nType {resetWord} to change options\nType {exitWord} to quit program.\n");
                Console.WriteLine(validWords[random.Next(validWords.Length)]);
                inputWord = Console.ReadLine();
            } while (inputWord != exitWord && inputWord != resetWord);
            if(inputWord == resetWord)
            {
                //implement reset feature
            }




        }
        static char[] ValidLetters()
        {
            Console.Clear();
            List<char> validLetterList = new List<char>();
            Console.WriteLine("Full alphabet used");
            
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
           
            return validLetterList.ToArray();
        }
        static char[] InValidLetters(char[] validLetters)
        {
            List<string> inValidLetters = new List<string>();
            {
                inValidLetters.Add("a");
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
                if (inValidLetters.Contains(Convert.ToString(c)))
                {
                    inValidLetters.Remove(Convert.ToString(c));
                }
            }

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
                    if (invalidLetters.Contains(c))
                    {
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
            return validWords.ToArray();

        }

    }

}
