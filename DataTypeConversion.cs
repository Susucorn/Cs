/* Park Suyeon
* <자료형 변환>
* 설명 : 
*       --> 큰 자료형에서 작은 자료형으로 변환? 데이터 깨질 수 있음
*               ex) 작은 그릇에 큰 내용물을 넣으면 넘쳐흐름
*               
* <자동 자료형 변환>
* 설명 : 자동 변환되는 자료형
* 
* [기존 자료형]  [자동 변환 되는 자료형]
* int           long, float, double
* long          float, double
* char          int, long, float, double
* float         double
*/
internal class DataTypeConversion
{
    private static void Main(string[] args)
    {
        // 1. long 자료형 --> int 자료형으로 변환
        long longNum = 2147483647L + 2147483647L;
        Console.WriteLine("longNum : " + longNum);
        int intNum = (int)longNum;
        Console.WriteLine("int 자료형으로 변환 : " + intNum);      // 데이터 손실 발생
        Console.WriteLine(intNum.GetType());

        Console.WriteLine();

        // 2. long 자료형 --> int 자료형으로 변환
        long longNum1 = 52273;
        Console.WriteLine("longNum1 : " + longNum1);
        int intNum1 = (int)longNum1;
        Console.WriteLine("int 자료형으로 변환 : " + intNum1);      // 데이터 손실 미발생
        Console.WriteLine(intNum1.GetType());

        Console.WriteLine();

        // 자동 자료형 변환 --> 작은 내용물을 큰 그릇에 담을 경우, 자동 자료형 변환 발생
        int num = 2147483647;

        long intToLong = num;   // int 자료형 -> long 자료형으로 자동 변환
        Console.WriteLine("num의 값 : " + intToLong);
        Console.WriteLine("자료형 : " + intToLong.GetType());

        Console.WriteLine();

        double intToDouble = num;   // int 자료형 -> double 자료형으로 자동 변환
        Console.WriteLine("intToDouble : " + intToDouble);
        Console.WriteLine("자료형 : " + intToDouble.GetType());
    }
}