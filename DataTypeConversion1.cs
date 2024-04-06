/* Park Suyeon
* <자료형 변환>
* 설명 : 정수형 변환, 연산 결과 출력
*/
internal class DataTypeConversion1
{
    private static void Main(string[] args)
    {
        // 문자열로 입력 받은 후
        Console.WriteLine("정수 두 개를 입력 : ");
        string stringNum1 = Console.ReadLine();
        string stringNum2 = Console.ReadLine();

        // int 변환하기
        int num1 = int.Parse(stringNum1);
        int num2 = int.Parse(stringNum2);

        // 출력하기
        Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
        Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
        Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));
        Console.WriteLine(num1 + " / " + num2 + " = " + ((float)num1 / num2).ToString("F2"));
        Console.WriteLine(num1 + " % " + num2 + " = " + (num1 % num2));
    }
}