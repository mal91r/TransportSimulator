using System;
using EKRLib;
using static PeerGrade6.Program;

namespace PeerGrade6
{
    /// <summary>
    /// Класс отчевает за генерацию данных.
    /// </summary>
    internal class Generator
    {
        /// <summary>
        /// Метод генерирует случайным образом объект типа Car или MotorBoat,
        /// либо выбрасывает исключение в случае возникновения ошибки.
        /// </summary>
        /// <returns>Объект-наследний типа Transport</returns>
        public Transport Generation()
        {
            try
            {
                int transportType = rand.Next(2);
                string model = ModelGeneration();
                uint power = (uint)rand.Next(10, 100);
                if (isModelCorrect(model) & isPowerCorrect(power))
                {
                    switch (transportType)
                    {
                        case 0:
                            return new Car(model, power);
                        case 1:
                            return new MotorBoat(model, power);
                    }
                }
                return Generation();
            }
            catch (TransportException e)
            {
                Console.WriteLine(e.Message);
                return Generation();
            }
        }

        /// <summary>
        /// Метод определяет, корректна ли мощность.
        /// </summary>
        /// <param name="power">Мощность</param>
        /// <returns>Булевое значение</returns>
        /// <exception cref="TransportException">Исплючение</exception>
        private bool isPowerCorrect(uint power)
        {
            if (power < 20)
            {
                throw new TransportException("мощность не может быть меньше 20 л.с.");
            }
            return true;
        }

        /// <summary>
        /// Метод определяет, корректна ли модель.
        /// </summary>
        /// <param name="model">Модель</param>
        /// <returns>Булевое значение</returns>
        /// <exception cref="TransportException">Исключение</exception>
        private bool isModelCorrect(string model)
        {
            if (model.Length == 5)
            {
                for (int i = 0; i < 5; i++)
                {
                    int latterToInt = (int)model[i];
                    if (latterToInt < 48 || latterToInt > 57 && latterToInt < 65 || latterToInt > 90)
                    {
                        throw new TransportException($"Недопустимая модель {model}");
                    }
                }
                return true;
            }
            throw new TransportException($"Недопустимая модель {model}");
        }

        /// <summary>
        /// Метод генерирует модель.
        /// </summary>
        /// <returns>Строковое значение модели</returns>
        private string ModelGeneration()
        {
            string model = "";
            char[] alphabet = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            for (int i = 0; i < 5; i++)
            {
                model += alphabet[rand.Next(36)];
            }
            return model;
        }
    }
}
