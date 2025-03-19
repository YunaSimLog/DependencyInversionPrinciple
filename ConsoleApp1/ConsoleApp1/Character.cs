using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // * 캐릭터 클래스
    public class Character
    {
        #region attribute
        // ----------------------------------------------------------------------------------------------------------------
        // * 캐릭터 이름
        string _name;
        // * 무기
        IWeapon _weapon;
        // ----------------------------------------------------------------------------------------------------------------
        #endregion

        #region private
        #endregion

        #region public

        /// <summary>
        /// 캐릭터 생성자
        /// </summary>
        /// <param name="name">캐릭터 이름 설정</param>
        /// <param name="weapon">캐릭터 무기 설정</param>
        public Character(string name, IWeapon weapon)
        {
            this._name = name;
            this._weapon = weapon;
        }

        /// <summary>
        /// 공격 메소드
        /// </summary>
        public void Attack()
        {
            Console.WriteLine($"{this._name} 공격");
            this._weapon.Attack();
        }
        #endregion
    }
}
