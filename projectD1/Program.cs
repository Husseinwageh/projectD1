namespace projectD1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estimateforcarpet cleaning service");
            Console.Write("HOW MANY SMALL CARPETS:");
            intSMALL CARPET = int.Parse(Console.ReadLine());
            Console.Write("HOW MANY LARGECARPETS:");
            intLargecarpet = int.Parse(Console.ReadLine());
            CONSTintpricesmallcarpets = 25;
            constintpricelargecarpets = 35;   
            constfloat Tax=6,6f;
            Console.WriteLine("pricepersmallRoom:$25");
            Console.WriteLine("priceperlargeRoom:$35");
            intTotalcost = (smallcarpet * pricesmallcarpets) + (largecarpet * pricelargecarpets);
           Console.WriteLine($"cost:{Totalcost:C"});
           Console.Writeline($"Tax:{Tax:c}"); 
            Console.writeline("=================================================================");
            Console.Writeline($"TotalEstimate :{Totalcost+Tax:c}");
            Console.Writeline("ThisEstimateISValidfor30Days");






            
        }






    }
}