using System;
using System.Collections.Generic;
using System.Text;

namespace ManipulandoStrings
{
    public class Character
    {
        private static char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        private static char[] consonants = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z', '\0' };

        public Character(IStream stream) { }

        public static char FirstChar(IStream input)
        {
            bool foundConsonant = false;
            char foundVowel = '\0';
            /* 
            Armazena a quantidade de vezes que as vogais apareceram
            0  = não existe
            -n = aparece mais de uma vez
            >1 = aparece 1 vez
            */
            int[] foundVowels = { 0, 0, 0, 0, 0 };

            do
            {
                var character = input.GetNext();

                if (IsConsonant(character))
                    foundConsonant = true;

                if (foundConsonant)
                {
                    int indexVowel = -1;

                    if (IsVowel(character, out indexVowel))
                    {
                        var vowelIncrement = foundVowels[indexVowel];
                        if (vowelIncrement >= 1 || vowelIncrement < 0)
                        {
                            vowelIncrement = vowelIncrement > 1 ? vowelIncrement * -1 : vowelIncrement;
                            vowelIncrement = vowelIncrement - input.Index();
                        }
                        else
                        {
                            vowelIncrement = vowelIncrement + input.Index();
                        }
                        foundVowels[indexVowel] = vowelIncrement;
                    }
                }

            } while (input.HasNext());

            foundVowel = GetLastVowelWithoutRepeat(foundVowel, foundVowels);

            return foundVowel;
        }

        private static char GetLastVowelWithoutRepeat(char foundVowel, int[] foundVowels)
        {
            int indexIncrementVowel = -1;
            int maxIncrement = 0;
            for (int i = 0; i < foundVowels.Length; i++)
            {
                if (foundVowels[i] > maxIncrement)
                {
                    maxIncrement = foundVowels[i];
                    indexIncrementVowel = i;
                }
            }

            if (indexIncrementVowel >= 0)
            {
                foundVowel = vowels[indexIncrementVowel];
            }

            return foundVowel;
        }

        private static bool IsVowel(char character, out int index)
        {
            index = -1;
            for (int v = 0; v < vowels.Length; v++)
            {
                if (character == vowels[v])
                {
                    index = v;
                    return true;
                }
            }

            return false;
        }

        private static bool IsConsonant(char character)
        {
            for (int c = 0; c < consonants.Length; c++)
            {
                if (character == consonants[c])
                {
                    return true;
                }
            }

            return false;
        }
    }
}
