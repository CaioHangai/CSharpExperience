# DIO - Trilha .NET - API e Entity Framework

## Desafio de projeto

Neste desafio usei meus conhecimentos adquiridos no módulo de API e Entity Framework, da trilha .NET da DIO.

## Contexto

* Construir um sistema gerenciador de tarefas, onde o usuário poderá cadastrar uma lista de tarefas que permitirá organizar melhor a sua rotina.

Essa lista de tarefas precisa ter um CRUD, ou seja, deverá permitir que o usuário obtenha os registros, crie, salve e delete esses registros.

* A aplicação deverá ser do tipo Web API ou MVC.

* A sua classe principal, a classe de tarefa, deve ser a seguinte:

[Diagrama da classe Tarefa](https://github.com/CaioHangai/CSharpExperience/blob/main/2BootcampPotencial.NETDeveloper/Modulo%20API/GerenciadorTarefasWebAPI/Image/diagramaClasse.png)

* Deve-se também gerar a migration para atualização no banco de dados.

## Métodos esperados

É esperado os seguintes métodos:

**Swagger**

[![Métodos Swagger](https://github.com/CaioHangai/CSharpExperience/blob/main/2BootcampPotencial.NETDeveloper/Modulo%20API/GerenciadorTarefasWebAPI/Image/swaggerExemplo.png)](https://github.com/CaioHangai/CSharpExperience/blob/main/2BootcampPotencial.NETDeveloper/Modulo%20API/GerenciadorTarefasWebAPI/Image/swaggerExemplo.png)

**Endpoints**

| Verbo  | Endpoint               | Parâmetro | Body          |
| ------ | ---------------------- | --------- | ------------- |
| GET    | /Tarefa/{id}           | id        | N/A           |
| PUT    | /Tarefa/{id}           | id        | Schema Tarefa |
| DELETE | /Tarefa/{id}           | id        | N/A           |
| GET    | /Tarefa/ObterTodos     | N/A       | N/A           |
| GET    | /Tarefa/ObterPorTitulo | titulo    | N/A           |
| GET    | /Tarefa/ObterPorData   | data      | N/A           |
| GET    | /Tarefa/ObterPorStatus | status    | N/A           |
| POST   | /Tarefa                | N/A       | Schema Tarefa |

**Schema**

Esse é o schema (model) de Tarefa, utilizado para passar para os métodos que exigirem

```
{
  "id": 0,
  "titulo": "string",
  "descricao": "string",
  "data": "2022-06-08T01:31:07.056Z",
  "status": "Pendente"
}
```
## Solução

Criei uma Web API conforme solicitado no desafio obedecendo as regras descritas acima, o resultado foi um programa funcional, para ver mais do codigo utilize os links abaixo :arrow_double_down: . 

**Controller** 

* :link:[Controllers](https://github.com/CaioHangai/CSharpExperience/blob/main/2BootcampPotencial.NETDeveloper/Modulo%20API/GerenciadorTarefasWebAPI/GerenciadorTarefasWebAPI/Controllers/TarefaController.cs)

**Models**

* :link:[Models](https://github.com/CaioHangai/CSharpExperience/tree/main/2BootcampPotencial.NETDeveloper/Modulo%20API/GerenciadorTarefasWebAPI/GerenciadorTarefasWebAPI/Models)

**Connection String**

* :link:[AppSettings.Jason](https://github.com/CaioHangai/CSharpExperience/blob/main/2BootcampPotencial.NETDeveloper/Modulo%20API/GerenciadorTarefasWebAPI/GerenciadorTarefasWebAPI/appsettings.Development.json)



## Acesse a plataforma da DIO no link abaixo :arrow_heading_down:

https://dio.me/sign-up?ref=TU18SH8YMC