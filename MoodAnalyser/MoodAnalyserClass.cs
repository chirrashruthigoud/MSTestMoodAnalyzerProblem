using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static MoodAnalyser.MoodAnlyzerCustomException;

namespace MoodAnalyser
{
    public class MoodAnalyserClass
    {
       string message;
        public MoodAnalyserClass()
        {

        }
        public MoodAnalyserClass(string message)
        { 
            this.message = message; 
        }
        
        public string AnalyzeMood(string message)
        {
            try
            {
                if (message.Contains("Sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            }
            catch 
            {
                return "Happy";
            }

        }
 public string AnalyzeMood()
       {
            try
            {
                if(message.Contains("Sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
                
             }
    }
}
