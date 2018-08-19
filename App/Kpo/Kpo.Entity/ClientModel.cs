using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kpo.Entity
{
    public class ClientModel: IModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public DateTime Date{ get; set; }
        public long Pasport { get; set; }
        public long Gender { get; set; }
        public string Adress { get; set; }
        public long Insurance { get; set; }



        public override string ToString()
        {
            return string.Format("ID:{0}; Имя:{1}; Фамилия: {2}; Отчество: {3}; Дата рождения {4}; Паспорт {5}; Пол {6}; Адрес {7};  Страховка {8}", Id, Name, Surname, Patronymic, Date, Pasport, Gender, Adress, Insurance);
        }
    }
}
