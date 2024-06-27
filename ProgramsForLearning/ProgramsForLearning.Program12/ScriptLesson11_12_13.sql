 
 --Para hacer comentarios en sql se usan -- o tambien se usa /**/
 --Select, Insert, Update, Delete


 --select NombresDeCamposSeparadosPorComaPonemosAsteriscoSiDeseamosTodosLosRegistros from NombreTabla where CondicionDeseada
 --and, or, not &&, || !
 select c.*, c.Name from Contacts c where DebAmount> 100000 and  sexid=2  ; 
 select   c.Name from Contacts c where DebAmount> 100000 and  sexid=2  ; 

/*insert into NombreTabla (NombresDeCamposDondeInsertaremosValoresSeparadosPorComa) 
 values (ValoresPorInsertarEnLosCamposQueHayamosPuestoPreviamenteSeparadosPorComaYEnElMismoOrden)
 */
INSERT INTO  Contacts 
           (ContactId  ,Name   ,LastName   ,Email ,Age  ,IsFavorite  --,BornDate
           ,DebAmount  ,SexId  ,Phone)
     VALUES
           (9 , 'Carmelo', 'Rubio', 'carlos@email.com', 15 ,0 , --null, 
          '150.54' , 2  , '234234234234');
;

/*Update NombreTabla set CampoPorActualizar = ValorPorActualizar Where Condicion*/

update Contacts set name='Alberto', LastName = 'Castro', sexid=1 where contactId = 6;

update Contacts set DebAmount=0 where DebAmount <= 10000;
 --select * from Contacts where contactId = 6;

 --delete from TablaPorEliminarElRegistro Where CondicionDeEliminacion 

 delete from contacts where contactId = 2;
 -----------------------------------



 select Contacts.name, Contacts.LastName, (select sex.name from sex   where sex.sexid = Contacts.sexid) 
 from Contacts where Contacts.DebAmount > 10000  ;

  select c.name, c.LastName, (select s.name from sex as s  where s.sexid = c.sexid) 
 from Contacts as c where c.DebAmount > 10000  ;

   select c.name, c.LastName, (select s.name from sex   s  where s.sexid = c.sexid) 
 from Contacts   c where c.DebAmount > 10000  ;


 select c.name, c.LastName,   s.name   
 from Contacts   c, sex s 
 where s.SexId = c.SexId and  c.DebAmount > 10000  ;

  select c.*,   s.name as SexName  
 from Contacts   c 
 inner join sex s on s.SexId = c.SexId
 where   c.DebAmount > 10000  ;

   select c.*,   s.name   SexName  
 from Contacts   c 
 inner join sex s on s.SexId = c.SexId
 where   c.DebAmount > 10000  ;


 
 select *  from vContacts2  
 where    DebAmount > 10000
 order by contactid desc;
	

 
 --Creacion de las vistas
 /*
CREATE VIEW  vContacts2
AS
SELECT c.ContactId, c.Name, c.LastName, c.Email, c.Age, c.IsFavorite, c.BornDate, c.DebAmount, c.SexId, c.Phone, s.Name AS SexName
FROM  dbo.Contacts AS c INNER JOIN
         dbo.Sex AS s ON s.SexId = c.SexId
 ;
*/
 

 /*

 INSERT INTO  vContacts2 
           (ContactId  ,Name   ,LastName   ,Email ,Age  ,IsFavorite  --,BornDate
           ,DebAmount  ,SexId  ,Phone)
     VALUES
           (10 , 'Carmelo', 'Rubio', 'carlos@email.com', 15 ,0 , --null, 
          '150.54' , 2  , '234234234234');
;
*/

/*

creando store procedure

create PROCEDURE [dbo].[AddContact] 
	@ContactId int,
	@Name varchar(50), 
	@LastName varchar(50), 
	 @Email varchar(30), 
	 @Age int =0, 
	 @BornDate Date = null, 
	 @DebAmount decimal (11,2) = 0, 
	 @SexId int = 1, 
	 @Phone varchar (15), 
	 @Sussess bit = 0 output
AS
BEGIN
	INSERT INTO  Contacts 
           (ContactId  ,Name   ,LastName   ,Email ,Age  ,IsFavorite   ,BornDate
           ,DebAmount  ,SexId  ,Phone)
     VALUES
           (@ContactId , @Name, @LastName, @Email, @Age ,0 ,  @BornDate, 
          @DebAmount , @SexId  , @Phone);
set @Sussess = 1;
END
ejecutando un store procedure


EXEC	 AddContact
	  12,
		 N'Pedro',
	  N'pe',
	  N'pedroperdope@email.com',10,null,
		  15000, 1,
		  N'151546546' 
 

 ---otra forma

 
DECLARE	@return_value int,
		@Sussess bit

EXEC	@return_value =  AddContact 
		@ContactId = 14,
		@Name = N'Pedro',
		@LastName = N'pe',
		@Email = N'pedroperdope@email.com',
		@DebAmount = 15000,
		@Phone = N'151546546',
		@Sussess = @Sussess OUTPUT

SELECT	@Sussess as N'@Sussess'

SELECT	'Return Value' = @return_value

*/


/*triggers disparadores de eventos


CREATE TRIGGER TrAfterInsert
   ON  Contacts
   AFTER  INSERT 
AS 
BEGIN
	declare @contactId int ,  @Name varchar(50),  @LastName varchar(50),   @Email varchar(30),   @Age int =0, 
	 @BornDate Date = null,   @DebAmount decimal (11,2) = 0,   @SexId int = 1,   @Phone varchar (15); 

	 select  @contactId = inserted.contactId, @Name = inserted.name 
	 from inserted;

	 insert into ContactsHistories(contactId, Name) values (@contactId,@Name);

END



*/
select * from contacts
select * from ContactsHistories

------

DECLARE @i INT = 15;
DECLARE @max INT = 1000000;

WHILE @i <= @max
BEGIN
    INSERT INTO Contacts 
           (ContactId, Name, LastName, Email, Age, IsFavorite, DebAmount, SexId, Phone)
     VALUES
           (@i, 'Carmelo', 'Rubio', cast( @i as varchar(50)) + '@email.com', 15, 0, '0.00', 2, '');

    SET @i = @i + 1;
END;

--optener la cantidad de registros que cumplen una condicion 
select count(*) from contacts  where DebAmount > 10000;

--permite devolver los valores donde no se dupliquen todos los campos que se indiquen
 select distinct    name , lastname, email,   debamount   from Contacts order by contactid desc

----me permite limitar la cnatidad de registros a devolver
 select top 100    name , lastname, email, debamount  from Contacts order by contactid desc

 --se usa para filtrar contenido que se contenga en el campo indicado
 select * from contacts where email like  '%@email.com%'

 --crear indices
 create index idx_contact_email on Contacts (Email);

 

 SELECT top 5  c.ContactId, Name, c.LastName, c.Email, c.Age, c.IsFavorite, c.BornDate, c.DebAmount, c.SexId, c.Phone, s.Name AS SexName
FROM  dbo.Contacts AS c INNER JOIN
         dbo.Sex AS s ON s.SexId = c.SexId


		 select * from contacts where email like  '%999999%'


		 begin transaction ; 
		 update contacts set IsFavorite = 0


		  select count (*) from contacts where IsFavorite = 1

		  rollback

		  commit


	 