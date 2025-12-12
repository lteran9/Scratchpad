using System;
using System.Text;
using DataStructures.Core.Strings;

namespace DataStructures.UseCases.Strings
{
    public class StringCompression : IUseCase<string>
    {
        private readonly string _str;

        public StringCompression(string str)
        {
            _str = str;
        }

        public string Execute()
        {
            if (!string.IsNullOrEmpty(_str))
            {
                // Count the number of times we see a character
                var dictionary = new Dictionary<char, int>();
                // Loop through the string once
                for (int i = 0; i < _str.Length; i++)
                {
                    if (dictionary.ContainsKey(_str[i]))
                    {
                        dictionary[_str[i]]++;
                    }
                    else
                    {
                        dictionary.Add(_str[i], 1);
                    }
                }

                // Create a new compressed string
                var compressed = new StringBuilder();
                foreach (var key in dictionary.Keys)
                {
                    var numberOfTimesSeen = dictionary[key];
                    compressed.Append($"{key}{numberOfTimesSeen}");
                }

                return compressed.ToString();
            }

            return string.Empty;
        }
    }
}