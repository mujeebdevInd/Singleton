using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Singleton
{
    public sealed class Singleton
    {
        private static Singleton instance = null;
        public int id { get;private set; }
        private Singleton()
        {
        }
        private static readonly object padlock = new object();
        public static Singleton GetInstance(int id)
        {
            if (instance == null)
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                        instance.id = id;
                    }
                    return instance;
                }

            }
            return instance;

        }
        public void Method()
        {
            //logic..
        }



    }
}