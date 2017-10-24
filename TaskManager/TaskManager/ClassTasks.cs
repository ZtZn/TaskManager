using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Diagnostics;
using System.IO;
using System.IO.MemoryMappedFiles;


namespace TaskManager
{
    public class ClassTasks
    {



        // запускает исполняемый файл через н минут
        public ClassTasks(string Path, Double Time)
        {
            while (true)
            {

                //Выполняем рассылку
                Thread.Sleep(TimeSpan.FromMinutes(Time));
                Process.Start(Path);

            }

        }
        // создание перегрузки // отправка сообщений на консоль
        public ClassTasks(string Message, TimeSpan on, TimeSpan off)
        {      // Выделенная именованная память
            MemoryMappedFile Memory;
            // Объект для чтения из памяти
            StreamReader SR_Memory;
            // Объект для записи в память
            StreamWriter SW_Memory;

            // Создаст, или подключится к уже созданной памяти с таким именем
            Memory = MemoryMappedFile.CreateOrOpen("MyMemory", 1024, MemoryMappedFileAccess.ReadWrite);
            // Создает поток для чтения
            SR_Memory = new StreamReader(Memory.CreateViewStream(), System.Text.Encoding.Default);
            // Создает поток для записи
            SW_Memory = new StreamWriter(Memory.CreateViewStream(), System.Text.Encoding.Default);

            if ((on < DateTime.Now.TimeOfDay) && (off > DateTime.Now.TimeOfDay))
            {
                // Встает в начало потока для записи
                SW_Memory.BaseStream.Seek(0, SeekOrigin.Begin);
                SW_Memory.WriteLine("{0}", Message);
                SW_Memory.Flush();
            }

            // По завершению цикла, закрывает все потоки и освобождает именованную память
            SR_Memory.Close();
            SW_Memory.Close();
            Memory.Dispose();

        }
    }
}