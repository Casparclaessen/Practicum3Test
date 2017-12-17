using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			panel1.Paint += Panel1_Paint;
			
		}

	
		
		// summary 
		// Drawing the grid on the panel 
		// summary
		private void Panel1_Paint(object sender, PaintEventArgs e)
		{
			Pen blackPen = new Pen(Color.Black, 1);
			Rectangle rect = new Rectangle(0, 0, panel1.Width -1, panel1.Height -1);
			e.Graphics.DrawRectangle(blackPen, rect);

			// int PointY = panel1.Height / 6;

			for (int i = 1; i < 7; i++)
			{
				int GridWith = panel1.Width / 6;
				GridWith = GridWith * i;
				e.Graphics.DrawLine(blackPen, GridWith, 0, GridWith, panel1.Height);
		
		
			}
			for (int i = 0; i < 7; i++)
			{
				int GridHeight = panel1.Height / 6;
				GridHeight = GridHeight * i;
				e.Graphics.DrawLine(blackPen, 0, GridHeight, panel1.Width, GridHeight);
			}

			/* 
			 * 
			 * *******This is a Test rectangle, but we have to put it inside another class I think? 
			 
			//Testrectangle
			// Create solid brush.
			SolidBrush redBrush = new SolidBrush(Color.Blue);

			// Create rectangle for ellipse.
			int x = 202;
			int y = 202;
			int widthStone = 100;
			int heightStone = 100;
			Rectangle rect1 = new Rectangle(x, y, widthStone, heightStone);

			// Fill ellipse on screen.
			e.Graphics.FillEllipse(redBrush, rect1);

			*/
	


	}

		

		

	}
	class Steen
	{
		SolidBrush redBrush = new SolidBrush(Color.Blue);

		// Create rectangle for ellipse.
		int x = 202;
		int y = 202;
		int widthStone = 100;
		int heightStone = 100;
		Rectangle rect1 = new Rectangle(x, y, widthStone, heightStone);


		// Fill ellipse on screen.
		e.Graphics.FillEllipse(redBrush, rect1);
	}


}
