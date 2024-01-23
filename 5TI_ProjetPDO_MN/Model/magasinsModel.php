<?php

function selectAllShops($pdo)
{
    try {
        $query = "select * from magasin";
        $selectAllShops = $pdo->prepare($query);
        $selectAllShops ->execute();
        $magasins=$selectAllShops->fetchAll();
        return $magasins; 
    } catch (PDOException $e) {
        $message = $e->getMessage();
        die($message);
    }
}