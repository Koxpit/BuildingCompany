USE BuildingCompany;

INSERT INTO Material (Name, UnitOfMeasure)
VALUES ('���������', '30�� �� 210��'), ('�����', '��.'), ('�����', '��.'), ('�������', '��.'), ('�����', '��.'), ('����', '��.'), ('������', '��.')

INSERT INTO Profession (Name)
VALUES ('��������'), ('���������'), ('���������'), ('��������'), ('����������'), ('��������'), ('�����')

INSERT INTO Worker (FIO, PhoneNumber, Comment)
VALUES ('���� � �', '89112253442', ''), ('��������� � �', '89112253433', ''), ('������ �. �', '89112253490', '')

INSERT INTO TypeOfFacility (Name)
VALUES ('������'), ('����������'), ('��������')

INSERT INTO Facility (Name, Address, TypeOfFacilityID)
VALUES ('����� ������', '�. ������, ��. �������� ����', 1), ('��������������� ���', '�. �������, ��. ��������������', 1), ('�������������� ����� ���', '�. ������, ��. ���������������', 1), ('�������', '�. ������, ��. �������', 1)

INSERT INTO ProfessionWorker (WorkerID, ProfessionID)
VALUES (1, 1), (2, 2)

INSERT INTO Brigade (Name, Brigadier, Comment)
VALUES ('������� 1', 3, '')

INSERT INTO MembershipBrigade (BrigadeID, WorkerID)
VALUES (1, 1), (1, 2), (1, 3)

INSERT INTO Schedule (FacilityID, WorkDescription, BrigadeID, Comment, EndingDate)
VALUES (1, '���������� ������', 1, '', '2021-01-29'), (2, '������ ��������', 1, '', '2021-01-15'), (3, '������ �������', 1, '', '2021-02-20')

INSERT INTO UseOfMaterial (FacilityID, BrigadeID, MaterialID, Amount)
VALUES (1, 1, 1, 10), (2, 1, 2, 10), (3, 1, 4, 10)
