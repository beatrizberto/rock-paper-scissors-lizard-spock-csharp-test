# Rock Paper Scissors  Lizard Spock API (C#)

API simples para o jogo Pedra, Papel, Tesoura, Lagarto, Spock, construída com C# / .NET e Visual Studio Code.

![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white) ![Visual Studio Code](https://img.shields.io/badge/Visual%20Studio%20Code-0078d7.svg?style=for-the-badge&logo=visual-studio-code&logoColor=white)
![Swagger](https://img.shields.io/badge/-Swagger-%23Clojure?style=for-the-badge&logo=swagger&logoColor=white)

Construída por Beatriz Moreira Berto.

Github: [@beatrizberto](https://www.github.com/beatrizberto)

Email: [beatrizberto@gmail.com](mailto:beatrizberto@gmail.com)

LinkedIn: [in/beatrizberto](https://www.linkedin.com/in/beatrizberto/)





## Sobre o jogo

Criado por Sam Kass e Karen Bryla e popularizado ao ser tema de episódio da série Big Bang Theory, o jogo acrescenta duas novas possibilidades ao tradicional jogo Jan Ken Po: além de Pedra, Papel, Tesoura, temos também Lagarto e Spock.

### Regras

* Scissors cuts Paper
* Paper covers Rock
* Rock crushes Lizard
* Lizard poisons Spock
* Spock smashes Scissors
* Scissors decapitates Lizard
* Lizard eats Paper
* Paper disproves Spock
* Spock vaporizes Rock
* Rock crushes Scissors


## Documentação da API

Nessa versão, um jogador disputa contra o "computador". O jogador escolhe sua jogada, que é confrontada com a jogada do computador, gerada automaticamente.

#### Escolha do jogador:

```http
  GET /api/Game/Play/${playerChoice}
```

| playerChoice   | Tipo       | Descrição                           |
| :---------- | :--------- | :---------------------------------- |
| `1` | `int` | **Rock** |
| `2` | `int` | **Paper** |
| `3` | `int` | **Scissors** |
| `4` | `int` | **Lizard** |
| `5` | `int` | **Spock** |
| `qualquer outra opção` |  | **Invalid option** |

### Escolha do Computador:

Gerada automaticamente entre 1 e 5.
| computerChoice   | Tipo       | Descrição                           |
| :---------- | :--------- | :---------------------------------- |
| `1` | `int` | **Rock** |
| `2` | `int` | **Paper** |
| `3` | `int` | **Scissors** |
| `4` | `int` | **Lizard** |
| `5` | `int` | **Spock** |

### Response body:

* Em caso de empate: 
`"{playerChoice} vs {computerChoice} - It's a draw. Try again!"`
* Em caso de vitória:
`"{playerChoice} vs {computerChoice} - You win!"`
* Em caso de derrota: 
`"{playerChoice} vs {computerChoice} - You loose..."`

### 400 Bad Request

Qualquer entrada `int` diferente de 1, 2, 3, 4 ou 5 para o jogador resulta em 400 Bad Request, retornando a string `Uh-Oh! Invalid move. Please choose rock, paper, scissors, lizard or Spock. ò__ó`






## Instruções

### Pré-requisitos

- [.NET Core SDK](https://dotnet.microsoft.com/download)
- Visual Studio Code
- Extensão C# (Microsoft)

### Instalação

1. Clone o repositório: `git clone https://github.com/seu-usuario/seu-projeto.git`
2. Navegue até o diretório: `cd seu-projeto`
3. Abra a pasta no VSCODE: `code .`
4. Execute o projeto: `dotnet run`

## Swagger
Exemplo `http://localhost:5086/swagger/index.html`

## Endpoint

Acesse o endpoint `Play` para jogar. Substitua `{playerChoice}` pelo número correspondente à sua escolha (1 para Pedra, 2 para Papel, 3 para Tesoura, 4 para Lagarto, 5 para Spock).

Exemplo: `http://localhost:5086/api/game/play/1`

## License

Distributed under the MIT License. See `LICENSE` for more information.

