using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using ExcelDataReader;
using Excel = Microsoft.Office.Interop.Excel;
using System.Net.Mail;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace Excell_Deneme_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private Ogrenci_Nesnesi Ogrenci = new Ogrenci_Nesnesi();
        string filePath_Input = "";
        string filePath_Outputs = "";

        public void Mail_Gonder(String yol, String Sender_Mail, String pass, String Receiver_Mail)
        {
            try
            {
                MailMessage ePosta = new MailMessage();
                ePosta.From = new MailAddress(Sender_Mail);
                ePosta.To.Add("musamilli@gmail.com");

                ePosta.Attachments.Add(new Attachment(yol));
                ePosta.Subject = "Dönem Notları";
                ePosta.Body = "Selam sana mesaj var";

                SmtpClient smtp = new SmtpClient();
                smtp.Credentials = new System.Net.NetworkCredential(Sender_Mail, pass);
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                //smtp.SendAsync(ePosta, (object)ePosta);
                smtp.Send(ePosta);
            }
            catch (SmtpException ex)
            {
                string msg = "Mail cannot be sent:";
                msg += ex.Message + yol;
                throw new Exception(msg);
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            file.Filter = "Excel Dosyası |*.xls|Excel Dosyası |*.xlsx|txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (file.ShowDialog() == DialogResult.OK)
            {
                txtDosya.Text = file.FileName;
            }

            //Dosyanın okunacağı dizin
            filePath_Input = file.FileName;
            filePath_Outputs = file.InitialDirectory;
            txtOutputsPath.Text = file.InitialDirectory;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();

            dialog.InitialDirectory = "C:\\Users";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                filePath_Outputs = dialog.FileName;
                txtOutputsPath.Text = dialog.FileName;
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            String Excel_Dosya_Yol = "";
            string str;
            int satir = 0;
            int sutun = 0;
            bool bayrak = false;
            int satirY = 1;
            int sayac = 0;
            String log = "";
            String sender_email = "";
            String sender_password = "";
            String[] tempDizi;

            if (txtSenderMail.Text == "" && txtSenderPassword.Text == "")
            {
                MessageBox.Show("Gönderici Mail ve Şifre bilgilerini girin!!");
            }

            sender_email = txtSenderMail.Text;
            sender_password = txtSenderPassword.Text;

            //Yeni oluşturulacak excel dosyasının değişkenleri.
            Excel.Application xlOrn = new Microsoft.Office.Interop.Excel.Application();

            if (xlOrn == null)
            {
                MessageBox.Show("Excel yüklü değil!!");
                return;
            }

            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlWorkBook = xlOrn.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);


            //Eski excel dosyasının değişkenleri
            Excel.Application xlUygulama;//uygulama değişkeni tanımlandı
            Excel.Workbook xlKitap;//kitap değişkeni tanımlandı
            Excel.Worksheet xlSayfa;//sayfa değişkeni tanımlandı
            Excel.Range range;//aralık değişkeni tanımlandı



            xlUygulama = new Excel.Application();//excelin bir örneği oluşturuldu

            //belirtilen yoldaki excel dosyası açıldı ve ilk sayfası okunmaya başlandı
            xlKitap = xlUygulama.Workbooks.Open(filePath_Input, 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            xlSayfa = (Excel.Worksheet)xlKitap.Worksheets.get_Item(1);

            //okunan sayfadaki son bölümün index değeri alındı.
            //satır ve sütun olacak şekilde iki boyutlu bir yapı üzerinde hareket edilecektir.
            range = xlSayfa.UsedRange;//alınacak aralık belirtilmediği için sayfa içindeki tüm alanları alacaktır.


            //satır ve sütunlar üzerinde dönerek ekrana okuduğumuz bilgileri yazdırıyoruz.
            for (satir = 1; satir <= range.Rows.Count; satir++)
            {
                for (sutun = 1; sutun <= range.Columns.Count; sutun++)
                {
                    str = (string)(range.Cells[satir, sutun] as Excel.Range).Value2;

                    if (str == "KISIM ")
                    {
                        Ogrenci.setOgrenci_Sinif((string)(range.Cells[satir, sutun + 3] as Excel.Range).Value2);
                    }

                    if (str == "ÖĞRENCİ NO")
                    {
                        Ogrenci.setOgrenci_No((string)(range.Cells[satir, sutun + 3] as Excel.Range).Value2);
                    }

                    if (str == "ADI SOYADI")
                    {
                        Ogrenci.setOgrenci_isim((string)(range.Cells[satir, sutun + 3] as Excel.Range).Value2);
                        sayac++;
                        tempDizi = Ogrenci.getOgrenci_isim().Split(' ');
                        Ogrenci.setOgrenci_Email(tempDizi[tempDizi.Length - 1].Remove(1, tempDizi[tempDizi.Length - 1].Length-1)+Ogrenci.getOgrenci_No()+"@dho.edu.tr");
                        log = sayac.ToString() + ")  " + Ogrenci.getOgrenci_No() + "  numaralı  " + Ogrenci.getOgrenci_isim() + "\nişlemleri yapılıyor.... \n\n" + Ogrenci.getOgrenci_Email() + "  adresine mail gönderiliyor...";
                        RtxtIcerik.Text = log;
                    }

                    if (str == "ÖĞRENCİ KARNESİ")
                    {

                        if (bayrak)
                        {
                            Excel_Dosya_Yol = filePath_Outputs + "\\" + Ogrenci.getOgrenci_No() + ".xls";
                            xlWorkBook.SaveAs(Excel_Dosya_Yol, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                            xlWorkBook.Close(true, misValue, misValue);
                            Mail_Gonder(Excel_Dosya_Yol, txtSenderMail.Text, txtSenderPassword.Text, Ogrenci.getOgrenci_Email());
                            sutun = 1;
                            satirY = 1;
                            bayrak = !bayrak;
                            xlWorkBook = xlOrn.Workbooks.Add(misValue);
                            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                            continue;
                        }
                        bayrak = !bayrak;
                    }
                    xlWorkSheet.Cells[satirY, sutun] = str;
                }
                satirY++;
            }

            //********************************************************
            //Burada File stream i memory stream e çverimek gerekecek.


            //***********************************************************


            Excel_Dosya_Yol = filePath_Outputs + "\\" + Ogrenci.getOgrenci_No() + ".xls";
            xlWorkBook.SaveAs(Excel_Dosya_Yol, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlOrn.Quit();

            xlKitap.Close(true, null, null);
            xlUygulama.Quit();

            Mail_Gonder(Excel_Dosya_Yol, txtSenderMail.Text, txtSenderPassword.Text, Ogrenci.getOgrenci_Email());




            /*Ram üzeründen de excelin bağlantısını kaldırıyoruz.*/
            /*try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlUygulama);
                xlUygulama = null;
            }
            catch (Exception ex)
            {
                xlUygulama = null;
                MessageBox.Show("Hata " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }*/
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
