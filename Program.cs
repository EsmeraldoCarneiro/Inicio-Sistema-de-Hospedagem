/*
 * ENUNCIADO DO EXERCÍCIO:
 * -----------------------------------------------------------------------------------------------
 * Sistema de Hospedagem Simplificado
 * 
 * Objetivo: Criar um programa que gerencie a reserva de um hotel utilizando Orientação a Objetos.
 * 
 * Requisitos:
 * 1. Classe Pessoa: Deve conter a propriedade 'Nome'.
 * 2. Classe Suíte: Deve conter 'QuantidadeHospedes' e 'ValorDiaria'.
 * 3. Classe Reserva: Deve relacionar um Hóspede, uma Suíte e a 'QuantidadeDias' de permanência.
 * 4. Regra de Negócio: O método 'CalcularTotal' deve retornar o valor da hospedagem. 
 *    Caso o período seja superior a 10 dias, conceder um desconto de 10% sobre o valor total.
 * 5. Saída: Exibir no console os detalhes da reserva e o valor final calculado.
 * -----------------------------------------------------------------------------------------------
 */

using System;

namespace SistemaHospedagem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instancia um novo hóspede passando o nome pelo construtor
            Pessoa hospede = new Pessoa("Fulano de Tal");

            // Instancia uma suíte com capacidade para 2 pessoas e diária de R$ 150,00
            Suíte suite = new Suíte(2, 150.00);

            // Cria a reserva vinculando o hóspede, a suíte e definindo 11 dias de estadia
            // Nota: Como 11 > 10, o desconto de 10% deve ser aplicado automaticamente.
            Reserva reserva = new Reserva(hospede, suite, 11);

            // Exibição dos resultados formatados
            Console.WriteLine();
            Console.WriteLine("--- RESUMO DA RESERVA ---");
            Console.WriteLine();
            Console.WriteLine("Hóspede: " + reserva.Hospede.Nome);
            Console.WriteLine("Valor da diária: R$ {0:F2}", reserva.Suite.ValorDiaria);
            Console.WriteLine("Capacidade da suíte: " + reserva.Suite.QuantidadeHospedes + " pessoa(s)");
            Console.WriteLine("Duração: " + reserva.QuantidadeDias + " dias");
            
            // Exibe o total chamando o método que contém a lógica de desconto
            Console.WriteLine("Total a pagar: R$ {0:F2}", reserva.CalcularTotal());

            Console.WriteLine("\nPressione Enter para sair...");
            Console.ReadLine();
        }
    }

    // Representa a entidade cliente/hóspede
    class Pessoa
    {
        public string Nome { get; }

        public Pessoa(string nome)
        {
            Nome = nome;
        }
    }

    // Representa o quarto/acomodação
    class Suíte
    {
        public int QuantidadeHospedes { get; }
        public double ValorDiaria { get; }

        public Suíte(int quantidadeHospedes, double valorDiaria)
        {
            QuantidadeHospedes = quantidadeHospedes;
            ValorDiaria = valorDiaria;
        }
    }

    // Classe responsável por unir as informações e processar os cálculos
    class Reserva
    {
        public Pessoa Hospede { get; }
        public Suíte Suite { get; }
        public int QuantidadeDias { get; }

        public Reserva(Pessoa hospede, Suíte suite, int quantidadeDias)
        {
            Hospede = hospede;
            Suite = suite;
            QuantidadeDias = quantidadeDias;
        }

        // Método que executa a lógica financeira da reserva
        public double CalcularTotal()
        {
            // Cálculo base: dias multiplicado pelo valor da suíte
            double total = QuantidadeDias * Suite.ValorDiaria;

            // Condicional: Se a estadia for longa (mais de 10 dias), aplica-se o desconto
            if (QuantidadeDias > 10)
            {
                // Multiplicar por 0.9 retira 10% do valor total
                total *= 0.9;
            }

            return total;
        }
    }
}