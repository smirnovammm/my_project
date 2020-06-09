using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace kursovaya
{
    abstract class Filters
    {
        protected abstract Color calculateNewPixelColor(Bitmap sourceImage, int x, int y);
        public int Clamp(int value, int min, int max)
        {
            if (value < min)
                return min;
            if (value > max)
                return max;
            return value;
        }
        public int getwidth(Bitmap sourceImage)
        {
            int width;
            return width = sourceImage.Width;
        }
        public int getheight(Bitmap sourceImage)
        {
            int height;
            return height = sourceImage.Height;
        }
        public virtual Bitmap processImage(Bitmap sourceImage, int r1, int r2, int s1, int s2)
        {
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            for (int i = 0; i < sourceImage.Width; i++)
            {
                for (int j = 0; j < sourceImage.Height; j++)
                    resultImage.SetPixel(i, j, calculateNewPixelColor(sourceImage, i, j));
            }
            return resultImage;
        }
        public int calculateIntensive(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            int gray = (int)((sourceColor.R + sourceColor.G + sourceColor.B) / 3);
            return gray;

        }

        /*public int[] Intensive(Bitmap sourceImage)
        {
            int[] intensive = new int[sourceImage.Width * sourceImage.Height];
            for (int m = 0; m < sourceImage.Width * sourceImage.Height; m++)
            {
                for (int i = 0; i < sourceImage.Width; i++)
                {
                    for (int j = 0; j < sourceImage.Height; j++)
                        intensive[m] = calculateIntensive(sourceImage, i, j);


                }
            }
            return intensive[];
        }*/
    }
    class InvertFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            Color resultColor = Color.FromArgb(255 - sourceColor.R, 255 - sourceColor.G, 255 - sourceColor.B);
            return resultColor;
        }
    };

    class LogarifmFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            int gray = (int)((sourceColor.R + sourceColor.G + sourceColor.B) / 3);
            int a = (int)(100 * Math.Log10(gray + 1));
            Color resultColor = Color.FromArgb(a, a, a);
            return resultColor;
        }
    }
    class StepenFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            int gray = (int)((sourceColor.R + sourceColor.G + sourceColor.B) / 3);
            int a = (int)(20 * Math.Pow(gray, 5));
            if (a > 255) a = 255;
            if (a < 0) a = 0;
            Color resultColor = Color.FromArgb(a, a, a);
            return resultColor;
        }


    }

    class kuski : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        { return Color.FromArgb(255, 0, 0); }
        public override Bitmap processImage(Bitmap sourceImage, int r1, int r2, int s1, int s2)
        {

            /* int[] intensive = new int[sourceImage.Width * sourceImage.Height];
             int m = 0;
             for (int i = 0; i < sourceImage.Height; i++)
             {
                 for (int j = 0; j < sourceImage.Width; j++)
                 {
                     intensive[m] = calculateIntensive(sourceImage, j, i);
                     m++;
                 } 
             }
             m -= m;
             int[] num = new int[m+1];
             for(int i = 0; i<(m+1); i++)
             {
                 num[i] = i;
             }
             //Сортировка гистограммы
             for (int i = 0; i < m; i++)
             {
                 int min = i;
                 for (int j = i + 1; j < (m+1); j++)
                     if (intensive[j] < intensive[min])
                     {
                         min = j;
                     }
             int tmp = intensive[i];
             intensive[i] = intensive[min];
             intensive[min] = tmp;
                 int numtmp = num[i];
                 num[i] = num[min];
                 num[min] = numtmp;
             }
             */
            int[] r = new int[4];
            int[] s = new int[4];
            //Создание объекта для генерации чисел
            Random rnd = new Random();

            //Получить случайное число (в диапазоне от 0 до 255)
            /*r[0] = 0;
            s[0] = 0;
            r[3] = 255;
            s[3] = 255;
            r[1] = rnd.Next(0, 255);
            r[2] = rnd.Next(r[1]+1, 255);
            s[1] = rnd.Next(0, 255);
            s[2] = rnd.Next(s[1]+1, 255);*/
            r[0] = 0;
            s[0] = 0;
            r[3] = 255;
            s[3] = 255;
            r[1] = r1;
            r[2] = r2;
            s[1] = s1;
            s[2] = s2;


            /*for (int i = 0; i < 3; i++) // Меняем яркость
            {
                double k = (s[i + 1] - s[i]) / (r[i + 1] - r[i]);
                int newR1 = r[i] * ((sourceImage.Width * sourceImage.Height )/ 255);
                int newR2 = r[i + 1] * ((sourceImage.Width * sourceImage.Height) / 255);
                for (int j = newR1; j < newR2; j++)
                {
                    if (k < 1) k = 1-k;
                    int inten = intensive[j];
                    intensive[j] = (int)(intensive[j] * k);
                    //if (intensive[j] == 0) intensive[j] = inten;
                    if (intensive[j] > 255) intensive[j] = 255;
                    if (intensive[j] < 0) intensive[j] = 0;
                }
            }
            for (int i = 0; i < (m); i++)
            {

                int min = i;
                for (int j = i + 1; j < (m+1); j++)
                    if (num[j] < num[min])
                    {
                        min = j;
                    }
                int tmp = num[i];
                num[i] = num[min];
                num[min] = tmp;
                int numtmp = intensive[i];
                intensive[i] = intensive[min];
                intensive[min] = numtmp;
            }

            m = 0;*/
            Color[,] resultcolor = new Color[sourceImage.Width, sourceImage.Height];
            Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            for (int i = 0; i < sourceImage.Height; i++)
            {
                for (int j = 0; j < sourceImage.Width; j++)
                {
                    int intensive = calculateIntensive(sourceImage, j, i);
                    for (int k = 0; k < 3; k++) // Меняем яркость
                    {
                        double koef = (s[k + 1] - s[k]) / (r[k + 1] - r[k]);
                        int newR1 = r[k];
                        int newR2 = r[k + 1];
                        if ((intensive >= newR1) & (intensive <= newR2))
                        {
                            intensive = (int)(intensive * k);
                            //if (intensive[j] == 0) intensive[j] = inten;
                            if (intensive > 255) intensive = 255;
                            if (intensive < 0) intensive = 0;
                        }
                    }

                    resultImage.SetPixel(j, i, Color.FromArgb(intensive, intensive, intensive));
                    //  resultcolor[i, j] = Color.FromArgb(intensive[m], intensive[m], intensive[m]);
                }
            }

            return resultImage;
        }
        /*  public override Bitmap processImage(Bitmap sourceImage, int r1, int r2, int s1, int s2)
          {

              int[] intensive = new int[sourceImage.Width * sourceImage.Height];
              int m = 0;
              for (int i = 0; i < sourceImage.Height; i++)
              {
                  for (int j = 0; j < sourceImage.Width; j++)
                  {
                      intensive[m] = calculateIntensive(sourceImage, j, i);
                      m++;
                  }
              }


              int[] r = new int[4];
              int[] s = new int[4];
              //Создание объекта для генерации чисел
              Random rnd = new Random();

              //Получить случайное число (в диапазоне от 0 до 255)
              /*r[0] = 0;
              s[0] = 0;
              r[3] = 255;
              s[3] = 255;
              r[1] = rnd.Next(0, 255);
              r[2] = rnd.Next(r[1]+1, 255);
              s[1] = rnd.Next(0, 255);
              s[2] = rnd.Next(s[1]+1, 255);*/
        /*   r[0] = 0;
           s[0] = 0;
           r[3] = 255;
           s[3] = 255;
           r[1] = 250;
           r[2] = 252;
           s[1] = 240;
           s[2] = 251;


           for (int i = 0; i < 3; i++) // Меняем яркость
           {
               double k = (s[i + 1] - s[i]) / (r[i + 1] - r[i]);
               int newR1 = r[i] * (sourceImage.Width * sourceImage.Height / 255);
               int newR2 = r[i + 1] * ((sourceImage.Width * sourceImage.Height) / 255);
               for (int j = newR1; j < newR2; j++)
               {
                   intensive[j] = (int)(intensive[j] * k);
                   if (intensive[j] > 255) intensive[j] = 255;
               }
           }
           m = 0;
           Color[,] resultcolor = new Color[sourceImage.Width, sourceImage.Height];
           Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
           for (int i = 0; i < sourceImage.Height; i++)
           {
               for (int j = 0; j < sourceImage.Width; j++)
               {
                   resultImage.SetPixel(j, i, Color.FromArgb(intensive[m], intensive[m], intensive[m]));
                   //  resultcolor[i, j] = Color.FromArgb(intensive[m], intensive[m], intensive[m]);
                   m++;
               }
           }

           return resultImage;
       }*/

    }
}
public class gys
{
    public int Clamp(int value, int min, int max)
    {
        if (value < min)
            return min;
        if (value > max)
            return max;
        return value;
    }
    public int getwidth(Bitmap sourceImage)
    {
        int width;
        return width = sourceImage.Width;
    }
    public int getheight(Bitmap sourceImage)
    {
        int height;
        return height = sourceImage.Height;
    }
    public static Bitmap equalizing(Bitmap Bmp)
    {
        Rectangle rect = new Rectangle(0, 0, Bmp.Width, Bmp.Height);
        System.Drawing.Imaging.BitmapData bmpData = Bmp.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite, Bmp.PixelFormat);
        IntPtr ptr = bmpData.Scan0;
        int bytes = bmpData.Stride * Bmp.Height;
        byte[] grayValues = new byte[bytes];
        int[] R = new int[256];
        byte[] N = new byte[256];
        byte[] left = new byte[256];
        byte[] right = new byte[256];
        System.Runtime.InteropServices.Marshal.Copy(ptr, grayValues, 0, bytes);
        for (int i = 0; i < grayValues.Length; i++) ++R[grayValues[i]];
        int z = 0;
        int Hint = 0;
        int Havg = grayValues.Length / R.Length;
        for (int i = 0; i < N.Length - 1; i++)
        {
            N[i] = 0;
        }
        for (int j = 0; j < R.Length; j++)
        {
            if (z > 255) left[j] = 255;
            else left[j] = (byte)z;
            Hint += R[j];
            while (Hint > Havg)
            {
                Hint -= Havg;
                z++;
            }
            if (z > 255) right[j] = 255;
            else right[j] = (byte)z;

            N[j] = (byte)((left[j] + right[j]) / 2);
        }
        for (int i = 0; i < grayValues.Length; i++)
        {
            if (left[grayValues[i]] == right[grayValues[i]]) grayValues[i] = left[grayValues[i]];
            else grayValues[i] = N[grayValues[i]];
        }

        System.Runtime.InteropServices.Marshal.Copy(grayValues, 0, ptr, bytes);
        Bmp.UnlockBits(bmpData);
        return Bmp;
    }
}




