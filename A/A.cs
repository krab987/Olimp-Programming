using System;

class Program
    {
        public static void Main(string[] args)
        {
            int numBurglars = Convert.ToInt32(Console.ReadLine());
            int[] masBurglars = new int[numBurglars];
            for (int i = 0; i < numBurglars; i++)
            {
                masBurglars[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            int[] resBurglars = new int[numBurglars];
            int indRes = 0;


            int[] checkList = new int[numBurglars + 1];
            for (int i = 0; i < numBurglars; i++)
            {
                int countCheckList = 0;
                checkList[countCheckList] = i + 1;
                countCheckList++;
                
                for (int j = i; countCheckList < numBurglars +1; j = masBurglars[j] - 1 )
                {
                    //Console.WriteLine("ind:"+j+"el:" +masBurglars[j]+"\n");
                    checkList[countCheckList] = masBurglars[j];
                    countCheckList++;
                }
                // foreach (var el in checkList)
                // {
                //     Console.WriteLine("el:" +el);
                // }
                // Console.WriteLine("-------------");

                for (int p = 0; p < numBurglars+1; p++)
                {
                    for (int k = p+1; k < numBurglars+1; k++)
                    {
                        // Console.WriteLine("---sravn-----");
                        // Console.WriteLine(checkList[p]);
                        // Console.WriteLine(checkList[k]);
                        if (checkList[p] == checkList[k])
                        {
                            resBurglars[indRes] = checkList[k];
                            indRes++;
                            k = p = numBurglars+1;
                        }
                    }
                    
                }
                
            }
            for (int p = 0; p < numBurglars; p++)
            {
                Console.WriteLine(resBurglars[p]);
            }
        }
    }
