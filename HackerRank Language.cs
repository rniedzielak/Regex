using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
class Solution
{
    static void Main(String[] args)
    {
        int q = Convert.ToInt32(Console.ReadLine());
        string one= "C:CPP:JAVA:PYTHON:PERL:PHP:RUBY:CSHARP:HASKELL:CLOJURE:BASH:SCALA:ERLANG:CLISP:LUA:BRAINFUCK:JAVASCRIPT:GO:D:OCAML:R:PASCAL:SBCL:DART:GROOVY:OBJECTIVEC";
        string two= one.Replace(":", "|");
        string regex = @"^[1-9]\d{4}\s" + "(" + two + ")$";
        Regex rx = new Regex(regex);
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
