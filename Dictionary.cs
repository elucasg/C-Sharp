// A dictionary is a collection of unique keys and a collection of values, where each key is associated with one value
using System;
using System.Collections.Generic;

public class DictionaryExample 
{
  static void Main()
  {
    Dictionary<string, string> domains = new Dictionary<string, string>();

    domains.Add("de", "Germany");
    domains.Add("sk", "Slovakia");
    domains.Add("us", "United States");
    domains.Add("ru", "Russia");
    domains.Add("hu", "Hungary");
    domains.Add("pl", "Poland");

    Console.WriteLine(domains["sk"]);
    Console.WriteLine(domains["de"]);

    Console.WriteLine("Dictionary has {0} items", domains.Count);

    Console.WriteLine("Keys of the dictionary:");

    List<string> keys = new List<string>(domains.Keys);
    foreach(string key in keys)
    {
        Console.WriteLine("{0}", key);
    }        

    Console.WriteLine("Values of the dictionary:");

    List<string> vals = new List<string>(domains.Values);
    foreach(string val in vals)
    {
        Console.WriteLine("{0}", val);
    }

    Console.WriteLine("Keys and values of the dictionary:");

    foreach(KeyValuePair<string, string> kvp in domains)
    {
        Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
    }
  }
}
