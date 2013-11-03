using Optimus.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimusApi.Tool.D2P.Map.Elements
{
    public interface IElement
    {
        ElementTypesEnum ElementType { get; }
    }
}
