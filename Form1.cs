using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            int height = Convert.ToInt32(txtRows.Text);
            int width = Convert.ToInt32(txtColumn.Text);
            int rotation = Convert.ToInt32(txtRotation.Text);
            int k = 0;

            string[] allElement = txtAreaElements.Text.Split(' ');
            int[,] matrix = new int[height, width];

            
            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    matrix[row, col] = (int.Parse(allElement[k]));
                    k++;
                }
            }

            txtAreaInputMatrix.Text = DisplayMatrix(matrix);

            txtAreaOutputMatrix.Text = TransformMatrixNtimesCounterClock(matrix, rotation);
           
        }

        static string TransformMatrixNtimesCounterClock(int[,] matrix, int rotation)
        {
            string str = string.Empty;
            for (int rcount = 1; rcount <= rotation; rcount++)
            {
                AntiClockwiseMatrixTransform(matrix);
                if (rcount == rotation)
                    str =  DisplayMatrix(matrix);
            }
            return str;
        }

        static void AntiClockwiseMatrixTransform(int[,] matrix)
        {
            int maxRow = matrix.GetLength(0) - 1;
            int maxCol = matrix.GetLength(1) - 1;
            int row = 0;
            int col = 0;

            while (maxRow > row && col < maxCol)
            {

                int previous = matrix[maxRow - 1, col];
                //bottom row item change
                for (int i = col; i <= maxCol; i++)
                {
                    int current = matrix[maxRow, i];
                    matrix[maxRow, i] = previous;
                    previous = current;
                }
                maxRow--;

                //right most column item change
                for (int i = maxRow; i >= row; i--)
                {
                    int current = matrix[i, maxCol];
                    matrix[i, maxCol] = previous;
                    previous = current;
                }

                maxCol--;

                if (maxRow >= row)
                {
                    //top row item change
                    for (int i = maxCol; i >= col; i--)
                    {
                        int current = matrix[row, i];
                        matrix[row, i] = previous;
                        previous = current;
                    }

                    row++;
                }

                if (col < maxCol + 1)
                {
                    //left column item change
                    for (int i = row; i <= maxRow; i++)
                    {
                        int current = matrix[i, col];
                        matrix[i, col] = previous;
                        previous = current;
                    }

                    col++;
                }

            }
        }


        private static string DisplayMatrix(int[,] matrix)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sb.Append(matrix[i, j] + " ");
                }
                sb.Append('\n');
            }
            sb.Append('\n');
            return sb.ToString();
        }
    }
}
