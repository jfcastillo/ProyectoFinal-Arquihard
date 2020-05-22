using System;
using System.Diagnostics;
using System.Drawing;

namespace ProyectoFinalArquiHard
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Bitmap imagen1 = new Bitmap(@"F:\Documentos\ICESI\7mo Semestre\Arquitectura de hardware\Proyecto final\imagen64.png", true);
            Bitmap nueva1 = version1(imagen1);
            nueva1.Save(@"F:\Documentos\ICESI\7mo Semestre\Arquitectura de hardware\Proyecto final\1nueva64.png");
            Bitmap imagen2 = new Bitmap(@"F:\Documentos\ICESI\7mo Semestre\Arquitectura de hardware\Proyecto final\imagen64.png", true);
            Bitmap nueva2 = version2(imagen2);
            nueva2.Save(@"F:\Documentos\ICESI\7mo Semestre\Arquitectura de hardware\Proyecto final\2nueva64.png");
            Bitmap imagen3 = new Bitmap(@"F:\Documentos\ICESI\7mo Semestre\Arquitectura de hardware\Proyecto final\imagen64.png", true);
            Bitmap nueva3 = version3(imagen3);
            nueva3.Save(@"F:\Documentos\ICESI\7mo Semestre\Arquitectura de hardware\Proyecto final\3nueva64.png");
            Bitmap imagen4 = new Bitmap(@"F:\Documentos\ICESI\7mo Semestre\Arquitectura de hardware\Proyecto final\imagen64.png", true);
            Bitmap nueva4 = version4(imagen4);
            nueva4.Save(@"F:\Documentos\ICESI\7mo Semestre\Arquitectura de hardware\Proyecto final\4nueva64.png");
            Bitmap imagen5 = new Bitmap(@"F:\Documentos\ICESI\7mo Semestre\Arquitectura de hardware\Proyecto final\imagen64.png", true);
            Bitmap nueva5 = version5(imagen5);
            nueva5.Save(@"F:\Documentos\ICESI\7mo Semestre\Arquitectura de hardware\Proyecto final\5nueva64.png");

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
            Console.WriteLine("Version 1 Tiempo " + tiempo);
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
            Console.WriteLine("Version 2 Tiempo " + tiempo);
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
            Console.WriteLine("Version 3 Tiempo " + tiempo);
            return imagen;
        }
        public static Bitmap version4(Bitmap imagen)
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
                    imagen.SetPixel(x, y, Color.FromArgb(r, color.G, color.B));
                }

            }
            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < columns; y++)
                {
                    Color color = imagen.GetPixel(x, y);                    
                    int g = 255 - color.G;
                    int b = 255 - color.B;
                    imagen.SetPixel(x, y, Color.FromArgb(color.R, g, b));
                }

            }
            timeA.Stop();

            tiempo = (long)(timeA.Elapsed.TotalMilliseconds * 1000000) / (rows * columns);
            Console.WriteLine("Version 4 Tiempo " + tiempo);
            return imagen;
        }
        public static Bitmap version5(Bitmap imagen)
        {
            Stopwatch timeA = new Stopwatch();
            timeA.Restart();
            timeA.Start();
            long tiempo = 0;
            int rows = imagen.Width;
            int columns = imagen.Height;
            for (int x = 0; x < rows - 1; x += 2)
            {
                for (int y = 0; y < columns - 1; y += 2)
                {
                    Color color = imagen.GetPixel(x, y);
                    int r = 255 - color.R;
                    int g = 255 - color.G;
                    int b = 255 - color.B;
                    imagen.SetPixel(x, y, Color.FromArgb(r, g, b));

                    Color color1 = imagen.GetPixel(x, y + 1);
                    r = 255 - color1.R;
                    g = 255 - color1.G;
                    b = 255 - color1.B;
                    imagen.SetPixel(x, y, Color.FromArgb(r, g, b));

                    Color color2 = imagen.GetPixel(x + 1, y);
                    r = 255 - color2.R;
                    g = 255 - color2.G;
                    b = 255 - color2.B;
                    imagen.SetPixel(x, y, Color.FromArgb(r, g, b));

                    Color color3 = imagen.GetPixel(x + 1, y + 1);
                    r = 255 - color3.R;
                    g = 255 - color3.G;
                    b = 255 - color3.B;
                    imagen.SetPixel(x, y, Color.FromArgb(r, g, b));
                }

            }
        
            timeA.Stop();

            tiempo = (long)(timeA.Elapsed.TotalMilliseconds * 1000000) / (rows * columns);
            Console.WriteLine("Version 5 Tiempo " + tiempo);
            return imagen;
        }
    }

}
