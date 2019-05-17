using System;
using Patterns.Builder;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
          var cb = new ClassBuilder("Person").AddField("Name","string").AddField("Age","int");
          System.Console.WriteLine(cb);
        }
    }
}
