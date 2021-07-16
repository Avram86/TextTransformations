using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextTransformations.Library.Factories;

namespace TextTransformations.Library
{
    public static class Application
    {
        private static string _text;
        private static TypesOfTransformation _typeOfTransformation;

        public static void InitializeApplication(string text, TypesOfTransformation typeOfTransformation)
        {
            _text = text ?? throw new ArgumentNullException(nameof(text)) ;
            _typeOfTransformation = typeOfTransformation;
        }
        public static string ApplyTransformation( TypesOfTransformation typeOfTransformation, int position = 0, string textToBeInserted = null, string textToBeRemoved=null, string  textToReplaceWith=null)
        {
            ITransformationTypeFactory factory;

            switch (typeOfTransformation)
            {
                case TypesOfTransformation.None:
                case TypesOfTransformation.UpperCase:
                    factory = new UppercaseTransformationFactory();
                    return  ReturnResultedText(factory);

                case TypesOfTransformation.LowerCase:
                    factory = new LowercaseTransformationFactory();
                    return ReturnResultedText(factory);

                case TypesOfTransformation.InsertSubStringAtCertainPosition:
                    factory = new InsertSubStringAtCertainPositionTransformationFactory(position, textToBeInserted);
                    return ReturnResultedText(factory);

                case TypesOfTransformation.ReplacesubStringWithAnother:
                    factory = new ReplaceSubStringTransformationFactory(textToReplaceWith, textToBeRemoved);
                    return ReturnResultedText(factory);

                case TypesOfTransformation.RemoveAllInstancesOfSubString:
                    factory = new RemoveAllInstancesOfSubStringTransformationFactory(textToBeRemoved);
                    return ReturnResultedText(factory);
            }

            return _text;
        }

        private static string ReturnResultedText(ITransformationTypeFactory factory)
        {
            Transformation transformation = factory.CreateTransformationType();
            string result = transformation.Transform(_text);
            return result;
        }
    }
}
