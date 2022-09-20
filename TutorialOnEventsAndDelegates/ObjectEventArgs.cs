using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialOnEventsAndDelegates
{
    public class ObjectEventArgs<T>
    {
        public ObjectEventArgs(T obj)
        {
            Object = obj;
        }
        public T Object { get; set; }
    }
}
