using GameModels.Characters.Interfaces;
using GameModels.Characters.Models;
using GameModels.Characters.Types;
using Newtonsoft.Json;
using NUnit.Framework;
using System;

namespace GameTests.Characters
{
    [TestFixture]
    class OccupationTest
    {
        private IOccupation occupation;

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

        /// <summary>
        /// 戰士能力值
        /// 物理攻擊力:1.5倍
        /// Ap:1.5倍
        /// HP:1.5倍
        /// </summary>
        [Test]
        public void WarriorAbilityTest()
        {
            AbilityDto abilityDto = GetAbilityDto();
            occupation = new Warrior();
            AbilityDto ability = GetAbilityDto();
            ability = GetAbilityDto();
            ability.Attack = 50 * 1.5;
            ability.ActionPoint = 50 * 1.5;
            ability.Health = 2000 * 1.5;

            var actual = occupation.Ability(abilityDto);
            var expected = ability;

            Assert.AreEqual(JsonConvert.SerializeObject(expected), JsonConvert.SerializeObject(actual));
        }

        /// <summary>
        /// 法師能力值
        /// HP:0.8倍
        /// MP:1.5倍
        /// 智力:1.5倍
        /// 魔法攻擊:2倍
        /// </summary>
        [Test]
        public void MageAbilityTest()
        {
            occupation = new Mage();
            AbilityDto abilityDto = GetAbilityDto();
            AbilityDto ability = GetAbilityDto();
            ability = GetAbilityDto();
            ability.Mattack = 50 * 2;
            ability.Intelligence = 50 * 1.5;
            ability.Magic = 1000 * 1.5;
            ability.Health = 2000 * 0.8;

            var actual = occupation.Ability(abilityDto);
            var expected = ability;

            Assert.AreEqual(JsonConvert.SerializeObject(expected), JsonConvert.SerializeObject(actual));
        }

        /// <summary>
        /// 坦克能力值
        /// HP:2倍
        /// luck:2倍
        /// 敏捷:0.8倍
        /// 迴避:1.5倍
        /// </summary>
        [Test]
        public void TankAbilityTest()
        {
            occupation = new Tank();
            AbilityDto abilityDto = GetAbilityDto();
            AbilityDto ability = GetAbilityDto();
            ability = GetAbilityDto();
            ability.Accuracy = 50 * 0.8;
            ability.Luck = 50 * 2;
            ability.Health = 2000 * 2;
            ability.Agility = 50 * 1.5;

            var actual = occupation.Ability(abilityDto);
            var expected = ability;

            Assert.AreEqual(JsonConvert.SerializeObject(expected), JsonConvert.SerializeObject(actual));
        }
    }
}
