using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace workflow
{
    public interface IStrategy
    {
        //  Each operation gets a number as input and return number as output 
        float DoOperation(float input);
    }
}
