# O que é C#



O **C#** (leia-se C-Sharp), é uma linguagem de programação orientada a objetos, que foi desenvolvida pela Microsoft e faz parte da plataforma . NET. Embora a linguagem **C#** tenha sido criada do zero, foi baseada na linguagem C++ e tem muitos elementos da linguagem Pascal e Java.

-Linguagem orientada a objeto e fortemente tipada

-A sintaxe do C# é similar do C, C++ ou Java

-Suporta os conceitos de Orientação a Objetos 

-Os programas C# são executados no .NET que inclui: CLR(Common Language Runtime), conjunto unificado de bibliotecas de classes atualmente o compilador de C# É Roslyn.

- O código fonte escrito em C# é compilado em uma linguagem intermediária (IL), o código e recursos de IL são armazenados no disco em um arquivo executável chamado assembly, geralmente com uma extensão EXE ou DLL

Além dos serviços de tempo de execução o .NET tambem inclui uma extensa biblioteca com milhares de classses que fornece uma ampla variedade de funcionalidades úteis, desde entrada e saída de arquivos, manipulação de caceias de caracteres, análise XML etc.

## Classses e objetos

* Classes são tipos mais fundamentais de C#, uma classe é uma estrutura de dados que combina estado(Campos) e ações (métodos).
* Objetos são a instancia de uma classe.
* As classes suportam herança e polimorfismo, mecanismo pelas as quais as chaves derivadas podem estender e especializar as classes base.
* Instancias de classes (objeto) são criadas usando o operador *New*, que aloca memória para uma nova instancia, e retorna uma referência a instância EX: ponto P1 = new ponto (0, 0); | ponto P2 = new ponto(10 , 20); 

* A memória alocada é automaticamente desalojada pelo garbage colector no C#.
* Os membros de uma classe podem ser estáticos ou membros de instância.
* Membros estáticos pertencem a classe e membros instância pertencem a objeto
* Constantes, variáveis, métodos, propriedades, construtores, etc.



## Acessibilidade

Cada membro de uma classe tem uma acessibilidade associada, que controla as regiões de texto do programa que podem acessar o membro.

**Podem ser:** 

* Public (qualquer parte do projeto pode acessá-lo)
* Protected (quando trata-se de herança temos classes que herdam de classes base e só as classes herdeiras tem acesso)
* Internal ( só é acessado pelo assembly que faz parte )
* Private (só tem acesso dentro da classe que está contido)



## Herança

Uma declaração de classe pode especificar uma classe base, herdando os membros public, Internal e protected da classe base.

## Métodos

São os parâmetros, que representam valores ou referencias de variáveis passados para método de um tipo de retorno, que especifica o tipo do valor calculado e retornado pelo método. 



**Uma boa prática é quando nomear um método que ele seja um verbo, pois indica uma ação e as propriedades um substantivo** 

