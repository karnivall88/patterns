using System;

namespace Patterns.Builder
{
    class HtmlBuilder
    {
       HtmlElement root = new HtmlElement();
       string rootName;

       public HtmlBuilder(string rootName)
       {
           this.rootName = rootName;
           root.Name = rootName;
       }

       public HtmlBuilder AddChild(string childName, string childText)
       {
           var e = new HtmlElement(childName,childText);
           root.Elements.Add(e);
           return this;

       }

       public override string ToString()
       {
           return root.ToString();
       }
       public void Clear()
       {
           root = new HtmlElement{Name = rootName};
       }
    }
}