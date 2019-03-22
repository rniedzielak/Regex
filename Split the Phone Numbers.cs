using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int q = int.Parse(Console.ReadLine());
        string pattern = @"(-)|( )";
        for(int i = 0; i < q; i++)
        {
            string [] output = Regex.Split(Console.ReadLine(), pattern);
            int counter = 0;
            foreach (string match in output) 
            {
                output[counter] = match;
                counter++;
            }
            Console.WriteLine("CountryCode={0},LocalAreaCode={1},Number={2}", output[0], output[2], output[4]);
        }
        
    }
}
