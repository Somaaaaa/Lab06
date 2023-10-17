using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Caesar
    {
        int key;
        public Caesar(int key)
        {
            this.key = key;
        }
        private string TransformMessage(string message, int key)
        {
            char[] original = message.ToCharArray();
            char[] transformed = new char[original.Length];
            for (int i = 0; i < original.Length; i++)
            {
                char originalChar = original[i];
                char transformedChar = (char)(originalChar + key);
                transformed[i] = transformedChar;
            }
            string transformedText = string.Join("", transformed);
            return transformedText;
        }
        public string Encode(string message)
        {
            return TransformMessage(message, key);
        }
        public string Decode(string message)
        {
            return TransformMessage(message, -key);
        }
    }
}
