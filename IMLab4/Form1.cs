//60*10 60*10
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMLab4
{
	public partial class Form1 : Form
	{
		private readonly Brush white = new SolidBrush(Color.White);
		private readonly Brush black = new SolidBrush(Color.Black);
		//	bool[] rule = new bool[8];
		bool[,] prev = new bool[60,60];
		int x = 0, y = 0, k=0, a1, a2;
		bool[,] next = new bool[60, 60];
		int neighbors=0;
		Random rnd = new Random();

		private Graphics gr;

		private void timer1_Tick(object sender, EventArgs e)
		{
			x = 0;
			y = 0;
			for (int i = 1; i < 59; i++)
			{
				for (int j = 1; j < 59; j++)
				{
					neighbors = 0;
					if (prev[i-1,j]) neighbors++;
					if (prev[i, j-1]) neighbors++;
					if (prev[i + 1, j]) neighbors++;
					if (prev[i, j+1]) neighbors++;

					if (prev[i,j])
					{
						if (neighbors < 2)
							next[i,j] = false;
						if ((neighbors == 2) || (neighbors == 3))
							next[i, j] = true;
						else
							next[i,j] = false;
					}else
					{
						if (neighbors == 3)
						{
							next[i, j] = true;
						}
						else next[i, j] = false;
					}
				}

			}


			k = rnd.Next(100, 500);
			for (int i = 0; i < k; i++)
			{
				a1 = rnd.Next(0, 59);
				a2 = rnd.Next(0, 59);
				if (!next[a1, a2])
				{
					next[a1, a2] = true;

				}
				else
				{
					next[a1, a2] = false;
				}

			}
			for (int i = 0; i < 60; i++)
			{
				for (int j = 0; j < 60; j++)
				{
					if (next[i, j])
					{
						gr.FillRectangle(black, x, y, 10, 10);
					}
					else
					{
						gr.FillRectangle(white, x, y, 10, 10);
					}
					x += 10;
				}
				x = 0;
				y += 10;
			}

			for (int i = 0; i < 60; i++)
			{
				for (int j = 0; j < 60; j++)
				{
					prev[i, j] = next[i, j];
					next[i, j] = false;
				}
			}



		}

		public Form1()
		{
			InitializeComponent();
			gr = panel1.CreateGraphics();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			for (int i=0; i < 60;  i++)
			{
				for (int j=0; j < 60; j++)
				{
					prev[i,j] = false;
					next[i,j] = false;
				}
			}
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (!timer1.Enabled)
			{
				k = (int)nCells.Value;
				int z = 0;
				while (z < k)
				{
					a1 = rnd.Next(0, 59);
					a2 = rnd.Next(0, 59);
					if (!prev[a1, a2])
					{
						prev[a1, a2] = true;
						z++;
					}
				}
				for (int i = 0; i < 60; i++)
				{
					for (int j = 0; j < 60; j++)
					{
						if (prev[i,j])
						{
							gr.FillRectangle(black, x, y, 10, 10);
						}
						else
						{
							gr.FillRectangle(white, x, y, 10, 10);
						}
						x += 10;
					}
					x = 0;
					y += 10;
				}
				
				
				timer1.Start();
			}
				
			else
			{
				timer1.Stop();
			}

		}
	}
}
