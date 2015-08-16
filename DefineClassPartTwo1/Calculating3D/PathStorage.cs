namespace Calculating3D
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public static class PathStorage
    {
        private static List<Path> paths;

        public static void LoadingPathFromFile(string textFile)
        {
            using (StreamReader readerOfFile = new StreamReader("LoaderTextFile.txt"))
            {
                string path;

                while ((path = readerOfFile.ReadLine()) != null)
                {
                    string[] coordinates = path.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    Path newPath = new Path();

                    for (int i = 0; i < coordinates.Length; i = i + 3)
                    {
                        Point3D newPoint = new Point3D(double.Parse(coordinates[i]), double.Parse(coordinates[i + 1]),
                            double.Parse(coordinates[i + 2]));
                        newPath.SequenceOf3Dpoints.Add(newPoint);
                    }

                    paths.Add(newPath);
                }
            }
        }

        public static void SavePathToFile(string nameOfFile)
        {
            using (StreamWriter writingToFile = new StreamWriter(nameOfFile))
            {
                for (int i = 0; i < paths.Count; i++)
                {
                    StringBuilder line = new StringBuilder();

                    for (int j = 0; j < paths[i].SequenceOf3Dpoints.Count; j++)
                    {
                        line.Append(paths[i].SequenceOf3Dpoints[j].X + " ");
                        line.Append(paths[i].SequenceOf3Dpoints[j].Y + " ");
                        line.Append(paths[i].SequenceOf3Dpoints[j].Z + " ");
                    }

                    writingToFile.WriteLine(line);
                }
            }
        }
    }
}
