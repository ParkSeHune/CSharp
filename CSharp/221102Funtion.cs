using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Parent
{
    public int money = 1000;
}

public class Child : Parent
{
    public string name = "자식";

    public void Run()
    {
        Console.WriteLine("열심히 달립니다.");
    }
}

public class A
{
    public int value = 100;

    public void Attack()
    {
        Console.WriteLine("공격이 감지되었습니다.");
    }
}

namespace CSharp
{
    internal class _221102Funtion
    {

        #region ref, out키워드 함수
        static void Calculator(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        static void Funtion(out int x)
        {
            //out키워드를 사용할 때는 함수 내부에서 매개변수의 값을 정의해 주어야 합니다.
            x = 1000;
        }
        #endregion

        //가변적 매개변수
        static int Sum(params int[] list)
        {
            int result = 0;

            for (int i = 0; i < list.Length; i++)
            {
                result += list[i];
            }

            return result;
        }

        //선택적 매개변수는 우측부터 정의해 주어야 합니다.
        static void Attack(int physics, int magic, int x = 0)
        {
            Console.WriteLine("Physics의 값: " + physics);
            Console.WriteLine("Magic의 값: " + magic);
            Console.WriteLine("X의 값: " + x);
        }

        //
        static void Profile(int age, string name)
        {
            Console.Write("age: " + age);
            Console.Write("name: " + name);
        }
        
        //static void Main(string[] args)
        //{
            //입력과 출력
            //C: printf("Hello World!");
            //c++: std:: << "Hello World!";
            //c#: Console.WriteLine("Hello World!");

            #region MemoryType
            /*
            //값 타입: 스캑 영역에 데이터를 할당하는 메모리
            {
                int value1 = 10;
                float value2 = 20.0f;

                Console.WriteLine(value1);
                Console.WriteLine(value2);
            }

            // 참조 타입: 힙 영역에 데이터를 할당하는 메모리
            A classA = new A();

            string name = "ParkSeHune";
            string name1 = name;

            name = "Park";
            name1 = "ParkSeHune11";
            */
            #endregion

            #region StringBuilder
            /*
            //stringBuilder
            //변경할 수 없는 string과 다르게 변경이 가능한 문자열을 나타내는 클래스 입니다.
            //string 객체는 값이 변경되면 메모리에서 이전 참조값을 버리고 새로운 참조 값으로 변경합니다.
            //stringBuilder 객체는 값이 변경되어도 힙 메모리 값이 삽입 및 제거됩니다.

            StringBuilder stringBuilder = new StringBuilder();

            //stringBuilder 객체 생성 및 초기화
            StringBuilder stringBuilder1 = new StringBuilder("SeHune");

            //stringBuilder는 문자 공간을 동적으로 확장시켜 줍니다.
            //stringBuilder 객체의 용량은 10 이고 최대 용량은 50입니다.
            StringBuilder stringBuilder2 = new StringBuilder(10, 50);

            Console.WriteLine("Append 하기 전: " + stringBuilder1);

            //Apend()
            //전달한 문자열을 stringBuilder 객체의 말미에 추가합니다.
            stringBuilder1.Append("1234");

            Console.WriteLine("Append 한 후: " + stringBuilder1);
            */
            #endregion

            #region Class
            /*
            A classA = new A();

            classA.value = 50;
            classA.Attack();

            A  classB = new A();

            classB.value = 70;
            classB.Attack();
            */
            #endregion

            #region refKeyword
            //인수를 참조로 전잘하기 위해 사용하는 키워드입니다.
            //ref함수 외부 -> 함수 내부로

            /*
            int a = 10;
            int b = 20;

            Calculator(a, b);
            */
            #endregion

            #region outKeyword
            /*
            int value;
            Funtion(out value);

            Console.WriteLine("value의 값: " + value);
            */
            #endregion

            #region 메소드의 오버로드
            //같은 이름의 함수를 여러개 정의하는 기능
            //Calculator(int x, int y);
            //Claculator(float x, float y);

            //정수를 x와 y에 넣으면 위 Calculator
            //실수를 x와 y에 넣으면 아래 Calculator

            //ref키워드랑 out키워드는 동시에 사용할 수 없습니다.
            //Calculator(out int x); (x)
            //Calculator(ref int x); (x)

            //ref키워드랑 out키워드는 런타임에는 다르게 작동하지만, 컴파일 단계에서는 두개의 키워드가 동일하게 동작합니다.

            //CRL은 ref와 out에 대한 IL을 생성하는 동안 두개(ref, out)을 구분하지 못하기 때문에 메소드의 오버로딩을 구현할 수 없습니다.
            #endregion

            #region Up, Down Casting
            /*
            //UpCasting
            // 암묵적으로 자식 클래스가 부모클래스로 형 변환되는 과정입니다.
            Parent parentPtr = new Child();
            parentPtr.money = 10000;

            //DownCasting
            //자식 클래스로 부모클래스를 강제적으로 형 변화시키는 과정
            Child childPtr = (Child)parentPtr;
            childPtr.Run();
            childPtr.name = "불효자식";
            childPtr.money = 100;
            */
            #endregion

            #region 가변길이 매개변수
            /*
            //가변적으로 매개변수를 설절할 수 있는 매개변수입니다.
            Console.WriteLine(Sum(10, 20, 30));
            Console.WriteLine(Sum(10, 20));
            Console.WriteLine(Sum(10, 20, 4, 5));
            */
            #endregion

            #region 선택적 매개변수
            /*
            //선택적 매개변수는 기본겂을 지정하게 되면 인수를 전달하지 않아도 기본값이 들어가기 떄문에 괜찮습니다.
            Attack(10, 20);
            Attack(10, 20, 30);
            */
            #endregion

            #region 명명된 매개변수
            /*
            //매개변수와 형식 매개변수의 위치를 바꾸어서 설정하는 매개변수 입니다.
            Profile(name: "박세훈", age: 19);
            */
            #endregion
        //}
    }
}
