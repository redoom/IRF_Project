INSERT INTO Country (CountryID, Name, Code) VALUES
('1', 'Hungary', 'HU'),
('2', 'Belgium', 'BE'),
('3', 'Bulgaria', 'BG'),
('4', 'Denmark	', 'DK'),
('5', 'Germany', 'DE'),
('6', 'Estonia', 'EE'),
('7', 'Ireland', 'IE'),
('8', 'Greece', 'EL'),
('9', 'Spain', 'ES'),
('10', 'France', 'FR'),
('11', 'Croatia', 'HR'),
('12', 'Italy', 'IT'),
('13', 'Cyprus', 'CY'),
('14', 'Latvia', 'LV'),
('15', 'Lithuania', 'LT')


INSERT INTO Coach (CoachID, Name, Age) VALUES
('1', 'Ilona Berecz', '71'),
('2', 'Roberto Pellizola', '60'),
('3', 'Barbara Fusarpoli', '51'),
('4', 'Igor Shpilband', '53'),
('5', 'Matteo Zanni', '34')


INSERT INTO Judge (JudgeID, Name, Age, CountryFK) VALUES
('1', 'Gyorgy Elek', '42', '1'),
('2', 'Waqar Shaffer', '54', '3'),
('3', 'Myron Jefferson', '32', '4'),
('4', 'Sadie Guy', '64', '2'),
('5', 'Sulayman Leonard', '43', '10'),
('6', 'Liam Delacruz', '24', '11'),
('7', 'Jez Zhang', '36', '6'),
('8', 'Zaynab Dotson', '64', '7'),
('9', 'Terri Chase', '45', '12'),
('10', 'Victor Booth', '42', '15')


INSERT INTO Competitor (CompetitorID, Name, Age, Gender, Height, CountryFK) VALUES
('1', 'Kelsi Lee', '23', 'F', '171', '12'),
('2', 'Marsha Neville', '22', 'F', '166', '1'),
('3', 'Tyrell Potts', '25', 'F', '160', '4'),
('4', 'Alanna Stamp', '20', 'F', '170', '5'),
('5', 'Kelsi Lee', '27', 'F', '162', '10'),
('6', 'Daniel Illes', '24', 'M', '186', '1'),
('7', 'Dexter Sosa', '25', 'M', '183', '3'),
('8', 'Cade Glass', '21', 'M', '190', '5'),
('9', 'Alasdair Baldwin', '24', 'M', '183', '12'),
('10', 'Simran Novak', '27', 'M', '183', '7')



INSERT INTO Competition (CompetitionID, Name, Type, Date, CountryFK, JudgeFK1, JudgeFK2, JudgeFK3, JudgeFK4, JudgeFK5) VALUES
('1', 'Kosice GP', 'GP', '2019/09/04', '3', '1', '3', '4', '6', '7'),
('2', 'Budapest GP', 'GP', '2019/09/12', '1', '2', '4', '6', '1', '8'),
('3', 'Ostrava GP', 'GP', '2019/09/23', '5', '10', '5', '3', '2', '7'),
('4', 'Europian Championships', 'EC', '2020/03/14', '7', '9', '4', '3', '6', '2'),
('5', 'World Championships', 'WC', '2020/03/26', '11', '1', '3', '6', '7', '8')





INSERT INTO Couple (FemaleCompetitorFK, MaleCompetitorFK, CoachFK, CountryFK) VALUES
('1', '6', '1', '1'),
('2', '7', '2', '5'),
('3', '8', '3', '6'),
('4', '9', '2', '8'),
('5', '10', '5', '10')


INSERT INTO Competition_Couple (CoupleFK, CompetitionFK, Rank) VALUES
( '1', '2', '1'),
('1', '4', '1'),
('1', '5', '2'),
('2', '2', '2'),
('2', '5', '1'),
('3', '1', '1'),
('3', '4', '2'),
('4', '1', '2'),
('4', '3', '1'),
('5', '2', '3')









