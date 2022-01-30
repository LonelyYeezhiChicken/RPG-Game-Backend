using GameModels.Characters.Interfaces;
using GameModels.Characters.Models;
using GameModels.Characters.Skills;
using Newtonsoft.Json;
using NUnit.Framework;
using System;

namespace GameTests.Characters.Skills
{
    [TestFixture]
    class SkillTest
    {
        private ISkill Skill = new StrAttack();

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
        public void StrAttackTest_確認屬性()
        {
            Console.WriteLine($"Id : {Skill.GetId}");
            Console.WriteLine($"Name : {Skill.GetName}");
            Console.WriteLine($"CD : {Skill.GetCD}");
            Console.WriteLine($"說明 : {Skill.GetDescription}");
        }

        [Test]
        public void StrAttackTest_打擊對方_正常扣血()
        {
            //我方
            AbilityDto userAbility = GetAbilityDto();
            //敵方
            AbilityDto othertAbility = GetAbilityDto();

            //結果
            AbilityDto outAbility = GetAbilityDto();
            outAbility.Health = 1850;

            var actual = Skill.UsingSkill(othertAbility, userAbility);
            var expected = outAbility;

            Assert.AreEqual(JsonConvert.SerializeObject(expected), JsonConvert.SerializeObject(actual));
        }

      
    }
}
