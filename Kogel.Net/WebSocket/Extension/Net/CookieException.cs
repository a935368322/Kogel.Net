using System;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace Kogel.Net.WebSocket.Extension.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class CookieException : FormatException, ISerializable
    {


        internal CookieException(string message): base(message)
        {
        }

        internal CookieException(string message, Exception innerException): base(message, innerException)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="serializationInfo"></param>
        /// <param name="streamingContext"></param>
        protected CookieException(SerializationInfo serializationInfo, StreamingContext streamingContext)
          : base(serializationInfo, streamingContext)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public CookieException(): base()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="serializationInfo"></param>
        /// <param name="streamingContext"></param>
        [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
        public override void GetObjectData(
          SerializationInfo serializationInfo, StreamingContext streamingContext
        )
        {
            base.GetObjectData(serializationInfo, streamingContext);
        }

        /// <summary>
        /// ʹ�����л���ǰʵ��������������ָ���� <see cref="SerializationInfo"/> ʵ��
        /// </summary>
        /// <param name="serializationInfo"></param>
        /// <param name="streamingContext"></param>
        [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter, SerializationFormatter = true)]
        void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
            base.GetObjectData(serializationInfo, streamingContext);
        }
    }
}
