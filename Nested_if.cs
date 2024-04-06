/* Park Suyeon
* <중첩 if문>
*/
internal class Nested_if
{
    private static void Main(string[] args)
    {
        // 아침, 점심, 저녁 구분하기
        int nowTime = DateTime.Now.Hour;
        Console.WriteLine($"현재 시각 : {nowTime}시");

        // 조건 --> 아침인가?
        if (nowTime < 11)
        {
            Console.WriteLine("아침 먹을 시간 입니다.");
        }

        // 그렇지 않으면... (나머지는)
        else
        {
            // 나머지 중에서 범위 지정
            if (nowTime < 15)
            {
                Console.WriteLine("점심 먹을 시간 입니다.");
            }

            // 그렇지 않으면... (나머지는)
            else
            {
                Console.WriteLine("저녁 먹을 시간 입니다.");
            }
        }
    }
}