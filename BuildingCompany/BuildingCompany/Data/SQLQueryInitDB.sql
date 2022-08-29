USE BuildingCompany;

INSERT INTO Material (Name, UnitOfMeasure)
VALUES ('Древесина', '30см на 210см'), ('Бетон', 'кг.'), ('Чугун', 'кг.'), ('Рулетка', 'шт.'), ('Топор', 'шт.'), ('Пила', 'шт.'), ('Кирпич', 'шт.')

INSERT INTO Profession (Name)
VALUES ('Бетонщик'), ('Геодезист'), ('Экономист'), ('Технолог'), ('Кровельщик'), ('Каменщик'), ('Маляр')

INSERT INTO Worker (FIO, PhoneNumber, Comment)
VALUES ('Олег А П', '89112253442', ''), ('Владислав В М', '89112253433', ''), ('Даниил Е. Г', '89112253490', '')

INSERT INTO TypeOfFacility (Name)
VALUES ('Здание'), ('Сооружение'), ('Строение')

INSERT INTO Facility (Name, Address, TypeOfFacilityID)
VALUES ('Жилое здание', 'г. Москва, ул. Проспект мира', 1), ('Многоквартирный дом', 'г. Михнево, ул. Второстепенная', 1), ('Индивидуальный жилой дом', 'г. Мытищи, ул. Староситненская', 1), ('Коттедж', 'г. Москва, ул. Пушкина', 1)

INSERT INTO ProfessionWorker (WorkerID, ProfessionID)
VALUES (1, 1), (2, 2)

INSERT INTO Brigade (Name, Brigadier, Comment)
VALUES ('Бригада 1', 3, '')

INSERT INTO MembershipBrigade (BrigadeID, WorkerID)
VALUES (1, 1), (1, 2), (1, 3)

INSERT INTO Schedule (FacilityID, WorkDescription, BrigadeID, Comment, EndingDate)
VALUES (1, 'Отделочные работы', 1, '', '2021-01-29'), (2, 'Ремонт подъезда', 1, '', '2021-01-15'), (3, 'Ремонт террасы', 1, '', '2021-02-20')

INSERT INTO UseOfMaterial (FacilityID, BrigadeID, MaterialID, Amount)
VALUES (1, 1, 1, 10), (2, 1, 2, 10), (3, 1, 4, 10)
