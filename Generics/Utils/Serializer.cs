using Newtonsoft.Json;

namespace Generics.Utils
{
    public class Serializer<T>
    {
        public string Serialize(T obj)
        {
            string serializedObj = JsonConvert.SerializeObject(obj);

            return serializedObj;
        }
    }
}
