using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo.BL.Filter
{
    public enum ConditionType
    {
        Equal = 0,         // равно        
        NotEqual,      // не равно        
        Below,         // меньше        
        Above,         // больше
        BelowOrEqual,  // меньше или равно
        AboveOrEqual,  // больше или равно        
        StartsWith,    // начинается с подстроки (для строк)        
        Contains,      // содержит подстроку (для строк)        
        In,			   // находится в списке значений        
        NotIn,		   // не находится в списке значений        
        NotContains, // не содержит подстроку (для строк)	
    }
}
