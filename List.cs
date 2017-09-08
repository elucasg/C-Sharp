// A List is a strongly typed list of objects that can be accessed by index
using System;
using System.Collections.Generic;

public class ListExample 
{
  static void Main()
  {
    List<string> langs = new List<string>();

    langs.Add("Java");
    langs.Add("C#");
    langs.Add("C");
    langs.Add("C++");
    langs.Add("Ruby");
    langs.Add("Javascript");

    // Check if the List contains a specific string
    Console.WriteLine(langs.Contains("C#"));

    // Access the elements of the List using the index. The position is zero-based
    Console.WriteLine(langs[1]); // Returns C#
    
    // IndexOf returns the first index of the specified parameter, or -1 if not found
    int pos = langs.IndexOf("C"); // returns 2
   

    // Remove elements from the List
    langs.Remove("C#");
    langs.Remove("C");

    // Insert element at a specific location.
    langs.Insert(4, "Haskell");

    // Sort the elements
    langs.Sort();

    foreach(string lang in langs)
    {
      Console.WriteLine(lang);
    }     
  }
}
