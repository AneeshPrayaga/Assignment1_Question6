using System;
using System.Linq;
using System.Text;

namespace Assignment1_Question6
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Q6: Enter the sentence to convert:");
            string sentence = Console.ReadLine();//input sentence
            string goatLatin = ToGoatLatin(sentence);//calling method
            Console.WriteLine("Goat Latin for the Given Sentence is - {0}  " , goatLatin);//print goat latin
           
           
           
        }


        private static string ToGoatLatin(string sentence)//method
        {
            try {
                var splittedinput = sentence.Split(" ");//splitting at space 
                StringBuilder Translated = new StringBuilder(); //creating a new string builder;
                int no_Of_As = 0;//initial number of A's
                foreach (string Words in splittedinput)//for each loop to iterate every word.
                {

                    no_Of_As++;//incrementing one A for every word

                    var Condition = Words[0];//checking only first word
                    if (Condition == 'a' || Condition == 'e' || Condition == 'i' || Condition == 'o' || Condition == 'u')// Condition == 'A' || Condition == 'E' || Condition == 'I' || Condition == 'O' || Condition == 'U'
                    {
                        Translated.Append(Words);//appending the first word and checking if its a ovel

                    }

                    else
                    {//if its not  ovel then we go here



                        for (int i = 1; i < Words.Length; i++)//loop iterating through letters in the word.
                        {

                            Translated.Append(Words[i]);///appending the world excluding first letter



                        }
                        Translated.Append(Words[0]);//appending the letter

                    }
                    Translated.Append("ma");//adding ma to all the words

                    for (int i = 0; i < no_Of_As; i++)//counting the word position and then adding a's
                        Translated.Append('a');
                    Translated.Append(" ");//adding pairs

                   


                }
                return Translated.ToString();//returning the translated string
            }
            catch
            {
                throw;
            }
            }
    }


}

            //Logic for adding a's.
            //int noOfAs = 0;

            //foreach(string wordsforA in splittedinput)
            //{
            //    noOfAs ++;
            //    for(int i = 1; i < splittedinput.Length; i++)
            //    {
            //        Translated.Append('a');
            //    }

            //}
            //Console.WriteLine(Translated + " Final transplation");

            //foreach(string s in splittedinput)
            //{
            //    Console.WriteLine(splittedinput.Length);
            //Console.WriteLine(splittedinput[0].Substring(0,1));
            ////for (int i = 0; i < splittedinput.Length; i++)
            //{
            //    string Condition = splittedinput[i].Substring(0, 1);
            //    if (Condition == "a" || Condition == "e"|| Condition == "i" || Condition == "o" || Condition == "u")
            //    {
            //        splittedinput[i] = string.Concat(splittedinput[i],"ma");

            //    }
            //    else
            //    {
            //        var Consonent = splittedinput[i];
            //       var  Consonent1 = splittedinput[i].Substring(0, 1);
            //        Consonent = 

            //        splittedinput[i] = string.Concat(splittedinput[i], "ma");
            //    }
            //}
            //foreach(string s in splittedinput)
            //{
            //    Console.WriteLine(s);
            //}
        
