# Strings

In computer programming a string is traditionally a sequence of characters terminated by a null character '\0'. Note that the null character is not the same as a null pointer, although both appear to have the value 0 when used in integer contexts.

A string is generally considered a data type and is often implemented as an array data structure of bytes that store a sequence of elements.

In our implementation of the string data structure we will use two approaches: an array of characters and a linked list of characters. The difference between the two implementations lies in the mutability of data structure representation. Using arrays of characters make it difficult to increase/modify the length of a string; this difficulty is not present when using a linked list representation. On the other hand, accessing a specific character within the string is a very fast operation on arrays, not so much on linked lists. 

