
int ano = 2024; 
List<int> years = new List<int>();

while(years.Count < 20)
{
    if((ano % 4 == 0 && ano % 100 != 0 ) || ano % 400 == 0)
    {
        years.Add(ano);
        
    }
    ano++;
}

for(int i = 0; i < years.Count; i++)
{
    Console.WriteLine(years[i]); 
}



   

