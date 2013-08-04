using System;
using System.Collections.Generic;
using System.Linq;

namespace Detetive
{
    public class Witness
    {
        private Dictionary<string, int> dctAnswer = new Dictionary<string,int>();

        //Initialize the witness with the solution
        public Witness(int _culptit, int _place, int _gun)
        {
            dctAnswer.Add(Constants.KEY_SUSPECT, _culptit);
            dctAnswer.Add(Constants.KEY_PLACE, _place);
            dctAnswer.Add(Constants.KEY_GUN, _gun);
        }

        public int nextTip(Dictionary<string, int> _hint)
        {
            List<int> possibleTips = new List<int>();

            //If the hint isn't right, it can be a possible tip
            if(!_hint[Constants.KEY_SUSPECT].Equals(dctAnswer[Constants.KEY_SUSPECT]))
                possibleTips.Add(1);
            if(!_hint[Constants.KEY_PLACE].Equals(dctAnswer[Constants.KEY_PLACE]))
                possibleTips.Add(2);
            if(!_hint[Constants.KEY_GUN].Equals(dctAnswer[Constants.KEY_GUN]))
                possibleTips.Add(3);

            //If there is no tip, the hint is the correct answer
            if(possibleTips.Count == 0)
                return 0;
            else
            {
                //Returns randomically one of the possible tips
                Random rnd = new Random();
                return possibleTips[rnd.Next(possibleTips.Count)];
            }


        }
    }
}