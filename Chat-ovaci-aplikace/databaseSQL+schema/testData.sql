-- 1) Uzivatel
INSERT INTO Uzivatel (jmeno, prijmeni, username, heslo) VALUES
('Lukáš', 'Novák', 'lukas', 'heslo1'),
('Petr', 'Svoboda', 'petr', 'heslo2'),
('Anna', 'Dvoøáková', 'anna', 'heslo3'),
('Karel', 'Beneš', 'karel', 'heslo4');

-- 2) Chata
INSERT INTO Chata (jmeno, zacatek, konec, kapacita, zeme, mesto, castMesta, ulice, PSC) VALUES
('Chata U Lesa', '2025-07-10 15:00:00', '2025-07-15 10:00:00', 20, 'Èesko', 'Brno', 'Bystrc', 'Lesní 12', '60200'),
('Horská Chata', '2025-08-01 14:00:00', '2025-08-07 11:00:00', 15, 'Èesko', 'Špindlerùv Mlın', NULL, 'Horská 5', '54351');

-- 3) Ucastnik
INSERT INTO Ucastnik (idUzivatel, idChaty, sumaCeny, zaplatil, zucastniSe) VALUES
(1, 1, 2500.00, TRUE, TRUE),
(2, 1, 2500.00, FALSE, TRUE),
(3, 1, 1500.00, TRUE, TRUE),
(4, 2, 3000.00, FALSE, TRUE);

-- 4) Den
INSERT INTO Den (idChaty, datum) VALUES
(1, '2025-07-10'),
(1, '2025-07-11'),
(1, '2025-07-12'),
(2, '2025-08-01'),
(2, '2025-08-02');

-- 5) Mistnost
INSERT INTO Mistnost (idChaty, nazevMistnosti, zatahujeNaNoc) VALUES
(1, 'Pokoj 1', TRUE),
(1, 'Pokoj 2', FALSE),
(2, 'Horskı pokoj', TRUE);

-- 6) Typ
INSERT INTO Typ (jmeno) VALUES
('Postel'),
('Matrace'),
('Houpací sí');

-- 7) Misto
INSERT INTO Misto (idMistnosti, idTyp, cenaMista, IdJeManzelskeS) VALUES
(1, 1, 200.00, 2),
(1, 1, 200.00, 1),
(1, 2, 100.00, null),
(2, 1, 150.00, null),
(3, 3, 50.00, null);

UPDATE Misto
SET IdJeManzelskeS = 2
WHERE idMistnosti = 1;

UPDATE Misto
SET IdJeManzelskeS = 1
WHERE idMistnosti = 2;

-- 8) Akce
INSERT INTO Akce (nazev, popis, casOD, casDO, cenaNavic) VALUES
('Vılet na rozhlednu', 'Pìší túra', '2025-07-11 09:00:00', '2025-07-11 14:00:00', 0),
('Grilování', 'Veèerní grilovaèka', '2025-07-11 18:00:00', NULL, 150.00),
('Sauna', NULL, '2025-08-02 20:00:00', NULL, 200.00);

-- 9) UcastnikAkce
INSERT INTO UcastnikAkce (idUcastnik, idAkce) VALUES
(1, 1),
(2, 1),
(1, 2),
(3, 2),
(4, 3);

-- 10) Role
INSERT INTO Role (nazev) VALUES
('Organizátor'),
('Kuchaø'),
('Úèastník');

-- 11) RoleUcastnik
INSERT INTO RoleUcastnik (idUcastnik, idRole) VALUES
(1, 1),
(2, 2),
(3, 3),
(4, 3);

-- 12) Ukoly
INSERT INTO Ukoly (nazev, popis, idUcastnik, idDen, splneno) VALUES
('Nákup jídla', 'Koupit maso a zeleninu', 1, 1, FALSE),
('Pøíprava ohnì', NULL, 2, 2, TRUE),
('Úklid chaty', 'Zametání a úklid kuchynì', 3, 3, FALSE);

-- 13) Program
INSERT INTO Program (idDen, nazev, popis, casZacatku, casKonce) VALUES
(1, 'Pøíjezd', 'Ubytování a volnı program', '2025-07-10 15:00:00', '2025-07-10 20:00:00'),
(2, 'Vılet', 'Celodenní vılet', '2025-07-11 08:00:00', '2025-07-11 17:00:00'),
(4, 'Sauna', NULL, '2025-08-01 19:00:00', '2025-08-01 22:00:00');

-- 14) Vlakno
INSERT INTO Vlakno (nazev, idChaty) VALUES
('Obecná diskuze', 1),
('Plánování vıletu', 1),
('Horská diskuze', 2);

-- 15) Zprava
INSERT INTO Zprava (idUcastnik, idVlakno, content) VALUES
(1, 1, 'Ahoj všichni!'),
(2, 1, 'Tìším se na chatu!'),
(3, 2, 'Kdy vyráíme na vılet?'),
(4, 3, 'Jaké bude poèasí?');

-- 16) PrihlasenyUZ
INSERT INTO PrihlasenyUZ (dateTimePrihlaseni, token, idUzivatel) VALUES
('2025-06-01 10:00:00', 'token123', 1),
('2025-06-02 11:30:00', 'token456', 2);

-- 17) Rezim
INSERT INTO Rezim (idDen, idUcastnik, nazev, popis, cena) VALUES
(1, 2, 'Pùldenní úèast', 'Pøijede a veèer', 0),
(2, 3, 'Bez pøespání', 'Úèastní se jen programu', 0);

-- 18) ObsazeniMista
INSERT INTO ObsazeniMista (idMisto, idDen, idUcastnik) VALUES
(1, 1, 1),
(1, 2, 1),
(1, 3, 2),
(2, 1, 2),
(3, 2, 3),
(4, 1, 1),
(5, 4, 4);
