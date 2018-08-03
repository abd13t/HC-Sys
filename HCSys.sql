-- --------------------------------------------------------
-- Hôte :                        10.0.36.161
-- Version du serveur:           5.7.20-log - MySQL Community Server (GPL)
-- SE du serveur:                Win64
-- HeidiSQL Version:             9.5.0.5196
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- Export de la structure de la table hcsys. request
CREATE TABLE IF NOT EXISTS `request` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `RequestTypeid` int(11) DEFAULT NULL,
  `Description_En` char(100) DEFAULT NULL,
  `Desciption_Ar` char(100) DEFAULT NULL,
  `Description_Urdo` char(100) DEFAULT NULL,
  `Priority` int(10) unsigned DEFAULT '0',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;

-- Export de données de la table hcsys.request : ~10 rows (environ)
DELETE FROM `request`;
/*!40000 ALTER TABLE `request` DISABLE KEYS */;
INSERT INTO `request` (`Id`, `RequestTypeid`, `Description_En`, `Desciption_Ar`, `Description_Urdo`, `Priority`) VALUES
	(1, 1, 'Medical care', 'الرعاية الطبية', 'طبی دیکھ بھال', 2),
	(2, 2, 'Sanitary cleaning', 'التنظيف الصحي', 'صفائی کی صفائی', 1),
	(3, 1, 'Ambulance', 'سيارة إسعاف', 'ایمبولینس', 2),
	(4, 1, 'Death declaration', 'إعلان عن وفاة', 'موت کا اعلان کرو', 1),
	(5, 3, 'Air Conditioner Maintenance', 'صيانة مكيفات الهواء', 'ایئر کنڈیشنر بحالی', 1),
	(6, 3, 'Electricity maintenance', 'صيانة الكهرباء', 'بجلی کی بحالی', 1),
	(7, 3, 'Plumbing Maintenance', 'صيانة السباكة', 'پلمبنگ بحالی', 1),
	(8, 3, 'General maintenance', 'الصيانة العامة', 'جنرل دیکھ بھال', 0),
	(9, 4, 'water supply', 'إمدادات المياه', 'پانی کی فراہمی', 0),
	(10, 4, 'food supply', 'امدادات الغذاء', 'خوراک کی فراہمی', 0);
/*!40000 ALTER TABLE `request` ENABLE KEYS */;

-- Export de la structure de la table hcsys. request_type
CREATE TABLE IF NOT EXISTS `request_type` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Description_En` char(100) DEFAULT NULL,
  `Desciption_Ar` char(100) DEFAULT NULL,
  `Description_Urdo` char(100) DEFAULT NULL,
  `Is_actif` bit(1) DEFAULT b'0',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

-- Export de données de la table hcsys.request_type : ~6 rows (environ)
DELETE FROM `request_type`;
/*!40000 ALTER TABLE `request_type` DISABLE KEYS */;
INSERT INTO `request_type` (`Id`, `Description_En`, `Desciption_Ar`, `Description_Urdo`, `Is_actif`) VALUES
	(1, 'Medical assistance', 'الخدمات الطبية', 'طبی امداد', b'1'),
	(2, 'Sanitary services and cleaning', 'الخدمات الصحية والتنظيف', 'سینیٹری کی خدمات اور صفائی', b'1'),
	(3, 'Maintenance service', 'خدمات الصيانة', 'بحالی کی خدمات', b'1'),
	(4, 'Food service', 'خدمة الطعام', 'کھانے کی خدمت', b'1'),
	(5, 'Hajj assistance', 'مساعدة الحاج', 'حج امداد', b'0'),
	(6, 'Other', 'آخر', 'دیگر', b'0');
/*!40000 ALTER TABLE `request_type` ENABLE KEYS */;

-- Export de la structure de la table hcsys. terminal
CREATE TABLE IF NOT EXISTS `terminal` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Latitude` double DEFAULT NULL,
  `Longitude` double DEFAULT NULL,
  `Description` char(100) DEFAULT NULL,
  `Message` text,
  `MacAdress` char(100) DEFAULT NULL,
  `Is_Locked` bit(1) DEFAULT b'0',
  `Ip_adress` char(60) DEFAULT NULL,
  `Last_Check` datetime DEFAULT NULL,
  `Is_actif` bit(1) DEFAULT b'1',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=49 DEFAULT CHARSET=utf8;

