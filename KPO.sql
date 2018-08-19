/*==============================================================*/
/* DBMS name:      MySQL 5.0                                    */
/* Created on:     22.12.2016 14:16:55                          */
/*==============================================================*/


/*==============================================================*/
/* Table: ANALYSE                                               */
/*==============================================================*/
create table ANALYSE
(
   ANALYSE_ID           int not null auto_increment,
   DATE_ID              int,
   ANALYSE_NAME         text not null,
   ANALYSE_RESULT       int,
   ANALYSE_NORM         int not null,
   primary key (ANALYSE_ID)
)
engine = InnoDB;

/*==============================================================*/
/* Table: CLIENT                                                */
/*==============================================================*/
create table CLIENT
(
   CLIENT_ID            int not null auto_increment,
   CLIENT_NAME          text not null,
   CLIENT_SURNAME       text not null,
   CLIENT_PATRONYMIC    text,
   CLIENT_BIRTH         date not null,
   CLIENT_PASPORT       int not null,
   CLIENT_GENDER        int(1),
   CLIENT_ADRESS        text,
   CLIENT_INSURANCE     int,
   primary key (CLIENT_ID)
)
engine = InnoDB;

/*==============================================================*/
/* Table: CLIENT_ANALYSE                                        */
/*==============================================================*/
create table CLIENT_ANALYSE
(
   CLIENT_ANALYSE_ID    int not null auto_increment,
   CLIENT_ID            int(10),
   ANALYSE_ID           int,
   primary key (CLIENT_ANALYSE_ID)
)
engine = InnoDB;

/*==============================================================*/
/* Table: CLIENT_DOCUMENT                                       */
/*==============================================================*/
create table CLIENT_DOCUMENT
(
   CLIENT_DOCUMENT_ID   int not null auto_increment,
   CLIENT_ID            int(10),
   DOCUMENT_ID          int,
   primary key (CLIENT_DOCUMENT_ID)
)
engine = InnoDB;

/*==============================================================*/
/* Table: CLIENT_OPERATION                                      */
/*==============================================================*/
create table CLIENT_OPERATION
(
   CLIENT_OPERATION_ID  int not null auto_increment,
   OPERATION_ID         int,
   CLIENT_ID            int(10),
   primary key (CLIENT_OPERATION_ID)
)
engine = InnoDB;

/*==============================================================*/
/* Table: DATE                                                  */
/*==============================================================*/
create table DATE
(
   DATE_ID              int not null auto_increment,
   DATE_DAY             date not null,
   DATE_TIME            time,
   primary key (DATE_ID)
)
engine = InnoDB;

/*==============================================================*/
/* Table: DOCUMET                                               */
/*==============================================================*/
create table DOCUMET
(
   DOCUMENT_ID          int not null auto_increment,
   DOCUMENT_NAME        char(10),
   DOCUMENT_DOC         mediumblob not null,
   primary key (DOCUMENT_ID)
)
engine = InnoDB;

/*==============================================================*/
/* Table: HISTORY                                               */
/*==============================================================*/
create table HISTORY
(
   HISTORY_ID           int not null auto_increment,
   DATE_ID              int,
   PERSONAL_ID          int,
   CLIENT_ID            int(10),
   HISTORY_DIAGNOSIS    text not null,
   HISTORY_SYMTOMS      text not null,
   primary key (HISTORY_ID)
)
engine = InnoDB;

/*==============================================================*/
/* Table: JOB                                                   */
/*==============================================================*/
create table JOB
(
   JOB_ID               int not null auto_increment,
   JOB_NAME             text not null,
   primary key (JOB_ID)
)
engine = InnoDB;

/*==============================================================*/
/* Table: OPERATION                                             */
/*==============================================================*/
create table OPERATION
(
   OPERATION_ID         int not null auto_increment,
   PERSONAL_ID          int,
   DATE_ID              int,
   OPERATION_TYPE_ID    int,
   OPERATION_NOTE       text not null,
   primary key (OPERATION_ID)
)
engine = InnoDB;

/*==============================================================*/
/* Table: OPERATION_TYPE                                        */
/*==============================================================*/
create table OPERATION_TYPE
(
   OPERATION_TYPE_ID    int not null auto_increment,
   OPERATION_TYPE_NAME  text not null,
   primary key (OPERATION_TYPE_ID)
)
engine = InnoDB;

