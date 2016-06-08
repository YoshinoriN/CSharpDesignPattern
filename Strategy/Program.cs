namespace Strategy
{
    public class Program
    {
        static void Main(string[] args)
        {
            var dynamics = System.Console.ReadLine();

            Piano _piano = new Piano();
            //ピアノを演奏します。
            _piano.Play(dynamics);

            System.Console.ReadLine();
        }
    }
}
