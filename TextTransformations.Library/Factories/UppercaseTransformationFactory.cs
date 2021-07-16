using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextTransformations.Library.Factories
{
    public class UppercaseTransformationFactory : ITransformationTypeFactory
    {
        public Transformation CreateTransformationType()
        {
            return new UppercaseTransformation();
        }
    }
}
