using System;

namespace EKRLib
{
    public abstract class Transport
    {
        protected string Model { get; set; }
        protected uint Power { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="model">Модель</param>
        /// <param name="power">Мощность</param>
        public Transport(string model, uint power)
        {
            Model = model;
            Power = power;
        }

        /// <summary>
        /// Абстрактный метод возвращающий звук мотора
        /// </summary>
        /// <returns>Строка с моделью и мощностью данного объекта транспорта</returns>
        abstract public string StartEngine();
        public override string ToString()
        {
            return $"Model: {Model}, Power: {Power}";
        }
    }
}
