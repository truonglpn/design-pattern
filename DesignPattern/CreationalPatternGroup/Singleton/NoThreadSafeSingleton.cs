using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Singleton
{
    class NoThreadSafeSingleton
    {
        private static NoThreadSafeSingleton instance = null;
        public static NoThreadSafeSingleton Instance
        {
            get
            {
                if (instance == null)
                    instance = new NoThreadSafeSingleton();
                return instance;
            }
        }
        private NoThreadSafeSingleton() { }

    }
}
