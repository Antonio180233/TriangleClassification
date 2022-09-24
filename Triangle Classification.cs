/*
 * Created by SharpDevelop.
 * User: Antonio Hernández
 * Date: 2/8/2021
 * Time: 6:23 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
namespace Tipo_Triangulos
{
   class Program
   {
       static void Main(string[] args)
       {
       	  double l1, l2, l3;
       			
    
           
           Console.Write("Introduzca el Valor Numerico del 1er angulo: ");
           l1 = Convert.ToDouble(Console.ReadLine());
           Console.Write("Introduzca el Valor Numerico del 2do Anguloo:");
           l2 = Convert.ToDouble(Console.ReadLine());
           Console.Write("Introduzca el Valor Numerico del 3er Angulo:");
           l3 = Convert.ToDouble(Console.ReadLine());
           if(l1<=0 || l2<=0  || l3<=0 ){
                Console.WriteLine("\nLos datos no son validos");     
            
           Console.Write("Introduzca el Valor Numerico del 1er angulo: ");
           l1 = Convert.ToDouble(Console.ReadLine());
           Console.Write("Introduzca el Valor Numerico del 2do Anguloo:");
           l2 = Convert.ToDouble(Console.ReadLine());
           Console.Write("Introduzca el Valor Numerico del 3er Angulo:");
           l3 = Convert.ToDouble(Console.ReadLine());                
           }
           if(l1+l2+l3<180 || l1+l2+l3>180){
           	 Console.WriteLine("\nLos datos no son validos");  
           	     Console.Write("Introduzca el Valor Numerico del 1er angulo: ");
           l1 = Convert.ToDouble(Console.ReadLine());
           Console.Write("Introduzca el Valor Numerico del 2do Anguloo:");
           l2 = Convert.ToDouble(Console.ReadLine());
           Console.Write("Introduzca el Valor Numerico del 3er Angulo:");
           l3 = Convert.ToDouble(Console.ReadLine());
           }
           if (l1>90 && l2 < 90 && l3<90 || l2>90 && l1 < 90 && l3<90 || l3>90 && l1 < 90 && l2 < 90)
               Console.WriteLine("\nEl Triangulo es obtusangulo");
           else
           {
           	if (l1 == 90 && l2 < 90 && l3 < 90 || l2 == 90 && l1 < 90 && l3 < 90 || (l3 == 90) && l2 < 90 && l1 < 90)
                   Console.WriteLine("\nEl Triangulo es rectangulo");
               else
               {
                   if (l1< 90 && l2 < 90 && l3 < 90)
                       Console.WriteLine("\nEl Triangulo es Acutangulo");
               }
               
             
               
         
           
           Console.ReadKey();
           }}}}
       