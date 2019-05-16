using System;
using System.Collections.Generic;


namespace Patterns.Builder
{
    public abstract class PersonBuilder
    {
        protected Person  person = new Person(); 
        public Person Build()
        {
            return person;
        }
    }
   public class PersonInfoBuilder<T>:PersonBuilder where T :PersonInfoBuilder<T>
    {
      
      public T Called (string name)
      {
          person.Name = name;
          return  (T)this;
      }
    }

   public class personJobBuilder<T> : PersonInfoBuilder<personJobBuilder<T>> where T: personJobBuilder<T>
    {
        public T WorksAs(string position)
        {
            person.Position = position;
            return (T)this;
        }
    }
}