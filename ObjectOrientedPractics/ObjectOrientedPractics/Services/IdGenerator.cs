using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPractics.Services
{
    public static class IdGenerator
    {
        /// <summary>
        /// Уникальный индетификатор. 
        /// </summary>
        private static int _id = 0;

        /// <summary>
        /// Создаёт уникальный идентификатор.
        /// </summary>
        /// <returns>Возвращает уникальный идентификатор.</returns>
        public static int GetNextId()
        {
            return _id++;
        }
    }
}
