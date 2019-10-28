using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    public static class UniqueId
    {
        private static int id;
        public static int GetId()
        {
            return ++id;
        }
    }
}
