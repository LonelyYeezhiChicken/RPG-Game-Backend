using GameModels.Characters;
using GameModels.Characters.Models.enums;
using Newtonsoft.Json;
using NUnit.Framework;
using System;

namespace GameTests.Characters
{
    [TestFixture]
    class CharacterTest
    {
        [Test]
        public void 角色數據()
        {
            Character character = new Character(OccupationEnum.Mage);
            Console.WriteLine("法師 : ");
            Console.WriteLine(JsonConvert.SerializeObject(character.Create()));

            character = new Character(OccupationEnum.Warrior);
            Console.WriteLine("戰士 : ");
            Console.WriteLine(JsonConvert.SerializeObject(character.Create()));

             character = new Character(OccupationEnum.Tank);
            Console.WriteLine("坦克 : ");
            Console.WriteLine(JsonConvert.SerializeObject(character.Create()));
        }
    }
}
