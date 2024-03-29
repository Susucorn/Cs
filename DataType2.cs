/* Park Suyeon
* <기본 자료형>
* 설명 : 복합 대입 연산자, 증감 연산자, 자료형 검사
*/
internal class DataType2
{
    private static void Main(string[] args)
    {
        // 복합 대입 연산자
        int input = 0;      // 누적의 값을 저장하기 위해 0으로 초기화

        input += 52;    // input = input + 52
        Console.WriteLine("input : " + input);
        input += 273;   // input = 52 + 273
        Console.WriteLine("input : " + input);
        input += 203;   // input = 325 + 203
        Console.WriteLine("input : " + input);

        Console.WriteLine();

        String output = "hello ";
        Console.WriteLine("output : " + output);
        output += "would ";
        Console.WriteLine("output : " + output);
        output += "!";
        Console.WriteLine("output : " + output);

        Console.WriteLine();

        // 증감 연산자
        int num = 10;
        num++;
        Console.WriteLine("num : " + num);
        num--;
        Console.WriteLine("num" + num);

        Console.WriteLine();

        // 증감 연산자의 후위 형태
        int num2 = 10;
        Console.WriteLine("----- 증감 연산자의 후위 형태 -----");
        Console.WriteLine("num2 : " + num2);
        Console.WriteLine("num2++ : " + (num2++));    // num2을 먼저 출력한 후에 1을 더함
        Console.WriteLine("num2-- : " + (num2--));    // 이 줄에서 num2 값이 11, 11을 출력 후 1을 뺌
        Console.WriteLine("현재 num2 : " + (num2));   // 이 줄에서 num2의 값은 10

        Console.WriteLine();

        // 증감 연산자의 전위 형태
        int num3 = 10;
        Console.WriteLine("----- 증감 연산자의 전위 형태 -----");
        Console.WriteLine("num3 : " + num3);
        Console.WriteLine("++num3 : " + (++num3));    // 출력하기 전에 num3의 값에 1을 더함
        Console.WriteLine("--num3 : " + (--num3));    // 이 줄에서 num3 값이 11, 출력하기 전에 1을 뺌
        Console.WriteLine("현재 num3 : " + (num3));   // 이 줄에서 num3의 값은 10

        Console.WriteLine();

        // 자료형 검사 --> GetType()
        int _int = 273;
        long _long = 522731033265;
        float _float = 52.273F;
        double _double = 52.273;
        char _char = '글';
        string _string = "문자열";

        Console.WriteLine(_int.GetType());      // 변수명.GetType()
        Console.WriteLine(_long.GetType());
        Console.WriteLine(_float.GetType());
        Console.WriteLine(_double.GetType());
        Console.WriteLine(_char.GetType());
        Console.WriteLine(_string.GetType());

        Console.WriteLine();

        Console.WriteLine((273).GetType());     // (값).GetType()
        Console.WriteLine((522731033265L).GetType());
        Console.WriteLine((52.273F).GetType());
        Console.WriteLine((52.273).GetType());
        Console.WriteLine(('자').GetType());
        Console.WriteLine(("문자열").GetType());
    }
}