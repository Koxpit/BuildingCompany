USE BuildingCompany;

GO
CREATE PROCEDURE sp_GetCurrentWorks
AS
BEGIN
SELECT Facility.Name AS 'Объект', TypeOfFacility.Name AS 'Тип объекта', Facility.Address AS 'Адрес объекта', 
WorkDescription AS 'Описание работы', Brigade.Name AS 'Бригада', Worker.FIO AS 'Бригадир', Worker.PhoneNumber AS 'Номер бригадира',
Brigade.Comment AS 'Комментарии о бригаде', Schedule.Comment AS 'Комментарии к работе', EndingDate AS 'Окончание работы' 
FROM Schedule
JOIN Facility ON Schedule.FacilityID = Facility.ID
JOIN TypeOfFacility ON Facility.TypeOfFacilityID = TypeOfFacility.ID
JOIN Brigade ON Schedule.BrigadeID = Brigade.ID
JOIN Worker ON Brigade.Brigadier = Worker.ID
WHERE GETDATE() < EndingDate
ORDER BY EndingDate
END

GO
CREATE PROCEDURE sp_GetBrigades
AS
SELECT Brigade.ID, Name AS 'Название', 
Brigadier AS 'Бригадир ID', Worker.FIO AS 'ФИО бригадира', Worker.PhoneNumber AS 'Телефон бригадира', 
Brigade.Comment AS 'Комментарий'
FROM Brigade
JOIN Worker ON Brigade.Brigadier = Worker.ID

GO
CREATE PROCEDURE sp_GetBrigadierID
@ID INT
AS
SELECT Brigadier FROM Brigade
WHERE Brigadier = @ID

GO
CREATE PROCEDURE sp_GetMembershipBrigades
AS
SELECT MembershipBrigade.ID, BrigadeID AS 'ID бригады', Brigade.Name AS 'Название бригады', Brigade.Brigadier AS 'ID бригадира', 
WorkerID AS 'ID рабочего', Worker.FIO AS 'ФИО рабочего', Worker.PhoneNumber AS 'Телефон рабочего'
FROM MembershipBrigade
JOIN Brigade ON MembershipBrigade.BrigadeID = Brigade.ID
JOIN Worker ON MembershipBrigade.WorkerID = Worker.ID

GO
CREATE PROCEDURE sp_GetBrigadeID
@ID INT
AS
SELECT ID FROM Brigade
WHERE ID = @ID

GO
CREATE PROCEDURE sp_GetWorkerID
@ID INT
AS
SELECT ID FROM Worker
WHERE ID = @ID

GO
CREATE PROCEDURE sp_GetMembershipBrigadeId
@BrigadeID INT,
@WorkerID INT
AS
SELECT ID FROM MembershipBrigade
WHERE BrigadeID = @BrigadeID AND WorkerID = @WorkerID

GO
CREATE PROCEDURE sp_GetWorkerIdByPhoneNumber
@PhoneNumber VARCHAR(11)
AS
SELECT ID FROM Worker
WHERE PhoneNumber = @PhoneNumber

GO
CREATE PROCEDURE sp_GetWorkers
AS
SELECT ID, FIO AS 'ФИО', PhoneNumber AS 'Номер телефона', Comment AS 'Комментарии' 
FROM Worker

GO
CREATE PROCEDURE sp_GetProfessionWorker
AS
SELECT ProfessionWorker.ID, 
WorkerID AS 'ID работника', ProfessionID AS 'ID специальности', Profession.Name AS 'Название специальности' 
FROM ProfessionWorker
JOIN Profession ON ProfessionWorker.ProfessionID = Profession.ID

GO
CREATE PROCEDURE sp_GetProfessionID
@ID INT
AS
SELECT ID FROM Profession
WHERE ID = @ID

GO
CREATE PROCEDURE sp_GetProfessionWorkerID
@WorkerID INT,
@ProfessionID INT
AS
SELECT ID FROM ProfessionWorker
WHERE WorkerID = @WorkerID AND ProfessionID = @ProfessionID

GO
CREATE PROCEDURE sp_GetProfessions
AS
SELECT ID, Name AS 'Наименование' FROM Profession 

GO
CREATE PROCEDURE sp_GetProfessionIdByName
@Name NVARCHAR(100)
AS
SELECT ID FROM Profession
WHERE Name = @Name

