using System;
namespace Programs
{
    class Max2DimensionArray
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Moi nhap so hang = ");

            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Moi nhap so cot = ");
            int colum = Convert.ToInt32(Console.ReadLine());
            int[,] Matran = new int[row, colum];
            for (int i = 0; i < row; i++)// nhap thong tin 
            {
                for (int j = 0; j < colum; j++)
                {
                    Console.WriteLine("Nhap gia tri cua phan tu [{0}, {1}]:", i, j);
                    Matran[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            /// Tim max va toa do cua no
            int max = Matran[0, 0];
            int maxRow = 0, maxCol = 0;
            // khai bao bien 
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < colum; j++)
                {
                    if (Matran[i, j] > max)// thực hiện so sánh với tọa độ(i,j) với Matran tọa đọ i=0,j=0
                    {
                        max = Matran[i, j];// nếu lớn hơn thì cho bằng với biến max
                        maxRow = i;// gán vào vị trí hàng
                        maxCol = j;// gán vào vị trí cột
                    }
                }
            }

            Console.WriteLine("Phan tu lon nhat cua ma tran la {0} o toa do [{1}, {2}].", max, maxRow, maxCol);
              //Console.WriteLine("Phan tu lon nhat cua ma tran la " + max + " o toa do [" + maxRow + ", " + maxCol + "].");
        }

    }
    }



