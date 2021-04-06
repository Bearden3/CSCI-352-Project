/*
 * Author: Jordan Taylor
 * Date: 03 / 26 / 2021
 * Description: Creates a player and professor using ICharacterFactory.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_of_the_Professor
{
    enum Characters { PROFESSOR, STUDENT };

    class CharacterCheck
    {
        Characters character;
        ICharacterFactory factory;

        // stat values for Player. The underscores '_' are in place to help distinguish a difference from the arguments.
        int _health = 0;
        int _sanity = 0;
        int _intellect = 0;

        public CharacterCheck(Characters c)
        {
            character = c;
        }

        public void CharacterAssign(int health, int sanity, int intellect) // These arguments will help update the values through main.
        {
            _health = health;
            _sanity = sanity;
            _intellect = intellect;

            switch (character)
            {
                case Characters.PROFESSOR:
                    factory = new ();
                    break;
                case Characters.STUDENT:
                    factory = new HTCFactory();
                    break;
            }
        }
    }
}