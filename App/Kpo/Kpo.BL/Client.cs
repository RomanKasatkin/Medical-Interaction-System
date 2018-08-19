using Kpo.Dal;
using Kpo.BL.Filter;
using Kpo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;

namespace Kpo.BL
{
   public class Client
    {
        private IQueryable<ClientModel> MakeSelect(MainDb db)
        {
            var query = from client in db.Client
                        select new ClientModel
                        {
                            Id = client.Id,
                            Name = client.Name,
                            Surname = client.Surname,
                            Patronymic = client.Patronymic,
                            Date = client.Date,
                            Pasport = client.Pasport,
                            Gender = client.Gender,
                            Adress = client.Adress,
                            Insurance = client.Insurance


                        };

            return query;
        }

        public void Edit(ClientModel model)
        {


            //Редактирование 
            using (var db = new MainDb())
            {
                db.Client.Where(q => q.Id == model.Id)
                    .Set(q => q.Name, model.Name)
                    .Set(q => q.Surname, model.Surname)
                    .Set(q => q.Patronymic, model.Patronymic)
                    .Set(q => q.Gender, model.Gender)
                    .Set(q=>q.Date, model.Date)
                    .Set(q => q.Pasport, model.Pasport)
                    .Set(q => q.Insurance, model.Insurance)
                    .Set(q => q.Adress, model.Adress)
                    .Update();
            }
        }
        /// <summary>
        /// Получить список по фильтрам
        /// </summary>
        /// <returns></returns>
        public List<ClientModel> List(List<FilterCondition> filters)
        {
            using (var db = new MainDb())
            {
                var query = MakeSelect(db);

                if (filters != null)
                {
                    foreach (var item in filters)
                    {
                        if (item.Field.Equals("Id", StringComparison.CurrentCultureIgnoreCase) && item.Value != null)
                        {
                            if (item.Type == ConditionType.Equal)
                            {
                                query = query.Where(q => q.Id.Equals(item.Value));
                            }
                            else if (item.Type == ConditionType.StartsWith)
                            {
                                query = query.Where(q => q.Id.ToString().StartsWith(item.Value.ToString()));
                            }
                            
                        }
                        if (item.Field.Equals("Name", StringComparison.CurrentCultureIgnoreCase) && item.Value != null)
                        {
                            if (item.Type == ConditionType.Equal)
                            {
                                query = query.Where(q => q.Name.Equals(item.Value));
                            }
                            else if (item.Type == ConditionType.StartsWith)
                            {
                                query = query.Where(q => q.Name.StartsWith(item.Value.ToString()));
                            }
                        }
                        if (item.Field.Equals("Surname", StringComparison.CurrentCultureIgnoreCase) && item.Value != null)
                        {
                            if (item.Type == ConditionType.Equal)
                            {
                                query = query.Where(q => q.Surname.Equals(item.Value));
                            }
                            else if (item.Type == ConditionType.StartsWith)
                            {
                                query = query.Where(q => q.Surname.StartsWith(item.Value.ToString()));
                            }
                        }
                        if (item.Field.Equals("Pasport", StringComparison.CurrentCultureIgnoreCase) && item.Value != null)
                        {
                            if (item.Type == ConditionType.Equal)
                            {
                                query = query.Where(q => q.Pasport.Equals(item.Value));
                            }
                            else if (item.Type == ConditionType.StartsWith)
                            {
                                query = query.Where(q => q.Pasport.ToString().StartsWith(item.Value.ToString()));
                            }
                        }                        
                    }
                }

                return query.ToList();
            }
        }

        /// <summary>
        /// Получить список всех пользователей системы
        /// </summary>
        /// <returns></returns>
        public List<ClientModel> List()
        {
            using (var db = new MainDb())
            {
                var query = MakeSelect(db);
                return query.ToList();
            }
        }
        /// <summary>
        /// Получить клиента по параметру
        /// </summary>
        /// <returns></returns>
        public ClientModel Get_Item(string field, string value, ConditionType type)
        {
            FilterCondition filter = new FilterCondition(field, value, type);
            using (var db = new MainDb())
            {
                var query = MakeSelect(db);

                if (filter != null)
                {

                    if (filter.Field.Equals("Id", StringComparison.CurrentCultureIgnoreCase) && filter.Value != null)
                    {
                        if (filter.Type == ConditionType.Equal)
                        {
                            query = query.Where(q => q.Id.Equals(filter.Value));
                        }
                    }
                    if (filter.Field.Equals("Pasport", StringComparison.CurrentCulture) && filter.Value != null)
                    {
                        if (filter.Type == ConditionType.Equal)
                        {
                            query = query.Where(q => q.Pasport.Equals(filter.Value));
                        }
                    }                   
                }
                ClientModel Result = new ClientModel();
                try
                {
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
        /// Добавить нового пациента
        /// </summary>
        /// <returns></returns>
      
        public long Add(ClientModel model)
        {
            using (var db = new MainDb())
            {
                long id = Convert.ToInt64(db.Client.InsertWithIdentity(() => new Kpo.Dal.MainDb.ClientDataModel
                {

                    
                    Name = model.Name,
                    Surname = model.Surname,
                    Patronymic = model.Patronymic,
                    Date = model.Date,
                    Pasport = model.Pasport,
                    Gender = model.Gender,
                    Adress = model.Adress,
                    Insurance = model.Insurance
                }));

                return id;
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
                db.Proc.Delete(q => q.Id == id);
            }
        }


    }
}
