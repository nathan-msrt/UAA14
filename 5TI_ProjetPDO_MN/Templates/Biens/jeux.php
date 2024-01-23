
    <form method="post" action="">
        <fieldset>
            <legend>Ajoute ton Jeu!</legend>
            <div class="mb-3">
                <label for="Login" class="form-label">Nom</label>
                <input type="text" placeholder="Nom" class="form-control" id="Nom" aria-describedby="emailHelp" name="txtNom" required>
            </div>
            <div class="mb-3">
                <label for="Password" class="form-label">Prix</label>
                <input type="password" placeholder="Prix" class="form-control" id="Prix" name="txtPrix" required>
            </div>
            <div class = "flex-direction">
                <label for="magasin">Magasin</label>
                <select name="magasin" id="magasin" multiple>
                    <optgroup label="Namur">
                    <?php foreach($shops as $shop) : ?>
                        <?php if($shop->magasinLocalite === 'Namur') : ?>
                                <option value="<?= $shop->magasinId ?>"><?= $shop->magasinNom ?></option>
                        <?php endif ?>
                        <?php endforeach ?>
                    </optgroup>
                    <optgroup label="Charleroi">
                    <?php foreach($shops as $shop) : ?>
                                <?php if($shop->magasinLocalite === 'Charleroi') : ?>
                                <option value="<?= $shop->magasinId ?>"><?= $shop->magasinNom ?></option>
                                <?php endif ?>
                                <?php endforeach ?>
                            </optgroup>
                        <optgroup label="Liège">
                        <?php foreach($shops as $shop) : ?>
                        <?php if($shop->magasinLocalite === 'Liege') : ?>
                                <option value="<?= $shop->magasinId ?>"><?= $shop->magasinNom ?></option>
                                <?php endif ?>
                            <?php endforeach ?>
                        </optgroup>
                        <optgroup label="Bruxelles">
                            <?php foreach($shops as $shop) : ?>
                                <?php if($shop->magasinLocalite === 'Bruxelles') : ?>
                                    <option value="<?= $shop->magasinId ?>"><?= $shop->magasinNom ?></option>
                                <?php endif ?>
                            <?php endforeach ?>
                        </optgroup>
                </select>
                <label for="theme">Thème du jeu</label>
                <select name="theme" id="theme" multiple>
                    <?php foreach($themes as $theme) : ?>
                        <option value="<?= $theme->themeId ?>"><?= $theme->themeNom ?></option>
                    <?php endforeach ?>
                </select>
            </div>
            <div>
                <button name="btnEnvoi" class="btn btn-primary">Envoi</button>
            </div>
        </fieldset>
    </form>