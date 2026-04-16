using System.Text;

namespace Anagram.Application
{
    public class AnagramChecker
    {
        public string ReverseWords(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new ArgumentNullException(nameof(text));
            }
            
            string[] words = text.Split(" ");

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = ReverseWord(words[i]);
            }
            
            return string.Join(" ", words);
        }
        
        private bool CheckLetter(char letter)
        {
            if (char.IsLetter(letter) || char.IsWhiteSpace(letter)) {
                return true;
            }
            
            return false;
        }
        
        public string ReverseWord(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                throw new ArgumentNullException(nameof(word));
            }
            
            char[] chars = word.ToCharArray();
            int left = 0;
            int right = chars.Length - 1;

            while (left < right)
            {
                if (!CheckLetter(chars[left]))
                {
                    left++;
                }
                else if (!CheckLetter(chars[right]))
                {
                    right--;
                }
                else
                {
                    char temp = chars[left];
                    chars[left] = chars[right];
                    chars[right] = temp;
            
                    left++;
                    right--;
                }
            }

            return new string(chars);
        }
    }
}