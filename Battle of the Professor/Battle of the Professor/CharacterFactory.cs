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
    class PlayerFactory : ICharacterFactory
    {
        public PlayerFactory()
        {
            int health = 0;
            int sanity = 0;
            int intellect = 0;
        }

        public void CreateCharacter()
        {
            // TODO: Create a player.
        }
    }

    class ProfessorFactory : ICharacterFactory
    {
        public ProfessorFactory()
        {
            int health = 0;
            int sanity = 0;
            int intellect = 0;
        }

        public void CreateCharacter()
        {
            // TODO: Create a professor.
        }
    }
}
