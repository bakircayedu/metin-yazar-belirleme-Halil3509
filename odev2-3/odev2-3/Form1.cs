using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace odev2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Metin metin = new Metin();

        public String filePath = String.Empty;
        String fileExt = string.Empty;
        OpenFileDialog openFileDialog = new OpenFileDialog();
        private void btnMetinYukle_Click(object sender, EventArgs e)
        {

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Dosya İsmini alma
                filePath = openFileDialog.FileName;

                txtDosyaYolu.Text = filePath.ToString();

            }
        }

        private void btnStackOku_Click(object sender, EventArgs e)
        {
            //Dosya uzantısını alma
            fileExt = Path.GetExtension(filePath);
            if (fileExt.CompareTo(".txt") == 0)
            {
                try
                {
                    String[] kelimeler;
                    StreamReader reader = new StreamReader(filePath);
                    StringBuilder builder = new StringBuilder();
                    string line = "";

                    

                    while ((line = reader.ReadLine()) != null)
                    {
                        kelimeler = line.Split(' ');
                        Cumle cumle = new Cumle();
                        foreach (string kelime in kelimeler)
                        {
                            Kelime kelimeTemp = new Kelime { OrjinalKisim = kelime };
                            cumle.Push(kelimeTemp);
                        }
                        metin.add(cumle); 
                    }
                    //Metni önişlnemiş hale getirme
                    OnIslemeYap(metin);

                    reader.Close();
                    rtbDosyaOzellikleri.Text = "Cümle Sayısı:" + metin.Length() + "\n";
                    for(int i = 0; i < metin.Length(); i++)
                    {
                        rtbDosyaOzellikleri.Text = "Cümle " + i + " Kelime Sayısı:" + metin.cumleler[i].Peek();
                    } 

                }
                catch (Exception er)
                {
                    throw new Exception("Hata:" + er.Message);
                }
            }
        }
        private void YalinYapma(Kelime kelime)
        {
            String orijinal = kelime.OrjinalKisim;
            int son = orijinal.Length - 1;
            int index = 0;
            foreach (char harf in orijinal)
            {
                if (char.IsPunctuation(harf))
                {
                    son = index;
                }
                index++;
            }
            String yalin = "";
            if (son != orijinal.Length - 1)
            {
                yalin = orijinal.Substring(0, son).ToLower();
            }
            else
            {
                yalin = orijinal.ToLower();
            }
            kelime.OnIslenmisHali = yalin;
        }

        private void SiklikBulma(Metin metin, Kelime kelime) 
        {
            //Her kelimeyi teker teker ön işlenmiş hale getirerek sıkliğini bulma
            int count = 0;
            for(int i = 0; i < metin.Length(); i++)
            {
                for(int j = 0; j < metin.cumleler[i].Length(); i++)
                {
                    if(metin.cumleler[i].GetElement(j) == kelime.OnIslenmisHali)
                    {
                        count++;
                    }
                }
            }
            kelime.KullanimSikligi = count;
        }
        private void OnIslemeYap(Metin metin)
        {
            for (int i = 0; i < metin.Length(); i++)
            {
                for (int j = 0; j < metin.cumleler[i].Length(); i++)
                {
                    Kelime kelime = metin.cumleler[i].GetElementKelime(j);
                    YalinYapma(kelime);
                    SiklikBulma(metin,kelime);
                }
            }
        }

        private void btnAgacaAktar_Click(object sender, EventArgs e)
        {
          for(int i = 0; i < metin.Length(); i++)
            {
                HeapProcesses heapTree = new HeapProcesses(metin.cumleler[i].Length()+1);
                for(int j = 0; j < metin.cumleler[i].Length(); i++)
                {
                    heapTree.Insert(metin.cumleler[i].GetElementKelime(j));
                }
            } 
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Hash yapma işlemi
            HashTableProcesses hashTableProcesses = new HashTableProcesses(100,10000);
            for(int i = 0;i< metin.Length(); i++)
            {
                for(int j = 0; j < metin.cumleler[i].Length(); j++)
                {
                    hashTableProcesses.Add(metin.cumleler[i].GetElement(j));
                }
            }
            
        }

        private void btnEnSikKelime_Click(object sender, EventArgs e)
        {
          
            int adet = Convert.ToInt32(txtKelimeAdet.Text);
            List<Kelime> butunKelimeler = new List<Kelime>();
            for (int i = 0; i < metin.Length(); i++)
            {
                for (int j = 0; j < metin.cumleler[i].Length(); j++)
                {
                    butunKelimeler.Add(metin.cumleler[i].GetElementKelime(j));
                }
            }
            HeapProcesses heapIslem = new HeapProcesses(butunKelimeler.Count);
            Kelime[] butunKelimelerArray = butunKelimeler.ToArray();
            MessageBox.Show(heapIslem.Sort(butunKelimelerArray, adet));
            
        }
    }

   
}
