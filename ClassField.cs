using System;
using System.Text;
using System.Collections.Generic;


namespace Patterns.Builder
{
   
    class ClassField
    {
        public string Name,Type;
        public List<ClassField> Fields = new List<ClassField>();
        private const int indentSize = 2;

        public ClassField()
        {
            
        }

        public ClassField(string name,string type)
        {
            this.Name = name;
            this.Type = type;
        }
        private string ClassToString(int indent)
        {
            var sb = new StringBuilder();

            string i = new string(' ',indentSize*indent);
            if(string.IsNullOrWhiteSpace(Type))
            { 
            sb.AppendLine($"{i}public class {Name}");
            }

            sb.AppendLine($"{i}"+'{');
             foreach (var f in Fields)
            {
                sb.Append(new string(' ',indentSize*(indent+1)));
                sb.AppendLine($"public {f.Type} {f.Name};");
                
            }
                sb.AppendLine($"{i}"+'}');               
                return sb.ToString();
        }

        public override string ToString()
        {
            return ClassToString(0);
        }

    }
}