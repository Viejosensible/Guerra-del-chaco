using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace ejercicios_video.ejercicios
{
    public class CampañaChaco
    {
        public static void Main(string[] args)
        {
            const double META = 12000;
            double suma = 0;
            int i = 1;
            int cordura = 100;
            Console.WriteLine("El hierro y la sed");
            Console.WriteLine("De minero en Oruro a Suboficial. \n");
            Console.WriteLine("Prologo  El adios al antiplano");
            Console.WriteLine("Santigo nacio en las frias y ventosas alturas de Oruro donde el aire es escaso y la tierra dura");
            Console.WriteLine("Asus 22 añoas dejo el  polvo de las minas de estaño y una madre ancian que rezaba en lenguas nativas ");
            Console.WriteLine("Cuando la patria llamo a defender el chaco Santiago marcho convencido de proteger el territori nacional");
            Console.WriteLine("Pero nadie le advirtio sobre el verdadero enemigo un infierno verde plano abrasador y sin una gota de agua potable");
            Console.WriteLine("y el contraste es brutal \n ");

            Console.WriteLine("Fase 1 : El bautismo de fuego");
            Console.WriteLine("El calor asfixiante y el asedio constante de las tropas paraguayas lo golpean de inmediato");
            cordura -= 15;
            Console.WriteLine($"Estado mental La brutalidad de la guerra reduce la cordura a {cordura} \n");

            Console.WriteLine("Fase 2 : La ruta del abastecimiento");
            Console.WriteLine("Para asegurar la posicion de su regimiento y ganarse los galones ");
            Console.WriteLine("Toma decisiones ");
            Console.WriteLine("Decide con cautela \n");
            while (i <= 5)
            {
                Console.WriteLine($"Dia {i} : ¿ Como deseas avazar ? (1.Con cautela juanto al peloton | 2. Arriesgarte solo al peligro en la picada):");
                string inputDecision = Console.ReadLine();

                int decision = 1;
                int.TryParse(inputDecision, out decision);

                if (decision == 2)
                {
                    Console.WriteLine("Te adentraste solo a explorar un sector sitiado por  el enemigo El terro la soleda y la sed te quiebran");
                    cordura -= 30;
                }
                else
                {
                    Console.WriteLine("Decides avanzar con prudencia junto a yus camaradas racionando el esfuerzo");
                    cordura -= 10;
                }
                if (cordura <= 0)
                {
                    Console.WriteLine("\n muerte ");
                    Console.WriteLine("La precion extrema del desierto el delirio de la sed y el aislamiento destruyo la mente de Snatiago y lo llevo a la muerte");
                    Console.WriteLine("Empezo a gritar nombres de sus hermanos de Oruro y se fue sin rumbo");
                    return;
                }
                Console.WriteLine("litros de agua asegurados en esta etapa ");
                string inputLitros = Console.ReadLine();
                double litrosActuales = 0;
                double.TryParse(inputLitros, out litrosActuales);
                suma += litrosActuales;


                Console.WriteLine($"Estado mental La brutalidad de la guerra reduce la cordura a {cordura} \n");
                i++;
            }
            Console.WriteLine("Fase 3 : El Balance del comando ");
            Console.WriteLine($" tatal acumulado de suministro en el campamento  {suma} litros");
            Console.WriteLine($"Cordura final de Snatiago {cordura} \n ");
            if (suma >= META && cordura > 20)
            {
                Console.WriteLine("\nMision cumplida con honor  y razon ");
                Console.WriteLine("A peasr de los traumas del monte chaqueño Santiago mantuvo la cordura y supero la meta logistica ");
                Console.WriteLine("El averlogrado tales asañas del boliviano reconoce su temple y lo asciende con honores a Subofial");
                Console.WriteLine("Desenlace sobrevivio al infierno vaerde El Suboficial Santiago regresa a Oruro , braza a su madre ");


            }
            else if (suma >= META && cordura <= 20)
            {
                Console.WriteLine("\nVictoria solo Victoria ");
                Console.WriteLine("Se alcanzo la meta de agua , pero la mente de Santiago quedo totalmente destrozada por los horrores del frente  ");
                Console.WriteLine("Desenlace Logro el ascenso a Suboficial pero llego a su ogar en silencio , con el alma atrapada en el aridez del Chaco ");

            }
            else
            {
                Console.WriteLine("\n Colapso y derrota  ");
                Console.WriteLine("Los suministros escasearon drasticamente y la mete de Santiago colapso ante la inmensidad de la batalla");
                Console.WriteLine("Desenlace La campaña militar fracaso los pocos sobrevivientes se retiran con profundas cicatrices invisi");
            }

        }
    }
        
}
