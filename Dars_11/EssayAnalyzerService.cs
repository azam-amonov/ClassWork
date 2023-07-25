namespace Dars_11;
/// <summary>
/// - Splitter method
/// - Words count method
/// --- O'ziga Content tipini oladi, umumiy nechta so'z qatnashganini hisoblaydi
/// 
/// - Repeated words count method
///  --- O'ziga Content tipini oladi, umumiy nechta so'z qayta takrorlanganini hsiblaydi
/// 
/// - Checks capital words
/// - Bosh harf bilan boshlanishi kereka bo'lgan so'zlarni aniqlaydi (oldidan '. ')kelgan so'zlar
/// 
/// - Checks not capital words
/// -- Kichik harflar bilan yzoilishi kerak bo'lgan so'zlarni aniqlaydi
/// 
/// - Checks characters count method
/// So'zda harflar soni 20-ta belgidan oshib ketgan bo'lsa uni hisoblaydi
///
/// - Get Overall Score
/// Umumiy ballni hisoblaydi, o'ziga barcha metodlar qiymatini oladi
/// </summary>
public class EssayAnalyzerService
{
    public int CountOfWords(string words)
    {
        string[] wordsArray = words.Split(' ');
        return wordsArray.Length < 500 ? -5 : 0;
    }

    public decimal CountOfRepeatedWords(string words)
    {
        string[] wordArray = words.Split(' ');
        decimal actualCount = wordArray.Length;
        decimal distinctCount = wordArray.Distinct().Count();
        decimal percent = (distinctCount / actualCount) * 100;
        
        return percent > 20 ? -5 : 0;
    }

    public int CountOfNotCapitalisedWords(string words)
    {
        string[] wordsArray = words.Split(".");
        int count = 0;

        foreach (string item in wordsArray)
        {
            if (Char.IsUpper(item, 1))
                ++count;
            Console.WriteLine(item);
        }

        return count;
    }
    

    public int LongWords(string words)
    {
        return 0;
    }
    
}