using System;

namespace GoogleInterviewPhonePad
{
    class Program
    {
        static void Main()
        {
            string phoneNumber = "366227781578151951891681";
            string[] words = new string[] { "foo", "bar", "baz", "foobar", "emo", "cap", "car", "cat" };
            string[] wordNumbers = new string[8];
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    wordNumbers[i] += Transcribe(char.Parse(words[i].Substring(j, 1)));
                }
            }

            for (int i = 0; i < wordNumbers.Length; i++)
            {
                if (phoneNumber.Contains(wordNumbers[i]))
                {
                    Console.WriteLine($"{words[i]} is in the phone number");
                }
            }

            Console.WriteLine("Press any key to exit:");
            Console.ReadKey();
        }

        private static int Transcribe(char oneChar)
        {
            int result = 0;
            switch (oneChar)
            {
                case 'a':
                case 'b':
                case 'c':
                    result = 2;
                    break;
                case 'd':
                case 'e':
                case 'f':
                    result = 3;
                    break;
                case 'g':
                case 'h':
                case 'i':
                    result = 4;
                    break;
                case 'j':
                case 'k':
                case 'l':
                    result = 5;
                    break;
                case 'm':
                case 'n':
                case 'o':
                    result = 6;
                    break;
                case 'p':
                case 'q':
                case 'r':
                case 's':
                    result = 7;
                    break;
                case 't':
                case 'u':
                case 'v':
                    result = 8;
                    break;
                case 'w':
                case 'x':
                case 'y':
                case 'z':
                    result = 9;
                    break;

                default:
                    result = 0;
                    break;
            }

            return result;
        }
    }
}
