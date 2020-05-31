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
            String line;
            StreamReader file = new StreamReader(@"C:\Users\sergi\OneDrive\Semestre\Arquitectura de computadores y Laboratorio\Taller Final\ProyectoFinal-Arquihard\casos.txt");
            StreamWriter sw = new StreamWriter(@"C:\Users\sergi\OneDrive\Semestre\Arquitectura de computadores y Laboratorio\Taller Final\ProyectoFinal-Arquihard\datos.txt");
            long time = 0;
            while ((line = file.ReadLine()) != null)
            {
                String[] dato = line.Split();
                String algoritmo = dato[0];
                String tamaño = dato[1];
                String bits = dato[2];
                String ruta = @"C:\Users\sergi\OneDrive\Semestre\Arquitectura de computadores y Laboratorio\Taller Final\ProyectoFinal-Arquihard\img\img" + bits + "b" + tamaño + ".png";

                //if (bits.Equals("96"))
                //{
                //    ruta = ruta + ".bmp";
                //}
                //else
                //{
                //    ruta = ruta + ".png";
                //}
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
                sw.WriteLine(time);

            }
            sw.Close();
            file.Close();

            //Bitmap original = new Bitmap(@"F:\Documentos\ICESI\7mo Semestre\Arquitectura de hardware\Proyecto final\img\img.png", true);


            //Image imagen = Image.FromFile(@"F:\Documentos\ICESI\7mo Semestre\Arquitectura de hardware\Proyecto final\img\img.png");


            //Bitmap img24b64 = ConvertTo24bpp(imagen, 64, 64);
            //img24b64.Save(@"F:\Documentos\ICESI\7mo Semestre\Arquitectura de hardware\Proyecto final\img\img24b64.png");
            //Bitmap img24b160 = ConvertTo24bpp(imagen, 160, 160);
            //img24b160.Save(@"F:\Documentos\ICESI\7mo Semestre\Arquitectura de hardware\Proyecto final\img\img24b160.png");
            //Bitmap img24b512 = ConvertTo24bpp(imagen, 512, 512);
            //img24b512.Save(@"F:\Documentos\ICESI\7mo Semestre\Arquitectura de hardware\Proyecto final\img\img24b512.png");
            //Bitmap img24b1500 = ConvertTo24bpp(imagen, 1500, 1500);
            //img24b1500.Save(@"F:\Documentos\ICESI\7mo Semestre\Arquitectura de hardware\Proyecto final\img\img24b1500.png");

            //Bitmap img32b64 = ConvertTo32bpp(imagen, 64, 64);
            //img32b64.Save(@"F:\Documentos\ICESI\7mo Semestre\Arquitectura de hardware\Proyecto final\img\img32b64.png");
            //Bitmap img32b160 = ConvertTo32bpp(imagen, 160, 160);
            //img32b160.Save(@"F:\Documentos\ICESI\7mo Semestre\Arquitectura de hardware\Proyecto final\img\img32b160.png");
            //Bitmap img32b512 = ConvertTo32bpp(imagen, 512, 512);
            //img32b512.Save(@"F:\Documentos\ICESI\7mo Semestre\Arquitectura de hardware\Proyecto final\img\img32b512.png");
            //Bitmap img32b1500 = ConvertTo32bpp(imagen, 1500, 1500);
            //img32b1500.Save(@"F:\Documentos\ICESI\7mo Semestre\Arquitectura de hardware\Proyecto final\img\img32b1500.png");


            //Bitmap img48b64 = ConvertTo48bpp(imagen, 64, 64);
            //img48b64.Save(@"F:\Documentos\ICESI\7mo Semestre\Arquitectura de hardware\Proyecto final\img\img48b64.png");
            //Bitmap img48b160 = ConvertTo48bpp(imagen, 160, 160);
            //img48b160.Save(@"F:\Documentos\ICESI\7mo Semestre\Arquitectura de hardware\Proyecto final\img\img48b160.png");
            //Bitmap img48b512 = ConvertTo48bpp(imagen, 512, 512);
            //img48b512.Save(@"F:\Documentos\ICESI\7mo Semestre\Arquitectura de hardware\Proyecto final\img\img48b512.png");
            //Bitmap img48b1500 = ConvertTo48bpp(imagen, 1500, 1500);
            //img48b1500.Save(@"F:\Documentos\ICESI\7mo Semestre\Arquitectura de hardware\Proyecto final\img\img48b1500.png");

            //Bitmap nueva1 = version1(imagen1);
            //nueva1.Save(@"F:\Documentos\ICESI\7mo Semestre\Arquitectura de hardware\Proyecto final\1nueva64.png");
            //Bitmap imagen2 = new Bitmap(@"F:\Documentos\ICESI\7mo Semestre\Arquitectura de hardware\Proyecto final\imagen64.png", true);
            //Bitmap nueva2 = version2(imagen2);
            //nueva2.Save(@"F:\Documentos\ICESI\7mo Semestre\Arquitectura de hardware\Proyecto final\2nueva64.png");
            //Bitmap imagen3 = new Bitmap(@"F:\Documentos\ICESI\7mo Semestre\Arquitectura de hardware\Proyecto final\imagen64.png", true);
            //Bitmap nueva3 = version3(imagen3);
            //nueva3.Save(@"F:\Documentos\ICESI\7mo Semestre\Arquitectura de hardware\Proyecto final\3nueva64.png");
            //Bitmap imagen4 = new Bitmap(@"F:\Documentos\ICESI\7mo Semestre\Arquitectura de hardware\Proyecto final\imagen64.png", true);
            //Bitmap nueva4 = version4(imagen4);
            //nueva4.Save(@"F:\Documentos\ICESI\7mo Semestre\Arquitectura de hardware\Proyecto final\4nueva64.png");
            //Bitmap imagen5 = new Bitmap(@"F:\Documentos\ICESI\7mo Semestre\Arquitectura de hardware\Proyecto final\imagen64.png", true);
            //Bitmap nueva5 = version5(imagen5);x
            //nueva5.Save(@"F:\Documentos\ICESI\7mo Semestre\Arquitectura de hardware\Proyecto final\5nueva64.png");


            //64,160,512,1500
        }
        
        public static Bitmap ConvertTo24bpp(Image img, int w, int h)
        {
            var bmp = new Bitmap(w, h, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            using (var gr = Graphics.FromImage(bmp))
                gr.DrawImage(img, new Rectangle(0, 0, w, h));
            return bmp;
        }
        public static Bitmap ConvertTo32bpp(Image img, int w, int h)
        {
            var bmp = new Bitmap(w, h, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
            using (var gr = Graphics.FromImage(bmp))
                gr.DrawImage(img, new Rectangle(0, 0, w, h));
            return bmp;
        }
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
