 int[] cards = [3, 5, 7, 8, 9];
 // int[] cards = {3, 5, 7, 8, 9};
 int[] cards2 = new int[50_000_000];
 // 50_000_000
 // 25_000_000
 // 12_500_000
 // 6_250_000
for (int i = 0; i < cards2.Length; i++)
 {
    cards2[i] = i + 1;
 }
 int query = 7;

 var result = FindCardLocationBinarySearch(cards, query);
 Console.WriteLine("Index von gesuchtem Element: " +result);
 //Console.WriteLine(cards2[10]);
 var result2 = FindCardLocationBinarySearch(cards: cards2, query: 40_942_069);
 Console.WriteLine(result2);//4_942_070


// Binary Search => 0(log(n))
int FindCardLocationBinarySearch(int[] cards, int query)
{
// todo: implementiere die gleiche funktionalität wie in FindCardLocation, aber mit Binary Search
int low = 0;
int high = cards.Length -1;

while(low <= high)
{
    int mid = (low + high)/2;

    if(cards[mid] == query)
    {
        return mid;
    }
       
    if(cards[mid] < query)
     {
        low = mid +1;
     } 
    else 
    {high = mid -1;}
    
}
    return -1; 
    
}


// Linear Search => 0(n)
int FindCardLocation(int[] cards, int query)
{
    /*
    Definiere Variable "index" und initialisiere mit Wert 0
    Wiederhole bis "index" gleich "cards" length:
        Wenn "cards" an "index" gleich "query", dann:
            Gebe "index" zurück
    Inkrementiere "index" um 1
    */
    int index = 0;
    while (index < cards2.Length)
    {
        if (cards2[index] == query)
            return index;
        index++; // index = index + 1;
    }
    return -1;
}
