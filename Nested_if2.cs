/* Park Suyeon
* <중첩 if문>
* 설명 : 10진수 세 자리를 입력받아 각 자리의 숫자들이 짝수인지 홀수인지 판단하는 프로그램 작성하기
*/
internal class Nested_if2
{
    private static void Main(string[] args)
    {
        // 3자리 수 입력받기
        Console.Write("3자리 정수 입력 : ");
        int num = int.Parse(Console.ReadLine());

        // 100의 자리, 10의 자리, 1의 자리 구분
        int num_100 = num / 100;
        int num_10 = (num % 100) / 10;
        int num_1 = num % 10;

        // 조건 --> 입력받은 수가 세자리 수 인가?
        if (num >= 100 && num <= 999)
        {
            // 100의 자리 수
            if (num_100 % 2 == 0) 
            { 
                Console.WriteLine("100의 자리 수는 짝수 입니다.");
            }
            else
            {
                Console.WriteLine("100의 자리 수는 홀수 입니다.");
            }

            // 10의 자리 수
            if (num_10 % 2 == 0)
            {
                Console.WriteLine("10의 자리 수는 짝수 입니다.");
            }
            else
            {
                Console.WriteLine("10의 자리 수는 홀수 입니다.");
            }

            // 1의 자리 수
            if (num_1 % 2 == 0)
            {
                Console.WriteLine("1의 자리 수는 짝수 입니다.");
            }
            else
            {
                Console.WriteLine("1의 자리 수는 홀수 입니다.");
            }
        }

        // 그렇지 않으면... (세 자리 수가 아니면)
        else
        {
            Console.WriteLine("입력하신 숫자는 세 자리 수가 아닙니다.");
        }
    }
}