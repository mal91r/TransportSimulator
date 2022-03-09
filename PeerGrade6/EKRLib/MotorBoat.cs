using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKRLib
{
    public class MotorBoat : Transport
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="model">Модель</param>
        /// <param name="power">Мощность</param>
        public MotorBoat(string model, uint power) : base(model, power) { }

        /// <summary>
        /// Переопределенный метод StartEngine из родительского класса Transport.
        /// </summary>
        /// <returns>Строка, содержащая модель и звук, издаваемый мотором</returns>
        public override string StartEngine()
        {
            return $"{Model}: Brrrbrr";
        }

        /// <summary>
        /// Переопределенный метод ToString.
        /// </summary>
        /// <returns>Строка содержащая тип транспорта и метод ToString родительского класса Transport</returns>
        public override string ToString()
        {
            return "MotorBoat. " + base.ToString();
        }
    }
}
