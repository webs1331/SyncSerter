using System.Text;
using Newtonsoft.Json;

namespace SyncSerter.Data
{
    internal class DataHelper
    {
        public static async Task<string> Read(string filePath)
        {
            var bytes = await File.ReadAllBytesAsync(filePath);

            return Encoding.UTF8.GetString(bytes);
        }

        public static async Task<T?> ReadJSON<T>(string fileName)
        {
            var json = await Read(fileName);

            try
            {
                return JsonConvert.DeserializeObject<T>(json);
            }
            catch (Exception)
            {
                return default;
            }
        }
    }
}
