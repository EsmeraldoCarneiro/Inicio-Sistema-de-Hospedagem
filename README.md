# 🏨 Sistema de Hospedagem (C# Console App)

Um sistema de reserva de hotel simplificado desenvolvido em **C#** para demonstrar conceitos fundamentais de **Programação Orientada a Objetos (POO)**, encapsulamento e lógica de negócios.

## 📝 Sobre o Projeto

O projeto simula a gestão de reservas de um hotel. Ele permite associar hóspedes a suítes específicas e calcula o valor total da hospedagem com base na quantidade de dias, aplicando regras de desconto automáticas.

### 📐 Modelagem de Dados (Diagrama de Classes)

O projeto segue uma estrutura de classes interligadas para garantir a organização do código:

*   **Pessoa:** Entidade base para hóspedes.
*   **Suíte:** Define o tipo de acomodação e custo.
*   **Reserva:** O "coração" do sistema, onde as entidades se encontram para o cálculo final.



---

## 🚀 Funcionalidades

*   **Cálculo Automatizado:** Processa o valor total da estadia instantaneamente.
*   **Regra de Desconto:** Se a reserva for superior a **10 dias**, o sistema concede **10% de desconto**.
*   **POO Pura:** Uso de construtores, propriedades e métodos de classe.

## 💻 Como Executar

1.  **Pré-requisitos:** Ter o [.NET SDK](https://dotnet.microsoft.com/download) instalado.
2.  **Clonar:** `git clone https://github.com/EsmeraldoCarneiro/Inicio-Sistema-de-Hospedagem.git`
3.  **Executar:** Navegue até a pasta e digite `dotnet run`.

## 🛠️ Possíveis Melhorias (Roadmap)

Este é um projeto educacional e pode ser expandido com as seguintes funcionalidades:

*   [ ] **Validação de Capacidade:** Impedir que uma reserva seja feita se o número de hóspedes exceder a capacidade da suíte.
*   [ ] **Persistência de Dados:** Salvar as reservas em um arquivo JSON ou Banco de Dados (SQL Server/SQLite).
*   [ ] **Interface de Usuário:** Criar um menu interativo para cadastrar hóspedes e suítes via teclado (Console.ReadLine).
*   [ ] **Tratamento de Exceções:** Adicionar blocos `try-catch` para evitar erros caso o usuário digite dados inválidos.

---

## 📊 Exemplo de Saída

```text
--- RESUMO DA RESERVA ---

Hóspede: Fulano de Tal
Valor da diária: R$ 150,00
Capacidade da suíte: 2 pessoa(s)
Duração: 11 dias
Total a pagar: R$ 1.485,00 (Desconto de 10% aplicado!)
```

---
✨ *Desenvolvido para estudos de arquitetura de software e C#.*

---

**Dica Extra:** Se você subir esse código para o GitHub, lembre-se de adicionar um arquivo chamado `.gitignore` (específico para Visual Studio) para que as pastas temporárias como `bin/` e `obj/` não sejam enviadas ao repositório.
