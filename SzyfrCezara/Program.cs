namespace SzyfrCezara
{
    public class Program
    {
        public static string SzyfrujCezara(int key, string text)
        {
            string letters = "abcdefghijklmnopqrstuvwxyz";

            string result = "";

            foreach (var textChar in text)
            {
                bool isUpper = char.IsUpper(textChar);

                int charIndex = letters.IndexOf(char.ToLower(textChar));

                if (charIndex == -1)
                {
                    result += textChar;
                    continue;
                }

                for (int i = 0; i < Math.Abs(key % letters.Length); i++)
                {
                    if (key > 0)
                        charIndex++;
                    else
                        charIndex--;
                }


                if (charIndex < 0)
                    charIndex += letters.Length;

                if (charIndex > letters.Length - 1)
                    charIndex -= letters.Length;

                if (char.ToLower(textChar) != textChar)
                    result += char.ToUpper(letters[charIndex]);
                else
                    result += letters[charIndex];
            }

            return result;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
