namespace SimpleFactory.Instrument
{
    /// <summary>
    /// フルートクラス
    /// </summary>
    public class Flute : IInstrument
    {
        public bool CanPortable()
        {
            return true;
        }

        public string Play()
        {
            return ("ピーピー");
        }
    }
}
