namespace Strategy.Dynamics
{
    /// <summary>
    /// インターフェースの実装クラス。
    /// フォルティシモのときの演奏を実装します。
    /// </summary>
    public class Fortessimo : IPlay
    {
        public void Play()
        {
            System.Console.WriteLine("ジャジャーン！");
        }
    }
}
