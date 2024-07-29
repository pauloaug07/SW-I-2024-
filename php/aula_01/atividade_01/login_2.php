<?php
    $usuario_entrada = $_POST['usuario'];
    $senha_entrada = $_POST['senha'];

    $usuario = "Carlos";
    $senha = "senha12340";

    if ($usuario_entrada == $usuario && $senha_entrada == $senha){
        echo "Bem vindo ".$usuario;
    } else {
        echo "Dados inválidos, insira as informações novamente";
    }
?>