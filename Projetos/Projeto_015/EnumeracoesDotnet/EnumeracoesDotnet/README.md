# Projeto: EnumeracoesDotnet

Este projeto demonstra, de forma simples, o uso de `enum` em C# através de um exemplo de pedidos (`Order`).

Objetivo: explicar o conceito de `enum`, mostrar a organização do projeto e exemplificar conversões entre `enum`, `string` e `int`.

-----------------------------------------

Sumário rápido

- O que é `enum`?
- Por que usar `enum`?
- Estrutura do projeto
- Conversões entre `enum`, `string` e `int`
- Como executar
- Observações e sugestões

-----------------------------------------

O que é `enum`?

`enum` (enumeração) é um tipo que define um conjunto nomeado de valores constantes. É ideal para representar estados ou opções com nomes legíveis em vez de números mágicos.

Por que usar `enum`?

- Legibilidade: `OrderStatus.Processing` é mais claro que `1`.
- Segurança e manutenção: reduz erros ao evitar números mágicos espalhados pelo código.
- Documentação implícita: os nomes dos valores explicam o significado dos estados.

Exemplo do projeto (resumo)

- `OrderStatus` (enum) contém: `PendingPayment`, `Processing`, `Shipped`, `Delivered`.
- `Order` possui `Id`, `Moment` (DateTime) e `Status` (do tipo `OrderStatus`).
- `Program.cs` cria um `Order`, imprime seus dados e demonstra conversões.

Arquivos principais

- `Program.cs` — ponto de entrada e demonstrações.
- `Entities/Order.cs` — classe `Order` com `ToString()` para exibir informações.
- `Entities/Enums/OrderStatus.cs` — definição da `enum`.

Como funcionam as conversões

- Enum para string:

  `string text = OrderStatus.Processing.ToString(); // "Processing"`

- String para enum (recomendado usar `TryParse`):

  `if (Enum.TryParse<OrderStatus>(input, out var status)) { /* sucesso */ } else { /* inválido */ }`

- Enum para inteiro:

  `int value = (int)OrderStatus.Shipped;`

- Inteiro para enum (valide antes com `Enum.IsDefined`):

  `if (Enum.IsDefined(typeof(OrderStatus), 2)) status = (OrderStatus)2;`

Como executar

No diretório do projeto execute:

```
cd Projetos/Projeto_015/EnumeracoesDotnet/EnumeracoesDotnet
dotnet run
```

Observações e sugestões de melhoria

- Ortografia: o valor `PendingPaymente` foi corrigido para `PendingPayment`.
- Visibilidade: os tipos foram alterados para `public` para facilitar uso fora do assembly.
- Parsing: prefira `Enum.TryParse(..., ignoreCase: true, out ...)` quando aceitar entrada externa.
- Persistência: se salvar valores no banco, defina explicitamente os inteiros da enum para evitar que mudanças de ordem quebrem dados.
- Flags: se precisar de máscaras bitwise, marque a enum com `[Flags]` e use potências de 2.

Conceitos avançados recomendados para incluir

- Tipo subjacente do `enum` (por padrão `int`) e como mudá-lo (`: byte`, `: long`).
- Uso de `Enum.IsDefined` para validar valores antes de converter.
- Diferenças entre `Enum.Parse` e `Enum.TryParse` e tratamento de erros.
- Serialização JSON de enums e controle com `System.Text.Json` (`JsonStringEnumConverter`) ou atributos específicos.
- Testes unitários cobrindo parsing inválido e conversões.

-----------------------------------------

Se quiser, eu posso:

- Aplicar outras melhorias no código (ex.: testes, tratamento de parsing, limpeza de comentários).
- Adicionar um README mais detalhado na pasta do projeto cobrindo exemplos de código e testes.

