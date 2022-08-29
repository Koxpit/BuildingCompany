USE BuildingCompany;

GO
CREATE PROCEDURE sp_GetCurrentWorks
AS
BEGIN
SELECT Facility.Name AS '������', TypeOfFacility.Name AS '��� �������', Facility.Address AS '����� �������', 
WorkDescription AS '�������� ������', Brigade.Name AS '�������', Worker.FIO AS '��������', Worker.PhoneNumber AS '����� ���������',
Brigade.Comment AS '����������� � �������', Schedule.Comment AS '����������� � ������', EndingDate AS '��������� ������' 
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
SELECT Brigade.ID, Name AS '��������', 
Brigadier AS '�������� ID', Worker.FIO AS '��� ���������', Worker.PhoneNumber AS '������� ���������', 
Brigade.Comment AS '�����������'
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
SELECT MembershipBrigade.ID, BrigadeID AS 'ID �������', Brigade.Name AS '�������� �������', Brigade.Brigadier AS 'ID ���������', 
WorkerID AS 'ID ��������', Worker.FIO AS '��� ��������', Worker.PhoneNumber AS '������� ��������'
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
SELECT ID, FIO AS '���', PhoneNumber AS '����� ��������', Comment AS '�����������' 
FROM Worker

GO
CREATE PROCEDURE sp_GetProfessionWorker
AS
SELECT ProfessionWorker.ID, 
WorkerID AS 'ID ���������', ProfessionID AS 'ID �������������', Profession.Name AS '�������� �������������' 
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
SELECT ID, Name AS '������������' FROM Profession 

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
SELECT ID, Name AS '������������', UnitOfMeasure AS '��. ���������'
FROM Material

GO
CREATE PROCEDURE sp_GetUseOfMaterials
AS
SELECT UseOfMaterial.ID, 
FacilityID AS 'ID �������', Facility.Name AS '�������� �������', Facility.Address AS '����� �������', 
BrigadeID AS 'ID �������', Brigade.Name AS '�������� �������', Worker.FIO AS '��� ���������', Worker.PhoneNumber AS '����� �������� ���������', 
MaterialID AS 'ID ���������', Material.Name AS '�������� ���������', Amount AS '����������' 
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
Facility.Name AS '������������', Address AS '�����', TypeOfFacilityID AS 'ID ���� �������', TypeOfFacility.Name AS '���' 
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
SELECT ID, Name AS '������������' FROM TypeOfFacility

GO
CREATE PROCEDURE sp_GetSchedules
AS
SELECT Schedule.ID, 
FacilityID AS 'ID �������', Facility.Name AS '�������� �������', Facility.Address AS '����� �������', TypeOfFacility.Name AS '��� �������', 
WorkDescription AS '�������� ������', 
BrigadeID AS 'ID �������', Brigade.Name AS '�������� �������', 
Worker.FIO AS '��� ���������', Worker.PhoneNumber AS '����� ���������', 
Schedule.Comment AS '�����������', EndingDate  AS '������� ����'
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
FacilityID AS 'ID �������', Facility.Name AS '�������� �������', Facility.Address AS '����� �������', TypeOfFacility.Name AS '��� �������', 
WorkDescription AS '�������� ������', 
BrigadeID AS 'ID �������', Brigade.Name AS '�������� �������', 
Worker.FIO AS '��� ���������', Worker.PhoneNumber AS '����� ���������', 
Schedule.Comment AS '�����������', EndingDate  AS '������� ����'
FROM Schedule
JOIN Facility ON Schedule.FacilityID = Facility.ID
JOIN TypeOfFacility ON Facility.TypeOfFacilityID = TypeOfFacility.ID
JOIN Brigade ON Schedule.BrigadeID = Brigade.ID
JOIN Worker ON Brigade.Brigadier = Worker.ID
WHERE EndingDate BETWEEN @BeginDate AND @EndDate