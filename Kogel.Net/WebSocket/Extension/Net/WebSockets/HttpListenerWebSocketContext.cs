using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Security.Principal;

namespace Kogel.Net.WebSocket.Extension.Net.WebSockets
{
    /// <summary>
    /// �ṩ�� <see cref="HttpListener"/> ʵ���� WebSocket ���������е���Ϣ�ķ���
    /// </summary>
    public class HttpListenerWebSocketContext : WebSocketContext
    {
        private HttpListenerContext _context;
        private WebSocket _websocket;

        internal HttpListenerWebSocketContext(HttpListenerContext context, string protocol)
        {
            _context = context;
            _websocket = new WebSocket(this, protocol);
        }

        internal Stream Stream
        {
            get
            {
                return _context.Connection.Stream;
            }
        }

        /// <summary>
        /// ��ȡ���������а����� HTTP cookie
        /// </summary>
        public override CookieCollection CookieCollection
        {
            get
            {
                return _context.Request.Cookies;
            }
        }

        /// <summary>
        /// ��ȡ���������а����� HTTP ��ͷ
        /// </summary>
        public override NameValueCollection Headers
        {
            get
            {
                return _context.Request.Headers;
            }
        }

        /// <summary>
        /// ��ȡ���������а����� Host ��ͷ��ֵ
        /// </summary>
        public override string Host
        {
            get
            {
                return _context.Request.UserHostName;
            }
        }

        /// <summary>
        /// ��ȡָʾ�ͻ����Ƿ�ͨ�������֤��ֵ
        /// </summary>
        public override bool IsAuthenticated
        {
            get
            {
                return _context.Request.IsAuthenticated;
            }
        }

        /// <summary>
        /// ��ȡһ��ֵ����ֵָʾ���������Ƿ�ӱ��ؼ��������
        /// </summary>
        public override bool IsLocal
        {
            get
            {
                return _context.Request.IsLocal;
            }
        }

        /// <summary>
        /// ��ȡһ��ֵ����ֵָʾ�Ƿ�ʹ�ð�ȫ������������������
        /// </summary>
        public override bool IsSecureConnection
        {
            get
            {
                return _context.Request.IsSecureConnection;
            }
        }

        /// <summary>
        /// ��ȡһ��ֵ����ֵָʾ�������Ƿ�Ϊ WebSocket ��������
        /// </summary>
        public override bool IsWebSocketRequest
        {
            get
            {
                return _context.Request.IsWebSocketRequest;
            }
        }

        /// <summary>
        /// ��ȡ���������а����� Origin ��ͷ��ֵ
        /// </summary>
        public override string Origin
        {
            get
            {
                return _context.Request.Headers["Origin"];
            }
        }

        /// <summary>
        /// ��ȡ���������а����Ĳ�ѯ�ַ���
        /// </summary>
        public override NameValueCollection QueryString
        {
            get
            {
                return _context.Request.QueryString;
            }
        }

        /// <summary>
        /// ��ȡ�ͻ��������URI
        /// </summary>
        public override Uri RequestUri
        {
            get
            {
                return _context.Request.Url;
            }
        }

        /// <summary>
        /// ��ȡ���������а����� Sec-WebSocket-Key ͷ��ֵ
        /// </summary>
        public override string SecWebSocketKey
        {
            get
            {
                return _context.Request.Headers["Sec-WebSocket-Key"];
            }
        }

        /// <summary>
        /// �����������а����� Sec-WebSocket-Protocol ��ͷ�л�ȡ��Э�������
        /// </summary>
        public override IEnumerable<string> SecWebSocketProtocols
        {
            get
            {
                var val = _context.Request.Headers["Sec-WebSocket-Protocol"];
                if (val == null || val.Length == 0)
                    yield break;

                foreach (var elm in val.Split(','))
                {
                    var protocol = elm.Trim();
                    if (protocol.Length == 0)
                        continue;

                    yield return protocol;
                }
            }
        }

        /// <summary>
        /// ��ȡ���������а����� Sec-WebSocket-Version ͷ��ֵ
        /// </summary>
        public override string SecWebSocketVersion
        {
            get
            {
                return _context.Request.Headers["Sec-WebSocket-Version"];
            }
        }

        /// <summary>
        /// ��ȡ���������͵��Ķ˵�
        /// </summary>
        public override System.Net.IPEndPoint ServerEndPoint
        {
            get
            {
                return _context.Request.LocalEndPoint;
            }
        }

        /// <summary>
        /// ��ȡ�ͻ�����Ϣ
        /// </summary>
        public override IPrincipal User
        {
            get
            {
                return _context.User;
            }
        }

        /// <summary>
        /// ��ȡ������������Ķ˵�
        /// </summary>
        public override System.Net.IPEndPoint UserEndPoint
        {
            get
            {
                return _context.Request.RemoteEndPoint;
            }
        }

        /// <summary>
        /// ��ȡ���ڿͻ��˺ͷ�����֮��˫��ͨ�ŵ� WebSocket ʵ��
        /// </summary>
        public override WebSocket WebSocket
        {
            get
            {
                return _websocket;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        internal void Close()
        {
            _context.Connection.Close(true);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="code"></param>
        internal void Close(HttpStatusCode code)
        {
            _context.Response.StatusCode = (int)code;
            _context.Response.Close();
        }

        /// <summary>
        /// ���ش���ǰʵ�����ַ���
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return _context.Request.ToString();
        }
    }
}
