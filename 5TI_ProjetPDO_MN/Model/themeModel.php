<?php
function selectAllThemes($pdo)
{
    try {
        $query = "select * from theme";
        $selectAllThemes = $pdo->prepare($query);
        $selectAllThemes ->execute();
        $themes=$selectAllThemes->fetchAll();
        return $themes; 
    } catch (PDOException $e) {
        $message = $e->getMessage();
        die($message);
    }
}