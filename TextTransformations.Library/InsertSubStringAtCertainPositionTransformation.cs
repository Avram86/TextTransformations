using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextTransformations.Library
{
    public class InsertSubStringAtCertainPositionTransformation : Transformation
    {
        private readonly int _position;
        private readonly string _subStringToBeInserted;

        public InsertSubStringAtCertainPositionTransformation(int position, string subStringToBeInserted)
        {
            _position = position ;
            _subStringToBeInserted = subStringToBeInserted ?? throw new ArgumentNullException(nameof(subStringToBeInserted));
        }
        public override string Transform(string text)
        {
            if(text is null)
            {
                throw new ArgumentNullException(nameof(text));
            }

            return text.Insert(_position, _subStringToBeInserted);
        }
    }
}