-- Export de données de la table hcsys.terminal : ~35 rows (environ)
DELETE FROM `terminal`;
/*!40000 ALTER TABLE `terminal` DISABLE KEYS */;
INSERT INTO `terminal` (`Id`, `Latitude`, `Longitude`, `Description`, `Message`, `MacAdress`, `Is_Locked`, `Ip_adress`, `Last_Check`, `Is_actif`) VALUES
	(1, 21.413413, 39.8858391, 'Mina -  Tente 25', 'Dear Hajj,\r\nYou have two holy cities of Mecca and Medina as part of an Umrah trip along with an American youth group. The following descriptions of what I experienced may help the reader and especially those of you who are blessed to be apart of this years Hajj program. I hope you will benefit from my experience and that it helps you to gain a glimpse of the incredible life changing journey you are about to embark upon. May Allah protect you and keep you safe and accept your Hajj Ameen. Please make dua for us as well. \r\n\r\nThank you', '23:36:21:19', b'0', '192.168.1.53', '2018-08-02 04:24:03', b'1'),
	(2, 21.413441, 39.8905418, 'Mina - Tente 21', 'Dear Hajj,\r\nYou have two holy cities of Mecca and Medina as part of an Umrah trip along with an American youth group. The following descriptions of what I experienced may help the reader and especially those of you who are blessed to be apart of this years Hajj program. I hope you will benefit from my experience and that it helps you to gain a glimpse of the incredible life changing journey you are about to embark upon. May Allah protect you and keep you safe and accept your Hajj Ameen. Please make dua for us as well. \r\n\r\nThank you', '85:36:21:67', b'0', '192.168.1.152', '2018-08-01 04:24:06', b'1'),
	(3, 21.413797, 39.8859668, 'Mina - Tente 131', 'Dear Hajj,\r\nYou have two holy cities of Mecca and Medina as part of an Umrah trip along with an American youth group. The following descriptions of what I experienced may help the reader and especially those of you who are blessed to be apart of this years Hajj program. I hope you will benefit from my experience and that it helps you to gain a glimpse of the incredible life changing journey you are about to embark upon. May Allah protect you and keep you safe and accept your Hajj Ameen. Please make dua for us as well. \r\n\r\nThank you', '23:45:21:20', b'0', '192.168.1.52', '2018-08-01 04:24:08', b'1'),
	(4, 21.413848, 39.8899042, 'Haram - gate 9', 'Dear Hajj,\r\nYou have two holy cities of Mecca and Medina as part of an Umrah trip along with an American youth group. The following descriptions of what I experienced may help the reader and especially those of you who are blessed to be apart of this years Hajj program. I hope you will benefit from my experience and that it helps you to gain a glimpse of the incredible life changing journey you are about to embark upon. May Allah protect you and keep you safe and accept your Hajj Ameen. Please make dua for us as well. \r\n\r\nThank you', '45:36:47:85', b'0', '192.168.1.41', '2018-07-31 04:24:11', b'1'),
	(5, 21.418335, 39.8960524, 'Mouzdalifa, floor 3 - way 03', 'Dear Hajj,\r\nYou have two holy cities of Mecca and Medina as part of an Umrah trip along with an American youth group. The following descriptions of what I experienced may help the reader and especially those of you who are blessed to be apart of this years Hajj program. I hope you will benefit from my experience and that it helps you to gain a glimpse of the incredible life changing journey you are about to embark upon. May Allah protect you and keep you safe and accept your Hajj Ameen. Please make dua for us as well. \r\n\r\nThank you', '78:36:21:25', b'0', '192.168.1.24', '2018-08-01 04:24:14', b'1'),
	(6, 21.413606, 39.8898798, 'Mina - Tente 213', 'Dear Hajj,', '78:36:21:25', b'0', '192.168.1.25', '2018-08-02 19:49:30', b'1'),
	(7, 21.413623, 39.8892578, 'Mina - Tente 253', 'Dear Hajj,', '78:36:21:25', b'0', '192.168.1.26', '2018-08-02 19:51:19', b'1'),
	(8, 21.414215, 39.8886948, 'Mina - Tente 262', 'Dear Hajj,', '78:36:21:25', b'0', '192.168.1.27', '2018-08-02 19:53:13', b'1'),
	(9, 21.414687, 39.8880458, 'Mina - Tent 257', 'Dear Hajj,', '78:36:21:25', b'0', '192.168.1.27', '2018-08-06 19:53:13', b'1'),
	(10, 21.414817, 39.8871338, 'Mina - Tent 274', 'Dear Hajj,', '78:36:21:25', b'0', '192.168.1.27', '2018-08-02 19:59:39', b'1'),
	(11, 21.415539, 39.8868518, 'Mina - Tent 276', 'Dear Hajj,', '78:36:21:25', b'0', '192.168.1.27', '2018-08-02 20:05:45', b'1'),
	(12, 21.416586, 39.8881708, 'Mina - Tent 281', 'Dear Hajj,', '78:36:21:25', b'0', '192.168.1.27', '2018-08-02 20:05:43', b'1'),
	(13, 21.417333, 39.8843168, 'Mina - Tent 241', '', '78:36:21:25', b'0', '192.168.1.27', '2018-08-03 07:12:04', b'1'),
	(14, 21.417188, 39.8838448, 'Mina - Tent 275', '', '78:36:21:25', b'0', '192.168.1.27', '2018-08-03 07:12:07', b'1'),
	(15, 21.416875, 39.8830868, 'Mina - Tent 125', '', '78:36:21:25', b'0', '192.168.1.27', '2018-08-03 07:12:08', b'1'),
	(16, 21.41657, 39.8821938, 'Mina - Tent 714', '', '78:36:21:25', b'0', '192.168.1.27', '2018-08-02 07:12:13', b'1'),
	(17, 21.416415, 39.8820868, 'Mina - Tent 865', '', '78:36:21:25', b'0', '192.168.1.27', '2018-08-05 07:12:16', b'1'),
	(18, 21.416822, 39.8813948, 'Mina - Tent 124', '', '78:36:21:25', b'0', '192.168.1.27', '2018-08-03 07:12:11', b'1'),
	(19, 21.4166, 39.8808208, 'Mina - Tent 107', '', '78:36:21:25', b'0', '192.168.1.27', '2018-08-03 07:12:10', b'1'),
	(20, 21.416116, 39.8810488, 'Mina - Tent 986', '', '78:36:21:25', b'0', '192.168.1.27', '2018-08-01 07:12:18', b'1'),
	(21, 21.417157, 39.8801318, 'Mina - Tent 214', '', '78:36:21:25', b'0', '192.168.1.27', '2018-08-03 07:09:22', b'1'),
	(22, 21.417277, 39.8793838, 'Mina - Tent 835', '', '78:36:21:25', b'0', '192.168.1.27', '2018-08-03 07:16:24', b'1'),
	(23, 21.417382, 39.8786888, 'Mina - Tent 102', '', '78:36:21:25', b'0', '192.168.1.27', '2018-08-03 07:09:28', b'1'),
	(24, 21.417287, 39.8778008, 'Mina - Tent 758', '', '78:36:21:25', b'0', '192.168.1.27', '2018-08-03 07:09:32', b'1'),
	(25, 21.416703, 39.8778648, 'Mina - Tent 452', '', '78:36:21:25', b'0', '192.168.1.27', '2018-08-03 07:16:30', b'1'),
	(26, 21.416126, 39.8786558, 'Mina - Tent 457', '', '78:36:21:25', b'0', '192.168.1.27', '2018-08-03 07:07:34', b'1'),
	(27, 21.415746, 39.8793078, 'Mina - Tent 104', '', '78:36:21:25', b'0', '192.168.1.27', '2018-08-03 07:08:36', b'1'),
	(28, 21.414954, 39.8814538, 'Mina - Tent 875', '', '78:36:21:25', b'0', '192.168.1.27', '2018-08-03 07:08:38', b'1'),
	(29, 21.414495, 39.8820248, 'Mina - Tent 222', '', '78:36:21:25', b'0', '192.168.1.27', '2018-08-03 07:09:39', b'1'),
	(30, 21.408734, 39.8877458, 'Mina - Tent 333', '', '78:36:21:25', b'0', '192.168.1.27', '2018-08-03 07:09:40', b'1'),
	(31, 21.408062, 39.8869708, 'Mina - Tent 444', '', '78:36:21:25', b'0', '192.168.1.27', '2018-08-03 07:07:42', b'1'),
	(32, 21.407176, 39.8884778, 'Mina - Tent 125', '', '78:36:21:25', b'0', '192.168.1.27', '2018-08-03 07:08:45', b'1'),
	(33, 21.406032, 39.8904438, 'Mina - Tent 899', '', '78:36:21:25', b'0', '192.168.1.27', '2018-08-03 07:07:46', b'1'),
	(34, 21.405213, 39.8924018, 'Mina - Tent 785', '', '78:36:21:25', b'0', '192.168.1.27', '2018-08-03 07:08:48', b'1'),
	(35, 21.4024835, 39.8990457, 'Mina - Tent 841', '', '78:36:21:25', b'0', '192.168.1.27', '2018-08-03 07:07:51', b'1'),
	(36, 21.4096831, 39.9011206, 'Mina - Tent 124', 'Dear Hajj,\r\nYou have two holy cities of Mecca and Medina as part of an Umrah trip along with an American youth group. The following descriptions of what I experienced may help the reader and especially those of you who are blessed to be apart of this years Hajj program. I hope you will benefit from my experience and that it helps you to gain a glimpse of the incredible life changing journey you are about to embark upon. May Allah protect you and keep you safe and accept your Hajj Ameen. Please make dua for us as well. \r\n\r\nThank you', '78:36:21:25', b'0', '192.168.1.24', '2018-08-01 04:24:14', b'1'),
	(37, 21.4095747, 39.9017253, 'Mina - Tent 874', NULL, NULL, b'0', NULL, NULL, b'1'),
	(38, 21.4091961, 39.9018746, 'Mina - Tent 120', NULL, NULL, b'0', NULL, NULL, b'1'),
	(39, 21.4092354, 39.9018347, 'Mina - Tent 124', NULL, NULL, b'0', NULL, NULL, b'1'),
	(40, 21.4091212, 39.9017878, 'Mina - Tent 800', NULL, NULL, b'0', NULL, NULL, b'1'),
	(41, 21.407066, 39.8992916, 'Mina - Tent 8990', NULL, NULL, b'0', NULL, NULL, b'1'),
	(42, 21.4114576, 39.8964095, 'Mina - Tent 8000', NULL, NULL, b'0', NULL, NULL, b'1'),
	(43, 21.4102018, 39.8952854, 'Mina - Tent 1240', NULL, NULL, b'0', NULL, NULL, b'1'),
	(44, 21.4104968, 39.8937524, 'Mina - Tent 3330', NULL, NULL, b'0', NULL, NULL, b'1'),
	(45, 21.4117131, 39.8934053, 'Mina - Tent 1047', NULL, NULL, b'0', NULL, NULL, b'1'),
	(46, 21.4122739, 39.8929152, 'Mina - Tent 2220', NULL, NULL, b'0', NULL, NULL, b'1'),
	(47, 21.41337, 39.8944816, 'Mina - Tent 3330', NULL, NULL, b'0', NULL, NULL, b'1'),
	(48, 21.4117607, 39.8950442, 'Mina - Tent 1040', NULL, NULL, b'0', NULL, NULL, b'1');
