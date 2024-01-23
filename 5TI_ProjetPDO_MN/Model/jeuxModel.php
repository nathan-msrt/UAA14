<?php

function DeleteUsersBiens($pdo)
{
    try {
        $query = "delete from biens where userid=: userid";
        $deleteUsersBiens = $pdo->prepare($query);
        $deleteUsersBiens->execute([
            'userid' => $_SESSION["user"] ->id
        ]);
    } catch (PDOException $e) {
        $message = $e->getMessage();
        die($message);
    }
}
