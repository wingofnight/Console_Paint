using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{

    public class Image
    {
       public Pixel[,] image = new Pixel[50, 123];
       public int height;
       public int width;


        public Image() {

            ImageInicialize();
        }


        public Image(int height, int width ) 
        {
            this.height = height;
            this.width = width;
            image = new Pixel[height, width];
            ImageInicialize();
        }

        private void ImageInicialize()
        {
            for (int i = 0; i < 50; i++)
            {
                for (int j = 0; j < 123; j++)
                {
                    Pixel pixel = new Pixel();
                    image[i, j] = pixel;
                }
            }
        }

        public void BrushPixel(Cursor cursor, Pixel pixel)
        {
            image[cursor._y-1, cursor._x-7] = pixel;
            
        }

        public void UpdateImage() {
            
            int count = 0;
            int line = 1;
            Console.SetCursorPosition(7, line);
            foreach (var item in image)
            {
                count++;

                Console.ForegroundColor = item.FColor;
                Console.BackgroundColor = item.BColor;
                Console.Write(item.symbol);
                if (count >= 123)
                {
                    count = 0;
                    line++;
                    Console.SetCursorPosition(7, line);
                }
            }
            

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

        }

        public void SaveImage() { }

        public void LoadImage() { }
    }
}
