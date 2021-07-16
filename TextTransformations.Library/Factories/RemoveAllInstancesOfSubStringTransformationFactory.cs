using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextTransformations.Library.Factories
{
    public class RemoveAllInstancesOfSubStringTransformationFactory : ITransformationTypeFactory
    {
        private readonly string _textToBeRemoved;

        public RemoveAllInstancesOfSubStringTransformationFactory(string textToBeRemoved)
        {
            _textToBeRemoved = textToBeRemoved ?? throw new ArgumentNullException(nameof(textToBeRemoved));
        }
        public Transformation CreateTransformationType()
        {
            return new RemoveAllInstancesOfSubStringTransformation(_textToBeRemoved);
        }
    }
}
