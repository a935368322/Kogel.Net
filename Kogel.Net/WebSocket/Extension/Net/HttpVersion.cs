using System;

namespace Kogel.Net.WebSocket.Extension.Net
{
    /// <summary>
    /// �ṩ HTTP �汾��
    /// </summary>
    public class HttpVersion
    {
        /// <summary>
        /// Provides a <see cref="Version"/> instance for the HTTP/1.0.
        /// </summary>
        public static readonly Version Version10 = new Version(1, 0);

        /// <summary>
        /// Provides a <see cref="Version"/> instance for the HTTP/1.1.
        /// </summary>
        public static readonly Version Version11 = new Version(1, 1);
    }
}
