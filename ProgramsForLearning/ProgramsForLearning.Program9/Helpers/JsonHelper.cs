using System.Text.Json;

namespace ProgramsForLearning.Program9.Helpers
{
    public static class JsonHelper
    {
        public static string Serialize(object obj)
        {
            if (obj == null)
            {
                return string.Empty;
            }
            return JsonSerializer.Serialize(obj);
        }

        public static string Serialize<T>(T obj)
        {
            if (obj == null)
            {
                return string.Empty;
            }
            return JsonSerializer.Serialize(obj);
        }


        public static T Deserialize<T>(string obj)
        {
            return JsonSerializer.Deserialize<T>(obj);
        }

    }
}
