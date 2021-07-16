using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextTransformations.Library.Factories
{
    public interface ITransformationTypeFactory
    {
        public abstract Transformation CreateTransformationType();
        //public Transformation GetTransformationTypeFactory()
        //{
        //    var transformation = CreateTransformationType();
        //    return transformation;
        //}
    }
}
