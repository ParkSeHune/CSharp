using System;
using System.Text;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace CSharp
{
    #region 인터페이스
    /*
    //인터페이스
    //상속받은 글래스는 인터페이스의 함수를 반드시 재정의 해주어야 합니다.
    //인터페이스는 인스턴스를 할 수 없으며 자식 클래스를 통해 인터페이스에 있는 함수를 호출할 수 있습니다.

    //인터페이스는 다중 상속이 가능합니다.

    interface IMouseEnter
    {
        void Enter();
    }

    interface IMouseDrag
    {
        void Enter();
        void Drag();
    }

    //C#은 다중상속을 지원하지 않습니다.
    public class Mouse : IMouseEnter, IMouseDrag
    {
        //명시적 구현
        //private이기 때문에 외부에서 객체를 통해 호출할 수 없습니다.
        void IMouseEnter.Enter()
        {
            Console.WriteLine("IMouseEnter.Enter");
        }

        void IMouseDrag.Enter()
        {
            Console.WriteLine("IMouseDrag.Enter");
        }

        //암묵적 구현
        //public이므로 외부에서 객체를 통해 호출이 가능합니다.]
        public void Drag()
        {
            Console.WriteLine("Drag");
        }
    }
    */
    #endregion

    #region 상수
    /*
    public class ReadOnly
    {
        //readonly는 함수 내부에서 선언할 수 없습니다.
        public readonly int data = 10;

        //readonly상수는 생성자에서 값을 초기화할 수 있습니다.

        public ReadOnly()
        {
            data = 200;
        }
    
    */
    #endregion

    internal class Program
    {
        static void Funtion(in int x)
        {
            //데이터 컨테이너
            //[캐릭터 체력] [캐릭터 공격력]
            //읽기 전용으로 처리할 때 사용합니다.
        }

        static void Main(string[] args)
        {
            #region 인터페이스
            /*
            Mouse mouse = new Mouse();
            mouse.Drag();

            //객체를 인터페이스 타입으로 업캐스팅 하게되면 호출할 수 있습니다.
            //인터페이스는 참조를 할 수 있습니다.

            IMouseDrag drag = new Mouse();
            drag.Enter();
            drag.Drag();

            IMouseEnter enter = new Mouse();
            enter.Enter();
            */
            #endregion

            #region 상수
            /*
            //const : 컴파일 시점에 적용되는 상수
            //const는 변수 선언과 동시에 값을 할당해야 합니다.
            //const는 stack영역에 할당됩니다.
            const int value = 20;
            Console.WriteLine(value);

            //readonly : 런타임 시점에 적용되는 상수
            //readonly는 모든 자료형에 사용할 수 있으며, 생성돠 동시에 초기화할 필요가 없습니다.
            //readonly는 Heap영역에 할당됩니다.

            ReadOnly readOnly = new ReadOnly();
            Console.WriteLine(readOnly.data);
            */
            #endregion

            #region in 키워드
            /*
            //in 키워드: Call by Reference 인수를 전달받습니다.
            //in으로 매개변수를 설정하게 되면 함수내부에서 값을 변경할 수 없습니다.

            int[] array = new int[5];
            array[0] = 10;
            array[1] = 20;
            array[2] = 30;
            array[3] = 40;

            int variable = 20;

            //foreach문은 데이터 컨테이너를 넣어주셔야 합니다.(array)
            //안전하고 복사비용을 절약할 수 있습니다.
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            */
            #endregion
        }
    }
}