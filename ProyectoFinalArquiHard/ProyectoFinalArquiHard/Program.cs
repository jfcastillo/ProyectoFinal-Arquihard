using System;
using System.Drawing;

namespace ProyectoFinalArquiHard
{
    class Program
    {
        static void Main(string[] args)
        {
            //% Versi�n 1
            //    ImRGB = ImRGB0;
            //for R = 1: Rows
            //                    for C = 1:Columns
            //        ImRGB(R, C, 1) = 255 - ImRGB(R, C, 1);  % Image[i, j].R
            //        ImRGB(R, C, 2) = 255 - ImRGB(R, C, 2); % Image[i, j].G
            //        ImRGB(R, C, 3) = 255 - ImRGB(R, C, 3);  % Image[i, j].B
            //        end
            //    end
            //    figure
            //    subplot(2, 1, 1)
            //    imshow(ImRGB0); title('ImRGB0');
            //subplot(2, 1, 2);
            //imshow(ImRGB); title('Version1');
            Bitmap imagen = new Bitmap(@"F:\Documentos\ICESI\7mo Semestre\Arquitectura de hardware\Proyecto final\imagen1.png", true);
            for(int x = 0; x < imagen.Width; x++)
            {
                for (int y = 0; y < imagen.Height; y++)
                {
                    Color color = imagen.GetPixel(x, y);
                    int r = 255 - color.R;
                    int g = 255 - color.G;
                    int b = 255 - color.B;

                    imagen.SetPixel(x, y, Color.FromArgb(r, g, b));
                    imagen.Save(@"F:\Documentos\ICESI\7mo Semestre\Arquitectura de hardware\Proyecto final\nueva.png");



                }
            }

        }
    }
}
