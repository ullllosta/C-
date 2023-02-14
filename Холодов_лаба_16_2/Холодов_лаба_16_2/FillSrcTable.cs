using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Холодов_лаба_16_2
{
    class FillSrcTable : DataInterface
    {
        // Список, который будет хранить распределённые данные 
        // кадой строки из выбранного файла по соответствующим свойствам
        // из SourceItem.cs
        private List<SourceItem> src;
        // Список, который будет хранить элемент, с распределёнными
        // по свойствам из SourceItem.cs данными, который имеет максимальную
        // стоимость кв.м
        private List<SourceItem> tmp;
        // Поле, для хранения максимальной стоимости кв.м
        private double mostExpensiveMetr = 0;
        // Символ, которым ожидается будут разделены данные в
        // выбранном пользователем файле
        private char devider = '*';

        // Возвращает true, если список src не пустой, т.е
        // файл, из которого берутся данные нам подходит
        public bool IsFull
        {
            get
            {
                if (src == null) return false;
                else return true;
            }
        }

        // Заполнение списка src данными из выбранного файла.
        // Содержимое строки сортируется по соответсувующим свойствам.
        // Возвращает true, если файл нам подходит и список src получилось заполнить
        private bool FillSrc(string datapath)
        {
            // Выделяем память под список src (до этого мы просто объявили список, как переменную)
            src = new List<SourceItem>();
            
            // Проходим по каждой строке из файла, которого мы выбрали, разбиваем её методом Split()
            // и присваиваем её составляющие соответствующим им полям таблицы, которые мы объявили
            // в SourceItem.cs 
            try
            {
                StreamReader sr = new StreamReader(datapath, Encoding.UTF8);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] items = line.Split(devider);
                    var item = new SourceItem()
                    {
                        Type = items[0].Trim(),
                        Rooms = byte.Parse(items[1].Trim()),
                        Area = int.Parse(items[2].Trim()),
                        Cost = double.Parse(items[3])
                    };
                    src.Add(item);
                }
                sr.Close();
                FindMostExpensiveMetr();
            } catch(IOException ex) { return false; }
            return true;
        }

        // Поиск объекта с самой высокой стоимостью кв.м
        public void FindMostExpensiveMetr()
        {
            // Поиск значения самой дорогой стоимости кв.м
            foreach (SourceItem item in src)
            {
                if (item.MetrCost > mostExpensiveMetr)
                    mostExpensiveMetr = item.MetrCost;
            }

            // Поиск самого объекта с самой высокой стоимостью кв.м
            tmp = new List<SourceItem>();
            foreach (SourceItem item in src)
            {
                if (mostExpensiveMetr == item.MetrCost)
                {
                    tmp.Add(item);
                    break;
                }
            }
        }

        // Вернёт экземпляр данного класса, что позволит обращаться к его методам,
        // если метод FillSrc() вернул true, т.е. выбранный файл нам подошёл
        // и список src было чем заполнить
        public static FillSrcTable TableFiller(string path)
        {
            FillSrcTable f = new FillSrcTable();
            if (f.FillSrc(path))
                return f;
            else
                return null;
        }


        public List<SourceItem> GetSrcItem()
        {
            // Если список src не пустой, то вернуть его
            if (IsFull)
                return src;
            else
                return null;
        }

        public List<SourceItem> GetMostExpensiveMetr()
        {
            // Если список src не пустой, выходит есть где искать объект
            // с самой высокой стоимостью кв.м., значит  метод FindMostExpensiveMetr()
            // был выполнен.
            // Возвращает объект с самой высокой стоимостью кв.м
            if (IsFull)
                return tmp;
            else
                return null;
        }
    }
}