GO
CREATE PROCEDURE sp_GetMaterialIdByName
@Name NVARCHAR(100)
AS
SELECT ID FROM Material
WHERE Name = @Name

GO
CREATE PROCEDURE sp_GetMaterials
AS
SELECT ID, Name AS 'Наименование', UnitOfMeasure AS 'Ед. измерения'
FROM Material

GO
CREATE PROCEDURE sp_GetUseOfMaterials
AS
SELECT UseOfMaterial.ID, 
FacilityID AS 'ID объекта', Facility.Name AS 'Название объекта', Facility.Address AS 'Адрес объекта', 
BrigadeID AS 'ID бригады', Brigade.Name AS 'Название бригады', Worker.FIO AS 'ФИО бригадира', Worker.PhoneNumber AS 'Номер телефона бригадира', 
MaterialID AS 'ID материала', Material.Name AS 'Название материала', Amount AS 'Количество' 
FROM UseOfMaterial
JOIN Facility ON UseOfMaterial.FacilityID = Facility.ID
JOIN Brigade ON UseOfMaterial.BrigadeID = Brigade.ID
JOIN Worker ON Brigade.Brigadier = Worker.ID
JOIN Material ON UseOfMaterial.MaterialID = Material.ID

GO
CREATE PROCEDURE sp_GetMaterialID
@ID INT
AS
SELECT ID FROM Material
WHERE ID = @ID

GO
CREATE PROCEDURE sp_GetFacilityID
@ID INT
AS
SELECT ID FROM Facility
WHERE ID = @ID

GO
CREATE PROCEDURE sp_GetFacilities
AS
SELECT Facility.ID, 
Facility.Name AS 'Наименование', Address AS 'Адрес', TypeOfFacilityID AS 'ID типа объекта', TypeOfFacility.Name AS 'Тип' 
FROM Facility
JOIN TypeOfFacility ON Facility.TypeOfFacilityID = TypeOfFacility.ID

GO
CREATE PROCEDURE sp_GetTypeOfFacilityID
@ID INT
AS
SELECT ID FROM TypeOfFacility
WHERE ID = @ID

GO
CREATE PROCEDURE sp_GetTypesOfFacilities
AS
SELECT ID, Name AS 'Наименование' FROM TypeOfFacility

GO
CREATE PROCEDURE sp_GetSchedules
AS
SELECT Schedule.ID, 
FacilityID AS 'ID объекта', Facility.Name AS 'Название объекта', Facility.Address AS 'Адрес объекта', TypeOfFacility.Name AS 'Тип объекта', 
WorkDescription AS 'Описание работы', 
BrigadeID AS 'ID бригады', Brigade.Name AS 'Название бригады', 
Worker.FIO AS 'ФИО бригадира', Worker.PhoneNumber AS 'Номер бригадира', 
Schedule.Comment AS 'Комментарии', EndingDate  AS 'Крайний срок'
FROM Schedule
JOIN Facility ON Schedule.FacilityID = Facility.ID
JOIN TypeOfFacility ON Facility.TypeOfFacilityID = TypeOfFacility.ID
JOIN Brigade ON Schedule.BrigadeID = Brigade.ID
JOIN Worker ON Brigade.Brigadier = Worker.ID

GO
CREATE PROCEDURE sp_GetSchedulesInPeriod
@BeginDate DATE,
@EndDate DATE
AS
SELECT Schedule.ID, 
FacilityID AS 'ID объекта', Facility.Name AS 'Название объекта', Facility.Address AS 'Адрес объекта', TypeOfFacility.Name AS 'Тип объекта', 
WorkDescription AS 'Описание работы', 
BrigadeID AS 'ID бригады', Brigade.Name AS 'Название бригады', 
Worker.FIO AS 'ФИО бригадира', Worker.PhoneNumber AS 'Номер бригадира', 
Schedule.Comment AS 'Комментарии', EndingDate  AS 'Крайний срок'
FROM Schedule
JOIN Facility ON Schedule.FacilityID = Facility.ID
JOIN TypeOfFacility ON Facility.TypeOfFacilityID = TypeOfFacility.ID
JOIN Brigade ON Schedule.BrigadeID = Brigade.ID
JOIN Worker ON Brigade.Brigadier = Worker.ID
WHERE EndingDate BETWEEN @BeginDate AND @EndDate