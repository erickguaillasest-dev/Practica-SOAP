<?php

//crear cliente

$cliente = new SoapClient('http://localhost:8080/ServicioWeb_SOAP/WSOperaciones?WSDL');

//utilizar metodo

$resultado_pago = $cliente->ProcesarPago([
    "total" => 1000,
    "pago" => 798789
 
])->return;

if($resultado_pago>=0){
    echo "Pago realizado, su vuelto es  $resultado_pago";
}else{
    echo 'dinero insuficiente';
}
