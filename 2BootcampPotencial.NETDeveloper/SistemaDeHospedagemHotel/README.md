# DIO - Trilha .NET - Explorando a linguagem C#



## Desafio de projeto

Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de explorando a linguagem C#, da trilha .NET da DIO.

## Contexto

Você foi contratado para construir um sistema de hospedagem, que será usado para realizar uma reserva em um hotel. Você precisará usar a classe Pessoa, que representa o hóspede, a classe Suíte, e a classe Reserva, que fará um relacionamento entre ambos.

O seu programa deverá calcular corretamente os valores dos métodos da classe Reserva, que precisará trazer a quantidade de hóspedes e o valor da diária, concedendo um desconto de 10% para caso a reserva seja para um período maior que 10 dias.

## Regras e validações

1. Não deve ser possível realizar uma reserva de uma suíte com capacidade menor do que a quantidade de hóspedes. Exemplo: Se é uma suíte capaz de hospedar 2 pessoas, então ao passar 3 hóspedes deverá retornar uma exception.
2. O método ObterQuantidadeHospedes da classe Reserva deverá retornar a quantidade total de hóspedes, enquanto que o método CalcularValorDiaria deverá retornar o valor da diária (Dias reservados x valor da diária).
3. Caso seja feita uma reserva igual ou maior que 10 dias, deverá ser concedido um desconto de 10% no valor da diária.

<img src="https://github.com/CaioHangai/BootcampPotencial.NETDeveloper/blob/main/SistemaDeHospedagemHotel/Diagrama%20Classe/diagrama_classe_hotel.png " /> 

## Solução

Desenvolvi a Solução conforme o diagrama de classes, acrescentando apenas a Classe DomainException para tratar minhas exceções de forma mais efetiva em uma possível refatoração futura. Adicionei ainda um menu no programa principal para instanciar a classe Suíte, onde ao usuário escolher a suíte desejada o método SelecaoSuite instancia a classe com as informações contidas nele.

Links para acessar a solução abaixo:

* :link: [Program.cs](https://github.com/CaioHangai/BootcampPotencial.NETDeveloper/blob/main/SistemaDeHospedagemHotel/SistemaHospedagem/Program.cs)
* :link: [Models](https://github.com/CaioHangai/BootcampPotencial.NETDeveloper/tree/main/SistemaDeHospedagemHotel/SistemaHospedagem/Models)
* :link: [Exception](https://github.com/CaioHangai/BootcampPotencial.NETDeveloper/tree/main/SistemaDeHospedagemHotel/SistemaHospedagem/Models/Exceptions)

## :arrow_double_down: Aprenda com a Digital Inovvation One :arrow_double_down: 



:link:[Clique e comece a aprender na DIO](https://dio.me/sign-up?ref=TU18SH8YMC)

