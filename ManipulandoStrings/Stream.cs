using System;
using System.Collections.Generic;
using System.Text;

namespace ManipulandoStrings
{
    public class Stream : IStream
    {
        /// <summary>
        /// Posição do caracter na sentência de caracteres
        /// </summary>
        private int index = -1;

        /// <summary>
        /// Sequencia de caracteres
        /// </summary>
        public string Sentence { get; set; }

        /// <summary>
        /// Pega o próximo caracter
        /// </summary>
        /// <returns></returns>
        public char GetNext()
        {

            index++;
            return Sentence[index];
        }

        /// <summary>
        /// Verifica se é o fim da sequencia de caracteres
        /// </summary>
        /// <returns></returns>
        public bool HasNext()
        {
            return index < Sentence.Length - 1;
        }

        public int Index()
        {
            return index;
        }
    }
}
