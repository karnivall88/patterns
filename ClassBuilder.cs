using System;
using System.Collections.Generic;


namespace Patterns.Builder
{
    public class ClassBuilder
    {
        ClassField cl = new ClassField();
        string className;

        public ClassBuilder(string className)
        {
            this.className = className;
            cl.Name = className;
        }
        public ClassBuilder AddField(string name, string type)
        {
            var f = new ClassField(name,type);
            cl.Fields.Add(f);
            return this;

        }
        public override string ToString()
        {
            return cl.ToString();
        }

    }
}