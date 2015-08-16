using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DistanceBewtweenPoints
{
    public static class PathStorage
    {
        private static List<Path> listOfPaths = new List<Path>();

        public static List<Path> ListOfPaths
        {
            get { return listOfPaths; }
        }

        public static void SavePathToTextFile(Path path)
        {
            StringBuilder sb = new StringBuilder();

            using (StreamWriter writer = new StreamWriter("SavedPaths.txt"))
            {
                foreach (Point3D point in path.ListOfPoints)
                {
                    sb.Append(point.X + "," + point.Y + "," + point.Z + " ");
                }
                writer.WriteLine(sb); ;
            }
        }

        public static void LoadPathsFromTextFile()
        {
            using (StreamReader reader = new StreamReader("LoadingOfPaths.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Path pathOfPoints = new Path();
                    string[] stringPath = line.Split(new Char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < stringPath.Length; i += 3)
                    {
                        Point3D pointInPath = new Point3D(double.Parse(stringPath[i]), double.Parse(stringPath[i + 1]), double.Parse(stringPath[i + 2]));
                        pathOfPoints.AddPoint(pointInPath);
                    }
                    listOfPaths.Add(pathOfPoints);
                }
            }
        }
    }
}
