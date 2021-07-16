using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextTransformations.Library
{
    public class RemoveAllInstancesOfSubStringTransformation : Transformation
    {
        private readonly string _subStringSearched;

        public RemoveAllInstancesOfSubStringTransformation(string subStringSearched)
        {
            _subStringSearched = subStringSearched ?? throw new ArgumentNullException(nameof(subStringSearched));
        }
        public override string Transform(string text)
        {
            if (text is null)
            {
                throw new ArgumentNullException(nameof(text));
            }

            if (text.Contains(_subStringSearched))
            {
                
                while (text.Contains(_subStringSearched))
                {
                    int index = text.IndexOf(_subStringSearched);
                    text = text.Remove(index, _subStringSearched.Length);
                }
            }

            return text;
        }
    }
}
