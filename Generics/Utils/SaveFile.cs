namespace Generics.Utils
{
    public class SaveFile
    {
        public void Save(string vehicle, string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(vehicle);
            }
        }
    }
}
