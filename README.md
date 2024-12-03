# Jogo de Xadrez

Este é um jogo de xadrez desenvolvido em C# no Visual Studio 2022. Ao executar o projeto, uma interface baseada em terminal (cmd) é aberta, onde duas pessoas podem jogar localmente. O jogo suporta todas as regras clássicas do xadrez, como movimento de peças, xeque, xeque-mate e empate. 

### Tecnologias Utilizadas

 * [Visual Studio 2022](https://visualstudio.microsoft.com/pt-br/vs/community/)
 * Cmd

## Dependências e Verções Necessárias

 * Visual Studio 2022 - Versão 2022
 * Net 8 - Versão 8.0

### Como rodar o projeto

  Caso você queira rodar o projeto em seu computador terá que ter o Visual Studio 2022 e clonar o repositório. Após rodar o projeto irá abrir o cmd com o projeto e começando o jogo pelas peças brancas.


---
  Vai precisar colocar o comando de origrem da peça que ira mexer.
  Primeiro comando é para selecionar a origem da peça e o segundo comando é para selecionar o destino dela. 
  * Exemplo: a2
  * Exemplo: a4
---

Após colocar esse comando a peça ira se movimentar trocar o turnp e passar a vez para o outro jogar que também vai precisar dar o comando.

---
  Como no exemplo anterior o primeiro comando é para selecionar a origem e o segundo o destino da peça.
  * Exemplo: a7
  * Exemplo: a5
---

Caso um peça seja morta ele vai para a parte de peças capturadas de cada cor.
Quando acontece um xeque aparece na tela uma mensagem alertando e quando acontece um xeque mate ele avisa e mostra o vencedor e um botao para jogar novamente caso queira começar novamente.

### Jogadas do xadrez

  Esse projeto tem algumas jogadas famosas do xadrez como:
  * Roque

## Próximo passos

Esse projeto foi desenvolvido de maneira simples em cmd apenas com C# será postado um novo projeto de um jogo de xadrez hospedado no Azure com penças reais e mais organizado.
