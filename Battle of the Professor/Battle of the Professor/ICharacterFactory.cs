/*
 * Author: Jordan Taylor
 * Date: 03 / 26 / 2021
 * Description: Allows CharacterFactory to create characters.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_of_the_Professor
{
    interface ICharacterFactory
    {
        void CreateCharacter();
    }
}
