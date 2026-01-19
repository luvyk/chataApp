-- 1.
INSERT INTO Uzivatel (jmeno, prijmeni, username, heslo) VALUES
('Luk·ö', 'Nov·k', 'lukas', 'heslo1'),
('Petr', 'Svoboda', 'petr', 'heslo2'),
('Anna', 'Dvo¯·kov·', 'anna', 'heslo3'),
('Karel', 'Beneö', 'karel', 'heslo4');

-- 2.
INSERT INTO Chata (jmeno, cena, zacatek, konec, kapacita) VALUES
('Chata U Lesa', 2500.00, '2025-07-10 15:00:00', '2025-07-15 10:00:00', 20),
('Horsk· Chata MedvÏd', 3200.00, '2025-08-01 14:00:00', '2025-08-07 11:00:00', 15);

-- 3.
INSERT INTO Ucastnik (idUzivatel, idChaty, zaplatil) VALUES
(1, 1, TRUE),
(2, 1, FALSE),
(3, 1, TRUE),
(4, 2, TRUE),
(1, 2, FALSE);

-- 4.
INSERT INTO Den (idChaty, datum) VALUES
(1, '2025-07-11'),
(1, '2025-07-12'),
(1, '2025-07-13'),
(2, '2025-08-02'),
(2, '2025-08-03');

-- 5.
INSERT INTO Mistnost (idChaty, nazevMistnosti, zatahujeNaNoc) VALUES
(1, 'Loûnice 1', TRUE),
(1, 'Loûnice 2', FALSE),
(1, 'Ob˝v·k', FALSE),
(2, 'HlavnÌ pokoj', TRUE),
(2, 'PodkrovÌ', TRUE);

-- 6.
INSERT INTO Typ (jmeno) VALUES
('Postel'),
('Matrace'),
('Karimatka'),
('HoupacÌ sÌù');

-- 7.
INSERT INTO Misto (idMistnosti, idUcastnik, idTyp) VALUES
(1, 1, 1),
(1, 2, 2),
(2, 3, 1),
(4, 4, 3),
(5, 5, 2);

-- 8.
INSERT INTO Akce (nazev, popis, casOD, casDO, cenaNavic) VALUES
('V˝let na rozhlednu', 'PÏöÌ t˙ra', '2025-07-12 09:00:00', '2025-07-12 14:00:00', 150.00),
('Grilov·nÌ', 'VeËernÌ grilovaËka', '2025-07-12 18:00:00', NULL, NULL),
('Sauna', 'Relax v saunÏ', '2025-08-03 20:00:00', '2025-08-03 22:00:00', 200.00);

-- 9.
INSERT INTO UcastnikAkce (idUcastnik, idAkce) VALUES
(1, 1),
(2, 1),
(3, 2),
(4, 3),
(5, 3);

-- 10.
INSERT INTO Role (nazev) VALUES
('VedoucÌ'),
('Kucha¯'),
('⁄klid'),
('ZdravotnÌk');

-- 11.
INSERT INTO RoleUcastnik (idUcastnik, idRole) VALUES
(1, 1),
(2, 3),
(3, 2),
(4, 4),
(5, 3);

-- 12.
INSERT INTO Ukoly (nazev, popis, idUcastnik, idDen, splneno) VALUES
('Uklidit kuchyÚ', 'Po snÌdani', 2, 1, FALSE),
('P¯ipravit oheÚ', NULL, 3, 2, TRUE),
('N·kup potravin', 'P¯ed veËe¯Ì', 1, 1, TRUE),
('Zkontrolovat lÈk·rniËku', NULL, 4, 4, FALSE);

-- 13.
INSERT INTO Program (idDen, nazev, popis, casZacatku, casKonce) VALUES
(1, 'SnÌdanÏ', NULL, '2025-07-11 08:00:00', '2025-07-11 09:00:00'),
(1, 'Hry v lese', 'T˝movÈ aktivity', '2025-07-11 10:00:00', '2025-07-11 12:00:00'),
(4, 'P¯Ìjezd', NULL, '2025-08-02 14:00:00', '2025-08-02 15:00:00');

-- 14.
INSERT INTO Vlakno (nazev, idChaty) VALUES
('Organizace', 1),
('Voln· diskuze', 1),
('Sauna pl·n', 2);

-- 15.
INSERT INTO Zprava (idUcastnik, idVlakno, content) VALUES
(1, 1, 'Ahoj, kdo bere auto?'),
(2, 1, 'J· m˘ûu vzÌt auto.'),
(3, 2, 'TÏöÌm se na chatu!'),
(4, 3, 'Kdo jde dnes do sauny?');

-- 16.
INSERT INTO PrihlasenyUZ (dateTimePrihlaseni, token, idUzivatel) VALUES
('2025-06-01 12:00:00', 'token123', 1),
('2025-06-01 12:05:00', 'token456', 2),
('2025-06-02 09:30:00', 'token789', 3);
