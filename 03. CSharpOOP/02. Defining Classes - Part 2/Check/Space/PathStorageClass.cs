
namespace Check.Space
{
    using Space;
    using System;
    using System.IO;
    using System.Linq;
    
    public class PathStorage
    {
        public static void Save(Path path, string fileName)
        {
            string fullPath = @"..\..\" + fileName;
            using (StreamWriter writer = new StreamWriter(fullPath))
            {
                writer.Write(path);
            }
        }

        public static Path Load(string fileName)
        {
            Path path = new Path();
            string fullPath = @"..\..\" + fileName;

            try
            {
                using (StreamReader reader = new StreamReader(fullPath))
                {
                    string[] allPoints = reader.ReadToEnd()
                        .Split(new string[] { "; " }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (var point in allPoints)
                    {
                        float[] coordinates = point.Trim('(').Trim(')')
                            .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(x => float.Parse(x))
                            .ToArray();

                        path.AddPoint(new Point3D(coordinates[0], coordinates[1], coordinates[2]));
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.Write("The file cannot be found.");
                return null;
            }

            return path;
        }
    }
}
