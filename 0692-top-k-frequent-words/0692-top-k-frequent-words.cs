public class Solution
{
    public IList<string> TopKFrequent(string[] words, int k)
    {
        Dictionary<string, int> freq = new();

        foreach (string word in words)
        {
            if (freq.ContainsKey(word))
                freq[word]++;
            else
                freq[word] = 1;
        }

        PriorityQueue<string, (int freq, string word)> heap =
            new(new WordComparer());

        foreach (var pair in freq)
        {
            heap.Enqueue(pair.Key, (pair.Value, pair.Key));

            if (heap.Count > k)
                heap.Dequeue();
        }

        List<string> result = new();

        while (heap.Count > 0)
        {
            result.Add(heap.Dequeue());
        }

        result.Reverse();

        return result;
    }
}

public class WordComparer : IComparer<(int freq, string word)>
{
    public int Compare((int freq, string word) x,
                       (int freq, string word) y)
    {
        if (x.freq != y.freq)
            return x.freq.CompareTo(y.freq);

        return y.word.CompareTo(x.word);
    }
}