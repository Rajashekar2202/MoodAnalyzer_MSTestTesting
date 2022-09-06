using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodAnalyser
    {
        public string message = "I am in Sad Mood";
        private string testmessage = "";
       
        public MoodAnalyser()
        {

        }
        public MoodAnalyser(string msg)
        {
            this.testmessage = msg;
        }

        public string AnalyseMood()
        {
            if (this.testmessage == message)
            {
                return "SAD";
            }
            else
            {
                return "Happy";
            }
        }
    }
}
