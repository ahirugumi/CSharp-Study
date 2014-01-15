using System;
using System.Drawing;
using System.Windows.Forms;

namespace kinmokuseimonoform
{
	public class MonoForm : Form
	{
		private TextBox textBox = new TextBox();
		private Button button = new Button();
		private Label label = new Label();

		public MonoForm ()
		{
			this.Load += new EventHandler(FormLoad);
		}

		public static void Main()
		{
			Application.Run(new MonoForm());
		}

		public void FormLoad(object sender , EventArgs e)
		{
			textBox.Name = "textbox";
			textBox.Location = new Point(10 , 20);
			textBox.Size = new Size(300 , 20);
			this.Controls.Add(textBox);

			button.Location = new Point(310 , 20);
			button.Text = "OK";
			this.Controls.Add(button);
			button.Click += new EventHandler(ButtonClick);

			label.Location = new Point(10 , 50);
			label.Size = new Size(300 , 20);
			this.Controls.Add(label);

			this.Size = new Size(400 , 100);
		}

		private void ButtonClick(object sender , EventArgs e)
		{
			this.label.Text = this.textBox.Text;
		}
	}
}

