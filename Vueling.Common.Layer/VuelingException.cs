using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vueling.Common.Layer
{
    public class VuelingException : Exception // VuelingException hereda de Exception
    {
        public VuelingException()
        {
        }

        public VuelingException(string message)
            : base(message)
        {
        }

        public VuelingException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
