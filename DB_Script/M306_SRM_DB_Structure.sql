-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le :  lun. 08 mars 2021 à 13:49
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
-- Base de données :  `m306_db_srm`
--

-- --------------------------------------------------------

--
-- Structure de la table `channels`
--

DROP TABLE IF EXISTS `channels`;
CREATE TABLE `channels` (
  `groupID` int(11) NOT NULL,
  `id` int(11) NOT NULL,
  `name` varchar(30) NOT NULL,
  `description` varchar(100) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `groups`
--

DROP TABLE IF EXISTS `groups`;
CREATE TABLE `groups` (
  `id` int(11) NOT NULL,
  `name` varchar(30) NOT NULL,
  `profilPicture` varchar(100) NOT NULL,
  `ownerID` int(11) NOT NULL,
  `active` tinyint(1) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `media`
--

DROP TABLE IF EXISTS `media`;
CREATE TABLE `media` (
  `id` int(11) NOT NULL,
  `messageID` int(11) NOT NULL,
  `url` varchar(100) NOT NULL,
  `typeMediaID` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `messages`
--

DROP TABLE IF EXISTS `messages`;
CREATE TABLE `messages` (
  `id` int(11) NOT NULL,
  `date` date NOT NULL,
  `content` text NOT NULL,
  `senderID` int(11) NOT NULL,
  `receiverUserID` int(11) NOT NULL,
  `receiverGroupID` int(11) NOT NULL,
  `receiverChannelID` int(11) NOT NULL,
  `active` tinyint(1) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `permissions`
--

DROP TABLE IF EXISTS `permissions`;
CREATE TABLE `permissions` (
  `id` int(11) NOT NULL,
  `name` varchar(30) NOT NULL,
  `description` varchar(100) NOT NULL,
  `typePermissionID` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

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
-- Structure de la table `relationgroupschannelsrolespermissions`
--

DROP TABLE IF EXISTS `relationgroupschannelsrolespermissions`;
CREATE TABLE `relationgroupschannelsrolespermissions` (
  `groupID` int(11) NOT NULL,
  `channelID` int(11) NOT NULL,
  `roleID` int(11) NOT NULL,
  `permissionID` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `relationgroupsrolespermissions`
--

DROP TABLE IF EXISTS `relationgroupsrolespermissions`;
CREATE TABLE `relationgroupsrolespermissions` (
  `groupID` int(11) NOT NULL,
  `roleID` int(11) NOT NULL,
  `permissionID` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `relationgroupsrolesusers`
--

DROP TABLE IF EXISTS `relationgroupsrolesusers`;
CREATE TABLE `relationgroupsrolesusers` (
  `groupID` int(11) NOT NULL,
  `roleID` int(11) NOT NULL,
  `userID` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `relationgroupsusers`
--

DROP TABLE IF EXISTS `relationgroupsusers`;
CREATE TABLE `relationgroupsusers` (
  `groupID` int(11) NOT NULL,
  `userID` int(11) NOT NULL,
  `aka` varchar(30) DEFAULT NULL,
  `ban` tinyint(1) NOT NULL DEFAULT '0'
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `report`
--

DROP TABLE IF EXISTS `report`;
CREATE TABLE `report` (
  `id` int(11) NOT NULL,
  `typeReportID` int(11) NOT NULL,
  `description` varchar(300) NOT NULL,
  `authorID` int(11) NOT NULL,
  `targetedMessageID` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `roles`
--

DROP TABLE IF EXISTS `roles`;
CREATE TABLE `roles` (
  `groupID` int(11) NOT NULL,
  `id` int(11) NOT NULL,
  `name` varchar(30) NOT NULL,
  `description` varchar(100) NOT NULL,
  `color` varchar(7) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `typesmedias`
--

DROP TABLE IF EXISTS `typesmedias`;
CREATE TABLE `typesmedias` (
  `id` int(11) NOT NULL,
  `name` varchar(30) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

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

DROP TABLE IF EXISTS `typespermissions`;
CREATE TABLE `typespermissions` (
  `id` int(11) NOT NULL,
  `name` varchar(30) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

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

DROP TABLE IF EXISTS `typesreports`;
CREATE TABLE `typesreports` (
  `id` int(11) NOT NULL,
  `name` varchar(30) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

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

DROP TABLE IF EXISTS `users`;
CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `email` varchar(100) NOT NULL,
  `password` varchar(64) NOT NULL,
  `name` varchar(30) NOT NULL,
  `profilPicture` varchar(100) NOT NULL,
  `active` tinyint(1) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `channels`
--
ALTER TABLE `channels`
  ADD PRIMARY KEY (`groupID`,`id`);

--
-- Index pour la table `groups`
--
ALTER TABLE `groups`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `media`
--
ALTER TABLE `media`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `messages`
--
ALTER TABLE `messages`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `permissions`
--
ALTER TABLE `permissions`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `relationgroupschannelsrolespermissions`
--
ALTER TABLE `relationgroupschannelsrolespermissions`
  ADD PRIMARY KEY (`groupID`,`channelID`,`roleID`,`permissionID`);

--
-- Index pour la table `relationgroupsrolespermissions`
--
ALTER TABLE `relationgroupsrolespermissions`
  ADD PRIMARY KEY (`groupID`,`roleID`,`permissionID`);

--
-- Index pour la table `relationgroupsrolesusers`
--
ALTER TABLE `relationgroupsrolesusers`
  ADD PRIMARY KEY (`groupID`,`roleID`,`userID`);

--
-- Index pour la table `relationgroupsusers`
--
ALTER TABLE `relationgroupsusers`
  ADD PRIMARY KEY (`groupID`,`userID`);

--
-- Index pour la table `report`
--
ALTER TABLE `report`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `authorID` (`authorID`,`targetedMessageID`);

--
-- Index pour la table `roles`
--
ALTER TABLE `roles`
  ADD PRIMARY KEY (`groupID`,`id`);

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
-- AUTO_INCREMENT pour la table `groups`
--
ALTER TABLE `groups`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT pour la table `media`
--
ALTER TABLE `media`
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
-- AUTO_INCREMENT pour la table `report`
--
ALTER TABLE `report`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
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
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
