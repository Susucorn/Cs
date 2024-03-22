/* Park Suyeon
* <변수>
* 설명 : 변수를 만듦 -> 변수를 선언한다,  변수에 값을 넣음 -> 변수에 값을 할당한다
*/
internal class Veriable
{
    private static void Main(string[] args)
    {
        // 정수형
        int a = 245, b = 52;
        Console.WriteLine(a+b);
        Console.WriteLine(a-b);
        Console.WriteLine(a*b);
        Console.WriteLine(a/b);
        Console.WriteLine(a%b);
        Console.WriteLine();

        // 최대값과 최소값 확인하기 --> MaxValue, MinValue
        Console.WriteLine("int형 최대값 : " + int.MaxValue);
        Console.WriteLine("int형 최소값 : " + int.MinValue);
        Console.WriteLine("long형 최대값 : " + long.MaxValue);
        Console.WriteLine("long형 최소값 : " + long.MinValue);
        Console.WriteLine();

        // 오버플로우? --> 범위를 벗어나면 발생
        int c = 2147483647, d = 1;
        int e = -2147483648, f = -1;
        Console.WriteLine(c + d);
        Console.WriteLine(e + f);
        Console.WriteLine();

        // unsigned 자료형 --> 부호가 없는 자료형(음수X)
        uint uInt = 4147483647;
        ulong uLong = 11223372036854775808;
        Console.WriteLine("unsigned int : " + uInt);
        Console.WriteLine("unsigned Long : " + uLong);
        Console.WriteLine();

        // 실수형
        double g = 52.273, h = 103.32;
        Console.WriteLine(g + h);
        Console.WriteLine(g - h);
        Console.WriteLine(g * h);
        Console.WriteLine(g / h);
        Console.WriteLine();

        // 문자형
        char ch = 'a';
        Console.WriteLine(ch);
        Console.WriteLine();

        char ch1 = 'a', ch2 = 'b';
        Console.WriteLine("-- 문자 자료형의 연산 -- ");
        Console.WriteLine("'a + 'b' = " + (ch1 + ch2));
        Console.WriteLine("'a - 'b' = " + (ch1 - ch2));
        Console.WriteLine("'a * 'b' = " + (ch1 * ch2));
        Console.WriteLine("'a / 'b' = " + (ch1 / ch2));
        Console.WriteLine("'a % 'b' = " + (ch1 % ch2));
        Console.WriteLine();

        // sizeof 연산자로 자료형의 크기 출력하기
        Console.WriteLine("int 자료형의 크기 --> " + sizeof(int));
        Console.WriteLine("long 자료형의 크기 --> " + sizeof(long));
        Console.WriteLine("float 자료형의 크기 --> " + sizeof(float));
        Console.WriteLine("double 자료형의 크기 --> " + sizeof(double));
        Console.WriteLine("char 자료형의 크기 --> " + sizeof(char));
        Console.WriteLine();

        // 문자열 자료형 (문자열을 나타내는 String은 클래스이므로 sizeof 연산자 사용 불가)
        String str = "반갑습니다!";
        Console.WriteLine(str);
        Console.WriteLine(str[5]);
        Console.WriteLine(str[3]);
        Console.WriteLine(str[0]);
        Console.WriteLine();

        // 불형
        bool one = 10 < 0, two = 23 > 4;
        Console.WriteLine(one);
        Console.WriteLine(two);
    }
}