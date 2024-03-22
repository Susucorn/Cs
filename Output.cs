/* Park Suyeon
* <출력>
* 설명 : Console 클래스의 WriteLine() 메소드를 사용하여 콘솔 화면에 출력
*      Console.WriteLine() --> 줄 바꿈 O
*      Console.Write() --> 줄 바꿈 X
*/
internal class Output
{
    private static void Main(string[] args)
    {
        // 줄 바꿈 O
        Console.WriteLine("Hello, World!");

        // 줄 바꿈 X
        Console.Write("Hello, World!");

        // 줄 바꿈 O --> \n
        Console.Write("Hello, World!\n");

        // 줄 바꿈 O --> WriteLine + \n ==> 두 줄 띄움
        Console.WriteLine("Hello, World!\n");

        Console.Write("Hello, World!\n\n\n\n");
    }
}