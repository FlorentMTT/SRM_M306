-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le :  lun. 22 mars 2021 à 13:29
-- Version du serveur :  5.7.17
-- Version de PHP :  7.1.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `m306_srm_db`
--

-- --------------------------------------------------------

--
-- Structure de la table `admins`
--
-- Création :  mer. 10 mars 2021 à 09:14
--

DROP TABLE IF EXISTS `admins`;
CREATE TABLE `admins` (
  `id` int(11) NOT NULL,
  `login` varchar(30) NOT NULL,
  `password` varchar(64) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- RELATIONS POUR LA TABLE `admins`:
--

--
-- Déchargement des données de la table `admins`
--


-- --------------------------------------------------------

--
-- Structure de la table `channels`
--
-- Création :  lun. 08 mars 2021 à 14:36
--

DROP TABLE IF EXISTS `channels`;
CREATE TABLE `channels` (
  `id` int(11) NOT NULL,
  `groupID` int(11) NOT NULL,
  `place` int(11) NOT NULL,
  `name` varchar(30) NOT NULL,
  `description` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- RELATIONS POUR LA TABLE `channels`:
--   `groupID`
--       `groups` -> `id`
--

-- --------------------------------------------------------

--
-- Structure de la table `groups`
--
-- Création :  mer. 10 mars 2021 à 09:13
--

DROP TABLE IF EXISTS `groups`;
CREATE TABLE `groups` (
  `id` int(11) NOT NULL,
  `name` varchar(30) NOT NULL,
  `profilPictureURL` varchar(100) NOT NULL,
  `ownerUserID` int(11) NOT NULL,
  `active` tinyint(1) NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- RELATIONS POUR LA TABLE `groups`:
--   `ownerUserID`
--       `users` -> `id`
--

-- --------------------------------------------------------

--
-- Structure de la table `medias`
--
-- Création :  mer. 10 mars 2021 à 09:14
--

DROP TABLE IF EXISTS `medias`;
CREATE TABLE `medias` (
  `id` int(11) NOT NULL,
  `messageID` int(11) NOT NULL,
  `url` varchar(100) NOT NULL,
  `typeMediaID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- RELATIONS POUR LA TABLE `medias`:
--   `typeMediaID`
--       `typesmedias` -> `id`
--   `messageID`
--       `messages` -> `id`
--

-- --------------------------------------------------------

--
-- Structure de la table `messages`
--
-- Création :  lun. 08 mars 2021 à 13:54
--

DROP TABLE IF EXISTS `messages`;
CREATE TABLE `messages` (
  `id` int(11) NOT NULL,
  `date` date NOT NULL,
  `content` text NOT NULL,
  `senderUserID` int(11) NOT NULL,
  `receiverUserID` int(11) NOT NULL,
  `receiverGroupID` int(11) NOT NULL,
  `receiverChannelID` int(11) NOT NULL,
  `active` tinyint(1) NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- RELATIONS POUR LA TABLE `messages`:
--   `senderUserID`
--       `users` -> `id`
--   `receiverUserID`
--       `users` -> `id`
--   `receiverGroupID`
--       `groups` -> `id`
--   `receiverChannelID`
--       `channels` -> `id`
--

-- --------------------------------------------------------

--
-- Structure de la table `permissions`
--
-- Création :  lun. 08 mars 2021 à 13:55
--

DROP TABLE IF EXISTS `permissions`;
CREATE TABLE `permissions` (
  `id` int(11) NOT NULL,
  `name` varchar(30) NOT NULL,
  `description` varchar(100) NOT NULL,
  `typePermissionID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- RELATIONS POUR LA TABLE `permissions`:
--   `typePermissionID`
--       `typespermissions` -> `id`
--

--
-- Déchargement des données de la table `permissions`
--

INSERT INTO `permissions` (`id`, `name`, `description`, `typePermissionID`) VALUES
(1, 'perm_name_admin_group', 'perm_desc_admin_group', 1),
(2, 'perm_name_admin_roles', 'perm_desc_admin_roles', 1),
(3, 'perm_name_admin_channels', 'perm_desc_admin_channels', 1),
(4, 'perm_name_admin_messages', 'perm_desc_admin_messages', 1),
(5, 'perm_name_invite_user', 'perm_desc_invite_user', 2),
(6, 'perm_name_change_other_user_ak', 'perm_desc_change_other_user_aka', 2),
(7, 'perm_name_kick_user', 'perm_desc_kick_user', 2),
(8, 'perm_name_ban_user', 'perm_desc_ban_user', 2),
(9, 'perm_name_read_message', 'perm_desc_read_message', 3),
(10, 'perm_name_send_message', 'perm_desc_send_message', 3),
(11, 'perm_name_join_file', 'perm_desc_join_file', 3),
(12, 'perm_name_integrate_link', 'perm_desc_integrate_link', 3),
(13, 'perm_name_change_user_aka', 'perm_desc_change_user_aka', 4);

-- --------------------------------------------------------

--
-- Structure de la table `relationschannelsrolespermissions`
--
-- Création :  mer. 10 mars 2021 à 09:17
--

DROP TABLE IF EXISTS `relationschannelsrolespermissions`;
CREATE TABLE `relationschannelsrolespermissions` (
  `channelID` int(11) NOT NULL,
  `roleID` int(11) NOT NULL,
  `permissionID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- RELATIONS POUR LA TABLE `relationschannelsrolespermissions`:
--   `permissionID`
--       `permissions` -> `id`
--   `channelID`
--       `channels` -> `id`
--   `roleID`
--       `roles` -> `id`
--

-- --------------------------------------------------------

--
-- Structure de la table `relationsgroupsusers`
--
-- Création :  mer. 10 mars 2021 à 09:17
--

DROP TABLE IF EXISTS `relationsgroupsusers`;
CREATE TABLE `relationsgroupsusers` (
  `groupID` int(11) NOT NULL,
  `userID` int(11) NOT NULL,
  `aka` varchar(30) DEFAULT NULL,
  `ban` tinyint(1) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- RELATIONS POUR LA TABLE `relationsgroupsusers`:
--   `groupID`
--       `groups` -> `id`
--   `userID`
--       `users` -> `id`
--

-- --------------------------------------------------------

--
-- Structure de la table `relationsrolespermissions`
--
-- Création :  mer. 10 mars 2021 à 09:27
--

DROP TABLE IF EXISTS `relationsrolespermissions`;
CREATE TABLE `relationsrolespermissions` (
  `roleID` int(11) NOT NULL,
  `permissionID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- RELATIONS POUR LA TABLE `relationsrolespermissions`:
--   `permissionID`
--       `permissions` -> `id`
--   `roleID`
--       `roles` -> `id`
--

-- --------------------------------------------------------

--
-- Structure de la table `relationsrolesusers`
--
-- Création :  mer. 10 mars 2021 à 09:23
--

DROP TABLE IF EXISTS `relationsrolesusers`;
CREATE TABLE `relationsrolesusers` (
  `roleID` int(11) NOT NULL,
  `userID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- RELATIONS POUR LA TABLE `relationsrolesusers`:
--   `userID`
--       `users` -> `id`
--   `roleID`
--       `roles` -> `id`
--

-- --------------------------------------------------------

--
-- Structure de la table `reports`
--
-- Création :  mer. 10 mars 2021 à 09:14
--

DROP TABLE IF EXISTS `reports`;
CREATE TABLE `reports` (
  `id` int(11) NOT NULL,
  `typeReportID` int(11) NOT NULL,
  `description` varchar(300) NOT NULL,
  `authorUserID` int(11) NOT NULL,
  `targetedMessageID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- RELATIONS POUR LA TABLE `reports`:
--   `typeReportID`
--       `typesreports` -> `id`
--   `targetedMessageID`
--       `messages` -> `id`
--   `authorUserID`
--       `users` -> `id`
--

-- --------------------------------------------------------

--
-- Structure de la table `roles`
--
-- Création :  lun. 08 mars 2021 à 14:37
--

DROP TABLE IF EXISTS `roles`;
CREATE TABLE `roles` (
  `id` int(11) NOT NULL,
  `groupID` int(11) NOT NULL,
  `place` int(11) NOT NULL,
  `name` varchar(30) NOT NULL,
  `description` varchar(100) NOT NULL,
  `color` varchar(7) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- RELATIONS POUR LA TABLE `roles`:
--   `groupID`
--       `groups` -> `id`
--

-- --------------------------------------------------------

--
-- Structure de la table `typesmedias`
--
-- Création :  lun. 08 mars 2021 à 13:40
--

DROP TABLE IF EXISTS `typesmedias`;
CREATE TABLE `typesmedias` (
  `id` int(11) NOT NULL,
  `name` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- RELATIONS POUR LA TABLE `typesmedias`:
--

--
-- Déchargement des données de la table `typesmedias`
--

INSERT INTO `typesmedias` (`id`, `name`) VALUES
(1, 'image/png'),
(2, 'image/jpg'),
(3, 'image/jpeg'),
(4, 'image/gif'),
(5, 'video/mp4'),
(6, 'video/webm'),
(7, 'video/ogg'),
(8, 'audio/mp3'),
(9, 'audio/mpeg'),
(10, 'audio/wav');

-- --------------------------------------------------------

--
-- Structure de la table `typespermissions`
--
-- Création :  lun. 08 mars 2021 à 13:40
--

DROP TABLE IF EXISTS `typespermissions`;
CREATE TABLE `typespermissions` (
  `id` int(11) NOT NULL,
  `name` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- RELATIONS POUR LA TABLE `typespermissions`:
--

--
-- Déchargement des données de la table `typespermissions`
--

INSERT INTO `typespermissions` (`id`, `name`) VALUES
(1, 'type_perm_admin'),
(2, 'type_perm_moderation'),
(3, 'type_perm_talk'),
(4, 'type_perm_other');

-- --------------------------------------------------------

--
-- Structure de la table `typesreports`
--
-- Création :  lun. 08 mars 2021 à 13:40
--

DROP TABLE IF EXISTS `typesreports`;
CREATE TABLE `typesreports` (
  `id` int(11) NOT NULL,
  `name` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- RELATIONS POUR LA TABLE `typesreports`:
--

--
-- Déchargement des données de la table `typesreports`
--

INSERT INTO `typesreports` (`id`, `name`) VALUES
(1, 'type_report_threat'),
(2, 'type_report_swearword'),
(3, 'type_report_indecent');

-- --------------------------------------------------------

--
-- Structure de la table `users`
--
-- Création :  mer. 10 mars 2021 à 09:13
--

DROP TABLE IF EXISTS `users`;
CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `email` varchar(100) NOT NULL,
  `password` varchar(64) NOT NULL,
  `name` varchar(30) NOT NULL,
  `profilPictureURL` varchar(100) NOT NULL,
  `active` tinyint(1) NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- RELATIONS POUR LA TABLE `users`:
--

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `admins`
--
ALTER TABLE `admins`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `channels`
--
ALTER TABLE `channels`
  ADD PRIMARY KEY (`id`),
  ADD KEY `groupID` (`groupID`);

--
-- Index pour la table `groups`
--
ALTER TABLE `groups`
  ADD PRIMARY KEY (`id`),
  ADD KEY `ownerID` (`ownerUserID`);

--
-- Index pour la table `medias`
--
ALTER TABLE `medias`
  ADD PRIMARY KEY (`id`),
  ADD KEY `messageID` (`messageID`),
  ADD KEY `typeMediaID` (`typeMediaID`);

--
-- Index pour la table `messages`
--
ALTER TABLE `messages`
  ADD PRIMARY KEY (`id`),
  ADD KEY `senderID` (`senderUserID`),
  ADD KEY `receiverUserID` (`receiverUserID`),
  ADD KEY `receiverGroupID` (`receiverGroupID`),
  ADD KEY `receiverChannelID` (`receiverChannelID`);

--
-- Index pour la table `permissions`
--
ALTER TABLE `permissions`
  ADD PRIMARY KEY (`id`),
  ADD KEY `typePermissionID` (`typePermissionID`);

--
-- Index pour la table `relationschannelsrolespermissions`
--
ALTER TABLE `relationschannelsrolespermissions`
  ADD PRIMARY KEY (`channelID`,`roleID`,`permissionID`) USING BTREE,
  ADD KEY `channelID` (`channelID`),
  ADD KEY `roleID` (`roleID`),
  ADD KEY `permissionID` (`permissionID`);

--
-- Index pour la table `relationsgroupsusers`
--
ALTER TABLE `relationsgroupsusers`
  ADD PRIMARY KEY (`groupID`,`userID`),
  ADD KEY `groupID` (`groupID`),
  ADD KEY `userID` (`userID`);

--
-- Index pour la table `relationsrolespermissions`
--
ALTER TABLE `relationsrolespermissions`
  ADD PRIMARY KEY (`roleID`,`permissionID`) USING BTREE,
  ADD KEY `roleID` (`roleID`),
  ADD KEY `permissionID` (`permissionID`);

--
-- Index pour la table `relationsrolesusers`
--
ALTER TABLE `relationsrolesusers`
  ADD PRIMARY KEY (`roleID`,`userID`) USING BTREE,
  ADD KEY `roleID` (`roleID`),
  ADD KEY `userID` (`userID`);

--
-- Index pour la table `reports`
--
ALTER TABLE `reports`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `authorID_targetedMessageID` (`authorUserID`,`targetedMessageID`) USING BTREE,
  ADD KEY `typeReportID` (`typeReportID`),
  ADD KEY `targetedMessageID` (`targetedMessageID`),
  ADD KEY `authorID` (`authorUserID`) USING BTREE;

--
-- Index pour la table `roles`
--
ALTER TABLE `roles`
  ADD PRIMARY KEY (`id`),
  ADD KEY `groupID` (`groupID`);

--
-- Index pour la table `typesmedias`
--
ALTER TABLE `typesmedias`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `typespermissions`
--
ALTER TABLE `typespermissions`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `typesreports`
--
ALTER TABLE `typesreports`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `admins`
--
ALTER TABLE `admins`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT pour la table `channels`
--
ALTER TABLE `channels`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT pour la table `groups`
--
ALTER TABLE `groups`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT pour la table `medias`
--
ALTER TABLE `medias`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT pour la table `messages`
--
ALTER TABLE `messages`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT pour la table `permissions`
--
ALTER TABLE `permissions`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;
--
-- AUTO_INCREMENT pour la table `reports`
--
ALTER TABLE `reports`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT pour la table `roles`
--
ALTER TABLE `roles`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
--
-- AUTO_INCREMENT pour la table `typesmedias`
--
ALTER TABLE `typesmedias`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
--
-- AUTO_INCREMENT pour la table `typespermissions`
--
ALTER TABLE `typespermissions`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT pour la table `typesreports`
--
ALTER TABLE `typesreports`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT pour la table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `channels`
--
ALTER TABLE `channels`
  ADD CONSTRAINT `channels_ibfk_1` FOREIGN KEY (`groupID`) REFERENCES `groups` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `groups`
--
ALTER TABLE `groups`
  ADD CONSTRAINT `groups_ibfk_1` FOREIGN KEY (`ownerUserID`) REFERENCES `users` (`id`) ON UPDATE CASCADE;

--
-- Contraintes pour la table `medias`
--
ALTER TABLE `medias`
  ADD CONSTRAINT `medias_ibfk_1` FOREIGN KEY (`typeMediaID`) REFERENCES `typesmedias` (`id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `medias_ibfk_2` FOREIGN KEY (`messageID`) REFERENCES `messages` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `messages`
--
ALTER TABLE `messages`
  ADD CONSTRAINT `messages_ibfk_1` FOREIGN KEY (`senderUserID`) REFERENCES `users` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `messages_ibfk_2` FOREIGN KEY (`receiverUserID`) REFERENCES `users` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `messages_ibfk_3` FOREIGN KEY (`receiverGroupID`) REFERENCES `groups` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `messages_ibfk_4` FOREIGN KEY (`receiverChannelID`) REFERENCES `channels` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `permissions`
--
ALTER TABLE `permissions`
  ADD CONSTRAINT `permissions_ibfk_1` FOREIGN KEY (`typePermissionID`) REFERENCES `typespermissions` (`id`) ON UPDATE CASCADE;

--
-- Contraintes pour la table `relationschannelsrolespermissions`
--
ALTER TABLE `relationschannelsrolespermissions`
  ADD CONSTRAINT `relationschannelsrolespermissions_ibfk_2` FOREIGN KEY (`permissionID`) REFERENCES `permissions` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `relationschannelsrolespermissions_ibfk_3` FOREIGN KEY (`channelID`) REFERENCES `channels` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `relationschannelsrolespermissions_ibfk_4` FOREIGN KEY (`roleID`) REFERENCES `roles` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `relationsgroupsusers`
--
ALTER TABLE `relationsgroupsusers`
  ADD CONSTRAINT `relationsgroupsusers_ibfk_1` FOREIGN KEY (`groupID`) REFERENCES `groups` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `relationsgroupsusers_ibfk_2` FOREIGN KEY (`userID`) REFERENCES `users` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `relationsrolespermissions`
--
ALTER TABLE `relationsrolespermissions`
  ADD CONSTRAINT `relationsrolespermissions_ibfk_2` FOREIGN KEY (`permissionID`) REFERENCES `permissions` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `relationsrolespermissions_ibfk_3` FOREIGN KEY (`roleID`) REFERENCES `roles` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `relationsrolesusers`
--
ALTER TABLE `relationsrolesusers`
  ADD CONSTRAINT `relationsrolesusers_ibfk_2` FOREIGN KEY (`userID`) REFERENCES `users` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `relationsrolesusers_ibfk_3` FOREIGN KEY (`roleID`) REFERENCES `roles` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `reports`
--
ALTER TABLE `reports`
  ADD CONSTRAINT `reports_ibfk_1` FOREIGN KEY (`typeReportID`) REFERENCES `typesreports` (`id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `reports_ibfk_2` FOREIGN KEY (`targetedMessageID`) REFERENCES `messages` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `reports_ibfk_3` FOREIGN KEY (`authorUserID`) REFERENCES `users` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `roles`
--
ALTER TABLE `roles`
  ADD CONSTRAINT `roles_ibfk_1` FOREIGN KEY (`groupID`) REFERENCES `groups` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
