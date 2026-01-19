-- 1. Uzivatel
drop database dbchata;

create database dbChata;
use dbChata;

CREATE TABLE Uzivatel (
  idUzivatel INT PRIMARY KEY AUTO_INCREMENT,
  jmeno VARCHAR(50),
  prijmeni VARCHAR(50),
  username VARCHAR(50),
  heslo VARCHAR(255)
);

-- 2. Chata
CREATE TABLE Chata (
  idChaty INT PRIMARY KEY AUTO_INCREMENT,
  jmeno VARCHAR(100),
  cena DECIMAL(10,2),
  zacatek DATETIME null,
  konec DATETIME null,
  kapacita INT
);

-- 3. Ucastnik
CREATE TABLE Ucastnik (
  idUcastnik INT PRIMARY KEY AUTO_INCREMENT,
  idUzivatel INT,
  idChaty INT,
  zaplatil BOOLEAN,
  FOREIGN KEY (idUzivatel) REFERENCES Uzivatel(idUzivatel),
  FOREIGN KEY (idChaty) REFERENCES Chata(idChaty)
);

-- 4. Den
CREATE TABLE Den (
  idDen INT PRIMARY KEY AUTO_INCREMENT,
  idChaty INT,
  datum DATE,
  FOREIGN KEY (idChaty) REFERENCES Chata(idChaty)
);

-- 5. Mistnost
CREATE TABLE Mistnost (
  idMistnosti INT PRIMARY KEY AUTO_INCREMENT,
  idChaty INT,
  nazevMistnosti VARCHAR(100) null,
  zatahujeNaNoc BOOLEAN null,
  FOREIGN KEY (idChaty) REFERENCES Chata(idChaty)
);

-- 6. Typ
CREATE TABLE Typ (
  idTyp INT PRIMARY KEY AUTO_INCREMENT,
  jmeno VARCHAR(50)
);

-- 7. Misto
CREATE TABLE Misto (
  idMisto INT PRIMARY KEY AUTO_INCREMENT,
  idMistnosti INT,
  idUcastnik INT,
  idTyp INT,
  FOREIGN KEY (idMistnosti) REFERENCES Mistnost(idMistnosti),
  FOREIGN KEY (idUcastnik) REFERENCES Ucastnik(idUcastnik),
  FOREIGN KEY (idTyp) REFERENCES Typ(idTyp)
);

-- 8. Akce
CREATE TABLE Akce (
  idAkce INT PRIMARY KEY AUTO_INCREMENT,
  nazev VARCHAR(100),
  popis VARCHAR(255) null,
  casOD DATETIME,
  casDO DATETIME null,
  cenaNavic DECIMAL(10,2) null
);

-- 9. UcastnikAkce
CREATE TABLE UcastnikAkce (
  idUcastnik INT,
  idAkce INT,
  PRIMARY KEY (idUcastnik, idAkce),
  FOREIGN KEY (idUcastnik) REFERENCES Ucastnik(idUcastnik),
  FOREIGN KEY (idAkce) REFERENCES Akce(idAkce)
);

-- 10. Role
CREATE TABLE Role (
  idRole INT PRIMARY KEY AUTO_INCREMENT,
  nazev VARCHAR(50)
);

-- 11. RoleUcastnik
CREATE TABLE RoleUcastnik (
  idUcastnik INT,
  idRole INT,
  PRIMARY KEY (idUcastnik, idRole),
  FOREIGN KEY (idUcastnik) REFERENCES Ucastnik(idUcastnik),
  FOREIGN KEY (idRole) REFERENCES Role(idRole)
);

-- 12. Ukoly
CREATE TABLE Ukoly (
  idUkolu INT PRIMARY KEY AUTO_INCREMENT,
  nazev VARCHAR(100),
  popis varchar(255) null,
  idUcastnik INT,
  idDen INT,
  splneno BOOLEAN,
  FOREIGN KEY (idUcastnik) REFERENCES Ucastnik(idUcastnik),
  FOREIGN KEY (idDen) REFERENCES Den(idDen)
);

-- 13. Program
CREATE TABLE Program (
  idProgramu INT PRIMARY KEY AUTO_INCREMENT,
  idDen INT,
  nazev VARCHAR(100),
  popis VARCHAR(255) null,
  casZacatku DATETIME,
  casKonce DATETIME,
  FOREIGN KEY (idDen) REFERENCES Den(idDen)
);

-- 14. Vlakno
CREATE TABLE Vlakno (
  idVlakno INT PRIMARY KEY AUTO_INCREMENT,
  nazev VARCHAR(100),
  idChaty INT,
  FOREIGN KEY (idChaty) REFERENCES Chata(idChaty)
);

-- 15. Zprava
CREATE TABLE Zprava (
  idZpravy INT PRIMARY KEY AUTO_INCREMENT,
  idUcastnik INT,
  idVlakno INT,
  content TEXT,
  FOREIGN KEY (idUcastnik) REFERENCES Ucastnik(idUcastnik),
  FOREIGN KEY (idVlakno) REFERENCES Vlakno(idVlakno)
);

-- 16. PrihlasenyUZ
CREATE TABLE PrihlasenyUZ (
  idPrihlaseni INT PRIMARY KEY AUTO_INCREMENT,
  dateTimePrihlaseni DATETIME,
  token VARCHAR(255),
  idUzivatel INT,
  FOREIGN KEY (idUzivatel) REFERENCES Uzivatel(idUzivatel)
);