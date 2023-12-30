using System;

namespace PnNP;


public class Program
{
    enum Item_name {
        Piano, 
        Synthetiseur, 
        MacBook, 
        Guitar, 
        Speaker, 
        PetitPiano, 
        Table, 
        Chaise
    }

    static void Main(string[] args) {

        int[,] Knapsack = {
                {50}, // Knapsack weight capacity
                {10000} // Knapsack price capacity
        };

        int[,,] items = item_list();
        Console.WriteLine(items);
        
        foreach (int element in items)
        {
            Console.WriteLine(element);
        }
        
    }

    public static int[,,] item_list() {
        
        int[,,] array = {
            {
                {(int)Item_name.Piano, (int)Item_name.Synthetiseur, (int)Item_name.MacBook, (int)Item_name.Guitar, (int)Item_name.Speaker, (int)Item_name.PetitPiano, (int)Item_name.Table, (int)Item_name.Chaise} // Item ID
            },
            {
                {2000, 500, 2400, 1000, 1200, 2000, 4000, 3000} // Item PRICE
            },
            {
                {12, 4, 12, 3, 8, 3, 23, 20} // Item Weight
            }
        };
        return array;
    }

}
