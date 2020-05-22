using System;
using System.Diagnostics;
using System.Drawing;

namespace ProyectoFinalArquiHard
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Bitmap imagen = new Bitmap(@"F:\Documentos\ICESI\7mo Semestre\Arquitectura de hardware\Proyecto final\imagen64.png", true);
            Bitmap nueva = version3(imagen);
            nueva.Save(@"F:\Documentos\ICESI\7mo Semestre\Arquitectura de hardware\Proyecto final\nueva64.png");
            
        }

        public static Bitmap version1(Bitmap imagen)
        {
            Stopwatch timeA = new Stopwatch();
            timeA.Restart();
            timeA.Start();
            long tiempo = 0;
            int rows = imagen.Width;
            int columns = imagen.Height;
            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < columns; y++)
                {
                    Color color = imagen.GetPixel(x, y);
                    int r = 255 - color.R;
                    int g = 255 - color.G;
                    int b = 255 - color.B;
                    imagen.SetPixel(x, y, Color.FromArgb(r, g, b));                    
                }
                
            }
            timeA.Stop();

            tiempo = (long)(timeA.Elapsed.TotalMilliseconds * 1000000) / (rows * columns);
            Console.WriteLine(rows + " " + columns + " Tiempo " + tiempo);
            return imagen;
        }
        public static Bitmap version2(Bitmap imagen)
        {
            Stopwatch timeA = new Stopwatch();
            long tiempo = 0;
            int rows = imagen.Width;
            int columns = imagen.Height;
            timeA.Restart();
            timeA.Start();            
            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < columns; y++)
                {
                    Color color = imagen.GetPixel(x, y);
                    int r = 255 - color.R;

                    imagen.SetPixel(x, y, Color.FromArgb(r, color.G, color.B));
                }

            }
            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < columns; y++)
                {
                    Color color = imagen.GetPixel(x, y);
                    
                    int g = 255 - color.G;
                    imagen.SetPixel(x, y, Color.FromArgb(color.R, g, color.B));
                }

            }
            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < columns; y++)
                {
                    Color color = imagen.GetPixel(x, y);

                    int b = 255 - color.B;
                    imagen.SetPixel(x, y, Color.FromArgb(color.R, color.G, b));
                }

            }

            timeA.Stop();
            tiempo = (long)(timeA.Elapsed.TotalMilliseconds * 1000000) / (rows * columns);
            Console.WriteLine(rows + " " + columns + " Tiempo " + tiempo);
            return imagen;
        }
        public static Bitmap version3(Bitmap imagen)
        {
            Stopwatch timeA = new Stopwatch();
            timeA.Restart();
            timeA.Start();
            long tiempo = 0;
            int rows = imagen.Width;
            int columns = imagen.Height;
            for (int y = 0; y < columns; y++)
            {
                for (int x = 0; x < rows; x++)
                {
                    Color color = imagen.GetPixel(x, y);
                    int r = 255 - color.R;
                    int g = 255 - color.G;
                    int b = 255 - color.B;
                    imagen.SetPixel(x, y, Color.FromArgb(r, g, b));
                }

            }
            timeA.Stop();

            tiempo = (long)(timeA.Elapsed.TotalMilliseconds * 1000000) / (rows * columns);
            Console.WriteLine(rows + " " + columns + " Tiempo " + tiempo);
            return imagen;
        }
    }

}
