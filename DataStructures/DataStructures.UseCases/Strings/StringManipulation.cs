using System;
using DataStructures.Core.Strings;

namespace DataStructures.UseCases.Strings
{
    public class StringManipulation
    {
        #region Chapter 1.1

        public static bool HasAllUniqueCharacters(IString value)
        {
            try
            {
                // Validate passed in value is not null
                if (value != null)
                {
                    // Keep a list of seen characters
                    var seenCharacters = new List<char>();
                    // Loop through string characters once
                    foreach (var character in value.ToCharArray())
                    {
                        if (seenCharacters.Contains(character) == false)
                        {
                            seenCharacters.Add(character);
                        }
                        else
                        {
                            // We've seen this character before so return false
                            return false;
                        }
                    }

                    // All characters in value are unique
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return false;
        }

        public static bool HasAllUniqueCharacters_Linq(IString value)
        {
            try
            {
                // Validate passed in value is not empty
                if (value != null)
                {
                    // Group characters, select first, and compare length of original string
                    return value.ToCharArray().GroupBy(x => x).Select(x => x.First()).Count() == value.Length;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return false;
        }

        public static bool HasAllUniqueCharacters_ASCII(IString value)
        {
            try
            {
                // Validate passed in value is not empty
                if (value != null)
                {
                    // There are only 128 characters in the ASCII alphabet
                    var seen = new bool[128];
                    for (int i = 0; i < value.Length; i++)
                    {
                        // Each index in the ASCII alphabet corresponds to a character
                        if (!seen[value[i]])
                        {
                            seen[value[i]] = true;
                        }
                        else
                        {
                            // We have seen this ASCII character so return false
                            return false;
                        }
                    }

                    // Did not see duplicate ASCII character
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return false;
        }

        #endregion

        #region Chapter 1.2

        /*
         * In mathematics, a permutation of a set is an arrangement of its members into a sequence or linear order, or if the set is already ordered, a rearrangement of its elements. 
         * {1,2,3} => {1,2,3}, {1,3,2}, {2,1,3}, {2,3,1}, {3,1,2}, and {3,2,1}
         */
        public static bool CheckPermutation(string a, string b)
        {
            try
            {
                // Check values are not null, empty strings allowed
                if (a != null && b != null)
                {
                    // Sets of different lengths cannot be permutations of each other
                    if (a.Length == b.Length)
                    {
                        // List of characters in A
                        var charactersA = new bool[128];
                        // List of characters in B
                        var charactersB = new bool[128];

                        // Set indices of characters seen in A
                        for (int i = 0; i < a.Length; i++)
                        {
                            charactersA[a[i]] = true;
                        }

                        // Set indices of characters seen in B
                        for (int i = 0; i < b.Length; i++)
                        {
                            charactersB[b[i]] = true;
                        }

                        // Make sure all elements match
                        for (int i = 0; i < 128; i++)
                        {
                            if (charactersA[i] != charactersB[i])
                            {
                                return false;
                            }
                        }

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return false;
        }

        public static bool CheckPermutation_HashSet(string str1, string str2)
        {
            try
            {
                // If lengths are different, they can't be permutations
                if (str1.Length != str2.Length)
                {
                    return false;
                }

                // Use a dictionary to count the frequency of characters in str1
                var charCount = new Dictionary<char, int>();

                // Count characters in str1
                foreach (var c in str1)
                {
                    if (charCount.ContainsKey(c))
                    {
                        charCount[c]++;
                    }
                    else
                    {
                        charCount[c] = 1;
                    }
                }

                // Decrease the count based on characters in str2
                foreach (var c in str2)
                {
                    if (charCount.ContainsKey(c))
                    {
                        charCount[c]--;
                    }
                    else
                    {
                        // If str2 contains a character not in str1, return false
                        return false;
                    }
                }

                // If all counts are zero, then the strings are permutations
                foreach (var count in charCount.Values)
                {
                    if (count != 0)
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return true;
        }

        /// <summary>
        /// To determine if one string is a permutation of another, you need to check if both strings have exactly the same characters, with the same frequency, but possibly in a different order.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool CheckPermutation_Linq(string a, string b)
        {
            try
            {
                if (a != null && b != null)
                {
                    if (a.Length == b.Length)
                    {
                        return a.OrderBy(x => x).SequenceEqual(b.OrderBy(y => y));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return false;
        }

        #endregion

        #region Chapter 1.3

        #endregion
    }
}