using System;
using System.Collections.Generic;

namespace PnNP;

public class Jewel
{
	public int Weight { get; set; }
	public int Value { get; set; }
}

public static int KnapSack(int bagCapacity, List jewels)
{
	var itemCount = jewels.Count;

	int[,] matrix = new int[itemCount + 1, bagCapacity + 1];

	//Go through each item. 
	for (int i = 0; i <= itemCount; i++)
	{
		//This loop basically starts at 0, and slowly gets bigger. 
		//Think of it like working out the best way to fit into smaller bags and then keep building on that. 
		for (int w = 0; w <= bagCapacity; w++)
		{
			//If we are on the first loop, then set our starting matrix value to 0. 
			if (i == 0 || w == 0)
			{
				matrix[i, w] = 0;
				continue;
			}

			//Because indexes start at 0, 
			//it's easier to read if we do this here so we don't think that we are reading the "previous" element etc. 
			var currentJewelIndex = i - 1;
			var currentJewel = jewels[currentJewelIndex];
			//Is the weight of the current jewel less than W 
			//(e.g. We could find a place to put it in the bag if we had to, even if we emptied something else?)
			if (currentJewel.Weight <= w)
			{
				//If I took this jewel right now, and combined it with other gems
				//Would that be bigger than what you currently think is the best effort now? 
				//In other words, if W is 50, and I weigh 30. If I joined up with another jewel that was 20 (Or multiple that weigh 20, or none)
				//Would I be better off with that combination than what you have right now?
				//If not, then just set the value to be whatever happened with the last item 
				//(may have fit, may have done the same thing and not fit and got the previous etc). 
				matrix[i, w] = Math.Max(currentJewel.Value + matrix[i - 1, w - currentJewel.Weight]
										, matrix[i - 1, w]);
			}
			//This jewel can't fit, so bring forward what the last value was because that's still the "best" fit we have. 
			else
				matrix[i, w] = matrix[i - 1, w];
		}
	}

	//Because we carry everything forward, the very last item on both indexes is our max val
	return matrix[itemCount, bagCapacity];
}

static void Main(string[] args)
{
	var items = new List
		{
			new Jewel {Value = 120, Weight = 10},
			new Jewel {Value = 100, Weight = 20},
			new Jewel {Value = 500, Weight = 30},

		};

	Console.WriteLine(KnapSack(50, items));
}
