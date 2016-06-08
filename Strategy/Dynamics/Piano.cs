namespace Strategy.Dynamics
{
    /// <summary>
    /// インターフェースの実装クラス。
    /// ピアノのとき（楽器のピアノじゃなくて強弱のピアノ）の演奏を実装します。
    /// </summary>
    public class Piano : IPlay
    {
        public void Play()
        {
            System.Console.WriteLine("ポロローン....");
        }
    }
}
