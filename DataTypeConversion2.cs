/* Park Suyeon
* <자료형 변환>
* 설명 : 간단하게 문자열로 변환하기
*/
internal class DataTypeConversion2
{
    private static void Main(string[] args)
    {
        // 숫자와 빈 문자열을 더하면? --> 간단한 문자열 변환
        int num = 13345;
        String output = num + "";
        Console.WriteLine(output);
        Console.WriteLine("output 타입 : "+ output.GetType());

        /*
        char character = 'a';
        String output2 = character;

        --> ** 문자를 문자열로 변환이 불가능
        */
    }
}