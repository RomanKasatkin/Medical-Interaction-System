using Kpo.BL.Filter;
using Kpo.Dal;
using Kpo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB;


namespace Kpo.BL
{
    public class User
    {
        public long Add(UserModel model)
        {
            //TODO: валидация модели 

            //Сохранение 
            using (var db = new MainDb())
            {
                long id = Convert.ToInt64(db.User.InsertWithIdentity(() => new Kpo.Dal.MainDb.PersonalDataModel
                {    
                    
                    Job_Id = model.Job_Id,
                    Name = model.Name,
                    Surname = model.Surname,
                    Patronymic = model.Patronymic,
                    Permition_level = model.Permition_Level,
                    Login = model.Login,
                    Password = model.Password
                }));

                return id;
            }
        }

        public void Edit(UserModel model)
        {
            

            //Редактирование 
            using (var db = new MainDb())
            {
                db.User.Where(q => q.Id == model.Id)
                    .Set(q => q.Job_Id, model.Job_Id)
                    .Set(q => q.Name, model.Name)
                    .Set(q => q.Surname, model.Surname)
                    .Set(q => q.Patronymic, model.Patronymic)
                    .Set(q => q.Permition_level, model.Permition_Level)
                    .Set(q => q.Login, model.Login)
                    .Set(q => q.Password, model.Password)
                    .Update();
            }
        }
        /// <summary>
        /// Удалить пользователя
        /// </summary>
        /// <param name="filters"></param>
        /// <returns></returns>
        public void Delete(long id)
        {
            using (var db = new MainDb())
            {
                db.User.Delete(q => q.Id == id);
            }
        }


        /// <summary>
        /// Получить список пользователей по фильтру
        /// </summary>
        /// <param name="filters"></param>
        /// <returns></returns>
        public List<UserModel> List(List<FilterCondition> filters)
        {
            using (var db = new MainDb())
            {
                var query = MakeSelect(db);

                if (filters != null)
                {
                    foreach (var item in filters)
                    {
                        if (item.Field.Equals("Login", StringComparison.CurrentCultureIgnoreCase) && item.Value != null)
                        {
                            if (item.Type == ConditionType.Equal)
                            {
                                query = query.Where(q => q.Login.Equals(item.Value));
                            }
                            else if (item.Type == ConditionType.Contains)
                            {
                                query = query.Where(q => q.Login.Contains(item.Value.ToString()));
                            }
                        }
                        if (item.Field.Equals("Job_Id", StringComparison.CurrentCultureIgnoreCase) && item.Value != null)
                        {
                            if (item.Type == ConditionType.Equal)
                            {
                                query = query.Where(q => q.Job_Id.Equals(item.Value));
                            }
                            
                        }
                        if (item.Field.Equals("Password", StringComparison.CurrentCultureIgnoreCase) && item.Value != null)
                        {
                            if (item.Type == ConditionType.Equal)
                            {
                                query = query.Where(q => q.Password.Equals(item.Value));
                            }
                            else if (item.Type == ConditionType.Contains)
                            {
                                query = query.Where(q => q.Password.Contains(item.Value.ToString()));
                            }
                        }
                        if (item.Field.Equals("Permition_Level", StringComparison.CurrentCultureIgnoreCase) && item.Value != null)
                        {
                            if (item.Type == ConditionType.Equal)
                            {
                                query = query.Where(q => q.Permition_Level.Equals(item.Value));
                            }
                            
                        }
                    }
                }
                                
                return query.ToList();
            }
        }
        /// <summary>
        /// Получить элемент по заданным параметрам
        /// </summary>
        /// <returns></returns>

        public UserModel Get_Item(string field, string value, ConditionType type)
        {
            FilterCondition filter = new FilterCondition(field,value,type);
            using (var db = new MainDb())
            {
                var query = MakeSelect(db);

                if (filter != null)
                {

                    if (filter.Field.Equals("Login", StringComparison.CurrentCultureIgnoreCase) && filter.Value != null)
                    {
                        if (filter.Type == ConditionType.Equal)
                        {
                            query = query.Where(q => q.Login.Equals(filter.Value));
                        }
                        else if (filter.Type == ConditionType.Contains)
                        {
                            query = query.Where(q => q.Login.Contains(filter.Value.ToString()));
                        }
                    }
                    if (filter.Field.Equals("Password", StringComparison.CurrentCulture) && filter.Value != null)
                    {
                        if (filter.Type == ConditionType.Equal)
                        {
                            query = query.Where(q => q.Password.Equals(filter.Value));
                        }
                        else if (filter.Type == ConditionType.Contains)
                        {
                            query = query.Where(q => q.Password.Contains(filter.Value.ToString()));
                        }
                    }
                    if (filter.Field.Equals("Permition_Level", StringComparison.CurrentCultureIgnoreCase) && filter.Value != null)
                    {
                        if (filter.Type == ConditionType.Equal)
                        {
                            query = query.Where(q => q.Permition_Level.Equals(filter.Value));
                        }

                    }
                    if (filter.Field.Equals("Id", StringComparison.CurrentCultureIgnoreCase) && filter.Value != null)
                    {
                        if (filter.Type == ConditionType.Equal)
                        {
                            query = query.Where(q => q.Id.Equals(filter.Value));
                        }
                    }
                }
                UserModel Result = new UserModel();
                try{
                Result = query.Single();
                     return Result;
                }
                catch
                {
                    return null;
                }

               
            }
        }

        /// <summary>
        /// Получить список всех пользователей системы
        /// </summary>
        /// <returns></returns>
        public List<UserModel> List()
        {
            using (var db = new MainDb())
            {
                var query = MakeSelect(db);
                return query.ToList();
            }                            
        }

        private IQueryable<UserModel> MakeSelect(MainDb db)
        {
            var query = from user in db.User
                        select new UserModel
                        {
                            Id = user.Id,
                            Job_Id=user.Job_Id,
                            Name = user.Name,
                            Surname = user.Surname,
                            Patronymic = user.Patronymic,
                            Permition_Level=user.Permition_level,
                            Login=user.Login,
                            Password=user.Password
                        };

            return query;
        }



    }
}
