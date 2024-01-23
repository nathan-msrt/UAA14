
<h1>Votre page profil</h1>
<ol>
    <div>
        <li>Nom</li>
        <p><?php $_SESSION["user"] -> utilisateurNom ?></p>
    </div>
    <div>
        <li>Prénom</li>
        <p><?php $_SESSION["user"] -> utilisateurPrenom ?></p>
    </div>
    <div>
        <li>Adresse postale</li>
        <p>Rue pichelin n°8c, 5140 Tongrinne</p>
    </div>
    <div>
        <li>Photo de profil</li>
        <div class="progress">
            <div class="progress-bar"></div>
        </div>
        <img id="imageProfil" src="Images/profil.png" alt="Mon image de profil">
    </div>
</ol>