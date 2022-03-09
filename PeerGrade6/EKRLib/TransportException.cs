using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKRLib
{
    /// <summary>
    /// Класс, наследующий класс Exception
    /// </summary>
    [Serializable]
    public class TransportException : Exception
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public TransportException() : base() { }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="message">Сообщение об ошибке</param>
        public TransportException(string message) : base(message) { }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="message">Сообщение об ошибке</param>
        /// <param name="inner">Исключение</param>
        public TransportException(string message, Exception inner) : base(message, inner) { }

        /// <summary>
        /// A constructor is needed for serialization when an
        /// exception propagates from a remoting server to the client.
        /// </summary>
        /// <param name="info">Информация</param>
        /// <param name="context">Контекст</param>
        protected TransportException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
