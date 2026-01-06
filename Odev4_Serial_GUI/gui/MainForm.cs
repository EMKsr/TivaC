/*
 * Created by SharpDevelop.
 * User: Emirhan KOŞAR
 * Date: 13.12.2025
 * Time: 17:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MikroOdevV1
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		string gelenveri = "";
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
		   
		    string[] portlar = System.IO.Ports.SerialPort.GetPortNames();
		
		    cbox_com.Items.Clear();
		
		    foreach (string port in portlar)
		    {
		        cbox_com.Items.Add(port);
		    }
		    
		    if(cbox_com.Items.Count > 0)
		    {
		        cbox_com.SelectedIndex = 0;
		    }
		    
		    cbox_brate.Items.Clear();
		    cbox_brate.Items.Add("9600");
		    cbox_brate.Items.Add("115200");
		    cbox_brate.Items.Add("57600");
		    cbox_brate.Items.Add("38400");
		    cbox_brate.Items.Add("19200");
		    cbox_brate.SelectedIndex = 0;
		    
		    cbox_Dbit.Items.Clear();
		    cbox_Dbit.Items.Add("8");
		    cbox_Dbit.Items.Add("7");
		    
		    cbox_Dbit.SelectedIndex = 0;
}
		
		void Btn_baglanClick(object sender, EventArgs e)
		{
			if(!serialPort1.IsOpen)
			{
				serialPort1.PortName=cbox_com.Text;
				serialPort1.BaudRate = Convert.ToInt32(cbox_brate.Text);
	    		serialPort1.DataBits = Convert.ToInt32(cbox_Dbit.Text);
	    		
	    		serialPort1.Open();
	    		
	    		durum_baglan.BackColor = Color.Green;
	    		durum_kes.BackColor = Color.Red;
			}
		}
		
		void Btn_kesClick(object sender, EventArgs e)
		{
			if(serialPort1.IsOpen)
			{
				// SerialPort1 kapama işlemi
				serialPort1.Close();
				
				// Renk Güncelleme
				durum_baglan.BackColor = Color.Red;
				durum_kes.BackColor = Color.Green;	
			}
		}
		
		void Btn_lcdyazdirClick(object sender, EventArgs e)
		{
			if(serialPort1.IsOpen)
			{
				// giden metni al
				string lcdye_giden_metin = tbox_lcdyeyazdir.Text;
				
				if (lcdye_giden_metin.StartsWith("#"))
		        {
		            // Başında # var, olduğu gibi gönder
		            serialPort1.Write(lcdye_giden_metin);
		        }
				else
				{
					MessageBox.Show("Hatalı Format! Başında'#' olmalıdır.");
				}
				
			}
			else
			{
				MessageBox.Show("Önce Bağlan butonuna basarak portu açmalısın!");
			}
		}
		
		void Btn_ledyakClick(object sender, EventArgs e)
		{
			if(serialPort1.IsOpen)
			{
				serialPort1.Write("*" + tbox_ledyak.Text);
			}
			else
			{
				MessageBox.Show("Port açık değil!");
			}
			
		}
		
		void Btn_zamangonderClick(object sender, EventArgs e)
		{
			if(serialPort1.IsOpen)
		    {
		        // Kutudaki saati al (Örn: 12:25:21)
		        string zaman = tbox_zamanayarla.Text;
		        
		        // Tiva C'ye gönderirken başına '&' ekliyoruz.
		        serialPort1.Write("&" + zaman);
		    }
		    else
		    {
		        MessageBox.Show("Port açık değil! Önce bağlanın.");
		    }
		}
		
		void SerialPort1DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
		{
		    try
		    {
		        // ReadExisting yerine ReadLine kullanıyoruz.
		        // Tiva'dan gelen "\n" karakterini görene kadar bekler ve tam paketi alır.
		        gelenveri = serialPort1.ReadLine(); 
		        
		        // Gelen verideki boşlukları ve gereksiz \r karakterlerini temizle
		        gelenveri = gelenveri.Trim();
		
		        // Arayüzü güncellemek için Thread aç
		        this.Invoke(new EventHandler(VeriyiArayuzeYaz));
		    }
		    catch (Exception)
		    {
		        // Port kapanırken hata verirse program patlamasın diye boş catch
		    }
		}
		void VeriyiArayuzeYaz(object sender, EventArgs e)
		{
		    // Boş veri geldiyse işlem yapma
		    if (string.IsNullOrEmpty(gelenveri)) return;
		
		    if (gelenveri.StartsWith("&")) // Zaman Verisi
		    {
		        // & işaretini atıp kutuya yaz
		        tbox_lcdzamani.Text = gelenveri.Substring(1);
		    }
		    else if (gelenveri.StartsWith("*")) // Buton Verisi
		    {
		        // * işaretini atıp kutuya yaz
		        tbox_btndurumu.Text = gelenveri.Substring(1);
		    }
		    else if (gelenveri.StartsWith("#")) // Gelen Metin (Eğer Tiva gönderiyorsa)
		    {
		        tbox_gelenmetin.Text = gelenveri.Substring(1);
		    }
		    
		    else if (gelenveri.StartsWith("$")) // ADC Verisi
		    {
		        // $ işaretini atıp adc kutusuna yaz
		        tbox_adc.Text = gelenveri.Substring(1);
		    }
		}
	}
}
