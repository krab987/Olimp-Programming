
#include <iostream>

using namespace std;
int main(int argc, char* argv[])
{
    int numBurglars;
    std::cin>>numBurglars;
    int masBurglars[numBurglars];
    for (int i = 0; i < numBurglars; i++)
    {
        cin>>masBurglars[i];
    }
    

    int checkList [numBurglars + 1];
    for (int i = 0; i < numBurglars; i++)
    {
        int countCheckList = 0;
        checkList[countCheckList] = i + 1;
        countCheckList++;
                
        for (int j = i; countCheckList < numBurglars +1; j = masBurglars[j] - 1 )
        {
            checkList[countCheckList] = masBurglars[j];
            countCheckList++;
        }

        for (int p = 0; p < numBurglars+1; p++)
        {
            for (int k = p+1; k < numBurglars+1; k++)
            {
                if (checkList[p] == checkList[k])
                {
                    cout << checkList[k] << " ";
                    k = p = numBurglars+1;
                }
            }
        }
                
    }

    return 0;
}

