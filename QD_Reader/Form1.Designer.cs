namespace QD_Reader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.textJob = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textStore = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textCourier = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.awbText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.errorMsg = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.printerList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblhead = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnSetting = new System.Windows.Forms.ToolStripButton();
            this.awbErr = new System.Windows.Forms.Label();
            this.courierErr = new System.Windows.Forms.Label();
            this.storeErr = new System.Windows.Forms.Label();
            this.noteErr = new System.Windows.Forms.Label();
            this.printerErr = new System.Windows.Forms.Label();
            this.jobErr = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(106, 96);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(192, 23);
            this.txtDate.TabIndex = 2;
            // 
            // textJob
            // 
            this.textJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textJob.Location = new System.Drawing.Point(301, 96);
            this.textJob.Name = "textJob";
            this.textJob.Size = new System.Drawing.Size(205, 23);
            this.textJob.TabIndex = 4;
            this.textJob.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textJob_KeyDown);
            this.textJob.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textJob_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "JOB#";
            // 
            // textStore
            // 
            this.textStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textStore.Location = new System.Drawing.Point(106, 256);
            this.textStore.Name = "textStore";
            this.textStore.Size = new System.Drawing.Size(192, 23);
            this.textStore.TabIndex = 6;
            this.textStore.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textStore_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Store#";
            // 
            // textCourier
            // 
            this.textCourier.AutoCompleteCustomSource.AddRange(new string[] {
            "DHL",
            "UPS",
            "FedEx",
            "Others"});
            this.textCourier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textCourier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCourier.Location = new System.Drawing.Point(106, 196);
            this.textCourier.Name = "textCourier";
            this.textCourier.Size = new System.Drawing.Size(192, 23);
            this.textCourier.TabIndex = 8;
            this.textCourier.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textCourier_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Courier";
            // 
            // awbText
            // 
            this.awbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.awbText.Location = new System.Drawing.Point(106, 132);
            this.awbText.Name = "awbText";
            this.awbText.Size = new System.Drawing.Size(192, 23);
            this.awbText.TabIndex = 10;
            this.awbText.TextChanged += new System.EventHandler(this.awbText_TextChanged);
            this.awbText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.awbText_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "AWB#";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(378, 387);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(128, 59);
            this.btnPrint.TabIndex = 13;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(106, 315);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(192, 53);
            this.txtNote.TabIndex = 17;
            this.txtNote.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNote_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Note";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(378, 452);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(128, 59);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // errorMsg
            // 
            this.errorMsg.AutoSize = true;
            this.errorMsg.ForeColor = System.Drawing.Color.Red;
            this.errorMsg.Location = new System.Drawing.Point(400, 30);
            this.errorMsg.Name = "errorMsg";
            this.errorMsg.Size = new System.Drawing.Size(35, 13);
            this.errorMsg.TabIndex = 19;
            this.errorMsg.Text = "label1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(301, 125);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(205, 256);
            this.richTextBox1.TabIndex = 20;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // printerList
            // 
            this.printerList.FormattingEnabled = true;
            this.printerList.Location = new System.Drawing.Point(106, 409);
            this.printerList.Name = "printerList";
            this.printerList.Size = new System.Drawing.Size(192, 21);
            this.printerList.TabIndex = 21;
            this.printerList.SelectedIndexChanged += new System.EventHandler(this.printerList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Select Printer";
            // 
            // lblhead
            // 
            this.lblhead.AutoSize = true;
            this.lblhead.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhead.Location = new System.Drawing.Point(19, 19);
            this.lblhead.Name = "lblhead";
            this.lblhead.Size = new System.Drawing.Size(152, 24);
            this.lblhead.TabIndex = 23;
            this.lblhead.Text = "Parcel Receiving";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnSetting});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(546, 93);
            this.toolStrip1.TabIndex = 24;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Visible = false;
            // 
            // toolStripBtnSetting
            // 
            this.toolStripBtnSetting.AutoSize = false;
            this.toolStripBtnSetting.AutoToolTip = false;
            this.toolStripBtnSetting.Image = global::QD_Reader.Properties.Resources.report;
            this.toolStripBtnSetting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSetting.Name = "toolStripBtnSetting";
            this.toolStripBtnSetting.Size = new System.Drawing.Size(80, 90);
            this.toolStripBtnSetting.Text = "Reports";
            this.toolStripBtnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBtnSetting.Click += new System.EventHandler(this.toolStripBtnSetting_Click);
            // 
            // awbErr
            // 
            this.awbErr.AutoSize = true;
            this.awbErr.ForeColor = System.Drawing.Color.Red;
            this.awbErr.Location = new System.Drawing.Point(105, 161);
            this.awbErr.Name = "awbErr";
            this.awbErr.Size = new System.Drawing.Size(35, 13);
            this.awbErr.TabIndex = 25;
            this.awbErr.Text = "label1";
            // 
            // courierErr
            // 
            this.courierErr.AutoSize = true;
            this.courierErr.ForeColor = System.Drawing.Color.Red;
            this.courierErr.Location = new System.Drawing.Point(103, 224);
            this.courierErr.Name = "courierErr";
            this.courierErr.Size = new System.Drawing.Size(35, 13);
            this.courierErr.TabIndex = 26;
            this.courierErr.Text = "label1";
            // 
            // storeErr
            // 
            this.storeErr.AutoSize = true;
            this.storeErr.ForeColor = System.Drawing.Color.Red;
            this.storeErr.Location = new System.Drawing.Point(103, 285);
            this.storeErr.Name = "storeErr";
            this.storeErr.Size = new System.Drawing.Size(35, 13);
            this.storeErr.TabIndex = 27;
            this.storeErr.Text = "label1";
            // 
            // noteErr
            // 
            this.noteErr.AutoSize = true;
            this.noteErr.ForeColor = System.Drawing.Color.Red;
            this.noteErr.Location = new System.Drawing.Point(110, 373);
            this.noteErr.Name = "noteErr";
            this.noteErr.Size = new System.Drawing.Size(35, 13);
            this.noteErr.TabIndex = 28;
            this.noteErr.Text = "label1";
            // 
            // printerErr
            // 
            this.printerErr.AutoSize = true;
            this.printerErr.ForeColor = System.Drawing.Color.Red;
            this.printerErr.Location = new System.Drawing.Point(110, 442);
            this.printerErr.Name = "printerErr";
            this.printerErr.Size = new System.Drawing.Size(35, 13);
            this.printerErr.TabIndex = 29;
            this.printerErr.Text = "label1";
            // 
            // jobErr
            // 
            this.jobErr.AutoSize = true;
            this.jobErr.ForeColor = System.Drawing.Color.Red;
            this.jobErr.Location = new System.Drawing.Point(341, 80);
            this.jobErr.Name = "jobErr";
            this.jobErr.Size = new System.Drawing.Size(35, 13);
            this.jobErr.TabIndex = 30;
            this.jobErr.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(546, 606);
            this.Controls.Add(this.jobErr);
            this.Controls.Add(this.printerErr);
            this.Controls.Add(this.noteErr);
            this.Controls.Add(this.storeErr);
            this.Controls.Add(this.courierErr);
            this.Controls.Add(this.awbErr);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblhead);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.printerList);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.errorMsg);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.awbText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textCourier);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textStore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textJob);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox textJob;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textStore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textCourier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox awbText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnReset;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label errorMsg;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox printerList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblhead;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripBtnSetting;
        private System.Windows.Forms.Label awbErr;
        private System.Windows.Forms.Label courierErr;
        private System.Windows.Forms.Label storeErr;
        private System.Windows.Forms.Label noteErr;
        private System.Windows.Forms.Label printerErr;
        private System.Windows.Forms.Label jobErr;
    }
}

