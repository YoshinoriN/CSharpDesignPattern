namespace SimpleFactory
{
    /// <summary>
    /// 楽器のインターフェースです。
    /// </summary>
    public interface IInstrument
    {
        /// <summary>
        /// 持ち運び可能かどうか。
        /// </summary>
        bool CanPortable();

        /// <summary>
        /// 楽器を鳴らします。
        /// </summary>
        string Play();
    }
}
