namespace Strategy.Dynamics
{
    /// <summary>
    /// インターフェースの実装クラス。
    /// フォルテのときの演奏を実装します。
    /// </summary>
    public class Forte : IPlay
    {
        public void Play()
        {
            System.Console.WriteLine("ジャーン！");
        }
    }
}
