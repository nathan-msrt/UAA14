<?php
function CreateUser($pdo)
{
    try {
        if (isset ($_POST["btnEnvoi"])) {
            $query = "insert into utilisateur (utilisateurNom, utilisateurPrenom, utilisateurPseudo, utilisateurEmail,  utilisateurMotDePasse, utilisateurRole) values ( :utilisateurNom, :utilisateurPrenom, :utilisateurPseudo, :utilisateurEmail, :utilisateurMotDePasse, :utilisateurRole)";
            $ajouteUser = $pdo->prepare($query);
            $ajouteUser->execute([
                'utilisateurNom'=> $_POST ['nom'],
                'utilisateurPrenom'=>$_POST ['prenom'],
                'utilisateurPseudo'=>$_POST ['pseudo'],
                'utilisateurMotDePasse'=>$_POST ['mot_de_passe'],
                'utilisateurEmail'=>$_POST ['email'],
                'utilisateurRole'=> 'user'
            ]);
        }
    } catch (PDOException $e) {
        die($e -> getMessage());
    }
}
/*try {
    $query = "SELECT * FROM biens";
    $ajoute = $pdo->prepare($query);
    $ajoute->execute();
    $biens = $ajoute->fetchAll();
} catch (PDOException $e) {
    $message = $e->getMessage();
    die($message);
}
echo '<pre>' , var_dump($biens) , '</pre>';*/

function chercherUser($pdo){
    try {
        $query = "select * from utilisateur where utilisateurPseudo=:utilisateurPseudo and utilisateurMotDePasse=:utilisateurMotDePasse";
        $chercheUser = $pdo->prepare($query);
        $chercheUser->execute([
            'utilisateurPseudo' => $_POST['pseudo'],
            'utilisateurMotDePasse' => $_POST['mot_de_passe'],
        ]);
        $user=$chercheUser -> fetch();
        var_dump($_SESSION);
        var_dump($user);
        if ($user) {
            $_SESSION['user']=$user;
        }//else pour dirre qu'on a pas de pseudo ou mot de passe valide
    } catch (PDOException $e) {
        $message = $e->getMessage();
        die($message);
    }
}
function UpdateUser($pdo)
{
    try {
        if (isset ($_POST["btnEnvoi"])) {
            $query = "update utilisateur set utilisateurNom=:utilisateurNom , utilisateurPrenom=:utilisateurPrenom, utilisateurPseudo=:utilisateurPseudo, utilisateurEmail=:utilisateurEmail,  utilisateurMotDePasse=:utilisateurMotDePasse where id=:id";
            $ajouteUser = $pdo->prepare($query);
            $ajouteUser->execute([
                'utilisateurNom'=> $_POST ['nom'],
                'utilisateurPrenom'=>$_POST ['prenom'],
                'utilisateurPseudo'=>$_POST ['pseudo'],
                'utilisateurMotDePasse'=>$_POST ['mot_de_passe'],
                'utilisateurEmail'=>$_POST ['email']
            ]);
        }
    } catch (PDOException $e) {
        die($e -> getMessage());
    }
}
function UpdateSession($pdo)
{
    try {
            $query = "select * from utilisateur where id=:id";
            $chercherUser = $pdo->prepare($query);
            $chercherUser->execute([
                'id' => $_SESSION['user']->id
            ]);
            $user=$chercherUser -> fetch();
            $_SESSION['user']=$user;
        
    } catch (PDOException $e) {
        $message = $e ->getMessage();
        die($message);
    }
}
function DeleteUser($pdo)
{
    try {
        $query = "delete from utilisateur where id=: id";
        $deleteUser = $pdo->prepare($query);
        $deleteUser->execute([
            'id' => $_SESSION["user"] ->id
        ]);
    } catch (PDOException $e) {
        $message = $e->getMessage();
        die($message);
    }
}
