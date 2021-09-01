using System;
using System.Security.Principal;

namespace Kogel.Net.WebSocket.Extension.Net
{
    /// <summary>
    /// �������� HTTP ���������֤���Ե��û���������
    /// </summary>
    public class HttpBasicIdentity : GenericIdentity
    {
        private string _password;
        internal HttpBasicIdentity(string username, string password) : base(username, "Basic")
        {
            _password = password;
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual string Password
        {
            get
            {
                return _password;
            }
        }
    }
}
