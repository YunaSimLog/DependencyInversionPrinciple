using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // * 무기 인터페이스
    public interface IWeapon
    {
        // * 무기 공격 메소드
        void Attack();
    }

    public class Sword : IWeapon
    {
        public void Attack()
        {
            Console.WriteLine("검 공격");
        }
    }

    public class Gun : IWeapon
    {
        public void Attack()
        {
            Console.WriteLine("총 공격");
        }
    }

    public class Arrow : IWeapon
    {
        public void Attack()
        {
            Console.WriteLine("화살 공격");
        }
    }
}
