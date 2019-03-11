using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
class Solution {
    static void Main(String[] args) {
        int q = Convert.ToInt32(Console.ReadLine());
        Regex rx = new Regex(@"^[a-z]{0,3}\d{2,8}[A-Z]{3,}");
        for (int qItr = 0; qItr < q; qItr++)
        {
            string test = Console.ReadLine();
            if(rx.IsMatch(test))
            {
                Console.WriteLine("VALID");
            }
            else
            {
                Console.WriteLine("INVALID");
            }
        }
    }       
}
