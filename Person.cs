using System;
using System.Collections.Generic;


namespace Patterns.Builder
{
    public class Person
    {
        public string Name;
        public string Position;
    public class Builder : personJobBuilder<Builder>
    {

    }
    public static Builder New => new Builder();
    public override string ToString()
    {
        return $"{nameof(Name)}: {Name}, {nameof(Position)}: {Position}";
    }
    }
}