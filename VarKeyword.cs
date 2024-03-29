/* Park Suyeon
* <기본 자료형>
* 설명 : var 키워드
*   --> 변수의 자료형을 자동으로 지정함 (초기화 할 때 지정한 자료형으로 지정됨)
*   --> 한 번 지정하면 다른 자료형으로 바꿀 수 없음 (강제 자료형 변환이 필요)
*   --> var 키워드를 사용하려면
*       1. 지역 변수로 선언해야 한다   --> 메서드 외부에 선언하면 오류 발생 !
*       2. 변수를 선언과 동시에 초기화 해야 한다
*/
internal class VarKeyword
{
    private static void Main(string[] args)
    {
        var num1 = 100;
        var num2 = 1.23F;
        var num3 = 1.23456789;
        var ch = '가';
        var str = "가나다";

        Console.WriteLine(num1.GetType());
        Console.WriteLine(num2.GetType());
        Console.WriteLine(num3.GetType());
        Console.WriteLine(ch.GetType());
        Console.WriteLine(str.GetType());

        Console.WriteLine();

        // 강제 자료형 변환
        var num_1 = (double)num1;
        var num_2 = (double)num2;
        var num_3 = (float)num3;

        Console.WriteLine("num_1의 자료형 : " + num_1.GetType());
        Console.WriteLine("num_2의 자료형 : " + num_2.GetType());
        Console.WriteLine("num_3의 자료형 : " + num_3.GetType());

    }
}