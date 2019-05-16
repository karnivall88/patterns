using System;
using Patterns.Builder;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
           var htmlTree = new HtmlBuilder("ul");
           htmlTree.AddChild("li","Text").AddChild("li","Hello").AddChild("li","World");
           System.Console.WriteLine(htmlTree.ToString());

           var pers = Person.New.Called("Lol").WorksAs("Test").Build();
           System.Console.WriteLine(pers);
        }
    }
}
