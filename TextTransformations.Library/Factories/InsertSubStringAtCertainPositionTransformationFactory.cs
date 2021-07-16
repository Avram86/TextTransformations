using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextTransformations.Library.Factories
{
    public class InsertSubStringAtCertainPositionTransformationFactory : ITransformationTypeFactory
    {
        private readonly int _position;
        private readonly string _subStringToBeInserted;

        public InsertSubStringAtCertainPositionTransformationFactory(int position, string subStringToBeInserted)
        {
            _position = position;
            _subStringToBeInserted = subStringToBeInserted;
        }
        public Transformation CreateTransformationType()
        {
            return new InsertSubStringAtCertainPositionTransformation(_position, _subStringToBeInserted);
        }
    }
}
