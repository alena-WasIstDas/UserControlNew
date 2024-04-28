using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5UserControl
{
    /// <summary>
    /// Наполнение заявки
    /// </summary>
    public class Request
    {
        public int ID;
        public DateTime Created;
        public string Equipment;
        public string Defect;
        public string Description;
        public string Client;
        public string Status = Statuses[2];
        public static List<string> Statuses = new() { "Выполнено", "В работе", "В ожидании" };
        public string Master;
        public string Comment;
    }
}
