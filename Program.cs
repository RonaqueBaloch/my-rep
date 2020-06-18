using System;

namespace sunset
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables
           
            int quantity  ;
            int largest;
            bool isequal = false;
            Console.WriteLine("enter the quantity of buildings");
            quantity = Convert.ToInt32(Console.ReadLine());
          
           //arrays
            int[] buildings = new int[quantity];
            int[]output=new int[quantity];
          
            //Getting the height of buldings from user
             for(int o = 0; o < buildings.Length; o++)
            {
                Console.WriteLine("enter the height of building number  " + (o + 1));
                buildings[o] = Convert.ToInt32(Console.ReadLine());
            }
         
            
            //checking that which buildings can see the sunset
            
            output[0] = buildings[0]; // first one will always see the sunset
             for (int i=1;i<buildings.Length; i++)
            {
                largest = buildings[i];

                for(int k=i; k >= 0; k--)
                {
                 
                    
                        if (buildings[k]>largest )
                        {
                            largest=buildings[k];
                        }
                        if (buildings[k] == largest)
                        {
                           isequal=true ;
                        }

                }
                if (buildings[i]==largest && isequal == false)
                {
                    output[i] = buildings[i];

                }
            
            }
          
            // printing the output array
            Console.WriteLine("heights of buildings that can see the sunset are below");
            
            for (int l = 0; l < output.Length; l++)
            {
               
                if (output[l] != 0)
                {
                  Console.WriteLine( " buildings number :: " +( l+1)+ " with height:: " + output[l]  );
                }
              
            }
            


        
        
        
        
        }
    }
}
