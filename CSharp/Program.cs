using System;
using System.Text;

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
    internal class Program
    {
        static void Main(string[] args)
        {
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

            A classA = new A();

            classA.value = 50;
            classA.Attack();

            A  classB = new A();

            classB.value = 70;
            classB.Attack();
        }
    }
}