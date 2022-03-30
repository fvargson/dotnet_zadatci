CREATE DATABASE hotel

USE hotel

CREATE TABLE Hotel (
    IdHotela INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    Naziv NVARCHAR(55) NOT NULL,
    Adresa NVARCHAR(100) NOT NULL,
    Grad NVARCHAR(55) NOT NULL,
    BrojZvjezdica TINYINT NOT NULL CHECK (BrojZvjezdica BETWEEN 1 AND 5)
)

CREATE TABLE Soba (
    IdSobe INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    Oznaka NVARCHAR(35) NOT NULL,
    Kapacitet INT NOT NULL,
    HotelId INT NOT NULL FOREIGN KEY REFERENCES Hotel(IdHotela)
)

CREATE TABLE Gost (
    IdGosta INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    OIB NVARCHAR(11) NOT NULL UNIQUE,
    Ime NVARCHAR(35) NOT NULL,
    Prezime NVARCHAR(35) NOT NULL
)

DROP TABLE Zauzece

CREATE TABLE Zauzece (
    IdZauzeca INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    SobaId INT NOT NULL FOREIGN KEY REFERENCES Soba(IdSobe),
    GostId INT NOT NULL FOREIGN KEY REFERENCES Gost(IdGosta),
    BrojGostiju INT NOT NULL,
    DatumOd DATETIME NOT NULL,
    DatumDo DATETIME NOT NULL
)

INSERT INTO Hotel (Naziv, Adresa, Grad, BrojZvjezdica) VALUES
('Entity Framework', 'Ulica ona iza ugla 15', 'Entity', 4),
('Entity Core',      'Ulica ona vamo 2',      'Entity', 5),
('ADO.NET',          'Ulica ona tamo 87',     'Entity', 4)

INSERT INTO Soba (Oznaka, Kapacitet, HotelId) VALUES
('1A', 5,  1),
('2A', 2,  1),
('3A', 2,  1),
('4A', 5,  1),
('5A', 3,  1),
('6A', 3,  1),
('7A', 1,  1),
('1B', 1,  1),
('2B', 1,  1),
('3B', 1,  1),
('4B', 5,  1),
('1A', 2,  2),
('2A', 2,  2),
('3A', 5,  2),
('4A', 5,  2),
('5A', 5,  2),
('6A', 5,  2),
('1B', 10, 2),
('2B', 10, 2),
('3B', 8,  2),
('4B', 8,  2),
('5B', 10, 2),
('6B', 10, 2),
('1C', 1,  2),
('2C', 1,  2),
('3C', 2,  2),
('4C', 2,  2),
('5C', 2,  2),
('6C', 2,  2),
('7C', 2,  2),
('1A', 5,  3),
('2A', 2,  3),
('3A', 2,  3),
('4A', 2,  3),
('1B', 2,  3),
('2B', 2,  3)

INSERT INTO Gost (OIB, Ime, Prezime) VALUES
('46546576465', 'Admin',    '62'),
('25648957482', 'Luka',     'Nekić'),
('01452725283', 'Andrea',   'Poljak'),
('89752987289', 'Antonio',  'Drdić'),
('98637254270', 'Dubravka', 'Jakupec'),
('71857058752', 'Dorian',   'Ribarić'),
('36052625720', 'Filip',    'Borojević'),
('28920269873', 'Filip',    'Vargić'),
('25037968527', 'Filip',    'Zelić'),
('63380527785', 'Iva',      'Kereša'),
('29670920827', 'Sanjin',   'Čajlaković'),
('69326932579', 'Tomica',   'Trnčić')

INSERT INTO Zauzece (SobaId, GostId, BrojGostiju, DatumOd, DatumDo) VALUES
(11, 1,  4, '2022-04-01', '2022-04-04'),
(18, 1,  9, '2022-07-08', '2022-07-22'),
(5,  2,  3, '2022-06-03', '2022-06-15'),
(21, 2,  6, '2022-10-01', '2022-10-08'),
(25, 2,  1, '2022-12-18', '2022-12-22'),
(31, 3,  2, '2023-01-15', '2023-01-21'),
(3,  4,  1, '2024-06-01', '2024-07-10'),
(2,  4,  1, '2023-07-25', '2023-08-02'),
(26, 5,  2, '2022-08-14', '2022-08-16'),
(30, 6,  2, '2023-09-01', '2023-09-13'),
(18, 7,  2, '2023-02-25', '2023-03-24'),
(5,  8,  1, '2022-11-11', '2022-11-12'),
(17, 9,  1, '2022-06-06', '2022-06-08'),
(9,  10, 2, '2024-12-30', '2024-01-02'),
(24, 11, 1, '2024-01-15', '2025-01-18'),
(34, 12, 2, '2023-08-06', '2023-08-15')
