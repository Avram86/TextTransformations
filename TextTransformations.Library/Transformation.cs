using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextTransformations.Library
{
    public abstract class Transformation
    {
        public abstract string Transform(string text); 
    }
}
