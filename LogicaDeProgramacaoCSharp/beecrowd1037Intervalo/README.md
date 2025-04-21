beecrowd | 1037

# Interval

Adapted by Neilor Tonin, URI ![img](https://resources.beecrowd.com.br/gallery/images/flags/br.gif) Brazil

**Timelimit: 1**

You must make a program that read a float-point number and print a message saying in which of following intervals the number belongs: [0,25] (25,50], (50,75], (75,100]. If the read number is less than zero or greather than 100, the program must print the message “Fora de intervalo” that means "Out of Interval".

The symbol '(' represents greather than. For example:
[0,25] indicates numbers between 0 and 25.0000, including both.
(25,50] indicates numbers greather than 25 (25.00001) up to 50.0000000.

## Input

The input file contains a floating-point number.

## Output

The output must be a message like following example.

| Input Sample | Output Sample     |
| ------------ | ----------------- |
| 25.01        | Intervalo (25,50] |

| 25.00 | Intervalo [0,25] |
| ----- | ---------------- |
|       |                  |

| 100.00 | Intervalo (75,100] |
| ------ | ------------------ |
|        |                    |

| -25.02 | Fora de intervalo |
| ------ | ----------------- |
|        |                   |

____________

# Intervalo

Adaptado por Neilor Tonin, URI ![img](https://resources.beecrowd.com.br/gallery/images/flags/br.gif)Brasil

**Limite de tempo: 1**

Você deve fazer um programa que leia um número de ponto flutuante e imprima uma mensagem dizendo a qual dos seguintes intervalos o número pertence: [0,25] (25,50], (50,75], (75,100). número for menor que zero ou maior que 100, o programa deverá imprimir a mensagem “Fora de intervalo” que significa "Fora do Intervalo".

O símbolo '(' representa maior que. Por exemplo:
[0,25] indica números entre 0 e 25,0000, incluindo ambos.
(25,50] indica números maiores que 25 (25,00001) até 50,0000000.

## Entrada

O arquivo de entrada contém um número de ponto flutuante.

## Resultado

A saída deve ser uma mensagem como o exemplo a seguir.

| Amostra de Entrada | Amostra de saída  |
| ------------------ | ----------------- |
| 25.01              | Intervalo (25,50] |

| 25h00 | Intervalo [0,25] |
| ----- | ---------------- |
|       |                  |

| 100,00 | Intervalo (75,100] |
| ------ | ------------------ |
|        |                    |

| -25,02 | Fora de intervalo |
| ------ | ----------------- |
|        |                   |
