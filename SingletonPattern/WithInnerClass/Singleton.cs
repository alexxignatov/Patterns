using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.WithInnerClass
{
    public sealed class Singleton
    {
        private Singleton() { }

        public static Singleton Instance { get { return InstanceHolder.instance; } }

        protected class InstanceHolder
        {
            static InstanceHolder() { }

            internal readonly static Singleton instance = new Singleton();
        }
    }
}
