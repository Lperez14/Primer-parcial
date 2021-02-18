using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {

            int billetesmil = 18, billetesquinientos = 19, billetes200 = 23, billetes100 = 50;
            int dispensa1000 = 0, dispensa500 = 0, dispensa200 = 0, dispensa100 = 0;
            string Nombrebanco = "";

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Bienveido al sistema Eliga el tipo de banco que desea hacer la transaccion *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* 1- Banco FDP Inversments                                                   *");
            Console.WriteLine("* 2-Otro                                                                     *");
            Console.WriteLine("******************************************************************************");
            Console.Write("- Eliga el banco de su preferencia: ");
            int banco = int.Parse(Console.ReadLine());

            Console.WriteLine("******************************************************************************");
            Console.Write("- Digite el monto a retirar: ");
            int monto = int.Parse(Console.ReadLine());
            
            if(monto% 2 == 0)
            {
                if (banco == 1 && monto <= 20000)
                {

                    Nombrebanco = "Banco FDP Inversments";
                    if (monto >= 1000)
                    {

                        do
                        {
                            monto -= 1000;
                            dispensa1000 += 1;
                            billetesmil -= 1;
                        } while (monto >= 1000);
                    }
                    if (monto >= 500)
                    {
                        do
                        {
                            monto -= 500;
                            dispensa500 += 1;
                            billetesquinientos -= 1;
                        } while (monto >= 500);
                    }
                    if (monto >= 200)
                    {
                        do
                        {
                            monto -= 200;
                            dispensa200 += 1;
                            billetes200 -= 1;
                        } while (monto >= 200);
                    }
                    if (monto >= 100)
                    {
                        do
                        {
                            monto -= 100;
                            dispensa100 += 1;
                            billetes100 -= 100;
                        } while (monto >= 100);

                    }
                }
                else if (banco == 2 && monto <= 10000)
                {
                    Nombrebanco = "Otro";
                    if (monto >= 1000)
                    {

                        do
                        {
                            monto -= 1000;
                            dispensa1000 += 1;
                            billetesmil -= 1;
                        } while (monto >= 1000);
                    }
                    if (monto >= 500)
                    {
                        do
                        {
                            monto -= 500;
                            dispensa500 += 1;
                            billetesquinientos -= 100;
                        } while (monto >= 500);
                    }
                    if (monto >= 200)
                    {
                        do
                        {
                            monto -= 200;
                            dispensa200 += 1;
                            billetes200 -= 1;
                        } while (monto >= 200);
                    }
                    if (monto >= 100)
                    {
                        do
                        {
                            monto -= 100;
                            dispensa100 += 1;
                            billetes100 -= 100;
                        } while (monto >= 100);

                    }
                }
                else
                {
                    Console.WriteLine("La opcion introducida no es valida o el monto a retirar supera al permito por el banco solicitado");
                }
                Console.Clear();

                if(monto > 1)
                {
                    Console.WriteLine($"Gracias por retirar en el banco: {Nombrebanco} numero de papeletas que recibira es: \n" +
                   $"-Papeleta de 1000: {dispensa1000}  \n" +
                   $"-Papeleta de 500: {dispensa500}  \n" +
                   $"-Papeleta de 200: {dispensa200}  \n" +
                   $"-Papeleta de 100: {dispensa100}   \n" +
                   $"-El cajero no pudo retirar: {monto} pesos"

                    );
                }
                else { 

                Console.WriteLine($"Gracias por retirar en el banco: {Nombrebanco} numero de papeletas que recibira es: \n" +
                    $"-Papeleta de 1000: {dispensa1000}  \n" +
                    $"-Papeleta de 500: {dispensa500}  \n" +
                    $"-Papeleta de 200: {dispensa200}  \n" +
                    $"-Papeleta de 100: {dispensa100}   \n" 
                     
                     );

            }

        }
        
       
                Console.ReadKey();
            }
    }
}
