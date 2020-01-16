using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDemo
{
	public partial class Form1 : Form
	{
		string basicNimi = "Anna elokuvan nimi";
		int kesto;
		public Form1()
		{
			InitializeComponent();
			textBoxID.ReadOnly = true;
		}
		
		private void infoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Sovelluksen on thnyt opettaja");
		}

		private void buttonUusiTietue_Click(object sender, EventArgs e)
		{
			textBoxNimi.Text = basicNimi;
			textBoxJulkaisuvuosi.Text = DateTime.Today.ToString();
		}

		private void poistuToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void textBoxNimi_MouseClick(object sender, EventArgs e)
		{
			textBoxNimi.Text = "";
		}

		private void textBoxJulkaisuvuosi_MouseClick(object sender, EventArgs e)
		{
			textBoxJulkaisuvuosi.Text = DateTime.Today.ToString();
		}

		private void textBoxKesto_MouseClick(object sender, EventArgs e)
		{
			textBoxKesto.Text = "";
		}

		private void richTextBoxArvio_MouseClick(object sender, EventArgs e)
		{
			richTextBoxArvio.Text = "";
		}

		private void textBoxNimi_MouseLeave(object sender, EventArgs e)
		{
			if(string.IsNullOrWhiteSpace(textBoxNimi.Text))
			{
				textBoxNimi.Text = basicNimi;
			}
		}
		
		// Onko tekstiä syötetty ollenkaan(eli onko kenttä tyhjä)
		// Onko tekstin muoto oikea numerokentissä(kesto ja julkaisuvuosi saa sisältää vain numeroita)
		private void buttonTallenna_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBoxNimi.Text))
			{
				MessageBox.Show("Anna nimi elokuvalle");
			}
			if (string.IsNullOrWhiteSpace(textBoxJulkaisuvuosi.Text))
			{
				MessageBox.Show("Anna julkaisuvuosi elokuvalle");
				DateTime numero;
				if (DateTime.TryParse(textBoxJulkaisuvuosi.Text, out numero))
				{

				}
				else
				{
					MessageBox.Show("Anna oikeanlainen datime");		
				}
			}
			if (string.IsNullOrWhiteSpace(textBoxKesto.Text))
			{
				MessageBox.Show("Anna elokuvan kesto");
				int tempKesto;
				if (Int32.TryParse(textBoxKesto.Text, out tempKesto)) 
				{
					
				}
				else
				{
					MessageBox.Show("Anna integer tyyppinen luku");
				}
			}

			else
			{
				MessageBox.Show("Olet voittaja");
			}
		}

		private void textBoxKesto_MouseLeave(object sender, EventArgs e)
		{
			textBoxKesto.Text = "";
			//kesto = Convert.ToInt32(textBoxKesto.Text);
		}
	}
}

