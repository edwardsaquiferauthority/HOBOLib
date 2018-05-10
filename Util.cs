using System.IO;

namespace HoboLib
{
    public static class Util
    {
        /// <summary>
        /// Generates a stream containing string data
        /// </summary>
        /// <param name="val">The text to put in the stream</param>
        /// <returns>A Stream object</returns>
        public static Stream GetStreamFromString(string val)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(val);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }
    }
}
