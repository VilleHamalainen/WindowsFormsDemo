namespace WindowsFormsDemo
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.labelID = new System.Windows.Forms.Label();
			this.labelNimi = new System.Windows.Forms.Label();
			this.labelJulkaisuvuosi = new System.Windows.Forms.Label();
			this.labelKesto = new System.Windows.Forms.Label();
			this.buttonUusiTietue = new System.Windows.Forms.Button();
			this.buttonTallenna = new System.Windows.Forms.Button();
			this.buttonPoista = new System.Windows.Forms.Button();
			this.textBoxID = new System.Windows.Forms.TextBox();
			this.textBoxNimi = new System.Windows.Forms.TextBox();
			this.textBoxJulkaisuvuosi = new System.Windows.Forms.TextBox();
			this.textBoxKesto = new System.Windows.Forms.TextBox();
			this.buttonEdellinen = new System.Windows.Forms.Button();
			this.buttonSeuraava = new System.Windows.Forms.Button();
			this.richTextBoxArvio = new System.Windows.Forms.RichTextBox();
			this.menuStripTiedosto = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.poistuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tietojaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.progressBarPerus = new System.Windows.Forms.ProgressBar();
			this.numericUpDownArvio = new System.Windows.Forms.NumericUpDown();
			this.menuStripTiedosto.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownArvio)).BeginInit();
			this.SuspendLayout();
			// 
			// labelID
			// 
			this.labelID.AutoSize = true;
			this.labelID.Location = new System.Drawing.Point(35, 45);
			this.labelID.Name = "labelID";
			this.labelID.Size = new System.Drawing.Size(16, 13);
			this.labelID.TabIndex = 0;
			this.labelID.Text = "Id";
			// 
			// labelNimi
			// 
			this.labelNimi.AutoSize = true;
			this.labelNimi.Location = new System.Drawing.Point(35, 80);
			this.labelNimi.Name = "labelNimi";
			this.labelNimi.Size = new System.Drawing.Size(27, 13);
			this.labelNimi.TabIndex = 1;
			this.labelNimi.Text = "Nimi";
			// 
			// labelJulkaisuvuosi
			// 
			this.labelJulkaisuvuosi.AutoSize = true;
			this.labelJulkaisuvuosi.Location = new System.Drawing.Point(35, 117);
			this.labelJulkaisuvuosi.Name = "labelJulkaisuvuosi";
			this.labelJulkaisuvuosi.Size = new System.Drawing.Size(70, 13);
			this.labelJulkaisuvuosi.TabIndex = 2;
			this.labelJulkaisuvuosi.Text = "Julkaisuvuosi";
			// 
			// labelKesto
			// 
			this.labelKesto.AutoSize = true;
			this.labelKesto.Location = new System.Drawing.Point(35, 152);
			this.labelKesto.Name = "labelKesto";
			this.labelKesto.Size = new System.Drawing.Size(59, 13);
			this.labelKesto.TabIndex = 3;
			this.labelKesto.Text = "Kesto (min)";
			// 
			// buttonUusiTietue
			// 
			this.buttonUusiTietue.Location = new System.Drawing.Point(530, 45);
			this.buttonUusiTietue.Name = "buttonUusiTietue";
			this.buttonUusiTietue.Size = new System.Drawing.Size(180, 40);
			this.buttonUusiTietue.TabIndex = 4;
			this.buttonUusiTietue.Text = "Uusi tietue";
			this.buttonUusiTietue.UseVisualStyleBackColor = true;
			this.buttonUusiTietue.Click += new System.EventHandler(this.buttonUusiTietue_Click);
			// 
			// buttonTallenna
			// 
			this.buttonTallenna.Location = new System.Drawing.Point(530, 107);
			this.buttonTallenna.Name = "buttonTallenna";
			this.buttonTallenna.Size = new System.Drawing.Size(180, 40);
			this.buttonTallenna.TabIndex = 5;
			this.buttonTallenna.Text = "Tallenna";
			this.buttonTallenna.UseVisualStyleBackColor = true;
			this.buttonTallenna.Click += new System.EventHandler(this.buttonTallenna_Click);
			// 
			// buttonPoista
			// 
			this.buttonPoista.Location = new System.Drawing.Point(530, 167);
			this.buttonPoista.Name = "buttonPoista";
			this.buttonPoista.Size = new System.Drawing.Size(180, 40);
			this.buttonPoista.TabIndex = 6;
			this.buttonPoista.Text = "Poista";
			this.buttonPoista.UseVisualStyleBackColor = true;
			// 
			// textBoxID
			// 
			this.textBoxID.Location = new System.Drawing.Point(207, 45);
			this.textBoxID.Name = "textBoxID";
			this.textBoxID.Size = new System.Drawing.Size(100, 20);
			this.textBoxID.TabIndex = 7;
			// 
			// textBoxNimi
			// 
			this.textBoxNimi.Location = new System.Drawing.Point(207, 80);
			this.textBoxNimi.Name = "textBoxNimi";
			this.textBoxNimi.Size = new System.Drawing.Size(100, 20);
			this.textBoxNimi.TabIndex = 8;
			this.textBoxNimi.MouseEnter += new System.EventHandler(this.textBoxNimi_MouseClick);
			this.textBoxNimi.MouseLeave += new System.EventHandler(this.textBoxNimi_MouseLeave);
			// 
			// textBoxJulkaisuvuosi
			// 
			this.textBoxJulkaisuvuosi.Location = new System.Drawing.Point(207, 117);
			this.textBoxJulkaisuvuosi.Name = "textBoxJulkaisuvuosi";
			this.textBoxJulkaisuvuosi.Size = new System.Drawing.Size(100, 20);
			this.textBoxJulkaisuvuosi.TabIndex = 9;
			this.textBoxJulkaisuvuosi.MouseEnter += new System.EventHandler(this.textBoxJulkaisuvuosi_MouseClick);
			// 
			// textBoxKesto
			// 
			this.textBoxKesto.Location = new System.Drawing.Point(207, 152);
			this.textBoxKesto.Name = "textBoxKesto";
			this.textBoxKesto.Size = new System.Drawing.Size(100, 20);
			this.textBoxKesto.TabIndex = 10;
			this.textBoxKesto.MouseEnter += new System.EventHandler(this.textBoxKesto_MouseClick);
			this.textBoxKesto.MouseLeave += new System.EventHandler(this.textBoxKesto_MouseLeave);
			// 
			// buttonEdellinen
			// 
			this.buttonEdellinen.Location = new System.Drawing.Point(62, 257);
			this.buttonEdellinen.Name = "buttonEdellinen";
			this.buttonEdellinen.Size = new System.Drawing.Size(122, 33);
			this.buttonEdellinen.TabIndex = 11;
			this.buttonEdellinen.Text = "Edellinen";
			this.buttonEdellinen.UseVisualStyleBackColor = true;
			// 
			// buttonSeuraava
			// 
			this.buttonSeuraava.Location = new System.Drawing.Point(219, 256);
			this.buttonSeuraava.Name = "buttonSeuraava";
			this.buttonSeuraava.Size = new System.Drawing.Size(110, 34);
			this.buttonSeuraava.TabIndex = 12;
			this.buttonSeuraava.Text = "Seuraava";
			this.buttonSeuraava.UseVisualStyleBackColor = true;
			// 
			// richTextBoxArvio
			// 
			this.richTextBoxArvio.Location = new System.Drawing.Point(38, 314);
			this.richTextBoxArvio.Name = "richTextBoxArvio";
			this.richTextBoxArvio.Size = new System.Drawing.Size(320, 96);
			this.richTextBoxArvio.TabIndex = 13;
			this.richTextBoxArvio.Text = "Arvio tähän";
			this.richTextBoxArvio.MouseEnter += new System.EventHandler(this.richTextBoxArvio_MouseClick);
			// 
			// menuStripTiedosto
			// 
			this.menuStripTiedosto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.tietojaToolStripMenuItem});
			this.menuStripTiedosto.Location = new System.Drawing.Point(0, 0);
			this.menuStripTiedosto.Name = "menuStripTiedosto";
			this.menuStripTiedosto.Size = new System.Drawing.Size(800, 24);
			this.menuStripTiedosto.TabIndex = 14;
			this.menuStripTiedosto.Text = "menuStrip1";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poistuToolStripMenuItem});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(64, 20);
			this.toolStripMenuItem1.Text = "Tiedosto";
			// 
			// poistuToolStripMenuItem
			// 
			this.poistuToolStripMenuItem.Name = "poistuToolStripMenuItem";
			this.poistuToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.poistuToolStripMenuItem.Text = "Poistu";
			this.poistuToolStripMenuItem.Click += new System.EventHandler(this.poistuToolStripMenuItem_Click);
			// 
			// tietojaToolStripMenuItem
			// 
			this.tietojaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
			this.tietojaToolStripMenuItem.Name = "tietojaToolStripMenuItem";
			this.tietojaToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
			this.tietojaToolStripMenuItem.Text = "Tietoja";
			// 
			// infoToolStripMenuItem
			// 
			this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
			this.infoToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
			this.infoToolStripMenuItem.Text = "Info";
			this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
			// 
			// progressBarPerus
			// 
			this.progressBarPerus.Location = new System.Drawing.Point(495, 347);
			this.progressBarPerus.Name = "progressBarPerus";
			this.progressBarPerus.Size = new System.Drawing.Size(100, 23);
			this.progressBarPerus.TabIndex = 15;
			// 
			// numericUpDownArvio
			// 
			this.numericUpDownArvio.DecimalPlaces = 1;
			this.numericUpDownArvio.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
			this.numericUpDownArvio.Location = new System.Drawing.Point(41, 416);
			this.numericUpDownArvio.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDownArvio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDownArvio.Name = "numericUpDownArvio";
			this.numericUpDownArvio.Size = new System.Drawing.Size(64, 20);
			this.numericUpDownArvio.TabIndex = 16;
			this.numericUpDownArvio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.numericUpDownArvio);
			this.Controls.Add(this.progressBarPerus);
			this.Controls.Add(this.richTextBoxArvio);
			this.Controls.Add(this.buttonSeuraava);
			this.Controls.Add(this.buttonEdellinen);
			this.Controls.Add(this.textBoxKesto);
			this.Controls.Add(this.textBoxJulkaisuvuosi);
			this.Controls.Add(this.textBoxNimi);
			this.Controls.Add(this.textBoxID);
			this.Controls.Add(this.buttonPoista);
			this.Controls.Add(this.buttonTallenna);
			this.Controls.Add(this.buttonUusiTietue);
			this.Controls.Add(this.labelKesto);
			this.Controls.Add(this.labelJulkaisuvuosi);
			this.Controls.Add(this.labelNimi);
			this.Controls.Add(this.labelID);
			this.Controls.Add(this.menuStripTiedosto);
			this.MainMenuStrip = this.menuStripTiedosto;
			this.Name = "Form1";
			this.Text = "Form1";
			this.menuStripTiedosto.ResumeLayout(false);
			this.menuStripTiedosto.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownArvio)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelID;
		private System.Windows.Forms.Label labelNimi;
		private System.Windows.Forms.Label labelJulkaisuvuosi;
		private System.Windows.Forms.Label labelKesto;
		private System.Windows.Forms.Button buttonUusiTietue;
		private System.Windows.Forms.Button buttonTallenna;
		private System.Windows.Forms.Button buttonPoista;
		private System.Windows.Forms.TextBox textBoxID;
		private System.Windows.Forms.TextBox textBoxNimi;
		private System.Windows.Forms.TextBox textBoxJulkaisuvuosi;
		private System.Windows.Forms.TextBox textBoxKesto;
		private System.Windows.Forms.Button buttonEdellinen;
		private System.Windows.Forms.Button buttonSeuraava;
		private System.Windows.Forms.RichTextBox richTextBoxArvio;
		private System.Windows.Forms.MenuStrip menuStripTiedosto;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem poistuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tietojaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
		private System.Windows.Forms.ProgressBar progressBarPerus;
		private System.Windows.Forms.NumericUpDown numericUpDownArvio;
	}
}

