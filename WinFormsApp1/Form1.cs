using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; // OleDb k�t�phanesini ekledik
using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string dbFilePath = @"D:\C# FOR UN�TY\Personal takip\WinFormsApp1\WinFormsApp1\bin\Debug\personel.accdb"; // Veritaban� dosya yolu
        string provider = "Microsoft.ACE.OLEDB.12.0"; // Access veritaban� provider'�
        string connectionString;

        public Form1()
        {
            InitializeComponent();
            connectionString = $"Provider={provider};Data Source={dbFilePath};Persist Security Info=True";
        }

        // Formlar aras� kullan�lacak de�i�kenler
        public static string name, phone, email, address, postalZip, country;

        // Yerel de�i�kenler
        int hak = 3;
        bool durum = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Kullan�c� Giri�i...";
            this.AcceptButton = button1; this.CancelButton = button2;
            label5.Text = Convert.ToString(hak);
            radioButton1.Checked = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Label 3 t�kland���nda yap�lacak i�lemler
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Button 1 t�kland���nda yap�lacak i�lemler
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // Label 5 t�kland���nda yap�lacak i�lemler
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
