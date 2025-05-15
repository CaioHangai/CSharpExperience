# Estrutura de dados.

​	Estrutura de dados é uma estrutura organizada de dados na memória de um computador ou em qualquer dispositivo de armazenamento,de forma que os dados possam ser utilizados  de forma correta.

​	essas estruturas encontram muitas aplicações no desenvolvimento de sistemas, sendo que alguns são altamente especializados e utilizados em tarefas específicas.

​	Usando as estruturas adequadas através de algoritmos, podemos trabalhar com uma grande quantidade de dados, como aplicações em bancos de dados ou serviço de busca.

​	Um algoritmo é um conjunto de instruções estruturadas e ordenadas, seu objetivo é realizar uma tarefa ou operação específica.

​	Os algoritmos são utilizados para manipular dados nas estruturas de várias formas, como por exemplo: inserir, excluir, procurar e ordenar dados.



## Principais estrutura de dados utilizado em algoritmo.

*  **Vetores e Matrizes(Também chamado de Arrays) :** são estrutura de dados simples que podem auxiliar quando há muitas variáveis do mesmo tipo em um algoritmo. 

  **Vetor ou Array unidimensional:** é uma variável que armazena várias variáveis do mesmo tipo. O vetor é uma estrutura de dados indexada, que pode armazenar uma determinada quantidade de vetores de valores do mesmo tipo.

  **Matriz ou Array Multidimensional:** é um vetor de vetores, uma matriz é um vetor que possui duas ou mais dimensões

  EX matriz 4 x 3:  

  ​                             2 -1 3 1

  ​                             0 -2 5 4

  ​                             0 -2 5 4

  ​                             -3 1 0 6

   

* **Registro:** é uma estrutura que fornece um formato especializado para armazenar informações em memória, enquanto arrays nos permitem armazenar vários dados de um único tipo de dados, o recurso de registro nos permite armazenar mais de um tipo  

  EX:

  | CPF          |      |
  | :----------- | ---- |
  | **NOME**     |      |
  | **ENDEREÇO** |      |
  | **CONTATO**  |      |

  Toda estrutura de registro tem um nome Ex: livro, e seus campos podem ser acessados por meio de uso do operador ponto(.), por exemplo para acessar o preço de um livro, poderíamos utilizar a seguinte declaração: **livro.Preco**  

* **Listas:** A diferença entre lista e array é que listas possuem tamanho ajustável, enquanto arrays possuem tamanho fixo, existem 2 tipos de listas:

  **LIGADAS:** existe os nós onde cada um dos nós conhece o valor que está sendo armazenado em seu interior além de conhecer o elemento  posterior a ele por isso ela é chamado de *Lista Ligada*, pois os nós são amarrados com essa indicação de qual é o próximo nó.  

  **DUPLAMENTE LIGADAS:** A grande diferença das listas duplamente ligadas para as listas ligadas é que elas são bidirecionais, vimos que, naturalmente não conseguimos "ANDAR PARA TRÁS" em listas ligadas, pois os nós de uma  lista ligada sabem somente quem é o próximo elemento nas listas duplamente ligadas, os nós sabem quem é o próximo elemento e quem é o anterior, o que permite a navegação reversa.  

* **Pilhas:** é uma estrutura de dados que serve como uma coleção de elementos, e permite o acesso a somente 1 item de dados armazenados por vez e seu acesso é restrito.

  **TIPOS DE PILHAS:** **LIFO ou UEPS:** **L**ast **I**n **F**irst **O**ut (**U**ltimo que **E**entra é o **P**rimeiro que **S**ai)

  **FIFO ou PEPS:** **F**irst **I**n **F**irst **O**ut (**P**rimeiro que **E**ntra **P**rimeiro que **S**ai )

* **Filas:** admite remoção de elementos e inserção de novos sujeito à seguinte regra de operação: elimina-se o elemento que está mais tempo na estrutura

* **Arvore:** organiza seus elementos de forma hierárquica, onde existe um elemento que fica no topo da arvore, chamado de  raiz e existem os elementos subordinados a ele, que são chamado de nós, folhas. 

* **Tabela Hashing:** uma tabela hash, de dispersão ou espalhamento é uma estrutura de dados especial, que associa chaves de pesquisa e valores.

  Uma tabela hash é uma generalização de ideia de array, porém utiliza uma função denominada de hashing para espalhar os elementos, fazendo com que os mesmos fiquem de forma não ordenada dentro do array que define a tabela

  *A tabela hash permite a associação de "valores chaves"*

  **Valores:** é a posição ou índice onde o elemento se encontra.

  **CHAVE:** parte da informação que compõe o elemento manipulado.

  *cada valor recebe uma chave que facilita encontrar o item desejado* 

* **Grafos:** são estruturas que permitem programar a relação entre objetos: os objetos são  vértices ou "nós" do grafo, os relacionamentos são arestas.