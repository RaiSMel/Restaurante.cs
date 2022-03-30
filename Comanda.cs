using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante
{
    class Comanda
    {

        //Atributos: Criar os atributos encapsulados (private) e criar os métodos de acesso

        private int id;
        private double valorConsumo;
        private double valorEstacionamento;
        private double valorCouvert;
        private double valorDescontoPromocional;
        private double valorTotal;

        public int getId()
        {
            return id;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public double getValorConsumo()
        {
            return valorConsumo;
        }
        public void setValorConsumo(double valorConsumo)
        {
            this.valorConsumo = valorConsumo;
        }
        public double getValorCouvert()
        {
            return valorCouvert;
        }
        public void setValorCouvert(double valorCouvert)
        {
            this.valorCouvert = valorCouvert;
        }
        public double getValorDescontoPromocional()
        {
            return valorDescontoPromocional;
        }
        public void setValorDescontoPromocional(double valorDescontoPromocional)
        {
            this.valorDescontoPromocional = valorDescontoPromocional;
        }
        public double getValorTotal()
        {
            return valorTotal;
        }
        public void setValorTotal(double valorTotal)
        {
            this.valorTotal = valorTotal;
        }
        public double getValorEstacionamento()
        {
            return valorEstacionamento;
        }
        public void setValorEstacionamento(double valorEstacionamento)
        {
            this.valorEstacionamento = valorEstacionamento;
        }

        //Construtores: Definir 3 construtores:
        //Um sem parâmetros ·
        public Comanda()
        {
            id = 0;
            valorConsumo = 0.0;
            valorEstacionamento = 0.0;
            valorCouvert = 0.0;
            valorDescontoPromocional = 0.0;
            valorTotal = 0.0;
        }
        //Um com parâmetros para inicializar todos os atributos ·
        public Comanda(int id, double valorConsumo, double valorEstacionamento, double valorCouvert, double valorDescontoPromocional, double valorTotal)
        {
            this.id = id;
            this.valorConsumo = valorConsumo;
            this.valorEstacionamento = valorEstacionamento;
            this.valorCouvert = valorCouvert;
            this.valorDescontoPromocional = valorDescontoPromocional;
            this.valorTotal = valorTotal;

        }

        //E um terceiro recebendo somente um parâmetro para inicializar o atributo id
        //Obs.: Inicializar o id da comanda pelo construtor
        public Comanda(int id)
        {
            this.id = id;
        }


        //verificarPromocao: verifica se o valor consumido foi superior a R$100, se foi armazena 10% do valor consumido no atributo valorDescontoPromocional.
        public void verificarPromocao()
        {
            if ( getValorConsumo() > 100)
            {
                setValorDescontoPromocional(valorConsumo * 0.1);
                Console.WriteLine("Valor promocional é de: "+getValorDescontoPromocional());
            }
            else
            {
                Console.WriteLine("Não possui valor promocional");
            }
        }
        //lancarGastos: Lê e armazena nos respectivos atributos o valor consumido, o valor do estacionamento e o
        //valor do couvert e inicializa os atributos valorDescontoPromocional e valorTotal com zero.
        public void lancarGastos()
        {

            Console.WriteLine("indique o id: ");
            setId(int.Parse(Console.ReadLine()));

            Console.WriteLine("indique o valor consumido: ");
            setValorConsumo(double.Parse(Console.ReadLine()));

            Console.WriteLine("indique o valor estacionamento: ");
            setValorEstacionamento(double.Parse(Console.ReadLine()));

            Console.WriteLine("indique o valor couvert: ");
            setValorCouvert(double.Parse(Console.ReadLine()));

            setValorDescontoPromocional(0);
            setValorTotal(0);

        }
        //listarComanda: Apresenta o conteúdos de todos os atributos.
        public void listarComanda()
        {
            Console.WriteLine("id: " + id + 
                "\nValor do consumo: " + valorConsumo + 
                "\nValor do estacionamento: " + valorEstacionamento +
                "\nValor do couvert: " + valorCouvert +
                "\nValor do desconto promocional: " + valorDescontoPromocional +
                "\nValor total: " + valorTotal);
                
        }
    }
}
