using System;

namespace TestSaber.Model
{
    public class BaseModel <T>
    {
        public T Value { get; set; }

        public virtual void Read() { }

        public virtual void Task() { }
    }
}