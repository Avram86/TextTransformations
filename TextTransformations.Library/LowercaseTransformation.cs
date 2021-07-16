using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextTransformations.Library
{
    public class LowercaseTransformation : Transformation
    {
        public override string Transform(string text)
        {
            if (text is null)
            {
                throw new ArgumentNullException(nameof(text));
            }

            return text.ToLowerInvariant();
        }
    }
}
