using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante
{
    class Principal
    {
        static void Main(string[] args)
        {
            //Instanciar um objeto do tipo Comanda chamado controleMesa.
            Comanda controleMesa = new Comanda();
            //Instanciar um objeto do tipo Caixa chamado caixa.
            Caixa caixa  = new Caixa();

            int op = 0;


            //· Apresentar um menu com as opções:
            //1 – Lançar gastos 2 – Verificar promoção 3 – Fechar mesa
            //4 – Listar comanda 0 – Sair
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Lançar gastos\n2 - Verificar promoção\n3 - Fechar mesa\n4 - Listar Comanda\n0 - Sair");
                op = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (op)
                {
                    case 1:
                        controleMesa.lancarGastos();
                        break;
                    case 2:
                        controleMesa.verificarPromocao();
                        break;
                    case 3:
                        caixa.totalizarComanda(controleMesa);
                        break;
                    case 4:
                        controleMesa.listarComanda();
                        break;
                }
                Console.ReadKey();
              
            } while (op != 0);

            Environment.Exit(1);
        }
    }
}
