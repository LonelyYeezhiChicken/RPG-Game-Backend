using GameModels.Characters;
using GameModels.Characters.Models;
using GameModels.Characters.Models.enums;
using GameModels.Characters.Skills;
using Newtonsoft.Json;
using NUnit.Framework;
using System;

namespace GameTests.Characters
{
    [TestFixture]
    class CharacterTest
    {
        public AbilityDto GetAbilityDto()
        {
            AbilityDto abilityDto = new AbilityDto();
            abilityDto.Level = 1;
            abilityDto.Health = 2000;
            abilityDto.Magic = 1000;
            abilityDto.ActionPoint = 50;
            abilityDto.Strength = 100;
            abilityDto.Intelligence = 50;
            abilityDto.Accuracy = 50;
            abilityDto.Luck = 50;
            abilityDto.Agility = 50;
            abilityDto.Attack = 50;
            abilityDto.Mattack = 50;
            return abilityDto;
        }

        [Test]
        public void 角色數據()
        {
            Character character = new Character(OccupationEnum.Mage, new StrAttack());
            Console.WriteLine("法師 : ");
            Console.WriteLine(JsonConvert.SerializeObject(character.Create()));

            character = new Character(OccupationEnum.Warrior, new StrAttack());
            Console.WriteLine("戰士 : ");
            Console.WriteLine(JsonConvert.SerializeObject(character.Create()));

            character = new Character(OccupationEnum.Tank, new StrAttack());
            Console.WriteLine("坦克 : ");
            Console.WriteLine(JsonConvert.SerializeObject(character.Create()));
        }

        [Test]
        public void 攻擊()
        {
            Character character = new Character(OccupationEnum.Mage, new StrAttack());
            //我方
            AbilityDto userAbility = GetAbilityDto();
            //敵方
            AbilityDto othertAbility = GetAbilityDto();
            try
            {
                AbilityDto ability = character.SkillAttack(othertAbility, ref userAbility);
                Console.WriteLine("對手能力");
                Console.WriteLine(JsonConvert.SerializeObject(ability));
                Console.WriteLine("自身能力");
                Console.WriteLine(JsonConvert.SerializeObject(userAbility));
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(10)]
        [TestCase(20)]
        public void 升等(int LV)
        {
            Character character = new Character(OccupationEnum.Mage, new StrAttack());            
            Console.WriteLine(character.GetExperiencePoint(LV));
        }
    }
}
