using System;

namespace ManipulandoStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Escreva uma palavra para encontrar a última vogal depois de uma consoante:");
                string sentence = Console.ReadLine();

                var stream = new Stream() { Sentence = sentence };
                var lastVowelAfterConsonant = Character.FirstChar(stream);

                var texto = lastVowelAfterConsonant == '\0' ? "Não existem vogais que não se repetem." : lastVowelAfterConsonant.ToString();

                Console.WriteLine($"Ultima vogal depois da consoante sem repetição é :{ texto}");
            }
        }
    }
}
