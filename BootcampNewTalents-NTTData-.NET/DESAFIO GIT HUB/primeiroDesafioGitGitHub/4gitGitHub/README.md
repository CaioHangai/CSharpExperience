# Git e GitHub

O GIT é um controlador de versões de programas criados por Linus Trovalds em 2005, e o GitHub é um local de armazenamento remoto dos códigos gerados pelo time de desenvolvimento é considerado uma rede social de programadores.

**Benefícios:**

-Controle de versão

-Armazenamento em nuvem

-Trabalho em equipe

-Melhorar seu código

-Reconhecimento

## Comandos básicos de navegação DOS. :black_large_square:

|                           WINDOWS                            |                       LINUX                        |
| :----------------------------------------------------------: | :------------------------------------------------: |
|                    DIR (Listar diretório)                    |                         LS                         |
|          CD + NOME DA PASTA  (Entrar em uma pasta)           |                 CD + NOME DA PASTA                 |
|                  CD.. (Retrocede uma pasta)                  |                        CD..                        |
|                    CLS (Limpa o terminal)                    |              CLEAR ( Atalho CTLR + L)              |
|         MKDIR + NOME DA PASTA DESEJADA (Cria pasta)          |           MKDIR + NOME DA PASTA DESEJADA           |
|      ECHO + NOME DO ARQUIVO > NOME DO ARQUIVO.EXTENSÃO       | ECHO + NOME DO ARQUIVO > NOME DO ARQUIVO.EXTENSÃO  |
|      DEL (Usado para deletar arquivos dentro de pastas)      | DEL (Usado para deletar arquivos dentro de pastas) |
| RMDR + NOME DA PASTA + /S /Q (Remove a pasta c/ todo conteúdo) |               RM -RF + NOME DA PASTA               |

## GIT debaixo dos panos

**SHA1:** significa *SECURE HASH ALGORITHM (Algoritmo de hash seguro),* é um conjunto de funções hash criptográficas projetada pela NSA(Agencia Nacional dos EUA), a encriptação gera conjunto de caracteres identificador de 40 dígitos únicos e serve como identificação.  

**Objetos fundamentais (BLOBS):** o BLOB armazena meta dados contendo o conteúdo dos arquivos no GIT como tamanho, extensão e etc.

**Tree (Arvore):** as arvores apontam para as BLOBS ou para outras arvores, quando algo é mudado muda o SHA da cadeia toda.

**Commit:** é a ação que gera os SHAs. 

**Chave SSH:** é uma forma de gerar conexão segura e encriptada entre duas máquinas

## Como gerar uma chave SSH

Deve-se gerar a chave SSH pois desde Agosto de 2021 o GITHUB mudou seus padrões de segurança, então o usuário gera uma chave SSH para Linkar o Git Bash em sua máquina com o GitHub, que além de ser mais seguro não exige User e Senha.

Para gerar a chave SSH deve se seguir os seguintes passos:

**NO GITBASH DIGITAR:** 

-$ ssh-keygen -t ED25519 -C + (seu e-mail do GitHub)

-(vai solicitar a senha) Criar uma senha

-cd /c/users/(Nome do usuário)/.SSH/

-LS

-$cat id_ed+(TAB).pub

-(Vai te dar uma chave pública, copia a chave e vá para o GitHub :arrow_right: )

**NO GITHUB:**

-Clica em cima do seu rosto/ SETTINGS/ SSH GPG KEYS/

-NEW SSH KEY

-COLOCAR O TÍTULO(Ex: me PC de casa..)

-COLOCAR A CHAVE QUE FOI COPIADA DO GIT BASH (Voltar para o Git Bash :leftwards_arrow_with_hook: )

**NO GITBASH :**

*INICIAR O SSH AGENT:*

-$ eval $ (ssh-agent -s)

-agent PID123.... (Vai startar o agent )

-$ ssh-add(Passar o caminho onde está a chave ) ID_25519

-(Colocar a senha da chave que foi criada)

## Principais comandos do GIT

##### Geral

```
git help
```

##### Comando específico

```
git help add
git help commit
git help <qualquer_comando_git>
```

## 

### Geral

##### Setar usuário

```
git config --global user.name "Leonardo Comelli"
```

##### Setar email

```
git config --global user.email leonardo@software-ltda.com.br
```

##### Setar editor

```
git config --global core.editor vim
```

##### Setar ferramenta de merge

```
git config --global merge.tool vimdiff
```

##### Setar arquivos a serem ignorados

```
git config --global core.excludesfile ~/.gitignore
```

##### Listar configurações

```
git config --list
```

### Criar novo repositório

```
git init
```

### Verificar estado dos arquivos/diretórios

```
git status
```

### Adicionar arquivo/diretório (staged área)

##### Adicionar um arquivo em específico

```
git add meu_arquivo.txt
```

##### Adicionar um diretório em específico

```
git add meu_diretorio
```

##### Adicionar todos os arquivos/diretórios

```
git add .	
```

##### Adicionar um arquivo que esta listado no .gitignore (geral ou do repositório)

```
git add -f arquivo_no_gitignore.txt
```

### Comitar arquivo/diretório

##### Comitar um arquivo

```
git commit meu_arquivo.txt
```

##### Comitar vários arquivos

```
git commit meu_arquivo.txt meu_outro_arquivo.txt
```

##### Comitar informando mensagem

```
git commit meuarquivo.txt -m "minha mensagem de commit"
```

### Remover arquivo/diretório

##### Remover arquivo

```
git rm meu_arquivo.txt
```

##### Remover diretório

```
git rm -r diretorio
```

