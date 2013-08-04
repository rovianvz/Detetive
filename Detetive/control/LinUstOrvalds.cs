using System;
using System.Collections.Generic;
using System.Linq;

namespace Detetive
{
    public class LinUstOrvalds
    {
        private int intSuspects;
        private int intGuns;
        private int intPlaces;

        private int currentSuspect = 0;
        private int currentGun = 0;
        private int currentPlace = 0;

        public LinUstOrvalds(int _suspects, int _guns, int _places)
        {
            intSuspects = _suspects;
            intGuns = _guns;
            intPlaces = _places;
        }

        public Dictionary<string, int> nextGuess(int clue)
        {
            //The clue can be eliminated as a suspect
            switch (clue) {
                case 1: currentSuspect++;
                        break;
                case 2: currentPlace++;
                        break;
                case 3: currentGun++;
                        break;
            }
            Dictionary <string, int> guess = new Dictionary<string,int>();
            guess.Add(Constants.KEY_SUSPECT, currentSuspect);
            guess.Add(Constants.KEY_PLACE, currentPlace);
            guess.Add(Constants.KEY_GUN, currentGun);

            return guess;
        }


    }
}