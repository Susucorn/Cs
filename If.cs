/* Park Suyeon
* <if 조건문>
* 설명 : true면 문장 실행, false면 문장 무시
*/
internal class If
{
    private static void Main(string[] args)
    {
        // (1) 홀수인지 짝수인지 구분하는 프로그램

        // 정수 입력받기
        Console.Write("숫자 입력 : ");
        int num = int.Parse(Console.ReadLine());

        // 조건 1 --> 짝수인가?
        if (num % 2 == 0)
        {
            Console.WriteLine($"입력하신 {num}은 짝수입니다.");
        }

        // 조건 2 --> 홀수인가?
        if (num % 2 != 0)
        {
            Console.WriteLine($"입력하신 {num}은 홀수입니다.");
        }

        Console.WriteLine();

        // (2) 양수인지 음수인지 0인지 구분하는 프로그램

        // 정수 입력받기
        Console.Write("숫자 입력 : ");
        int num1 = int.Parse(Console.ReadLine());

        // 조건 1 --> 양수인가?
        if (num1 > 0)
        {
            Console.WriteLine($"입력하신 {num1}은 양수입니다.");
        }

        // 조건 2 --> 음수인가?
        if (num1 < 0)
        {
            Console.WriteLine($"입력하신 {num1}은 음수입니다.");
        }

        // 조건 3 --> 0 인가?
        if (num1 == 0)
        {
            Console.WriteLine($"입력하신 {num1}은 0 입니다.");
        }

        Console.WriteLine();

        // (3) 현재 시간 구하는 프로그램

        // 현재 Hour 출력 --> DateTime.Now.Hour
        Console.WriteLine("현재 Hour 출력 : " + DateTime.Now.Hour);

        // 조건 1 --> 오전인가?
        if (DateTime.Now.Hour < 12)
        {
            Console.WriteLine("오전 입니다.");
        }

        // 조건 2 --> 오후인가?
        if (DateTime.Now.Hour >= 12)
        {
            Console.WriteLine("오후 입니다.");
        }

    }
}