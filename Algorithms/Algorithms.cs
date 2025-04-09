

using BenchmarkDotNet.Attributes;

public class Algorithms
{
    int[] cards; // Deklaration
    public Algorithms()
    {
         cards = new int[50_000_000]; // Initialisierung
        for (int i = 0; i < cards.Length; i++)
        {
        cards[i] = i + 1;
        }
    }
    // Binary Search => 0(log(n))
    [Benchmark]
    public void TestBinarySearch()
    {
        
    FindCardLocationBinarySearch(cards, query: 40_942_069);
    
    }
    public static int FindCardLocationBinarySearch(int[] cards, int query)
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

[Benchmark]
    public void TestLinearSearch()
    {
        
    FindCardLocation(cards, query: 40_942_069);
    }
    
// Linear Search => 0(n)
public static int FindCardLocation(int[] cards, int query)
{
    /*
    Definiere Variable "index" und initialisiere mit Wert 0
    Wiederhole bis "index" gleich "cards" length:
        Wenn "cards" an "index" gleich "query", dann:
            Gebe "index" zurück
    Inkrementiere "index" um 1
    */
    int index = 0;
    while (index < cards.Length)
    {
        if (cards[index] == query)
            return index;
        index++; // index = index + 1;
    }
    return -1;
}

}
