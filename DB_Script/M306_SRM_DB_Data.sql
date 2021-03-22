-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le :  lun. 22 mars 2021 à 13:24
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

--
-- Déchargement des données de la table `admins`
--
INSERT INTO `groups` (`id`, `name`, `profilPictureURL`, `ownerUserID`, `active`) VALUES
(1, 'Forum Général', 'pp_forumgeneral_01.png', 1, 1),
(2, 'Les G@m3rz', 'pp_lesg_m3rz_01.png', 10, 1),
(3, 'Révision : cours CG', 'pp_revisioncourscg_01.png', 7, 1);

--
-- Déchargement des données de la table `channels`
--

INSERT INTO `channels` (`id`, `groupID`, `place`, `name`, `description`) VALUES
(1, 1, 1, 'Général', 'file principal de discussion'),
(2, 2, 1, 'Général', 'file principal de discussion'),
(3, 3, 1, 'Général', 'file principal de discussion'),
(4, 3, 2, 'Anglais', 'pour le cours d\'anglais'),
(5, 3, 3, 'Math', 'pour le cours de math'),
(6, 3, 4, 'Physique', 'pour le cours de physique'),
(7, 3, 5, 'Economie', 'pour le cours d\'économie'),
(8, 3, 6, 'Société, L&C', 'pour les cours de société et de langue et communication');

--
-- Déchargement des données de la table `groups`
--


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
(7, 3);

--
-- Déchargement des données de la table `roles`
--

INSERT INTO `roles` (`id`, `groupID`, `place`, `name`, `description`, `color`) VALUES
(1, 3, 1, 'Professeurs', 'roles pour les professeurs', '#FF9800'),
(2, 3, 2, 'Elèves', 'roles pour les élèves', '#03A9F4'),
(3, 1, 1, 'Administrateurs', 'Gère l\'administration du serveur', '#E53935'),
(4, 1, 2, 'Moderateurs', 'Gère les membres', '#29B6F6'),
(5, 1, 3, 'Membres', 'Roles de base de tous les utilisateurs', '#8BC34A'),
(6, 2, 1, 'Destiny 2', 'Joueurs de Destiny 2', '#29B6F6'),
(7, 2, 2, 'LoL', 'Joueurs de LoL', '#FDD835'),
(8, 2, 3, 'CS-GO', 'Joueurs de CS-GO', '#FFF59D'),
(9, 2, 4, 'WoW', 'Joueurs de WoW', '#3F51B5'),
(10, 2, 5, 'SSBU', 'Joueurs de SSBU', '#F44336');

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
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
