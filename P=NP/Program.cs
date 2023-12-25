using System;

class Program
{
    static void Main(string[] args) {
        int item_n = 8;
        int[,] Knapsack = {
                {50}, // Knapsack weight capacity
                {10000} // Knapsack price capacity
        };

        int[][][] items = new int[item_n][item_n][item_n];

        Console.WriteLine("Hello World !");

    }

    public static void item_list(int[][][]args) {
        enum Item_name {
            Piano, 
            Synthetiseur, 
            MacBook, 
            Guitar, 
            Speaker, 
            PetitPiano, 
            Table, 
            Chaise,
        }

        int[][][] array = {
                {Item_name.Piano, Item_name.Synthetiseur, Item_name.MacBook, Item_name.Guitar, Item_name.Speaker, Item_name.PetitPiano, Item_name.Table, Item_name.Chaise}, // Item ID
                {2000,           500,                    2400,              1000,             1200,              2000,                 4000,            3000}, // Item PRICE
                {12,             4,                      12,                3,                8,                 3,                    23,              20} // Item Weight
        };
        args = array;

    }

}
