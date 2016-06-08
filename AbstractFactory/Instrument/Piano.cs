namespace SimpleFactory.Instrument
{
    /// <summary>
    /// ピアノクラス
    /// </summary>
    public class Piano : IInstrument
    {
        public bool CanPortable()
        {
            return false;
        }

        public string Play()
        {
            return("ポロローン");
        }
    }
}
