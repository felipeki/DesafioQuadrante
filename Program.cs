using System;

namespace DesafioQuadrante
{
    class Program
    {
        static void Main(string[] args)
        {
            String coordenadas = Console.ReadLine();
            string[] arraycorrdenadas = coordenadas.Split(" ");
            double y = Convert.ToDouble(arraycorrdenadas[0]);
            double x = Convert.ToDouble(arraycorrdenadas[1]);
            
           
             if (x== 0.0 && y== 0.0)
             Console.WriteLine("Origem");
             if(x== 0.0 && y!=0.0)
             Console.WriteLine("Eixo X");
             if(x!= 0.0 && y==0.0)
             Console.WriteLine("Eixo Y");
             if (x>0 && y>0)
             Console.WriteLine("Q1");
             if (x<0 && y>0)
             Console.WriteLine("Q2");
             if (x<0 && y<0)
             Console.WriteLine("Q3");
             if (x>0 && y<0)
             Console.WriteLine("Q4");
           
        
        }
    }
}
