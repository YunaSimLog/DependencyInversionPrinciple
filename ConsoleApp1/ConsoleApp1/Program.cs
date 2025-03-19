using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // * 홍길동 캐릭터 생성 - 무기는 검
            Character character = new Character("홍길동", new Sword());
            character.Attack();

            // * 김철수 캐리거 생성 - 무기는 총
            character = new Character("김철수", new Gun());
            character.Attack();

            // * 이영희 캐릭터 생성 - 무기는 화살    
            character = new Character("이영희", new Arrow());
            character.Attack();
        }
    }
}
