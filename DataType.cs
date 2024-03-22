/* Park Suyeon
* <기본 자료형>
* 설명 : 정수, 실수, 문자, 문자열, 불
*/
internal class DataType
{
    private static void Main(string[] args)
    {
        // 정수
        int x = 10, y = 6, c = x + y;

        Console.WriteLine("x + y = " + (x + y));
        Console.WriteLine("x + y = " + c);

        Console.WriteLine("\n");
        Console.WriteLine(" -- 정수의 연산 -- ");
        Console.WriteLine(x + " + " + y + " = " + (x + y));
        Console.WriteLine(x + " - " + y + " = " + (x - y));
        Console.WriteLine(x + " * " + y + " = " + (x * y));
        Console.WriteLine(x + " / " + y + " = " + (x / y)); // ** C#은 정수/정수 계산 결과가 정수로 나옴
        Console.WriteLine(x + " % " + y + " = " + (x % y));

        Console.WriteLine();

        // --> 나머지 연산자의 부호는 왼쪽 피연산자의 부호를 따름
        Console.WriteLine(" -- 음수와 나머지 연산자 -- ");
        Console.WriteLine("4 % 3 = " + (4 % 3));
        Console.WriteLine("-4 % 3 = " + (-4 % 3));
        Console.WriteLine("4 % -3 = " + (4 % -3));
        Console.WriteLine("-4 % -3 = " + (-4 % -3));

        Console.WriteLine();

        // 실수
        Console.WriteLine(" -- 실수의 연산 -- ");
        Console.WriteLine("1.0 + 2.0 = " + (1.0 + 2.0));    // 결과가 정수
        Console.WriteLine("1.0 - 2.0 = " + (1.0 - 2.0));    // 결과가 정수
        Console.WriteLine("1.0 * 2.0 = " + (1.0 * 2.0));    // 결과가 정수
        Console.WriteLine("1.0 / 2.0 = " + (1.0 / 2.0));    // 결과가 실수
        Console.WriteLine("1.0 % 2.0 = " + (1.0 % 2.0));    // 실수는 나머지 연산 하지 않기, 결과 예측 어려움

        Console.WriteLine();

        // 문자
        char a = 'a', A = 'A';
        Console.WriteLine("-- 문자 출력 --");
        Console.WriteLine(a);
        Console.WriteLine(A);
        Console.WriteLine("'a' + 'A --> " + ('a'+'A'));     // 문자 + 문자는 덧셈 연산 수행함
        Console.WriteLine();

        // 문자열
        String s1 = "안녕하세요", s2 = "Hello World!";
        Console.WriteLine("-- 문자열 출력 --");
        Console.WriteLine(s1);
        Console.WriteLine(s2);
        Console.WriteLine(s1 + s2);
        Console.WriteLine("가나다" + "라마바" + "사아차카타파하");

        Console.WriteLine();    

        Console.WriteLine("-- 이스케이프 문자 -- ");    
        Console.WriteLine("good\t\t morning\t!");
        Console.WriteLine("\"\'\\");

        Console.WriteLine();

        Console.WriteLine("-- 인덱스로 문자 선택하기 -- ");
        Console.WriteLine("안녕하세요"[0]);
        Console.WriteLine("안녕하세요"[1]);
        Console.WriteLine("안녕하세요"[2]);
        // --> 문자열이 5개인데 100번째 글자 출력하라하면? 런타임 에러
    }
}