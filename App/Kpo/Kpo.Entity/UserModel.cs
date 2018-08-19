using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kpo.Entity
{
    public class UserModel: IModel
    {
        public long Id { get; set; }
        public long Job_Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public long Permition_Level { get; set; }
        public string Login { get; set; }
        public string Password {get; set;}




        public override string ToString()
        {
            return string.Format("ID:{0}; Job_Id: {7}, Имя:{1}; Фамилия: {2}; Отчество: {3}; Уровень доступа{4}; Логин {5}; Пароль {6}", Id, Name, Surname, Patronymic, Permition_Level, Login, Password, Job_Id);
        }
    }
}
