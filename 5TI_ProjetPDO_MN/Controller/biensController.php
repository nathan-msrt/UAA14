<?php

require_once "Model/magasinsModel.php";
require_once "Model/themeModel.php";

$uri = $_SERVER['REQUEST_URI'];

if($uri === '/index.php' || $uri === "/" ){
    require_once "Templates/Biens/voirTousLesBiens.php";
}else if ($uri === '/voirLeBien'){
    require_once "Templates/Biens/voirLeBien.php";
}else if ($uri === '/jeux'){
    $shops = selectAllShops($pdo);
    $themes = selectAllThemes($pdo);
    
    require_once "Templates/Biens/jeux.php";
}