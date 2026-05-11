var filePath = "C:\\Users\\mahma\\CodeProjects\\LearningProjects\\LearnC-Sharp\\CSVReader\\sampleData.csv";
var reader = new CsvReader();
var result = reader.Read(filePath);
Console.ReadKey();

public class CsvReader
{
    const char SEPARATOR = ',';
    public CsvData Read(string filePath)
    {
        using var reader = new StreamReader(filePath);
        var columns = reader.ReadLine().Split(SEPARATOR);

        List<string[]> rows = new List<string[]>();
        while (!reader.EndOfStream)
        {
            var row = reader.ReadLine().Split(SEPARATOR);
            rows.Add(row);
        }
        return new CsvData(columns, rows);
    }
}

public class CsvData(string[] headers, IEnumerable<string[]> records)
{
    public string[] Headers { get; } = headers;
    public IEnumerable<string[]> Records { get; } = records;
}