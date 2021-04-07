<?php
// Projet: M306_SRM
// Script: Vue displayToolBox.php
// Description: construit le code HTML pour l'affichage des différents parties dynamique
// Auteur: Briard Thibaud
// Version 1.0.0 PC 01.03.2021, version initial

function displayMedias($idPost) {
    $output = "";
    $audioFiles = [];

    // Si le post contient au un média
    if (getNumberOfMediaForPost($idPost) > 0) {
        $medias = getAllMediasFormPost($idPost);
        // Si le post contient plus d'un média
        if (getNumberOfImagesOrVideosForPost($idPost) > 1) {
            $output .= "<div id=\"carousel_post$idPost\" class=\"carousel slide\" data-interval=\"false\">";
            $output .= "<ol class=\"carousel-indicators\" style=\"padding-bottom:10px\">";
            foreach ($medias as $index => $media) {
                $main = ($index == 0) ? 'active' : '';
                if (explode("/", $media['typeMedia'])[0] != "audio") {
                    $output .= "<li data-target=\"#carousel_post$idPost\" data-slide-to=\"0\" class=\"$main\"></li>";
                }
            }
            $output .= "</ol>";
            $output .= "<div class=\"carousel-inner\">";
            foreach ($medias as $index => $media) {
                $main = ($index == 0) ? ' active' : '';
                // Empeche l'audio de se retrouver dans le carousel
                if (explode("/", $media['typeMedia'])[0] == "audio") {
                    array_push($audioFiles, $media);
                }
                else {
                    $output .= "<div class=\"carousel-item $main\">";
                    $output .= typeSelector($media);
                    $output .= "</div>";
                }
            }
            $output .= "</div>";
            $output .= "<a class=\"carousel-control-prev h-75\" href=\"#carousel_post$idPost\" role=\"button\" data-slide=\"prev\">";
            $output .= "<span class=\"carousel-control-prev-icon\" aria-hidden=\"true\"></span>";
            $output .= "<span class=\"sr-only\">Previous</span>";
            $output .= "</a>";
            $output .= "<a class=\"carousel-control-next h-75\" href=\"#carousel_post$idPost\" role=\"button\" data-slide=\"next\">";
            $output .= "<span class=\"carousel-control-next-icon\" aria-hidden=\"true\"></span>";
            $output .= "<span class=\"sr-only\">Next</span>";
            $output .= "</a>";
            $output .= "</div>";
        }
        else {
            foreach ($medias as $index => $media) {
                if (explode("/", $media['typeMedia'])[0] == "audio") {
                    array_push($audioFiles, $media);
                }
                else {
                    $output .= typeSelector($media);
                }
            }
        }
    
        $medias = $audioFiles;
        foreach ($medias as $index => $media) {
            $output .= typeSelector($media);
        }
    }

    return $output;
}

function typeSelector($media) {
    $output = "";
    
    switch (explode("/", $media['typeMedia'])[0]) {
        case 'image':
            $output = displayImage($media);
            break;

        case 'video':
            $output = displayVideo($media);
            break;
        
        case 'audio':
            $output = displayAudio($media);
            break;
            
        default:
            # code...
            break;
    }

    return $output;
}

function displayImage($media) {
    $output = "";

    $output .= "<img class=\"card-img-top w-100\" src=\"medias/" . $media['nameMedia'] . "\" alt=\"" . $media['nameMedia'] . "\">";

    return $output;
}

function displayVideo($media) {
    $output = "";

    $output .= "<video class=\"card-img-top w-100\" controls autoplay muted loop>";
    $output .= "<source src=\"medias/" . $media['nameMedia'] . "\" type=\"" . $media['typeMedia'] . "\">";
    $output .= "</video>";

    return $output;
}

function displayAudio($media) {
    $output = "";

    $output .= "<audio  class=\"card-img-top w-100\" controls>";
    $output .= "<source src=\"medias/" . $media['nameMedia'] . "\" type=\"" . $media['typeMedia'] . "\">";
    $output .= "</audio>";

    return $output;
}

/**
 * construit le code HTML pour l'affichage de la liste des groupes données
 * @param array $groups : les groupes données
 * @return string code HTML pour l'affichage de la liste
 */
function displayListProfilPicture($data) {
    // Initialize
    $output = '';

    // Processing
    foreach ($data as $key => $row) {
        $output .= '<li class="list-group-item d-flex justify-content-between align-items-center position-relative">';
        $output .= '<a onclick="callChannels(' . $row['id'] . ')" class="rounded-circle"> ';
        $output .= '<img src="ressources_medias/groups/' . $row['profilPictureURL'] . '" class="rounded-circle" style="height: 75px;" alt="' . $row['profilPictureURL'] . '">';
        //$output .= '<span class="badge badge-danger badge-pill position-absolute" style="right:20%; bottom:10%;">1</span>';
        $output .= '</a>';
        $output .= '</li>';
    }

    // Exit
    return $output;
}

/**
 * construit le code HTML pour l'affichage de la liste des groupes données
 * @param array $groups : les groupes données
 * @return string code HTML pour l'affichage de la liste
 */
function displayListChannels($data) {
    // Initialize
    $output = '';

    // Processing
    
    foreach ($data as $key => $row) {
        $output .= '<li class="list-group-item d-flex justify-content-between align-items-center position-relative">';
        $output .= '<button onclick="callMessages(' . $row['id'] . ')" class="btn btn-secondary btn-sm">' . $row['name'] . '</button>';
        $output .= '</li>';
    }

    // Exit
    return $output;
}

/**
 * construit le code HTML pour l'affichage de la liste des groupes données
 * @param array $groups : les groupes données
 * @return string code HTML pour l'affichage de la liste
 */
function displayListMessages($data) {
    // Initialize
    $output = '';

    // Processing
    
    foreach ($data as $key => $row) {
        $output .= '<div class="media">';
        $output .= '<img style="height: 65px;"  class="mr-3 rounded-circle" src="ressources_medias/users/' . $row['profilPictureURL'] . '" alt="' . $row['profilPictureURL'] . '">';
        $output .= '<div class="media-body">';
        $output .= '<h5 class="mt-0">' . $row['username'] . '</h5>';
        $output .= '<p>' . $row['content'] . '</p>';
        $output .= '</div>';
        $output .= '</div>';
    }

    // Exit
    return $output;
}