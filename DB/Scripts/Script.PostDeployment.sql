DECLARE @SeedUsers TABLE (
    [Username] NVARCHAR(50),
    [Password] NVARCHAR(255),
    [Role] NVARCHAR(20),
    [IsActive] BIT
);

INSERT INTO @SeedUsers ([Username], [Password], [Role], [IsActive]) VALUES
('admin', 'admin123', 'Admin', 1),
('registrar', 'registrar123', 'Registrar', 1),
('cashier', 'cashier123', 'Cashier', 1);

MERGE INTO [dbo].[Users] AS Target
USING @SeedUsers AS Source
ON (Target.[Username] = Source.[Username])

WHEN MATCHED THEN
    UPDATE SET 
        Target.[Role] = Source.[Role],
        Target.[IsActive] = Source.[IsActive]

WHEN NOT MATCHED BY TARGET THEN
    INSERT ([Username], [Password], [Role], [IsActive])
    VALUES (Source.[Username], Source.[Password], Source.[Role], Source.[IsActive]);










    GO

MERGE INTO [dbo].[GradeLevels] AS Target
USING (VALUES 
    ('Grade 7',  12000.00, 3500.00),
    ('Grade 8',  12500.00, 3500.00),
    ('Grade 9',  13000.00, 3800.00),
    ('Grade 10', 13500.00, 4000.00)
) AS Source ([GradeLevelName], [TuitionFee], [MiscellaneousFee])
ON (Target.[GradeLevelName] = Source.[GradeLevelName])
WHEN MATCHED THEN
    UPDATE SET 
        [TuitionFee] = Source.[TuitionFee],
        [MiscellaneousFee] = Source.[MiscellaneousFee]
WHEN NOT MATCHED BY TARGET THEN
    INSERT ([GradeLevelName], [TuitionFee], [MiscellaneousFee])
    VALUES (Source.[GradeLevelName], Source.[TuitionFee], Source.[MiscellaneousFee]);
GO



-- Seed initial Sections for School Year 2026-2027
DECLARE @SeedSections TABLE (
    [SectionName] NVARCHAR(50),
    [GradeLevelName] NVARCHAR(50),
    [SchoolYear] NVARCHAR(20),
    [Adviser] NVARCHAR(100),
    [MaxCapacity] INT
);

INSERT INTO @SeedSections ([SectionName], [GradeLevelName], [SchoolYear], [Adviser], [MaxCapacity]) VALUES
('Rizal', 'Grade 7', '2026-2027', 'Ms. Elena Santos', 40),
('Bonifacio', 'Grade 7', '2026-2027', 'Mr. Marco Reyes', 40),
('Mabini', 'Grade 8', '2026-2027', 'Ms. Clara Cruz', 40),
('Luna', 'Grade 9', '2026-2027', 'Mr. Jose Bautista', 40),
('Del Pilar', 'Grade 10', '2026-2027', 'Ms. Sofia Garcia', 40);

MERGE INTO [dbo].[Sections] AS Target
USING (
    SELECT 
        s.[SectionName],
        g.[GradeLevelID],
        s.[SchoolYear],
        s.[Adviser],
        s.[MaxCapacity]
    FROM @SeedSections s
    INNER JOIN [dbo].[GradeLevels] g ON s.[GradeLevelName] = g.[GradeLevelName]
) AS Source
ON (
    Target.[SectionName] = Source.[SectionName] 
    AND Target.[GradeLevelID] = Source.[GradeLevelID] 
    AND Target.[SchoolYear] = Source.[SchoolYear]
)
WHEN NOT MATCHED BY TARGET THEN
    INSERT ([SectionName], [GradeLevelID], [SchoolYear], [Adviser], [MaxCapacity])
    VALUES (Source.[SectionName], Source.[GradeLevelID], Source.[SchoolYear], Source.[Adviser], Source.[MaxCapacity]);
GO








GO

-- Seed 50 Sample High School Students
DECLARE @SeedStudents TABLE (
    [StudentNumber] NVARCHAR(30),
    [FirstName] NVARCHAR(50),
    [MiddleName] NVARCHAR(50),
    [LastName] NVARCHAR(50),
    [DateOfBirth] DATE,
    [Gender] NVARCHAR(15),
    [Address] NVARCHAR(255),
    [ContactNumber] NVARCHAR(20),
    [Email] NVARCHAR(100),
    [GuardianName] NVARCHAR(100),
    [GuardianContact] NVARCHAR(20)
);

