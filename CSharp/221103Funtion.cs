using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class _221103Funtion
    {
        /*
        delegate void Calculator(int x);

        static void Add(int x)
        {
            Console.WriteLine("Add함수 {0}: ", x); //{} 안에 x값이 들어갑니다.
        }

        static void Div(int x)
        {
            Console.WriteLine("Div함수 {0}: ", x);
        }

        static void Mul(int x)
        {
            Console.WriteLine("Mul함수 {0}: ", x);
        }

        static void Minus(int x, int y)
        {
            Console.WriteLine("Minus함수 {0}, {1}: ", x, y);
        }
        */

        //static void Main(string[] args)
        //{
        #region Boxong, Unboxing
        /*
        //박싱(Boxing)
        //값 형식의 변수가 object타입으로 변환되는 과정입니다.
        //int, float, char, struct(구조체)
        //참조 타입: enum, class, object

        //object 타입의 변수는 어떠한 값이라도 할당 가능합니다.
        int value = 10;

        object obj1 = value; //박싱

        int temp = (int)obj1; //언박싱

        Console.WriteLine("obj1: " + obj1.ToString());

        //언박싱(UnBoxing)
        //object타입의 변수가 값 형식으로 변환되는 과정입니다.


        ArrayList arrayList = new ArrayList();
        arrayList.Add(30); //박싱

        int num = (int)arrayList[0]; //언박싱

        //단순히 스택에 값을 넣는 것보다 언박싱을 통해서 스택에 값을 넣으면 4배 정도의 시간이 소요됩니다.
        */
        #endregion
        
        #region Deligate
        //델리게이트(대리자)
        //델리게이트 목록에 실행할 함수들을 등록한 다음 이 델리게이트에 등록된 함수들을 연쇄적으로 대신 실행시켜주는 기능입니다.
        //ex) TCP/UDT 소켓에 서버 통신할 때 패킷을 보낼 떄 많이 사용됩니다.

        /*
        //델리게이트 선언
        Calculator calculator;

        int value = 100;

        calculator = Add; //델리게이트에 함수를 등록하면 그 함수들의 포인터들(주소값)이 저장됩니다/ 

        calculator(value); //델리게이트로 호출 (체인 연결 전)

        //함수의 호출 : Add()
        //함수의 주소 : Div
        calculator += Div; //델리게이트 체인을 구현합니다.

        calculator(value); //델리게이트로 호출 (체인 연결 후)

        calculator -= Div;
        calculator(value);

        //calculator += Minus; 델리게이트와 매개변수의 갯수가 다르기 때문에 등록할 수 없습니다.
        //델리게이트가 실행될 때 등록된 함수들을 전부 실행합니다.
        //이때 등록된 주소들을 참조하여 함수들을 차례로 실헹시킵니다.
        */
        #endregion
        //}
    }
}
