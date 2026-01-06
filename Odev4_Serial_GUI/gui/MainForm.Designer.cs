/*
 * Created by SharpDevelop.
 * User: emirh
 * Date: 13.12.2025
 * Time: 17:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MikroOdevV1
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btn_baglan = new System.Windows.Forms.Button();
			this.btn_kes = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.tbox_lcdyeyazdir = new System.Windows.Forms.TextBox();
			this.btn_lcdyazdir = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.btn_ledyak = new System.Windows.Forms.Button();
			this.tbox_ledyak = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.btn_zamangonder = new System.Windows.Forms.Button();
			this.tbox_zamanayarla = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.tbox_lcdzamani = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.tbox_btndurumu = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.tbox_gelenmetin = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.label18 = new System.Windows.Forms.Label();
			this.cbox_com = new System.Windows.Forms.ComboBox();
			this.cbox_brate = new System.Windows.Forms.ComboBox();
			this.cbox_Dbit = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.durum_kes = new System.Windows.Forms.Panel();
			this.durum_baglan = new System.Windows.Forms.Panel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tbox_adc = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label2.Location = new System.Drawing.Point(6, 19);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 19);
			this.label2.TabIndex = 2;
			this.label2.Text = "COM";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label3.Location = new System.Drawing.Point(6, 42);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 21);
			this.label3.TabIndex = 4;
			this.label3.Text = "BaudRate";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btn_baglan
			// 
			this.btn_baglan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_baglan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btn_baglan.Location = new System.Drawing.Point(187, 28);
			this.btn_baglan.Name = "btn_baglan";
			this.btn_baglan.Size = new System.Drawing.Size(102, 20);
			this.btn_baglan.TabIndex = 5;
			this.btn_baglan.Text = "BAĞLAN";
			this.btn_baglan.UseVisualStyleBackColor = true;
			this.btn_baglan.Click += new System.EventHandler(this.Btn_baglanClick);
			// 
			// btn_kes
			// 
			this.btn_kes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_kes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btn_kes.Location = new System.Drawing.Point(187, 54);
			this.btn_kes.Name = "btn_kes";
			this.btn_kes.Size = new System.Drawing.Size(102, 20);
			this.btn_kes.TabIndex = 6;
			this.btn_kes.Text = "KES";
			this.btn_kes.UseVisualStyleBackColor = true;
			this.btn_kes.Click += new System.EventHandler(this.Btn_kesClick);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(43, 15);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(117, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "LCD Ekranına Yazdır";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tbox_lcdyeyazdir
			// 
			this.tbox_lcdyeyazdir.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.tbox_lcdyeyazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.tbox_lcdyeyazdir.Location = new System.Drawing.Point(166, 18);
			this.tbox_lcdyeyazdir.Name = "tbox_lcdyeyazdir";
			this.tbox_lcdyeyazdir.Size = new System.Drawing.Size(105, 21);
			this.tbox_lcdyeyazdir.TabIndex = 9;
			this.tbox_lcdyeyazdir.Text = "#Metin";
			// 
			// btn_lcdyazdir
			// 
			this.btn_lcdyazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.btn_lcdyazdir.ForeColor = System.Drawing.Color.Black;
			this.btn_lcdyazdir.Location = new System.Drawing.Point(277, 18);
			this.btn_lcdyazdir.Name = "btn_lcdyazdir";
			this.btn_lcdyazdir.Size = new System.Drawing.Size(87, 20);
			this.btn_lcdyazdir.TabIndex = 10;
			this.btn_lcdyazdir.Text = "LCD Yazdır";
			this.btn_lcdyazdir.UseVisualStyleBackColor = true;
			this.btn_lcdyazdir.Click += new System.EventHandler(this.Btn_lcdyazdirClick);
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(11, 15);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(26, 23);
			this.label6.TabIndex = 11;
			this.label6.Text = "1.";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(12, 41);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(26, 23);
			this.label7.TabIndex = 15;
			this.label7.Text = "2.";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btn_ledyak
			// 
			this.btn_ledyak.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.btn_ledyak.ForeColor = System.Drawing.Color.Black;
			this.btn_ledyak.Location = new System.Drawing.Point(278, 44);
			this.btn_ledyak.Name = "btn_ledyak";
			this.btn_ledyak.Size = new System.Drawing.Size(87, 20);
			this.btn_ledyak.TabIndex = 14;
			this.btn_ledyak.Text = "LED Yak";
			this.btn_ledyak.UseVisualStyleBackColor = true;
			this.btn_ledyak.Click += new System.EventHandler(this.Btn_ledyakClick);
			// 
			// tbox_ledyak
			// 
			this.tbox_ledyak.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.tbox_ledyak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.tbox_ledyak.Location = new System.Drawing.Point(167, 44);
			this.tbox_ledyak.Name = "tbox_ledyak";
			this.tbox_ledyak.Size = new System.Drawing.Size(105, 21);
			this.tbox_ledyak.TabIndex = 13;
			this.tbox_ledyak.Text = "A&B";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(44, 41);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(117, 23);
			this.label8.TabIndex = 12;
			this.label8.Text = "LED Yak";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label9.ForeColor = System.Drawing.Color.Black;
			this.label9.Location = new System.Drawing.Point(12, 68);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(26, 23);
			this.label9.TabIndex = 19;
			this.label9.Text = "3.";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btn_zamangonder
			// 
			this.btn_zamangonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.btn_zamangonder.ForeColor = System.Drawing.Color.Black;
			this.btn_zamangonder.Location = new System.Drawing.Point(278, 71);
			this.btn_zamangonder.Name = "btn_zamangonder";
			this.btn_zamangonder.Size = new System.Drawing.Size(87, 20);
			this.btn_zamangonder.TabIndex = 18;
			this.btn_zamangonder.Text = "Zaman Gonder";
			this.btn_zamangonder.UseVisualStyleBackColor = true;
			this.btn_zamangonder.Click += new System.EventHandler(this.Btn_zamangonderClick);
			// 
			// tbox_zamanayarla
			// 
			this.tbox_zamanayarla.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.tbox_zamanayarla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.tbox_zamanayarla.Location = new System.Drawing.Point(167, 71);
			this.tbox_zamanayarla.Name = "tbox_zamanayarla";
			this.tbox_zamanayarla.Size = new System.Drawing.Size(105, 21);
			this.tbox_zamanayarla.TabIndex = 17;
			this.tbox_zamanayarla.Text = "11:58:51";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label10.ForeColor = System.Drawing.Color.Black;
			this.label10.Location = new System.Drawing.Point(44, 68);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(117, 23);
			this.label10.TabIndex = 16;
			this.label10.Text = "Zaman Ayarla";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label12.ForeColor = System.Drawing.Color.Black;
			this.label12.Location = new System.Drawing.Point(10, 18);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(26, 23);
			this.label12.TabIndex = 24;
			this.label12.Text = "1.";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tbox_lcdzamani
			// 
			this.tbox_lcdzamani.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.tbox_lcdzamani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.tbox_lcdzamani.Location = new System.Drawing.Point(165, 21);
			this.tbox_lcdzamani.Name = "tbox_lcdzamani";
			this.tbox_lcdzamani.Size = new System.Drawing.Size(199, 21);
			this.tbox_lcdzamani.TabIndex = 22;
			this.tbox_lcdzamani.Text = "11:58:51";
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label13.ForeColor = System.Drawing.Color.Black;
			this.label13.Location = new System.Drawing.Point(42, 18);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(117, 23);
			this.label13.TabIndex = 21;
			this.label13.Text = "LCD Ekran Saati";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label14.ForeColor = System.Drawing.Color.Black;
			this.label14.Location = new System.Drawing.Point(11, 44);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(26, 23);
			this.label14.TabIndex = 27;
			this.label14.Text = "2.";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tbox_btndurumu
			// 
			this.tbox_btndurumu.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.tbox_btndurumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.tbox_btndurumu.Location = new System.Drawing.Point(166, 47);
			this.tbox_btndurumu.Name = "tbox_btndurumu";
			this.tbox_btndurumu.Size = new System.Drawing.Size(198, 21);
			this.tbox_btndurumu.TabIndex = 26;
			this.tbox_btndurumu.Text = "Butona Basıldı";
			// 
			// label15
			// 
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label15.ForeColor = System.Drawing.Color.Black;
			this.label15.Location = new System.Drawing.Point(43, 44);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(117, 23);
			this.label15.TabIndex = 25;
			this.label15.Text = "Buton Durumu";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label16
			// 
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label16.ForeColor = System.Drawing.Color.Black;
			this.label16.Location = new System.Drawing.Point(11, 70);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(26, 23);
			this.label16.TabIndex = 30;
			this.label16.Text = "3.";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tbox_gelenmetin
			// 
			this.tbox_gelenmetin.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.tbox_gelenmetin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.tbox_gelenmetin.Location = new System.Drawing.Point(166, 73);
			this.tbox_gelenmetin.Name = "tbox_gelenmetin";
			this.tbox_gelenmetin.Size = new System.Drawing.Size(198, 21);
			this.tbox_gelenmetin.TabIndex = 29;
			this.tbox_gelenmetin.Text = "Metin Geldisi";
			// 
			// label17
			// 
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label17.ForeColor = System.Drawing.Color.Black;
			this.label17.Location = new System.Drawing.Point(43, 70);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(117, 23);
			this.label17.TabIndex = 28;
			this.label17.Text = "Gelen Metin";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// serialPort1
			// 
			this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1DataReceived);
			// 
			// label18
			// 
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label18.Location = new System.Drawing.Point(6, 69);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(72, 21);
			this.label18.TabIndex = 32;
			this.label18.Text = "DataBits";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cbox_com
			// 
			this.cbox_com.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.cbox_com.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cbox_com.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.cbox_com.FormattingEnabled = true;
			this.cbox_com.Location = new System.Drawing.Point(84, 17);
			this.cbox_com.Name = "cbox_com";
			this.cbox_com.Size = new System.Drawing.Size(86, 21);
			this.cbox_com.TabIndex = 33;
			this.cbox_com.Text = "COM3";
			// 
			// cbox_brate
			// 
			this.cbox_brate.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.cbox_brate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cbox_brate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.cbox_brate.FormattingEnabled = true;
			this.cbox_brate.Location = new System.Drawing.Point(84, 42);
			this.cbox_brate.Name = "cbox_brate";
			this.cbox_brate.Size = new System.Drawing.Size(86, 21);
			this.cbox_brate.TabIndex = 34;
			this.cbox_brate.Text = "9600";
			// 
			// cbox_Dbit
			// 
			this.cbox_Dbit.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.cbox_Dbit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cbox_Dbit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.cbox_Dbit.FormattingEnabled = true;
			this.cbox_Dbit.Location = new System.Drawing.Point(84, 69);
			this.cbox_Dbit.Name = "cbox_Dbit";
			this.cbox_Dbit.Size = new System.Drawing.Size(86, 21);
			this.cbox_Dbit.TabIndex = 35;
			this.cbox_Dbit.Text = "8";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.durum_kes);
			this.groupBox1.Controls.Add(this.durum_baglan);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.cbox_Dbit);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.cbox_brate);
			this.groupBox1.Controls.Add(this.btn_baglan);
			this.groupBox1.Controls.Add(this.cbox_com);
			this.groupBox1.Controls.Add(this.btn_kes);
			this.groupBox1.Controls.Add(this.label18);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
			this.groupBox1.Location = new System.Drawing.Point(13, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(374, 100);
			this.groupBox1.TabIndex = 36;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Bağlantı Ayarları";
			// 
			// durum_kes
			// 
			this.durum_kes.BackColor = System.Drawing.Color.Green;
			this.durum_kes.Location = new System.Drawing.Point(291, 60);
			this.durum_kes.Name = "durum_kes";
			this.durum_kes.Size = new System.Drawing.Size(11, 10);
			this.durum_kes.TabIndex = 37;
			// 
			// durum_baglan
			// 
			this.durum_baglan.BackColor = System.Drawing.Color.DarkRed;
			this.durum_baglan.Location = new System.Drawing.Point(291, 33);
			this.durum_baglan.Name = "durum_baglan";
			this.durum_baglan.Size = new System.Drawing.Size(11, 10);
			this.durum_baglan.TabIndex = 36;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.tbox_lcdyeyazdir);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.btn_lcdyazdir);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.tbox_ledyak);
			this.groupBox2.Controls.Add(this.btn_ledyak);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.tbox_zamanayarla);
			this.groupBox2.Controls.Add(this.btn_zamangonder);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox2.ForeColor = System.Drawing.Color.Maroon;
			this.groupBox2.Location = new System.Drawing.Point(13, 118);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(374, 99);
			this.groupBox2.TabIndex = 37;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Kontrol Paneli";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Controls.Add(this.tbox_adc);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.tbox_lcdzamani);
			this.groupBox3.Controls.Add(this.label13);
			this.groupBox3.Controls.Add(this.label12);
			this.groupBox3.Controls.Add(this.label16);
			this.groupBox3.Controls.Add(this.label15);
			this.groupBox3.Controls.Add(this.tbox_gelenmetin);
			this.groupBox3.Controls.Add(this.tbox_btndurumu);
			this.groupBox3.Controls.Add(this.label17);
			this.groupBox3.Controls.Add(this.label14);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox3.ForeColor = System.Drawing.Color.Maroon;
			this.groupBox3.Location = new System.Drawing.Point(13, 223);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(374, 132);
			this.groupBox3.TabIndex = 38;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Durum Monitörü";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(11, 97);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(26, 23);
			this.label1.TabIndex = 33;
			this.label1.Text = "4.";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tbox_adc
			// 
			this.tbox_adc.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.tbox_adc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.tbox_adc.Location = new System.Drawing.Point(166, 100);
			this.tbox_adc.Name = "tbox_adc";
			this.tbox_adc.Size = new System.Drawing.Size(198, 21);
			this.tbox_adc.TabIndex = 32;
			this.tbox_adc.Text = "ADC Geldisi";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(43, 97);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(117, 23);
			this.label4.TabIndex = 31;
			this.label4.Text = "Okunan ADC";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(403, 367);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Name = "MainForm";
			this.Text = "MikroOdevV1 Hazırlayan: Emirhan KOSAR";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbox_adc;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Panel durum_baglan;
		private System.Windows.Forms.Panel durum_kes;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox cbox_Dbit;
		private System.Windows.Forms.ComboBox cbox_brate;
		private System.Windows.Forms.ComboBox cbox_com;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label18;
		private System.IO.Ports.SerialPort serialPort1;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox tbox_gelenmetin;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox tbox_btndurumu;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox tbox_lcdzamani;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox tbox_zamanayarla;
		private System.Windows.Forms.Button btn_zamangonder;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox tbox_ledyak;
		private System.Windows.Forms.Button btn_ledyak;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btn_lcdyazdir;
		private System.Windows.Forms.TextBox tbox_lcdyeyazdir;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btn_kes;
		private System.Windows.Forms.Button btn_baglan;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
	}
}
