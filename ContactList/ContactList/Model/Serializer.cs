using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using static System.Environment;

namespace ContactList.Model
{
    /// <summary>
    /// Предоставляет методы для сериализации и десериализации данных
    /// </summary>
    public static class Serializer
    {
        /// <summary>
        /// Создает экземпляр класса <see cref="Serializer"/>
        /// </summary>
        static Serializer()
        {
            Path = $@"{Environment.GetFolderPath(SpecialFolder.ApplicationData)}" +
                    @"\Isaichenko Nikita\List of Program\";
            NameFile = "data.json";

            if (!File.Exists(Path))
            {
                DirectoryInfo directory = Directory.CreateDirectory(Path);
            }
        }
        /// <summary>
        /// Возвращает и задает путь куда будут сериализоватся данные.
        /// </summary>
        public static string Path { get; set; }

        /// <summary>
        /// Возвращает и задает имя файла.
        /// </summary>
        public static string NameFile { get; set; }

        /// <summary>
        /// Сохраняет данные из списка в формате JSON.
        /// </summary>
        /// <param name="students">Список студентов.</param>
        public static void SaveToFile(List<Contact> contacts)
        {
            using (StreamWriter writer = new StreamWriter(Path + NameFile))
            {

                writer.Write(JsonConvert.SerializeObject(contacts));
            }
        }

        /// <summary>
        /// Загружает данные в формате JSON и десериализует их в список.
        /// </summary>
        /// <returns>Список объектов <see cref="Student"/>.</returns>
        public static List<Contact> LoadFromFile()
        {
            {
                var contacts = new List<Contact>();

                try
                {
                    using (StreamReader reader = new StreamReader(Path + NameFile))
                    {
                        contacts = JsonConvert.DeserializeObject<List<Contact>>(reader.ReadToEnd());
                    }

                    if (contacts == null) contacts = new List<Contact>();
                }
                catch
                {
                    return contacts;
                }

                return contacts;
            }
        }
    }
}
