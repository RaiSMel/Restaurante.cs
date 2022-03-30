using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante
{
    class Caixa
    {
        //totalizarComanda: Recebe um parâmetro do tipo Comanda, soma os valores de consumo,
        //estacionamento e couvert, subtrai o desconto promocional, armazena o total no atributo valorTotal e o retorna.
        public double totalizarComanda(Comanda mesa)
        {
            mesa.verificarPromocao();
            Console.Clear();
            mesa.setValorTotal(mesa.getValorConsumo() + mesa.getValorCouvert() +
                mesa.getValorEstacionamento() - mesa.getValorDescontoPromocional());
            return mesa.getValorTotal();     
            
        }
       
    }
}
