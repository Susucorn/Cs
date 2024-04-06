/* Park Suyeon
* <if else 조건문>
* 설명 : 확실한 비교 조건
*       --> 버튼을 눌렸다 / 버튼을 눌리지 않았다
*           밥을 먹었다 / 밥을 먹지 않았다
*           짝수  / 홀수
*           오전  / 오후
*/
internal class If_else
{
    private static void Main(string[] args)
    {
        // (1) 짝수, 홀수 구분하기

        // 정수 입력받기
        Console.Write("숫자 입력 : ");
        int num = int.Parse(Console.ReadLine());

        // 조건 --> 짝수인가?
        if (num % 2 == 0)
        {
            Console.WriteLine("짝수 입니다.");
        }

        // 그렇지 않다면 ... (나머지는)
        else
        {
            Console.WriteLine("홀수 입니다.");
        }

        Console.WriteLine();

        // (2) 현재 시간 구하는 프로그램

        // 현재 Hour 출력 --> DateTime.Now.Hour
        Console.WriteLine("현재 Hour 출력 : " + DateTime.Now.Hour);

        // 조건 --> 오전인가?
        if (DateTime.Now.Hour < 12)
        {
            Console.WriteLine("오전 입니다.");
        }

        // 그렇지 않다면 ... (나머지는)
        else
        {
            Console.WriteLine("오후 입니다.");
        }

    }
}