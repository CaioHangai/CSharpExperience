# Boocamp DIO/ Pottencial - Trilha .NET - Fundamentos

## Desafio de projeto

Para este desafio, precisei usar os conhecimentos adquiridos no módulo de fundamentos, da trilha .NET da DIO.

## Contexto
Você foi contratado para construir um sistema para um estacionamento, que será usado para gerenciar os veículos estacionados e realizar suas operações, como por exemplo adicionar um veículo, remover um veículo (e exibir o valor cobrado durante o período) e listar os veículos.

## Proposta
Você precisará construir uma classe chamada "Estacionamento", conforme o diagrama abaixo:
<img src="https://github.com/CaioHangai/CSharpExperience/blob/main/2BootcampPotencial.NETDeveloper/SistemaParaEstacionamentoCSharp/Diagrama%20de%20Classes/diagrama_classe.png" />

A classe contém três variáveis, sendo:

**precoInicial**: Tipo decimal. É o preço cobrado para deixar seu veículo estacionado.

**precoPorHora**: Tipo decimal. É o preço por hora que o veículo permanecer estacionado.

**veiculos**: É uma lista de string, representando uma coleção de veículos estacionados. Contém apenas a placa do veículo.

A classe contém três métodos, sendo:

**AdicionarVeiculo**: Método responsável por receber uma placa digitada pelo usuário e guardar na variável **veiculos**.

**RemoverVeiculo**: Método responsável por verificar se um determinado veículo está estacionado, e caso positivo, irá pedir a quantidade de horas que ele permaneceu no estacionamento. Após isso, realiza o seguinte cálculo: **precoInicial** * **precoPorHora**, exibindo para o usuário.

**ListarVeiculos**: Lista todos os veículos presentes atualmente no estacionamento. Caso não haja nenhum, exibir a mensagem "Não há veículos estacionados".

Por último, deverá ser feito um menu interativo com as seguintes ações implementadas:
1. Cadastrar veículo
2. Remover veículo
3. Listar veículos
4. Encerrar

## Solução
Na minha solução decidi deixar o preço inicial como forma de taxa para estacionar e o valor cobrado por hora fixo, exibo esses valores antes do usuário começar a utilizar o programa, caso o usuário esteja de acordo com os valores ele interage com o sistema aceitando as condições e entra de fato no menu para cadastrar o veículo. Abaixo segue o link para a classe Estacionamento e o programa em si(Program.cs) :arrow_double_down:

* :link:[Classe Estacionamento](https://github.com/CaioHangai/CSharpExperience/blob/main/2BootcampPotencial.NETDeveloper/SistemaParaEstacionamentoCSharp/ConsoleApp1/ConsoleApp1/Models/Estacionamento.cs)
* :link:[Program.cs](https://github.com/CaioHangai/CSharpExperience/blob/main/2BootcampPotencial.NETDeveloper/SistemaParaEstacionamentoCSharp/ConsoleApp1/ConsoleApp1/Program.cs)

## Acesse a plataforma da DIO no link abaixo :arrow_heading_down:

https://dio.me/sign-up?ref=TU18SH8YMC