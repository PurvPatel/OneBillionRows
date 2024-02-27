using System.IO;
using System.Text;

// read file
const Int32 BufferSize = 128;
using (var fileStream = File.OpenRead("../../data.txt"))
{
  using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
  {
    String line;
    while ((line = streamReader.ReadLine()) != null)
    {
      // Process line
      Console.WriteLine(line);
    }
  }
}