INSERT INTO @SeedStudents VALUES
('2026-0001', 'Juan', 'Santos', 'Dela Cruz', '2013-04-12', 'Male', 'Brgy. Poblacion, Balayan, Batangas', '09171000001', 'juan.delacruz@email.com', 'Roberto Dela Cruz', '09181000001'),
('2026-0002', 'Maria', 'Reyes', 'Santos', '2013-07-23', 'Female', 'Brgy. Ermita, Balayan, Batangas', '09171000002', 'maria.santos@email.com', 'Elena Santos', '09181000002'),
('2026-0003', 'Jose', 'Cruz', 'Reyes', '2013-01-15', 'Male', 'Brgy. Caloocan, Balayan, Batangas', '09171000003', 'jose.reyes@email.com', 'Marco Reyes', '09181000003'),
('2026-0004', 'Ana', 'Bautista', 'Garcia', '2013-09-08', 'Female', 'Brgy. Lanatan, Balayan, Batangas', '09171000004', 'ana.garcia@email.com', 'Sofia Garcia', '09181000004'),
('2026-0005', 'Carlo', 'Mendoza', 'Bautista', '2013-11-30', 'Male', 'Brgy. Gumamela, Balayan, Batangas', '09171000005', 'carlo.bautista@email.com', 'Jose Bautista', '09181000005'),
('2026-0006', 'Sofia', 'Lopez', 'Mendoza', '2013-02-19', 'Female', 'Brgy. San Piro, Balayan, Batangas', '09171000006', 'sofia.mendoza@email.com', 'Teresa Mendoza', '09181000006'),
('2026-0007', 'Miguel', 'Torres', 'Aquino', '2013-06-05', 'Male', 'Brgy. Navotas, Balayan, Batangas', '09171000007', 'miguel.aquino@email.com', 'Ramon Aquino', '09181000007'),
('2026-0008', 'Camille', 'Ramos', 'Villanueva', '2013-08-14', 'Female', 'Brgy. Dalig, Balayan, Batangas', '09171000008', 'camille.villanueva@email.com', 'Liza Villanueva', '09181000008'),
('2026-0009', 'Gabriel', 'Castillo', 'Fernandez', '2013-03-27', 'Male', 'Brgy. Carenahan, Balayan, Batangas', '09171000009', 'gabriel.fernandez@email.com', 'Antonio Fernandez', '09181000009'),
('2026-0010', 'Bea', 'Rivera', 'Flores', '2013-12-03', 'Female', 'Brgy. District 1, Balayan, Batangas', '09171000010', 'bea.flores@email.com', 'Carmen Flores', '09181000010'),
('2026-0011', 'Rafael', 'Gomez', 'Navarro', '2013-05-18', 'Male', 'Brgy. District 2, Balayan, Batangas', '09171000011', 'rafael.navarro@email.com', 'Eduardo Navarro', '09181000011'),
('2026-0012', 'Nicole', 'Morales', 'Domingo', '2013-10-21', 'Female', 'Brgy. District 3, Balayan, Batangas', '09171000012', 'nicole.domingo@email.com', 'Maricel Domingo', '09181000012'),
('2026-0013', 'Daniel', 'Pascual', 'Salazar', '2013-07-09', 'Male', 'Brgy. District 4, Balayan, Batangas', '09171000013', 'daniel.salazar@email.com', 'Vicente Salazar', '09181000013'),
('2026-0014', 'Angela', 'Perez', 'Delos Santos', '2012-04-02', 'Female', 'Brgy. Patugo, Balayan, Batangas', '09171000014', 'angela.delossantos@email.com', 'Gloria Delos Santos', '09181000014'),
('2026-0015', 'Christian', 'Diaz', 'Tolentino', '2012-08-29', 'Male', 'Brgy. Sampaga, Balayan, Batangas', '09171000015', 'christian.tolentino@email.com', 'Ricardo Tolentino', '09181000015'),
('2026-0016', 'Jasmine', 'Gutierrez', 'Soriano', '2012-01-11', 'Female', 'Brgy. Lucban, Balayan, Batangas', '09171000016', 'jasmine.soriano@email.com', 'Rosario Soriano', '09181000016'),
('2026-0017', 'Joshua', 'Castro', 'Mercado', '2012-09-17', 'Male', 'Brgy. Baclaran, Balayan, Batangas', '09171000017', 'joshua.mercado@email.com', 'Manuel Mercado', '09181000017'),
('2026-0018', 'Katrina', 'Alvarez', 'Manalo', '2012-11-06', 'Female', 'Brgy. Santol, Balayan, Batangas', '09171000018', 'katrina.manalo@email.com', 'Evelyn Manalo', '09181000018'),
('2026-0019', 'Mark', 'Jimenez', 'Valdez', '2012-03-25', 'Male', 'Brgy. Tanggoy, Balayan, Batangas', '09171000019', 'mark.valdez@email.com', 'Ernesto Valdez', '09181000019'),
('2026-0020', 'Patricia', 'Ruiz', 'Ocampo', '2012-06-14', 'Female', 'Brgy. Duhatan, Balayan, Batangas', '09171000020', 'patricia.ocampo@email.com', 'Rowena Ocampo', '09181000020'),
('2026-0021', 'Adrian', 'Vargas', 'Aguilar', '2012-12-19', 'Male', 'Brgy. Gimalas, Balayan, Batangas', '09171000021', 'adrian.aguilar@email.com', 'Fernando Aguilar', '09181000021'),
('2026-0022', 'Bianca', 'Romero', 'Evangelista', '2012-02-28', 'Female', 'Brgy. Lagnas, Balayan, Batangas', '09171000022', 'bianca.evangelista@email.com', 'Cristina Evangelista', '09181000022'),
('2026-0023', 'Kenneth', 'Herrera', 'Concepcion', '2012-05-07', 'Male', 'Brgy. Magabe, Balayan, Batangas', '09171000023', 'kenneth.concepcion@email.com', 'Arturo Concepcion', '09181000023'),
('2026-0024', 'Alyssa', 'Medina', 'Santiago', '2012-10-12', 'Female', 'Brgy. Malalay, Balayan, Batangas', '09171000024', 'alyssa.santiago@email.com', 'Luzviminda Santiago', '09181000024'),
('2026-0025', 'Patrick', 'Ortega', 'De Guzman', '2012-07-31', 'Male', 'Brgy. Munting Tubig, Balayan, Batangas', '09171000025', 'patrick.deguzman@email.com', 'Alfredo De Guzman', '09181000025'),
('2026-0026', 'Clarissa', 'Silvestre', 'Macapagal', '2011-04-20', 'Female', 'Brgy. Palikpikan, Balayan, Batangas', '09171000026', 'clarissa.macapagal@email.com', 'Imelda Macapagal', '09181000026'),
('2026-0027', 'Vincent', 'Ramos', 'Panganiban', '2011-08-03', 'Male', 'Brgy. Pooc, Balayan, Batangas', '09171000027', 'vincent.panganiban@email.com', 'Renato Panganiban', '09181000027'),
('2026-0028', 'Hannah', 'Cruz', 'Dimaculangan', '2011-01-26', 'Female', 'Brgy. Putol, Balayan, Batangas', '09171000028', 'hannah.dimaculangan@email.com', 'Corazon Dimaculangan', '09181000028'),
('2026-0029', 'Jerome', 'Santos', 'Ilagan', '2011-09-15', 'Male', 'Brgy. Sambat, Balayan, Batangas', '09171000029', 'jerome.ilagan@email.com', 'Danilo Ilagan', '09181000029'),
('2026-0030', 'Samantha', 'Bautista', 'Manansala', '2011-11-22', 'Female', 'Brgy. Sukol, Balayan, Batangas', '09171000030', 'samantha.manansala@email.com', 'Teresita Manansala', '09181000030'),
('2026-0031', 'Paolo', 'Garcia', 'Villamor', '2011-03-09', 'Male', 'Brgy. Taktak, Balayan, Batangas', '09171000031', 'paolo.villamor@email.com', 'Gregorio Villamor', '09181000031'),
('2026-0032', 'Denise', 'Lopez', 'Catapang', '2011-06-28', 'Female', 'Brgy. Taludtud, Balayan, Batangas', '09171000032', 'denise.catapang@email.com', 'Natividad Catapang', '09181000032'),
('2026-0033', 'Nathaniel', 'Mendoza', 'Marasigan', '2011-12-10', 'Male', 'Brgy. Calzada, Balayan, Batangas', '09171000033', 'nathaniel.marasigan@email.com', 'Rolando Marasigan', '09181000033'),
('2026-0034', 'Kirsten', 'Aquino', 'Hernandez', '2011-02-14', 'Female', 'Brgy. Caybunga, Balayan, Batangas', '09171000034', 'kirsten.hernandez@email.com', 'Milagros Hernandez', '09181000034'),
('2026-0035', 'Francis', 'Villanueva', 'Magtibay', '2011-05-30', 'Male', 'Brgy. Cayponce, Balayan, Batangas', '09171000035', 'francis.magtibay@email.com', 'Benjamin Magtibay', '09181000035'),
('2026-0036', 'Trisha', 'Fernandez', 'Atienza', '2011-10-04', 'Female', 'Brgy. Cumba, Balayan, Batangas', '09171000036', 'trisha.atienza@email.com', 'Remedios Atienza', '09181000036'),
('2026-0037', 'Dominic', 'Flores', 'Malabanan', '2011-07-17', 'Male', 'Brgy. Dalig, Balayan, Batangas', '09171000037', 'dominic.malabanan@email.com', 'Salvador Malabanan', '09181000037'),
('2026-0038', 'Aubrey', 'Navarro', 'Pascua', '2010-04-06', 'Female', 'Brgy. District 5, Balayan, Batangas', '09171000038', 'aubrey.pascua@email.com', 'Carl Ivan Pascua', '09181000038'),
('2026-0039', 'Lance', 'Domingo', 'Lubay', '2010-08-21', 'Male', 'Brgy. District 6, Balayan, Batangas', '09171000039', 'lance.lubay@email.com', 'Jairus Levi Lubay', '09181000039'),
('2026-0040', 'Chloe', 'Salazar', 'De Castro', '2010-01-19', 'Female', 'Brgy. District 7, Balayan, Batangas', '09171000040', 'chloe.decastro@email.com', 'Francis De Castro', '09181000040'),
('2026-0041', 'Sean', 'Delos Santos', 'Bautista', '2010-09-27', 'Male', 'Brgy. District 8, Balayan, Batangas', '09171000041', 'sean.bautista@email.com', 'Aries Bautista', '09181000041'),
('2026-0042', 'Gabrielle', 'Tolentino', 'Reyes', '2010-11-13', 'Female', 'Brgy. District 9, Balayan, Batangas', '09171000042', 'gabrielle.reyes@email.com', 'Victoria Reyes', '09181000042'),
('2026-0043', 'Bryan', 'Soriano', 'Cruz', '2010-03-02', 'Male', 'Brgy. District 10, Balayan, Batangas', '09171000043', 'bryan.cruz@email.com', 'Teodoro Cruz', '09181000043'),
('2026-0044', 'Janelle', 'Mercado', 'Santos', '2010-06-11', 'Female', 'Brgy. District 11, Balayan, Batangas', '09171000044', 'janelle.santos@email.com', 'Consuelo Santos', '09181000044'),
('2026-0045', 'Kevin', 'Manalo', 'Garcia', '2010-12-24', 'Male', 'Brgy. District 12, Balayan, Batangas', '09171000045', 'kevin.garcia@email.com', 'Florencio Garcia', '09181000045'),
('2026-0046', 'danica', 'Valdez', 'Mendoza', '2010-02-05', 'Female', 'Brgy. Ermita, Balayan, Batangas', '09171000046', 'danica.mendoza@email.com', 'Leonora Mendoza', '09181000046'),
('2026-0047', 'Jayson', 'Ocampo', 'Aquino', '2010-05-16', 'Male', 'Brgy. Lanatan, Balayan, Batangas', '09171000047', 'jayson.aquino@email.com', 'Guillermo Aquino', '09181000047'),
('2026-0048', 'Erika', 'Aguilar', 'Villanueva', '2010-10-29', 'Female', 'Brgy. Navotas, Balayan, Batangas', '09171000048', 'erika.villanueva@email.com', 'Rosalinda Villanueva', '09181000048'),
('2026-0049', 'Cedric', 'Evangelista', 'Fernandez', '2010-07-04', 'Male', 'Brgy. Poblacion, Balayan, Batangas', '09171000049', 'cedric.fernandez@email.com', 'Herminio Fernandez', '09181000049'),
('2026-0050', 'Mikaela', 'Concepcion', 'Flores', '2010-08-18', 'Female', 'Brgy. San Piro, Balayan, Batangas', '09171000050', 'mikaela.flores@email.com', 'Estrella Flores', '09181000050');

MERGE INTO [dbo].[Students] AS Target
USING @SeedStudents AS Source
ON (Target.[StudentNumber] = Source.[StudentNumber])
WHEN NOT MATCHED BY TARGET THEN
    INSERT (
        [StudentNumber], [FirstName], [MiddleName], [LastName],
        [DateOfBirth], [Gender], [Address], [ContactNumber],
        [Email], [GuardianName], [GuardianContact]
    )
    VALUES (
        Source.[StudentNumber], Source.[FirstName], Source.[MiddleName], Source.[LastName],
        Source.[DateOfBirth], Source.[Gender], Source.[Address], Source.[ContactNumber],
        Source.[Email], Source.[GuardianName], Source.[GuardianContact]
    );
GO

GO

