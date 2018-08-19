using Kpo.DAL;
using Kpo.Entity;
using LinqToDB;
using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Kpo.Dal
{
    public partial class MainDb : DbManagerBase
    {
        public MainDb()
        {

        }

        public ITable<PersonalDataModel> User { get { return GetTable<PersonalDataModel>(); } }


        [Table(Name = "PERSONAL")]
        [Description("Пользователь")]
        public class PersonalDataModel : IModel
        {
            [PrimaryKey]
            [Column(Name = "PERSONAL_ID", CanBeNull = false, Length = 19)]
            [Description("ID пользователя")]
            public long Id { get; set; }

            [NotNull]
            [Column(Name = "JOB_ID", CanBeNull = false, Length = 19)]
            [Description("ID пользователя")]
            public long Job_Id { get; set; }

            [NotNull]
            [Column(Name = "PERSONAL_NAME", CanBeNull = false, Length = 50)]
            [Description("Имя")]
            public string Name { get; set; }

            [NotNull]
            [Column(Name = "PERSONAL_SURNAME", CanBeNull = false, Length = 50)]
            [Description("Фамилия")]
            public string Surname { get; set; }

            [Nullable]
            [Column(Name = "PERSONAL_PATRONYMIC", CanBeNull = true, Length = 50)]
            [Description("Отчество")]
            public string Patronymic { get; set; }

            [NotNull]
            [Column(Name = "PERSONAL_PERMITION", CanBeNull = false, Length = 1)]
            [Description("Уровень доступа")]
            public long Permition_level { get; set; }

            [NotNull]
            [Column(Name = "PERSONAL_LOGIN", CanBeNull = false, Length = 50)]
            [Description("Логин")]
            public string Login { get; set; }

            [NotNull]
            [Column(Name = "PERSONAL_PASSWORD", CanBeNull = false, Length = 50)]
            [Description("Логин")]
            public string Password { get; set; }
        }
        public ITable<JobDataModel> Job { get { return GetTable<JobDataModel>(); } }


        [Table(Name = "JOB")]
        [Description("Профессия")]
        public class JobDataModel : IModel
        {
            [NotNull]
            [Column(Name = "JOB_ID", CanBeNull = false, Length = 19)]
            [Description("Id")]
            public long Id { get; set; }

            [NotNull]
            [Column(Name = "JOB_NAME", CanBeNull = false, Length = 50)]
            [Description("Название")]
            public string Name { get; set; }
        }
        public ITable<ClientDataModel> Client { get { return GetTable<ClientDataModel>(); } }

        [Table(Name= "CLIENT")]
        [Description("Пациент")]
        public class ClientDataModel : IModel
        {
            [NotNull]
            [Column(Name = "CLIENT_ID", CanBeNull = false, Length = 19)]
            [Description("Id")]
            public long Id { get; set; }

            [NotNull]
            [Column(Name = "CLIENT_NAME", CanBeNull = false, Length = 50)]
            [Description("Имя")]
            public string Name { get; set; }

            [NotNull]
            [Column(Name = "CLIENT_SURNAME", CanBeNull = false, Length = 50)]
            [Description("Фамилия")]
            public string Surname { get; set; }

            [Nullable]
            [Column(Name = "CLIENT_PATRONYMIC", CanBeNull = true, Length = 50)]
            [Description("Отчество")]
            public string Patronymic { get; set; }

            [NotNull]
            [Column(Name = "CLIENT_BIRTH", CanBeNull = false, Length = 10)]
            [Description("Дата рождения")]
            public DateTime Date { get; set; }

            [NotNull]
            [Column(Name = "CLIENT_PASPORT", CanBeNull = false, Length = 10)]
            [Description("Наомер паспорта")]
            public long Pasport { get; set; }

            [NotNull]
            [Column(Name = "CLIENT_GENDER", CanBeNull = false, Length = 1)]
            [Description("Наомер паспорта")]
            public long Gender { get; set; }

            [NotNull]
            [Column(Name = "CLIENT_ADRESS", CanBeNull = false, Length = 10)]
            [Description("Адрес")]
            public string Adress { get; set; }

            [NotNull]
            [Column(Name = "CLIENT_INSURANCE", CanBeNull = false, Length = 16)]
            [Description("Наомер страховки")]
            public long Insurance { get; set; }
        }

        public ITable<ProcTypeDataModel> ProcType { get { return GetTable<ProcTypeDataModel>(); } }

            [Table(Name = "PROC_TYPE")]
            [Description("Тип процедуры")]

        public class ProcTypeDataModel : IModel
            {
                [NotNull]
                [Column(Name = "PROC_TYPE_ID", CanBeNull = false, Length = 19)]
                [Description("Id")]
                public long Id { get; set; }

                [Nullable]
                [Column(Name = "JOB_ID", CanBeNull = true, Length = 19)]
                [Description("Id профессии")]
                public long Job_Id { get; set; }

                [NotNull]
                [Column(Name = "PROC_TYPE_NAME", CanBeNull = false, Length = 50)]
                [Description("Название")]
                public string Name { get; set; }
            }

            public ITable<ProcDataModel> Proc { get { return GetTable<ProcDataModel>(); } }

            [Table(Name = "PROC")]
            [Description("Процедура")]

            public class ProcDataModel : IModel
            {
                [NotNull]
                [Column(Name = "PROC_ID", CanBeNull = false, Length = 19)]
                [Description("Id")]
                public long Id { get; set; }

                [NotNull]
                [Column(Name = "PERSONAL_ID", CanBeNull = false, Length = 19)]
                [Description("Id персонала")]
                public long Personal_Id { get; set; }

                [NotNull]
                [Column(Name = "DATE_ID", CanBeNull = false, Length = 19)]
                [Description("Id Даты")]
                public long Date_Id { get; set; }

                [NotNull]
                [Column(Name = "PROC_TYPE_ID", CanBeNull = false, Length = 19)]
                [Description("Id Типа процедуры")]

                public long Proc_Type_Id { get; set; }

                [NotNull]
                [Column(Name = "CLIENT_ID", CanBeNull = false, Length = 19)]
                [Description("Id Клиента")]
                public long Client_Id { get; set; }
            }

            public ITable<DateDataModel> Date { get { return GetTable<DateDataModel>(); } }

            [Table(Name = "DATE")]
            [Description("Тип процедуры")]

            public class DateDataModel : IModel
            {
                [NotNull]
                [Column(Name = "DATE_ID", CanBeNull = false, Length = 19)]
                [Description("Id")]
                public long Id { get; set; }

                [NotNull]
                [Column(Name = "DATE_DAY", CanBeNull = false, Length = 50)]
                [Description("Название")]
                public DateTime Day { get; set; }

                [NotNull]
                [Column(Name = "DATE_TIME", CanBeNull = false, Length = 50)]
                [Description("Название")]
                public DateTime Time { get; set; }
            }


            public ITable<FreeTimeDataModel> FreeTime { get { return GetTable<FreeTimeDataModel>(); } }

            [Table(Name = "FREETIME")]
            [Description("Свободное время")]

            public class FreeTimeDataModel : IModel
            {
               

                [NotNull]
                [Column(Name = "FREETIME_ID", CanBeNull = false, Length = 19)]
                [Description("Название")]
                public long Id { get; set; }

                [NotNull]
                [Column(Name = "PERSONAL_ID", CanBeNull = false, Length = 19)]
                [Description("Id")]
                public long Personal_Id { get; set; }

                [NotNull]
                [Column(Name = "FREETIME_TIME", CanBeNull = false, Length = 50)]
                [Description("Название")]
                public DateTime Time { get; set; }
                [NotNull]
                [Column(Name = "FREETIME_DAY", CanBeNull = false, Length = 50)]
                [Description("Название")]
                public DateTime Day { get; set; }
            }

            public ITable<HistoryDataModel> History { get { return GetTable<HistoryDataModel>(); } }

            [Table(Name = "HISTORY")]
            [Description("История")]

            public class HistoryDataModel : IModel
            {


                [NotNull]
                [Column(Name = "HISTORY_ID", CanBeNull = false, Length = 19)]
                [Description("Название")]
                public long Id { get; set; }

                [NotNull]
                [Column(Name = "DATE_ID", CanBeNull = false, Length = 19)]
                [Description("Id")]
                public long Date_Id { get; set; }

                [NotNull]
                [Column(Name = "PERSONAL_ID", CanBeNull = false, Length = 19)]
                [Description("Название")]
                public long Personal_Id { get; set; }

                [NotNull]
                [Column(Name = "CLIENT_ID", CanBeNull = false, Length = 19)]
                [Description("Название")]
                public long Client_Id { get; set; }

                [NotNull]
                [Column(Name = "HISTORY_DIAGNOSIS", CanBeNull = false, Length = 50)]
                [Description("Название")]
                public string Diagnosis { get; set; }
                [NotNull]
                [Column(Name = "HISTORY_SYMTOMS", CanBeNull = false, Length = 50)]
                [Description("Название")]
                public string Symptoms { get; set; }
            }


            public ITable<AnalyseDataModel> Analyse { get { return GetTable<AnalyseDataModel>(); } }

            [Table(Name = "ANALYSE")]
            [Description("Анализы")]

            public class AnalyseDataModel : IModel
            {


                [NotNull]
                [Column(Name = "ANALYSE_ID", CanBeNull = false, Length = 19)]
                [Description("Название")]
                public long Id { get; set; }

                [Nullable]
                [Column(Name = "DATE_ID", CanBeNull = true, Length = 19)]
                [Description("Id")]
                public long Date_Id { get; set; }
                
                [NotNull]
                [Column(Name = "CLIENT_ID", CanBeNull = false, Length = 19)]
                [Description("Название")]
                public long Client_Id { get; set; }
                [NotNull]
                [Column(Name = "ANALYSE_TYPE_ID", CanBeNull = false, Length = 50)]
                [Description("Результат")]
                public long Type_Id { get; set; }

                [NotNull]
                [Column(Name = "ANALYSE_RESULT", CanBeNull = false, Length = 19)]
                [Description("Результат")]
                public long Result { get; set; }
                [Nullable]
                [Column(Name = "ANALYSE_COMENT", CanBeNull = true, Length = 50)]
                [Description("Коментарий")]
                public string Coment { get; set; }
            }

            public ITable<AnalyseTypeDataModel> AnalyseType { get { return GetTable<AnalyseTypeDataModel>(); } }

            [Table(Name = "ANALYSE_TYPE")]
            [Description("Тип процедуры")]

            public class AnalyseTypeDataModel : IModel
            {
                [NotNull]
                [Column(Name = "ANALYSE_TYPE_ID", CanBeNull = false, Length = 19)]
                [Description("Id")]
                public long Id { get; set; }

                [NotNull]
                [Column(Name = "ANALYSE_TYPE_NAME", CanBeNull = false, Length = 50)]
                [Description("Название")]
                public string Name { get; set; }

                
            }
       


    }

}

