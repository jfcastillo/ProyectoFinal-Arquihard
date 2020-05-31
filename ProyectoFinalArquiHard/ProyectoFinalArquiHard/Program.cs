using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;

namespace ProyectoFinalArquiHard
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se probó anteriormente que las 5 versiones de algoritmos convertian la imagen igual, por eso se retorna el tiempo.
            //Variable donde se almacena el tiempo de ejecución
            long time = 0;
            //Variable para seleccionar el algoritmo: 1,2,3,4,5
            String algoritmo = "5";
            //Variable para seleccionar el tamaño: 64,160,512,1500
            String tamaño = "1500";
            //Variable para seleccionar los bits: 24,32,48
            String bits = "48";
            //Ruta en la que se encuentra la imagen a pasar por las versiones de los algoritmos
            String ruta = @"F:\Documentos\ICESI\7mo Semestre\Arquitectura de hardware\Proyecto final\img\img" + bits + "b" + tamaño + ".png";
            Bitmap imagen = new Bitmap(ruta, true); 

            switch (algoritmo)
            {
                case "1":
                    time = version1(imagen);
                    break;
                case "2":
                    time = version2(imagen);
                    break;
                case "3":
                    time = version3(imagen);
                    break;
                case "4":
                    time = version4(imagen);
                    break;
                case "5":
                    time = version5(imagen);
                    break;
                default:
                    break;
                }
        }
        //Método para convertir la imagen a 24 bits por pixel
        public static Bitmap ConvertTo24bpp(Image img, int w, int h)
        {
            var bmp = new Bitmap(w, h, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            using (var gr = Graphics.FromImage(bmp))
                gr.DrawImage(img, new Rectangle(0, 0, w, h));
            return bmp;
        }
        //Método para convertir la imagen a 32 bits por pixel
        public static Bitmap ConvertTo32bpp(Image img, int w, int h)
        {
            var bmp = new Bitmap(w, h, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
            using (var gr = Graphics.FromImage(bmp))
                gr.DrawImage(img, new Rectangle(0, 0, w, h));
            return bmp;
        }
        //Método para convertir la imagen a 48 bits por pixel
        public static Bitmap ConvertTo48bpp(Image img, int w, int h)
        {
            var bmp = new Bitmap(w, h, System.Drawing.Imaging.PixelFormat.Format48bppRgb);
            using (var gr = Graphics.FromImage(bmp))
                gr.DrawImage(img, new Rectangle(0, 0, w, h));
            return bmp;
        }

        public static long version1(Bitmap imagen)
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

            tiempo = (long)(timeA.Elapsed.TotalMilliseconds * 1000000);
            Console.WriteLine("Version 1 Tiempo " + tiempo);
            return tiempo;
        }
        public static long version2(Bitmap imagen)
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
            tiempo = (long)(timeA.Elapsed.TotalMilliseconds * 1000000) ;
            Console.WriteLine("Version 2 Tiempo " + tiempo);
            return tiempo;
        }
        public static long version3(Bitmap imagen)
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

            tiempo = (long)(timeA.Elapsed.TotalMilliseconds * 1000000);
            Console.WriteLine("Version 3 Tiempo " + tiempo);
            return tiempo;
        }
        public static long version4(Bitmap imagen)
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

            tiempo = (long)(timeA.Elapsed.TotalMilliseconds * 1000000);
            Console.WriteLine("Version 4 Tiempo " + tiempo);
            return tiempo;
        }
        public static long version5(Bitmap imagen)
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
                    imagen.SetPixel(x, y + 1, Color.FromArgb(r, g, b));

                    Color color2 = imagen.GetPixel(x + 1, y);
                    r = 255 - color2.R;
                    g = 255 - color2.G;
                    b = 255 - color2.B;
                    imagen.SetPixel(x + 1, y, Color.FromArgb(r, g, b));

                    Color color3 = imagen.GetPixel(x + 1, y + 1);
                    r = 255 - color3.R;
                    g = 255 - color3.G;
                    b = 255 - color3.B;
                    imagen.SetPixel(x + 1, y + 1, Color.FromArgb(r, g, b));
                }

            }
        
            timeA.Stop();

            tiempo = (long)(timeA.Elapsed.TotalMilliseconds * 1000000);
            Console.WriteLine("Version 5 Tiempo " + tiempo);
            return tiempo;
        }
    }

}