/*==============================================================*/
/* Table: PERSONAL                                              */
/*==============================================================*/
create table PERSONAL
(
   PERSONAL_ID          int not null auto_increment,
   JOB_ID               int,
   PERSONAL_NAME        text not null,
   PERSONAL_SURNAME     text not null,
   PERSONAL_PATRONYMIC  text,
   PERSONAL_PERMITION   int not null,
   PERSONAL_LOGIN       text not null,
   PERSONAL_PASSWORD    text not null,
   primary key (PERSONAL_ID)
)
engine = InnoDB;

/*==============================================================*/
/* Table: PROC                                                  */
/*==============================================================*/
create table PROC
(
   PROC_ID              int not null auto_increment,
   PERSONAL_ID          int,
   DATE_ID              int,
   PROC_TYPE_ID         int,
   CLIENT_ID            int not null,
   primary key (PROC_ID)
)
engine = InnoDB;

/*==============================================================*/
/* Table: PROC_TYPE                                             */
/*==============================================================*/
create table PROC_TYPE
(
   PROC_TYPE_ID         int not null auto_increment,
   PROC_TYPE_NAME       text not null,
   primary key (PROC_TYPE_ID)
)
engine = InnoDB;

alter table ANALYSE add constraint FK_Reference_19 foreign key (DATE_ID)
      references DATE (DATE_ID) on delete restrict on update restrict;

alter table CLIENT_ANALYSE add constraint FK_Reference_3 foreign key (CLIENT_ID)
      references CLIENT (CLIENT_ID) on delete restrict on update restrict;

alter table CLIENT_ANALYSE add constraint FK_Reference_4 foreign key (ANALYSE_ID)
      references ANALYSE (ANALYSE_ID) on delete restrict on update restrict;

alter table CLIENT_DOCUMENT add constraint FK_Reference_1 foreign key (CLIENT_ID)
      references CLIENT (CLIENT_ID) on delete restrict on update restrict;

alter table CLIENT_DOCUMENT add constraint FK_Reference_2 foreign key (DOCUMENT_ID)
      references DOCUMET (DOCUMENT_ID) on delete restrict on update restrict;

alter table CLIENT_OPERATION add constraint FK_Reference_12 foreign key (OPERATION_ID)
      references OPERATION (OPERATION_ID) on delete restrict on update restrict;

alter table CLIENT_OPERATION add constraint FK_Reference_13 foreign key (CLIENT_ID)
      references CLIENT (CLIENT_ID) on delete restrict on update restrict;

alter table HISTORY add constraint FK_Reference_14 foreign key (DATE_ID)
      references DATE (DATE_ID) on delete restrict on update restrict;

alter table HISTORY add constraint FK_Reference_20 foreign key (PERSONAL_ID)
      references PERSONAL (PERSONAL_ID) on delete restrict on update restrict;

alter table HISTORY add constraint FK_Reference_21 foreign key (CLIENT_ID)
      references CLIENT (CLIENT_ID) on delete restrict on update restrict;

alter table OPERATION add constraint FK_Reference_10 foreign key (PERSONAL_ID)
      references PERSONAL (PERSONAL_ID) on delete restrict on update restrict;

alter table OPERATION add constraint FK_Reference_11 foreign key (DATE_ID)
      references DATE (DATE_ID) on delete restrict on update restrict;

alter table OPERATION add constraint FK_Reference_18 foreign key (OPERATION_TYPE_ID)
      references OPERATION_TYPE (OPERATION_TYPE_ID) on delete restrict on update restrict;

alter table PERSONAL add constraint FK_Reference_7 foreign key (JOB_ID)
      references JOB (JOB_ID) on delete restrict on update restrict;

alter table PROC add constraint FK_Reference_17 foreign key (PROC_TYPE_ID)
      references PROC_TYPE (PROC_TYPE_ID) on delete restrict on update restrict;

alter table PROC add constraint FK_Reference_22 foreign key (CLIENT_ID)
      references CLIENT (CLIENT_ID) on delete restrict on update restrict;

alter table PROC add constraint FK_Reference_8 foreign key (PERSONAL_ID)
      references PERSONAL (PERSONAL_ID) on delete restrict on update restrict;

alter table PROC add constraint FK_Reference_9 foreign key (DATE_ID)
      references DATE (DATE_ID) on delete restrict on update restrict;

/*==============================================================*/
/* DBMS name:      MySQL 5.0                                    */
/* Created on:     22.12.2016 14:16:55                          */
/*==============================================================*/


/*==============================================================*/
/* Index: I_PROC_AK                                             */
/*==============================================================*/
create unique index I_PROC_AK on PROC
(
   PERSONAL_ID,
   DATE_ID
);

