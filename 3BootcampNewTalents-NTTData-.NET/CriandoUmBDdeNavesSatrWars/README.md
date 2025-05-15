# Diagrama e requisitos do banco de dados. 



## Este banco de dados atende aos seguintes requisitos do Sistema: 



**FUNCIONAMENTO DO SISTEMA:** para o Sistema de Gerenciamento de Naves, ao solicitar uma nave, o sistema busca em seu banco de dados se o piloto solicitante é devidamente habilitado para pilotar a nave requerida e se a mesma encontra-se disponível no momento da consulta, caso alguma das situações não estejam regulares, o sistema deve apresentar uma mensagem de erro, se, estiver tudo dentro dos conformes a solicitação da nave será feita, gerando um histórico de viagens com a identificação da nave e do piloto bem como sua hora de partida e sua hora de retorno, ao realizar o cadastro de Planetas, Pilotos, Naves e ao gerar o Histórico de Viagens o sistema deverá atender os seguintes itens: 

* No cadastro dos planetas deverão conter uma identificação numérica, nome, rotação, orbita, clima, população.
* No cadastro de pilotos deve ser possível cadastrar: identificação do piloto, nome, o ano de seu nascimento, e o planeta natal do mesmo.
* No cadastro da naves será gerado um ID para cada nave registrada, nome, modelo, quantidade de passageiros, peso de carga e sua classe.
* No histórico de viagens deve conter ID da nave em curso, ID do piloto responsável pela viagem, data de saída e data de chegada.
* O sistema não deve permitir que uma nave em uso esteja disponível no sistema.
* Caso o piloto não seja devidamente habilitado a pilotar a nave solicitada, o sistema não deverá autorizar a ação e informar ao operador.
* Ao solicitar uma nave o piloto deverá informar a quantidade de passageiros e o peso da carga total da nave. 



## Diagrama Entidade-Relacionamento.



![Diagrama BootCamp EVERIS](https://github.com/CaioHangai/BootcampNewTalents-NTTData-.NET/blob/main/CriandoUmBDdeNavesSatrWars/BDSisGeNa/DERImg/DERSisGeNa.jpeg)

# 

 
