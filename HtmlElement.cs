using System;
using System.Text;
using System.Collections.Generic;


namespace Patterns.Builder
{
   
    class HtmlElement
    {
       public string Name,Text;
       public List<HtmlElement> Elements = new List<HtmlElement>();
       private const int indentSize = 2;
       public HtmlElement()
       {
        
       }
       public HtmlElement(string name, string text)
       {
           Name = name;
           Text = text;
       }

       private string ToStringImpl(int indent)
       {
           var sb = new StringBuilder();
           var i = new string(' ',indentSize*indent);
           sb.AppendLine($"{i}<{Name}>");
           
           if(!string.IsNullOrWhiteSpace(Text))
           {
               sb.Append(new string(' ',indentSize*(indent+1)));
               sb.AppendLine(Text);
           }

           foreach (var e in Elements)
           {
               sb.AppendLine(e.ToStringImpl(indent+1));
           }

           sb.Append($"{i}</{Name}>");

           return sb.ToString();
          
       }

       public override string ToString()
       {
           return ToStringImpl(0);
       }

    }
}
