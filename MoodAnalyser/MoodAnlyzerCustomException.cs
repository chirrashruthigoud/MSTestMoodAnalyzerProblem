using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnlyzerCustomException:Exception
    {
         public enum EnumMethod
         {
           NULL_MOOD,
           EMPTY_MOOD
                
         }
        public EnumMethod enumobj;
        public MoodAnlyzerCustomException(EnumMethod enumobject,string message):base(message)
        {
         this.enumobj = enumobject;
            
        }
    }
}
