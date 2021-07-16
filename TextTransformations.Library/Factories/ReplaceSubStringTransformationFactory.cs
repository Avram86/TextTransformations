using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextTransformations.Library.Factories
{
    public class ReplaceSubStringTransformationFactory : ITransformationTypeFactory
    {
        private readonly string _stringToReplaceWith;
        private readonly string _stringToBeReplaced;

        public ReplaceSubStringTransformationFactory(string stringToReplaceWith, string stringToBeReplaced)
        {
            _stringToReplaceWith = stringToReplaceWith ?? throw new ArgumentNullException(nameof(stringToReplaceWith));
            _stringToBeReplaced = stringToBeReplaced ?? throw new ArgumentNullException(nameof(stringToBeReplaced));
        }
        public Transformation CreateTransformationType()
        {
            return new ReplaceSubStringTransformation(_stringToReplaceWith, _stringToBeReplaced);
        }
    }
}
