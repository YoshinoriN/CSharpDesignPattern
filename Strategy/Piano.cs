namespace Strategy
{
    /// <summary>
    /// ピアノクラス（強弱じゃなくて楽器のほうのピアノ）
    /// </summary>
    public class Piano
    {
        private static IPlay _currentPlay;

        /// <summary>
        /// 演奏します。
        /// </summary>
        /// <param name="dynamics">強弱</param>
        public void Play(string dynamics)
        {
            switch (dynamics)
            {
                case "pp":
                    _currentPlay = new Dynamics.Pianissimo();
                    break;
                case "p":
                    _currentPlay = new Dynamics.Piano();
                    break;
                case "f":
                    _currentPlay = new Dynamics.Forte();
                    break;
                case "ff":
                    _currentPlay = new Dynamics.Fortessimo();
                    break;
                default: //他の強弱記号あるけど、めんどくさいので省略
                    break;
            }
            _currentPlay.Play();
        }
    }
}
