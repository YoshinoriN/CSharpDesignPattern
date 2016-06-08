namespace Strategy.Dynamics
{
    /// <summary>
    /// インターフェースの実装クラス。
    /// ピアニッシモのときの演奏を実装します。
    /// </summary>
    public class Pianissimo : IPlay
    {
        public void Play()
        {
            System.Console.WriteLine("チャーン....");
        }
    }
}
