<?php

require_once "Model/userModel.php";

$uri = $_SERVER["REQUEST_URI"];

if($uri === "/inscription"){
    if(isset($_POST["btnEnvoi"])){
        $messageErrorLogin = verifData();
        if (!($messageErrorLogin)) {
            createUser($pdo);
            header('location:/connexion');
        }
    }
    require_once "Templates/users/inscriptionOrEditProfil.php";
}elseif ($uri === "/connexion") {
    if(isset($_POST["btnEnvoi"])){
            chercherUser($pdo);
            header('location:/');
        
    }
    require_once "Templates/users/connexion.php";
}elseif ($uri === "/deconnexion") {
        session_destroy();
        header('location:/');
}elseif ($uri === "/profil") {
    if(isset($_POST["bntEnvoi"])){

        UpdateUser($pdo);
        UpdateSession($pdo);
        header('location:/profil');
    }elseif (isset($_POST['btnSuppression'])) {
        DeleteUsersBiens($pdo);
        DeleteUser($pdo);
        session_destroy();
        header('location:/');
    }
    require_once "Templates/users/inscriptionOrEditProfil.php";
}

function verifData(){
    foreach($_POST as $key => $value) {
        if (empty(str_replace(' ', '', $value))) {
            $messageErrorLogin[$key] = "Votre " . $key . " est vide";
        }
    }
    if (isset($messageErrorLogin)) {
        return $messageErrorLogin;
    }
    else {
        return false;
    }
}
