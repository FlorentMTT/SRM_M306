-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Hôte : localhost:3306
-- Généré le : ven. 09 avr. 2021 à 14:30
-- Version du serveur :  5.7.24
-- Version de PHP : 7.2.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `m306_srm_db`
--

-- --------------------------------------------------------

--
-- Structure de la table `admins`
--

CREATE TABLE `admins` (
  `id` int(11) NOT NULL,
  `login` varchar(30) NOT NULL,
  `password` varchar(64) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `email` varchar(100) NOT NULL,
  `password` varchar(64) NOT NULL,
  `name` varchar(30) NOT NULL,
  `profilPictureURL` varchar(100) NOT NULL,
  `active` tinyint(1) NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `users`
--

INSERT INTO `users` (`id`, `email`, `password`, `name`, `profilPictureURL`, `active`) VALUES
(1, 'jean.neymar@email.com', '8185c8ac4656219f4aa5541915079f7b3743e1b5f48bacfcc3386af016b55320', 'Jean Neymar', 'pp_jeanneymar_01.png', 1),
(2, 'alain.terrieur@email.com', '8185c8ac4656219f4aa5541915079f7b3743e1b5f48bacfcc3386af016b55320', 'Alain Terrieur', 'pp_alainterrieur_01.png', 1),
(3, 'alex.terrieur@email.com', '8185c8ac4656219f4aa5541915079f7b3743e1b5f48bacfcc3386af016b55320', 'Alex Terrieur', 'pp_alexterrieur_01.png', 1),
(4, 'sam.embouchincoin@email.com', '8185c8ac4656219f4aa5541915079f7b3743e1b5f48bacfcc3386af016b55320', 'Sam Embouchincoin', 'pp_samembouchincoin_01.png', 1),
(5, 'barack.afritt@email.com', '8185c8ac4656219f4aa5541915079f7b3743e1b5f48bacfcc3386af016b55320', 'Barack Afritt', 'pp_barackafritt_01.png', 1),
(6, 'sarah.croche@email.com', '8185c8ac4656219f4aa5541915079f7b3743e1b5f48bacfcc3386af016b55320', 'Sarah Croche', 'pp_sarahcroche_01.png', 1),
(7, 'telara.contepa@emial.com', '8185c8ac4656219f4aa5541915079f7b3743e1b5f48bacfcc3386af016b55320', 'Telara Contepa', 'pp_telaracontepa_01.png', 1),
(8, 'lou.rsesauvage@email.com', '8185c8ac4656219f4aa5541915079f7b3743e1b5f48bacfcc3386af016b55320', 'Lou Rsesauvage', 'pp_loursesauvage_01.png', 1),
(9, 'heidi.commentuva@email.com', '8185c8ac4656219f4aa5541915079f7b3743e1b5f48bacfcc3386af016b55320', 'Heidi Commentuva', 'pp_heidicommentuva_01.png', 1),
(10, 'camille.onette@email.com', '8185c8ac4656219f4aa5541915079f7b3743e1b5f48bacfcc3386af016b55320', 'Camille Onette', 'pp_camilleonette_01.png', 1);


--
-- Déchargement des données de la table `admins`
--

INSERT INTO `admins` (`id`, `login`, `password`) VALUES
(1, 'Admin_SRM', '8185c8ac4656219f4aa5541915079f7b3743e1b5f48bacfcc3386af016b55320');

-- --------------------------------------------------------


--
-- Structure de la table `roles`
--

CREATE TABLE `roles` (
  `id` int(11) NOT NULL,
  `groupID` int(11) NOT NULL,
  `place` int(11) NOT NULL,
  `name` varchar(30) NOT NULL,
  `description` varchar(100) NOT NULL,
  `color` varchar(7) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `roles`
--

INSERT INTO `roles` (`id`, `groupID`, `place`, `name`, `description`, `color`) VALUES
(1, 3, 1, 'Professeurs', 'roles pour les professeurs', '#FF9800'),
(2, 3, 2, 'Elèves', 'roles pour les élèves', '#03A9F4'),
(3, 1, 1, 'Administrateurs', 'Gère ladministration du serveur', '#E53935'),
(4, 1, 2, 'Moderateurs', 'Gère les membres', '#29B6F6'),
(5, 1, 3, 'Membres', 'Roles de base de tous les utilisateurs', '#8BC34A'),
(6, 2, 1, 'Destiny 2', 'Joueurs de Destiny 2', '#29B6F6'),
(7, 2, 2, 'LoL', 'Joueurs de LoL', '#FDD835'),
(8, 2, 3, 'CS-GO', 'Joueurs de CS-GO', '#FFF59D'),
(9, 2, 4, 'WoW', 'Joueurs de WoW', '#3F51B5'),
(10, 2, 5, 'SSBU', 'Joueurs de SSBU', '#F44336');

-- --------------------------------------------------------

--
-- Structure de la table `groups`
--

CREATE TABLE `groups` (
  `id` int(11) NOT NULL,
  `name` varchar(30) NOT NULL,
  `profilPictureURL` varchar(100) NOT NULL,
  `ownerUserID` int(11) NOT NULL,
  `active` tinyint(1) NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `groups`
--

INSERT INTO `groups` (`id`, `name`, `profilPictureURL`, `ownerUserID`, `active`) VALUES
(1, 'Forum Général', 'pp_forumgeneral_01.png', 1, 1),
(2, 'Les G@m3rz', 'pp_lesg_m3rz_01.png', 10, 1),
(3, 'Révision : cours CG', 'pp_revisioncourscg_01.png', 7, 1);

-- --------------------------------------------------------

--
-- Structure de la table `channels`
--

CREATE TABLE `channels` (
  `id` int(11) NOT NULL,
  `groupID` int(11) NOT NULL,
  `place` int(11) NOT NULL,
  `name` varchar(30) NOT NULL,
  `description` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `channels`
--

INSERT INTO `channels` (`id`, `groupID`, `place`, `name`, `description`) VALUES
(1, 1, 1, 'Général', 'file principal de discussion'),
(2, 2, 1, 'Général', 'file principal de discussion'),
(3, 3, 1, 'Général', 'file principal de discussion'),
(4, 3, 2, 'Anglais', 'pour le cours danglais'),
(5, 3, 3, 'Math', 'pour le cours de math'),
(6, 3, 4, 'Physique', 'pour le cours de physique'),
(7, 3, 5, 'Economie', 'pour le cours déconomie'),
(8, 3, 6, 'Société, L&C', 'pour les cours de société et de langue et communication');

-- --------------------------------------------------------

--
-- Structure de la table `medias`
--

CREATE TABLE `medias` (
  `id` int(11) NOT NULL,
  `messageID` int(11) NOT NULL,
  `url` varchar(100) NOT NULL,
  `typeMediaID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

-- --------------------------------------------------------

--
-- Structure de la table `messages`
--

CREATE TABLE `messages` (
  `id` int(11) NOT NULL,
  `date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `content` text NOT NULL,
  `senderUserID` int(11) NOT NULL,
  `receiverUserID` int(11) DEFAULT NULL,
  `receiverGroupID` int(11) DEFAULT NULL,
  `receiverChannelID` int(11) DEFAULT NULL,
  `active` tinyint(1) NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `messages`
--

INSERT INTO `messages` (`id`, `date`, `content`, `senderUserID`, `receiverUserID`, `receiverGroupID`, `receiverChannelID`, `active`) VALUES
(1, '2021-03-22 14:00:00', 'Salut Alain, c\'est Alex !', 3, 2, NULL, NULL, 1),
(3, '2021-03-22 14:07:14', 'Vous avez l\'exercice de Math pour vendredi ?', 5, NULL, 3, 5, 1),
(4, '2021-03-22 14:07:51', 'Non désolé', 10, NULL, 3, 5, 1);

-- --------------------------------------------------------

--
-- Structure de la table `permissions`
--

CREATE TABLE `permissions` (
  `id` int(11) NOT NULL,
  `name` varchar(30) NOT NULL,
  `description` varchar(100) NOT NULL,
  `typePermissionID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

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

CREATE TABLE `relationschannelsrolespermissions` (
  `channelID` int(11) NOT NULL,
  `roleID` int(11) NOT NULL,
  `permissionID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

-- --------------------------------------------------------

--
-- Structure de la table `relationsgroupsusers`
--

CREATE TABLE `relationsgroupsusers` (
  `groupID` int(11) NOT NULL,
  `userID` int(11) NOT NULL,
  `aka` varchar(30) DEFAULT NULL,
  `ban` tinyint(1) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- Déchargement des données de la table `relationsgroupsusers`
--

INSERT INTO `relationsgroupsusers` (`groupID`, `userID`, `aka`, `ban`) VALUES
(1, 1, 'jean', 0),
(1, 2, 'alain', 0),
(1, 3, 'alex', 0),
(1, 4, 'sam', 0),
(1, 5, 'barack', 0),
(1, 6, 'sarah', 0),
(1, 7, 'telara', 0),
(1, 8, 'lou', 0),
(1, 9, 'heidi', 0),
(1, 10, 'camille', 0),
(2, 2, 'AL123', 0),
(2, 3, 'xX_Robotz_Xx', 0),
(2, 10, 'Maya666', 0),
(3, 5, 'barack.frtt', 0),
(3, 7, 'telara.cntp', 0),
(3, 10, 'camille.ntt', 0);

-- --------------------------------------------------------

--
-- Structure de la table `relationsrolespermissions`
--

CREATE TABLE `relationsrolespermissions` (
  `roleID` int(11) NOT NULL,
  `permissionID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

-- --------------------------------------------------------

--
-- Structure de la table `relationsrolesusers`
--

CREATE TABLE `relationsrolesusers` (
  `roleID` int(11) NOT NULL,
  `userID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- Déchargement des données de la table `relationsrolesusers`
--

INSERT INTO `relationsrolesusers` (`roleID`, `userID`) VALUES
(1, 7),
(2, 5),
(2, 10),
(3, 1),
(4, 5),
(4, 7),
(4, 10),
(5, 2),
(5, 3),
(5, 4),
(5, 6),
(5, 8),
(5, 9),
(6, 10),
(7, 2),
(7, 3),
(7, 10),
(9, 10);

-- --------------------------------------------------------

--
-- Structure de la table `reports`
--

CREATE TABLE `reports` (
  `id` int(11) NOT NULL,
  `typeReportID` int(11) NOT NULL,
  `description` varchar(300) NOT NULL,
  `authorUserID` int(11) NOT NULL,
  `targetedMessageID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- Déchargement des données de la table `reports`
--

INSERT INTO `reports` (`id`, `typeReportID`, `description`, `authorUserID`, `targetedMessageID`) VALUES
(2, 1, 'Vous avez lexercice de Math pour vendredi ?', 5, 3);

-- --------------------------------------------------------


--
-- Structure de la table `typesmedias`
--

CREATE TABLE `typesmedias` (
  `id` int(11) NOT NULL,
  `name` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

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

CREATE TABLE `typespermissions` (
  `id` int(11) NOT NULL,
  `name` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

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

CREATE TABLE `typesreports` (
  `id` int(11) NOT NULL,
  `name` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

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
-- Index pour la table `typespermissions`
--
ALTER TABLE `typespermissions`
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
-- AUTO_INCREMENT pour la table `messages`
--
ALTER TABLE `messages`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT pour la table `permissions`
--
ALTER TABLE `permissions`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT pour la table `typespermissions`
--
ALTER TABLE `typespermissions`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

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
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