/*!40000 ALTER TABLE `terminal` ENABLE KEYS */;

-- Export de la structure de la table hcsys. terminal_request
CREATE TABLE IF NOT EXISTS `terminal_request` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `TerminalId` int(11) DEFAULT NULL,
  `DateTime` datetime DEFAULT NULL,
  `Longitude` double DEFAULT NULL,
  `Latitude` double DEFAULT NULL,
  `Request_Id` int(11) DEFAULT NULL,
  `Is_Done` bit(1) DEFAULT b'0',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=34 DEFAULT CHARSET=utf8;

-- Export de données de la table hcsys.terminal_request : ~2 rows (environ)
DELETE FROM `terminal_request`;
/*!40000 ALTER TABLE `terminal_request` DISABLE KEYS */;
INSERT INTO `terminal_request` (`Id`, `TerminalId`, `DateTime`, `Longitude`, `Latitude`, `Request_Id`, `Is_Done`) VALUES
	(1, 11, '2018-08-02 22:43:57', 39.8884778, 21.407176, 9, b'1'),
	(2, 11, '2018-08-02 22:45:16', 39.8868518, 21.415539, 10, b'1'),
	(17, 20, '2018-08-03 01:28:19', 39.8810488, 21.416116, 5, b'1'),
	(18, 9, '2018-08-03 01:29:08', 39.8880458, 21.414687, 9, b'1'),
	(19, 9, '2018-08-03 01:29:40', 39.8880458, 21.414687, 1, b'1'),
	(20, 31, '2018-08-03 01:30:18', 39.8869708, 21.408062, 10, b'1'),
	(21, 21, '2018-08-03 01:30:26', 39.8801318, 21.417157, 2, b'1'),
	(22, 4, '2018-08-03 01:30:35', 39.8899042, 21.413848, 10, b'1'),
	(23, 24, '2018-08-03 01:40:38', 39.8778008, 21.417287, 3, b'1'),
	(24, 32, '2018-08-03 01:41:05', 39.8884778, 21.407176, 2, b'1'),
	(25, 19, '2018-08-03 01:41:23', 39.8808208, 21.4166, 9, b'1'),
	(26, 16, '2018-08-03 01:47:50', 39.8821938, 21.41657, 9, b'1'),
	(27, 16, '2018-08-03 02:39:52', 39.8821938, 21.41657, 1, b'1'),
	(28, 8, '2018-08-03 04:20:23', 39.8886948, 21.414215, 1, b'1'),
	(29, 34, '2018-08-03 05:25:18', 39.8924018, 21.405213, 4, b'1'),
	(30, 9, '2018-08-03 06:34:17', 39.8880458, 21.414687, 2, b'1'),
	(31, 13, '2018-08-03 06:40:59', 39.8843168, 21.417333, 9, b'0'),
	(32, 26, '2018-08-03 06:41:38', 39.8786558, 21.416126, 8, b'1'),
	(33, 11, '2018-08-03 07:28:25', 39.8868518, 21.415539, 3, b'0');
/*!40000 ALTER TABLE `terminal_request` ENABLE KEYS */;

-- Export de la structure de la table hcsys. user
CREATE TABLE IF NOT EXISTS `user` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `FullName` char(50) DEFAULT NULL,
  `User` char(50) DEFAULT NULL,
  `Password` char(50) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Export de données de la table hcsys.user : ~0 rows (environ)
DELETE FROM `user`;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
/*!40000 ALTER TABLE `user` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
