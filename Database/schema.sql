-- Drop constraints
if exists (select 1 from sys.foreign_keys where name = 'FK_FEEDBACK_DESCRIBES_MEAL')
   alter table FEEDBACK drop constraint FK_FEEDBACK_DESCRIBES_MEAL
go

if exists (select 1 from sys.foreign_keys where name = 'FK_FEEDBACK_GIVE_A_USER')
   alter table FEEDBACK drop constraint FK_FEEDBACK_GIVE_A_USER
go

if exists (select 1 from sys.foreign_keys where name = 'FK_ORDER_HAS_A2_PAYMENT')
   alter table "ORDER" drop constraint FK_ORDER_HAS_A2_PAYMENT
go

if exists (select 1 from sys.foreign_keys where name = 'FK_ORDER_ORDER_USER')
   alter table "ORDER" drop constraint FK_ORDER_ORDER_USER
go

if exists (select 1 from sys.foreign_keys where name = 'FK_ORDER_DE_ORDER_DET_ORDER')
   alter table ORDER_DETAILS drop constraint FK_ORDER_DE_ORDER_DET_ORDER
go

if exists (select 1 from sys.foreign_keys where name = 'FK_ORDER_DE_ORDER_DET_MEAL')
   alter table ORDER_DETAILS drop constraint FK_ORDER_DE_ORDER_DET_MEAL
go

if exists (select 1 from sys.foreign_keys where name = 'FK_PAYMENT_HAS_A_ORDER')
   alter table PAYMENT drop constraint FK_PAYMENT_HAS_A_ORDER
go

-- Drop tables
drop table if exists FEEDBACK
drop table if exists MEAL
drop table if exists ORDER_DETAILS
drop table if exists "ORDER"
drop table if exists PAYMENT
drop table if exists "USER"
go

-- Table: USER
create table "USER" (
   USER_ID numeric not null,
   USER_NAME NVARCHAR(MAX) NOT NULL,
   PHONE numeric not null,
   ROLE varchar(1024) not null,
   BALANCE float null,
   constraint PK_USER primary key (USER_ID)
)
go

-- Table: MEAL
create table MEAL (
   MEAL_NAME varchar(255) not null,
   CATEGORY varchar(255) not null check (
       CATEGORY IN (
           'Appetizers', 'Main Course', 'Side Dishes', 'Salads',
           'Soup', 'Sandwiches and Wraps', 'Desserts', 'Beverages'
       )),
   PRICE money not null,
   DESCRIPTION varchar(255) not null,
   CALORIES varchar(255) not null,
   AVAILABILITY bit not null,
   SEASON varchar(255) null,
   constraint PK_MEAL primary key (MEAL_NAME)
)
go

-- Table: PAYMENT
create table PAYMENT (
   PAYMENTID int identity(1,1) not null,
   ORDER_ID int not null,
   AMOUNT float not null,
   METHOD varchar(1024) not null,
   PAYMENTDATE datetime not null,
   constraint PK_PAYMENT primary key (PAYMENTID)
)
go

-- Table: ORDER
create table "ORDER" (
   ORDER_ID int identity(1,1),
   PAYMENTID int null,
   USER_ID numeric not null,
   ORDER_DATE datetime not null,
   STATUS varchar(1024) not null,
   constraint PK_ORDER primary key (ORDER_ID)
)
go

-- Table: ORDER_DETAILS
create table ORDER_DETAILS (
   ORDER_ID int not null,
   MEAL_NAME varchar(255) not null,
   QUANTITY int null,
   constraint PK_ORDER_DETAILS primary key (ORDER_ID, MEAL_NAME)
)
go

-- Table: FEEDBACK
create table FEEDBACK (
   USER_ID numeric not null,
   FEEDBACKID int identity(1,1),
   MEAL_NAME varchar(255) not null,
   COMMENT varchar(1024) null,
   RATING INT NOT NULL CHECK (Rating BETWEEN 1 AND 5),
   FEEDBACKDATE datetime not null,
   constraint PK_FEEDBACK primary key (USER_ID, FEEDBACKID)
)
go

-- Indexes
create index GIVE_A_FK on FEEDBACK (USER_ID)
create index DESCRIBES_FK on FEEDBACK (MEAL_NAME)
create index ORDER_FK on "ORDER" (USER_ID)
create index HAS_A2_FK on "ORDER" (PAYMENTID)
create index ORDER_DETAILS_FK on ORDER_DETAILS (ORDER_ID)
create index ORDER_DETAILS2_FK on ORDER_DETAILS (MEAL_NAME)
create index HAS_A_FK on PAYMENT (ORDER_ID)
go

-- Foreign keys
alter table FEEDBACK add constraint FK_FEEDBACK_DESCRIBES_MEAL foreign key (MEAL_NAME) references MEAL (MEAL_NAME) ON UPDATE CASCADE ON DELETE CASCADE
alter table FEEDBACK add constraint FK_FEEDBACK_GIVE_A_USER foreign key (USER_ID) references "USER" (USER_ID) ON UPDATE CASCADE ON DELETE CASCADE
alter table "ORDER" add constraint FK_ORDER_HAS_A2_PAYMENT foreign key (PAYMENTID) references PAYMENT (PAYMENTID) ON UPDATE CASCADE ON DELETE CASCADE
alter table "ORDER" add constraint FK_ORDER_ORDER_USER foreign key (USER_ID) references "USER" (USER_ID) ON UPDATE CASCADE ON DELETE CASCADE
alter table ORDER_DETAILS add constraint FK_ORDER_DE_ORDER_DET_ORDER foreign key (ORDER_ID) references "ORDER" (ORDER_ID) ON UPDATE CASCADE ON DELETE CASCADE
alter table ORDER_DETAILS add constraint FK_ORDER_DE_ORDER_DET_MEAL foreign key (MEAL_NAME) references MEAL (MEAL_NAME) ON UPDATE CASCADE ON DELETE CASCADE
go

