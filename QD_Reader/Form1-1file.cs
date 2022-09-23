using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
//using iTextSharp;
//using iTextSharp.text;
//using iTextSharp.text.pdf;

namespace QD_Reader
{
    public partial class Form1 : Form
    {
        string serverName = "";
        string dbName = "";
        string userName = "";
        string password = "";
        string connectionString = "";
        string currDir = "";
        private System.Drawing.Font printFontBarCode;
        private System.Drawing.Font printFontText;
        private StreamReader streamToPrint;
        private string stringToPrint;
        PrivateFontCollection fontCollection;
        string pdfName = "";
        string loggedInUser = "";
        bool isDataSaved = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadFile();
            txtDate.Enabled = false;
            txtDate.Text = Convert.ToString(DateTime.Now);
            //lblBarcode.Text = "";
            //lblFull.Text = "";
            this.Text = "Parcel Receiving";
            errorMsg.Text = "";
            awbText.TabIndex = 1;
            textCourier.TabIndex = 2;
            textStore.TabIndex = 3;
            textJob.TabIndex = 4;
            txtNote.TabIndex = 5;
            fontCollection = new PrivateFontCollection();
            //fontCollection.AddFontFile(currDir + @"\barcode_font.ttf");
            //lblBarcode.Font=fontCollection
            loadPrinterList();
            MemoryFonts.AddMemoryFont(Properties.Resources.ARIBL0);
            MemoryFonts.AddMemoryFont(Properties.Resources.barcode_font);
            txtDate.AutoSize = false;
            txtDate.Size = new System.Drawing.Size(192, 30);

            awbText.AutoSize = false;
            awbText.Size = new System.Drawing.Size(192, 30);

            textJob.AutoSize = false;
            textJob.Size = new System.Drawing.Size(205, 30);

            textStore.AutoSize = false;
            textStore.Size = new System.Drawing.Size(192, 30);

            textCourier.AutoSize = false;
            textCourier.Size = new System.Drawing.Size(192, 30);
            resetForm();
            loggedInUser = System.Security.Principal.WindowsIdentity.GetCurrent().Name;



        }

