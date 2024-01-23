
<form method="post" action="">
    <fieldset>
        <legend>Inscription</legend>
        <div class="mb-3">
            <label for="Nom" class="form-label">Nom</label>
            <input type="text" placeholder="Nom" class="form-control" id="Nom" name="nom"   value="<?php if(isset($_SESSION["user"])) :?><?= $_SESSION["user"]->utilisateurNom ?> <?php endif ?>">
            <?php if(isset($messageErrorLogin["nom"])) : ?><p><?= $messageErrorLogin["nom"] ?> </p> <?php endif ?> 
        </div>
        <div class="mb-3">
            <label for="Prenom" class="form-label">Prénom</label>
            <input type="text" placeholder="Prénom" class="form-control" id="Prenom" name="prenom" value="<?php if(isset($_SESSION["user"])) :?><?= $_SESSION["user"]->utilisateurPrenom ?><?php endif ?>">
            <?php if(isset($messageErrorLogin["prenom"])) : ?><p><?= $messageErrorLogin["prenom"] ?> </p> <?php endif ?> 
        </div>
        <div class="mb-3">
            <label for="email" class="form-label">Email</label>
            <input type="email" placeholder="Email" class="form-control" id="email" name="email" value="<?php if(isset($_SESSION["user"])) :?><?= $_SESSION["user"]->utilisateurEmail ?><?php endif ?>">>
            <?php if(isset($messageErrorLogin["email"])) : ?><p><?= $messageErrorLogin["email"] ?> </p><?php endif ?> 
        </div>
        <div class="mb-3">
            <label for="pseudo" class="form-label">Pseudo</label>
            <input type="text" placeholder="pseudo" class="form-control" id="pseudo" name="pseudo" value="<?php if(isset($_SESSION["user"])) :?><?= $_SESSION["user"]->utilisateurPseudo ?><?php endif ?>">>
            <?php if(isset($messageErrorLogin["pseudo"])) : ?><p><?= $messageErrorLogin["pseudo"] ?> </p><?php endif ?> 
        </div>
        <div class="mb-3">
            <label for="mot_de_passe" class="form-label">Mot de passe</label>
            <input type="<?php if(isset($_SESSION['user'])) : ?>text<?php else :?>password<?php endif ?>" placeholder="Mot de passe" class="form-control" id="mot_de_passe" name="mot_de_passe" value="<?php if(isset($_SESSION["user"])) :?><?= $_SESSION["user"]->utilisateurMotDePasse ?><?php endif ?>">>
            
            <?php if(isset($messageErrorLogin["mot_de_passe"])) : ?><p><?= str_replace("_", " ", $messageErrorLogin["mot_de_passe"] ) ?> </p> <?php endif ?> 
        </div>
        <div class = "flex" >
            <input type="submit" name="btnEnvoi" class="btn btn-primary" value = "Envoyer"></input>
            <?php if(isset($_SESSION['user'])) : ?><input type="submit" name="btnEnvoi" class="btn btn-primary" value = "Supprimer"></input><?php endif ?>
        </div>
        
    </fieldset>
</form>