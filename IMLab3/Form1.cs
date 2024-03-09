// 111 110 101 100 011 010 001 000
//	1	1	2	2	1	1	2	2
//	0	1	2	3	4	5	6	7
namespace IMLab3
{

	public partial class Form1 : Form {

		private readonly Brush white = new SolidBrush(Color.White);
		private readonly Brush black = new SolidBrush(Color.Black);

		bool[] rule = new bool[8];
		bool[] prev = new bool[10];
	int x = 0, y = 0;
	bool[] next = new bool[10];

	private Graphics gr;
	public Form1()
	{
		InitializeComponent();
		gr = panel1.CreateGraphics();
	}

	private void numericUpDown1_ValueChanged(object sender, EventArgs e)
	{

	}

	private void label1_Click(object sender, EventArgs e)
	{

	}

	private void button1_Click(object sender, EventArgs e)
	{
		int r = (int)rulee.Value;
		int k = 128;

		for (int i = 7; i >= 0; i--)
		{
			if (r >= k)
			{
				rule[i] = true;
				r -= k;
			}
			else
			{
				rule[i] = false;
			}

			k = k / 2;

		}

		for (int i = 1; i < 9; i++)
		{
			if (prev[i])
			{
				if (prev[i - 1])
				{
					if (prev[i + 1]) //111
					{
						next[i] = rule[0];
					}
					else /// 110
					{
						next[i] = rule[1];
					}
				}
				else
				{
					if (prev[i + 1]) //101
					{
						next[i] = rule[2];
					}
					else /// 100
					{
						next[i] = rule[3];
					}
				}
			}
			else
			{
				if (prev[i - 1])
				{
					if (prev[i + 1]) //011
					{
						next[i] = rule[4];
					}
					else /// 010
					{
						next[i] = rule[5];
					}
				}
				else
				{
					if (prev[i + 1]) //001
					{
						next[i] = rule[6];
					}
					else /// 000
					{
						next[i] = rule[7];
					}
				}
			}
		}
		next[0] = next[8];
		next[9] = next[1];

		for (int i = 1; i < 9; i++)
		{
			if (next[i])
			{
				gr.FillRectangle(black, x, y, 30, 30);
			}
			else 
			{ 
				gr.FillRectangle(white, x, y, 30, 30);
			}
			x += 30;
		}
			x = 0;
			y += 30;
		for (int i=0; i<10; i++)
			{
				prev[i] = next[i];
				next[i] = false;
			}
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{

	}

	private void Form1_Load(object sender, EventArgs e)
	{
		for (int i = 0; i < 10; i++)
		{ prev[i] = false; }
			prev[4]=true;
			prev[5]=true;
			prev[7] = true;
	}
}
}