        private void chkBarcode_Click(object sender, EventArgs e)
        {
           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //lblBarcode.Text = "";
            //lblFull.Text = "";
            resetForm();
            
        }
        private void resetForm()
        {
            textJob.Text = "";
            textCourier.Text = "";
            awbText.Text = "";
            textStore.Text = "";
            txtNote.Text = "";
            errorMsg.Text = "";
            richTextBox1.Text = "";
            errorMsg.Text = "";

            awbErr.Text = "";
            storeErr.Text = "";
            noteErr.Text = "";
            courierErr.Text = "";
            jobErr.Text = "";
            printerErr.Text = "";
            awbText.Select();
            btnPrint.Text = "Save and Print";
            isDataSaved = false;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string[] job = new string[1];
            if(!validateForm())
            {
                return;
            }
            if (printerList.SelectedIndex == 0)
            {
                printerErr.Text = "Please select a printer to proceed";
                return;
            }
            job = richTextBox1.Text.Split('\n').ToArray();
            databaseLayer dbobj = new databaseLayer(connectionString);
            int k = 0;
            if (isDataSaved)
            {
                printPage(job, textStore.Text);
            }
            else 
            {
                string awbTextFormatted = awbText.Text;
                if (textCourier.Text.ToUpper()=="FEDEX" && awbText.Text.Length > 30)
                {
                    awbTextFormatted = awbText.Text.Substring(awbText.Text.Length - 12);
                }
                k = dbobj.saveDataToDB(awbTextFormatted, textCourier.Text, job, textStore.Text, txtNote.Text, loggedInUser);
                if (k == 0)
                {
                    LogWriter l = new LogWriter("k=0 "+ awbTextFormatted+" "+ textCourier.Text+" " + job[0] +" "+textStore.Text+" "+txtNote.Text+" "+ loggedInUser);
                    errorMsg.Text = "There is some error in saving data";
                    isDataSaved = false;
                }
                else
                {
                    errorMsg.Text = "Data saved successfully";
                    //MessageBox.Show("Data saved successfully");
                    //string barcodestring = createBarcodestring(job);
                    isDataSaved = true;
                    btnPrint.Text = "Print";
                    printPage(job, textStore.Text);
                    //resetForm();
                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs ev)
        {
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = 0;//ev.MarginBounds.Left;
            float topMargin = 0;//ev.MarginBounds.Top;
            string line = null;

            // Calculate the number of lines per page.
            linesPerPage = 2;//ev.MarginBounds.Height /printFontBarCode.GetHeight(ev.Graphics);

            // Print each line of the file.
            int i = 1;
            while (count < linesPerPage &&
                ((line = streamToPrint.ReadLine()) != null))
            {
                if (line.Contains("*"))
                {
                    yPos = topMargin + (count *
                       printFontBarCode.GetHeight(ev.Graphics));
                    ev.Graphics.DrawString(line, printFontBarCode, Brushes.Black,
                       leftMargin, yPos, new StringFormat());
                }
                else
                {
                    if (line != "")
                    {
                        yPos = topMargin + (count *
                          printFontText.GetHeight(ev.Graphics));
                        ev.Graphics.DrawString(line, printFontText, Brushes.Black,
                           leftMargin, yPos, new StringFormat());
                    }
                }
                
                count++;
            }

            // If more lines exist, print another page.
            if (line != null)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;
        }
        

        private void awbText_TextChanged(object sender, EventArgs e)
        {
            if(awbText.Text.Length==8 && awbText.Text.ToUpper().StartsWith("1Z"))
            {
                textCourier.Text = "UPS";
            }
            else if(Regex.IsMatch(awbText.Text, "^(0|[1-9][0-9]*)$") && (awbText.Text.Length==10 || awbText.Text.Length == 15 || awbText.Text.Length == 20 || awbText.Text.Length == 22))
            {
                textCourier.Text = "FedEx";
            }
            else
            {
                textCourier.Text = "";
            }
            if (awbText.Text.Trim().Length > 0)
            {
                awbErr.Text = "";
            }

        }
        private bool validateForm()
        {
            bool isValid = true;
            if (awbText.Text.Trim() == "")
            {
                awbErr.Text="Please enter AWB#";
                isValid = false;
                return isValid;
            }
            if (textCourier.Text.Trim() == "")
            {
                courierErr.Text = "Please enter Courier";
                isValid = false;
                return isValid;
            }
            if (textStore.Text.Trim() == "")
            {
                storeErr.Text = "Please enter Store number(4 char)";
                isValid = false;
                return isValid;
            }
            else if (textStore.Text.Trim().Length !=4)
            {
                storeErr.Text = "Store number should be of 4 charachters";
                isValid = false;
                return isValid;
            }
            /*else
            {
                while (textStore.Text.Length < 5)
                {
                    textStore.Text = "0" + textStore.Text;
                }
            }*/
            List<string> jobList = new List<string>();
            jobList = richTextBox1.Text.Split('\n').ToList();
            if (jobList.Count == 0)
            {
                errorMsg.Text = "Please enter atleast 1 Job number";
                isValid = false;
                return isValid;
            }
            /*if (textJob.Text.Trim() == "" || textJob.Text.Length < 4)
            {
                errorMsg.Text = "Please enter Job number and should be of minimum 4 charachter";
                isValid = false;
                return isValid;
            }*/
           
            return isValid;
        }
        
        private void printPage(string[] job,string store)
        {
            try
            {
                printFontBarCode = MemoryFonts.GetFont(
                               // using 0 since this is the first font in the collection
                               1,

                               // this is the size of the font
                               12,

                               // the font style if any. Bold / Italic / etc
                               FontStyle.Regular
                           );
                printFontText = MemoryFonts.GetFont(
                               // using 0 since this is the first font in the collection
                               0,

                               // this is the size of the font
                               30,

                               // the font style if any. Bold / Italic / etc
                               FontStyle.Regular
                           );
                string strToPrint = "";
                
                foreach (string s in job)
                {
                    if(s=="")
                    {
                        continue;
                    }
                    strToPrint = strToPrint + createPrintNumber(s, store) + "\n";
                    strToPrint = strToPrint + barCodeString(s, store) + "\n";
                }
                byte[] byteArray = Encoding.UTF8.GetBytes(strToPrint);
                //pdfPath = createPdf();
                MemoryStream stream1 = new MemoryStream(byteArray);
                stringToPrint = strToPrint;
                streamToPrint = new StreamReader(stream1);//(currDir + @"\page.txt");
                try
                {
                   
                    PrintDocument pd = new PrintDocument();
                    pd.PrinterSettings.PrinterName = printerList.SelectedItem.ToString();
                    pd.PrintPage += new PrintPageEventHandler
                       (this.printDocument1_PrintPage);
                    pd.Print();
                }
                finally
                {
                    streamToPrint.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textJob_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textJob_KeyDown(object sender, KeyEventArgs e)
        {
            if (textStore.Text.Trim() == "")
            {
                storeErr.Text = "Please enter Store number(4 char)";
                return;
            }
            else if (textStore.Text.Trim().Length != 4)
            {
                storeErr.Text = "Store number should be of 4 char";
                return;
            }
            if (e.KeyCode == Keys.Enter && textJob.Text.Trim().Length<4)
            {
                errorMsg.Text = "Please enter atleast 4 charachter in job code";
                return;
            }
            if (e.KeyCode == Keys.Enter)
            {
                richTextBox1.Text += textJob.Text + "\n";
                textJob.Text = "";
            }
        }
        private void loadPrinterList()
        {
            printerList.Items.Add("Select Printer");
            printerList.SelectedIndex = 0;
            foreach (String strPrinter in PrinterSettings.InstalledPrinters)
            {
                printerList.Items.Add(strPrinter);
            }
        }
        private void loadFile()
        {
            string codeBase = Assembly.GetExecutingAssembly().CodeBase;
            UriBuilder uri = new UriBuilder(codeBase);
            string path = Uri.UnescapeDataString(uri.Path);
            currDir = Path.GetDirectoryName(path);

            XmlDocument doc = new XmlDocument();
            doc.Load(currDir + @"\config.xml");
            string xmlcontents = doc.InnerXml;
            string docInner = doc.InnerText;
            connectionString = doc.ChildNodes[0].ChildNodes[0].InnerText.ToString();

        }
        private string createBarcodestring(string [] job)
        {
            string storeNo = textStore.Text.Substring(textStore.Text.Length - 4);
            string finalString = "";
            foreach(string s in job)
            {
                if (s == "")
                {
                    continue;
                }
                finalString+= storeNo+s.Substring(s.Length - 4);
                finalString += "\n\n\n";
            }
            return finalString;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void awbText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(textCourier.Text.Trim()=="")
                {
                    textCourier.Select();
                }
                else
                {
                    textStore.Select();
                }
            }
        }

        private void textCourier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                    textStore.Select();
            }
            if (textCourier.Text.Trim().Length > 0)
            {
                courierErr.Text = "";
            }
        }

        private void textStore_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textJob.Select();
            }
            if (textStore.Text.Trim().Length > 0)
            {
                storeErr.Text = "";
            }
        }

        private void toolStripBtnSetting_Click(object sender, EventArgs e)
        {
            settingFrm frm = new settingFrm(connectionString);
            frm.ShowDialog();
        }
        public string createPrintNumber(string jobNumber,string storeNum)
        {
            string s = "";
            s =  storeNum.Substring(storeNum.Length - 4) + jobNumber.Substring(jobNumber.Length - 4);
            return s;
        }
        public string  barCodeString(string jobNumber, string storeNum)
        {
            string s = "";
            s = "*0" + storeNum + jobNumber + "*";
            return s;
        }

        private void txtNote_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtNote.Text.Trim().Length > 0)
            {
                noteErr.Text = "";
            }
        }
    }
}
