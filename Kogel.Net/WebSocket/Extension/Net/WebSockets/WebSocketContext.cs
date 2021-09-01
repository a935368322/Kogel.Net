using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Principal;

namespace Kogel.Net.WebSocket.Extension.Net.WebSockets
{
    /// <summary>
    /// �� WebSocket ���������й�������Ϣ�ķ���
    /// </summary>
    public abstract class WebSocketContext
    {
        /// <summary>
        /// 
        /// </summary>
        protected WebSocketContext()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public abstract CookieCollection CookieCollection { get; }

        /// <summary>
        /// 
        /// </summary>
        public abstract NameValueCollection Headers { get; }

        /// <summary>
        /// 
        /// </summary>
        public abstract string Host { get; }

        /// <summary>
        /// 
        /// </summary>
        public abstract bool IsAuthenticated { get; }

        /// <summary>
        /// 
        /// </summary>
        public abstract bool IsLocal { get; }

        /// <summary>
        /// ��ȡһ��ֵ����ֵָʾ�Ƿ�ʹ�ð�ȫ������������������
        /// </summary>
        public abstract bool IsSecureConnection { get; }

        /// <summary>
        /// 
        /// </summary>
        public abstract bool IsWebSocketRequest { get; }

        /// <summary>
        /// 
        /// </summary>
        public abstract string Origin { get; }

        /// <summary>
        /// 
        /// </summary>
        public abstract NameValueCollection QueryString { get; }

        /// <summary>
        /// 
        /// </summary>
        public abstract Uri RequestUri { get; }

        /// <summary>
        /// 
        /// </summary>
        public abstract string SecWebSocketKey { get; }

        /// <summary>
        /// 
        /// </summary>
        public abstract IEnumerable<string> SecWebSocketProtocols { get; }

        /// <summary>
        /// 
        /// </summary>
        public abstract string SecWebSocketVersion { get; }

        /// <summary>
        /// 
        /// </summary>
        public abstract System.Net.IPEndPoint ServerEndPoint { get; }

        /// <summary>
        /// 
        /// </summary>
        public abstract IPrincipal User { get; }

        /// <summary>
        /// 
        /// </summary>
        public abstract System.Net.IPEndPoint UserEndPoint { get; }

        /// <summary>
        /// 
        /// </summary>
        public abstract WebSocket WebSocket { get; }
    }
}
