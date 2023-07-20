using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFoodCost.Exceptions 
{
    [Serializable]
    internal class ValueNotAvailable : Exception, IUseEx
    {
        public string DefaultMessage => $"Некорректное значение. '{ParamName}'";
        public string ParamName { get; }

        public ValueNotAvailable(string paramName)
        {
            ParamName = paramName;
        }
    }
}
