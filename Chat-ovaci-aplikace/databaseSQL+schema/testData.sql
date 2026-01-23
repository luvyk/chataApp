-- 1.
INSERT INTO Uzivatel (jmeno, prijmeni, username, heslo) VALUES
('Lukáš', 'Novák', 'lukas', 'heslo1'),
('Petr', 'Svoboda', 'petr', 'heslo2'),
('Anna', 'Dvoøáková', 'anna', 'heslo3'),
('Karel', 'Beneš', 'karel', 'heslo4'),
('Jana', 'Králová', 'jana', 'heslo5'),
('Tomáš', 'Vlèek', 'tomas', 'heslo6');

-- 2.
INSERT INTO Chata (jmeno, zacatek, konec, kapacita, zeme, mesto, castMesta, ulice, PSC) VALUES
('Zimní chata 2025', '2025-02-10 16:00', '2025-02-15 10:00', 20, 'Èesko', 'Špindlerùv Mlýn', 'Bedøichov', 'Horská 12', '54351'),
('Letní chata 2025', '2025-07-05 14:00', '2025-07-12 10:00', 25, 'Èesko', 'Lipno', NULL, 'Pøehradní 8', '38278'),
('Podzimní chata 2025', '2025-10-01 15:00', '2025-10-05 11:00', 15, 'Èesko', 'Jizerka', NULL, 'Jizerská 3', '46850');

-- 3.
INSERT INTO Ucastnik (idUzivatel, idChaty, sumaCeny, zaplatil, zucastniSe) VALUES
(1, 1, 2500, TRUE, TRUE),
(2, 1, 2500, FALSE, TRUE),
(3, 1, 2500, TRUE, TRUE),

(4, 2, 3000, TRUE, TRUE),
(5, 2, 3000, FALSE, TRUE),
(6, 2, 3000, TRUE, FALSE),

(1, 3, 1800, TRUE, TRUE),
(3, 3, 1800, TRUE, TRUE);

-- 4.
INSERT INTO Den (idChaty, datum) VALUES
(1, '2025-02-11'),
(1, '2025-02-12'),
(1, '2025-02-13'),
(1, '2025-02-14'),

(2, '2025-07-06'),
(2, '2025-07-07'),
(2, '2025-07-08'),

(3, '2025-10-02'),
(3, '2025-10-03');

-- 5.
INSERT INTO Mistnost (idChaty, nazevMistnosti, zatahujeNaNoc) VALUES
(1, 'Pokoj A', TRUE),
(1, 'Pokoj B', FALSE),
(2, 'Ložnice 1', TRUE),
(2, 'Ložnice 2', TRUE),
(3, 'Hlavní pokoj', FALSE);

-- 6.
INSERT INTO Typ (jmeno) VALUES
('Postel'),
('Matrace'),
('Karimatka'),
('Dvojlùžko');

-- 7.
INSERT INTO Misto (idMistnosti, idUcastnik, idTyp, cenaMista) VALUES
(1, 1, 1, 500),
(1, 2, 2, 300),
(2, 3, 1, 500),

(3, 4, 4, 700),
(4, 5, 1, 500),

(5, 7, 2, 300);

-- 8.
INSERT INTO Akce (nazev, popis, casOD, casDO, cenaNavic) VALUES
('Lyžování', 'Celodenní skipas', '2025-02-12 09:00', '2025-02-12 16:00', 800),
('Sauna', 'Veèerní relax', '2025-02-13 19:00', NULL, 200),
('Výlet lodí', 'Okruh po pøehradì', '2025-07-07 10:00', '2025-07-07 13:00', 300);

-- 9.
INSERT INTO UcastnikAkce (idUcastnik, idAkce) VALUES
(1, 1),
(2, 1),
(3, 2),
(4, 3),
(5, 3);

-- 10.
INSERT INTO Role (nazev) VALUES
('MainOrg'),
('Org'),
('Kuchaø'),
('Úèastník');

-- 11.
INSERT INTO RoleUcastnik (idUcastnik, idRole) VALUES
(1, 1),  -- Lukáš = MainOrg zimní chaty
(2, 4),
(3, 4),

(4, 1),  -- Karel = MainOrg letní chaty
(5, 4),

(7, 1);  -- Lukáš = MainOrg podzimní chaty

-- 12.
INSERT INTO Ukoly (nazev, popis, idUcastnik, idDen, splneno) VALUES
('Nákup jídla', 'Koupit snídani', 1, 1, FALSE),
('Úklid', 'Vysát spoleèné prostory', 2, 2, TRUE),
('Pøíprava veèeøe', 'Uvaøit guláš', 3, 3, FALSE),
('Rozdìlat oheò', 'Pøíprava ohništì', 4, 5, TRUE);

-- 13.
INSERT INTO Program (idDen, nazev, popis, casZacatku, casKonce) VALUES
(1, 'Pøíjezd', 'Ubytování a veèeøe', '2025-02-11 16:00', '2025-02-11 20:00'),
(2, 'Lyžování', 'Celodenní program', '2025-02-12 09:00', '2025-02-12 16:00'),
(5, 'Grilování', 'Veèerní akce', '2025-07-06 18:00', '2025-07-06 22:00');

-- 14.
INSERT INTO Vlakno (nazev, idChaty) VALUES
('Obecná diskuze', 1),
('Jídlo', 1),
('Doprava', 2),
('Program', 3);

-- 15.
INSERT INTO Zprava (idUcastnik, idVlakno, content) VALUES
(1, 1, 'Ahoj všichni, tìším se!'),
(2, 1, 'Já taky!'),
(3, 2, 'Co budeme vaøit?'),
(4, 3, 'Kdo jede autem?');

-- 16.
INSERT INTO PrihlasenyUZ (dateTimePrihlaseni, token, idUzivatel) VALUES
(NOW(), 'token123', 1),
(NOW(), 'token456', 2);

-- 17.
INSERT INTO Rezim (idDen, idUcastnik, nazev, popis, cena) VALUES
(1, 2, 'Pùlden', 'Pøijede až odpoledne', 0),
(5, 5, 'Výlet', 'Pouze úèast na výletì', 0),
(8, 7, 'Bez spaní', 'Pøijede jen na program', 0);