using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextTransformations.Library
{
    public class ReplaceSubStringTransformation : Transformation
    {
        private readonly string _subStringForReplacement;
        private readonly string _subStringToBeReplaced;

        public ReplaceSubStringTransformation(string subStringForReplacement, string subStringToBeReplaced)
        {
            _subStringForReplacement = subStringForReplacement ?? throw new ArgumentNullException(nameof(subStringForReplacement));
            _subStringToBeReplaced = subStringToBeReplaced ?? throw new ArgumentNullException(nameof(subStringToBeReplaced));
        }
        public override string Transform(string text)
        {
            if (text is null)
            {
                throw new ArgumentNullException(nameof(text));
            } 

            if (text.Contains(_subStringToBeReplaced))
            {
                 return text.Replace(_subStringToBeReplaced.Trim(), _subStringForReplacement);
            }

            Console.WriteLine("The sub-string doe not appear in the original text!");
            return text;
        }
    }
}
