using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    //where T : struct
    //T는 null을 허용하지 않는 값 형식으로만 받을 수 있도록 설정해주는 기능입니다.

    //where T : class
    //T는 참조 형식만 받을 수 있도록 설정해주는 기능입니다.

    //where T : base class name(클래스 이름)
    //T는 지정된 기본 클래스거나 이 클래스에서 파생된 클래스이어야 합니다.
    class GenericClass<T> where T : GameObject
    {
        private T data;

        public T Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }
    }

    public class GameObject
    {
        public float x;
        public float y;
        public float z;
    }

    public class Sphere : GameObject
    {
        public int meshRenderer;
        public int color;
    }

    public class Light
    {
        public int brightness;
    }

    internal class _221104Funtion
    {
        delegate int DelFuntion(int x, int y);

        //일반 한수
        static void Funtion(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        //static void Main(string[] args)
        //{
            #region 무명 형식
            /*
            //형식의 선언과 동시에 인스턴스를 할당하는 형식입니다.
            //인스턴스를 만들고 다시 사용하지 않을 때 유용합니다.
            //무명 형식의 프로퍼티에 할당된 값은 변경이 불가능합니다. (R-Value) (읽기 전용)

            var temp = new { Age = 19, Name = "Park" };

            int value = 20;
            //int value: (L-Value) 메모리 주소를 가지고 있는 변수
            // 20: (R-Value) 한번 연산이 이루어지고 더 이상 참조할 수 없는 임시 변수

            Console.WriteLine("Age: {0}, Name: (1)" + temp.Age, temp.Name);
            */
            #endregion

            #region 무명 메서드
            /*
            //일회성으로서 단순한 명령어 구문으로 구성된 메서드를 정의하지 않고, 델리게이트를 이용하여 일회용 메서드를 정의하는 메서드입니다.

            //델리게이트 선언
            DelFuntion swap;

            //무명 메소드를 참조합니다.
            //임시적으로 사용하고 끝나는 함수입니다.
            swap = delegate (int x, int y)
                   {
                       int temp = x;
                       x = y;
                       y = temp;

                       return y;
                   };

            Console.WriteLine(swap(10, 20));
            */
            #endregion

            #region 비교연산자
            /*
            int x = 5;
            int y = 15;

            //t = 참 = 1
            bool t = x < y;

            //f = 거짓 = 0
            bool f = x == y;

            //1 이면 실행
            if (t)
            {
                Console.WriteLine("참");
            }
            */
            #endregion

            #region where
            /*
            //class - 참조 타입이 아닌 값 타입은 제약을 겁니다.
            GenericClass<int> intData = new GenericClass<int>();
            intData.Data = 100;

            Console.WriteLine(intData.Data);

            //struct - 값 타입이 아닌 참조 타입은 제약을 겁니다.
            GenericClass<string> stringData = new GenericClass<string>();
            stringData.Data = "stringData";

            Console.WriteLine(stringData.Data);
            */
            /*
            GenericClass<GameObject> gameObject = new GenericClass<GameObject>();
            GenericClass<Sphere> sphere = new GenericClass<Sphere>();

            //GameObject를 상속받지 않아서 오류 발생
            GenericClass<Light> light = new GenericClass<Light>();

            sphere.Data.color = 100;
            sphere.Data.meshRenderer = 90;

            Console.WriteLine(sphere.Data.color);
            Console.WriteLine(sphere.Data.meshRenderer);
            */
            #endregion
        //}
    }
}
