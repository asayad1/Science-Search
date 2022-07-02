namespace FinalResearchAssistant
{
    partial class RetrieverForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RetrieverForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuSlider1 = new Bunifu.Framework.UI.BunifuSlider();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.arxivTrue = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.coreTrue = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label12 = new System.Windows.Forms.Label();
            this.historyYes = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.historyNo = new Bunifu.Framework.UI.BunifuCheckbox();
            this.searchButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.errorMessage = new System.Windows.Forms.Label();
            this.documentTimer = new System.Windows.Forms.Timer(this.components);
            this.mergedTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(18)))), ((int)(((byte)(13)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-17, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1285, 45);
            this.panel1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Science Search - Research Assistant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 35.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(226, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(830, 64);
            this.label2.TabIndex = 20;
            this.label2.Text = "Science Search Resource Retriever";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(357, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(541, 37);
            this.label6.TabIndex = 21;
            this.label6.Text = "Search For Scholarly Journals And Articles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans Light", 20F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(41, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 37);
            this.label3.TabIndex = 22;
            this.label3.Text = "Search Query:";
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Open Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(18)))), ((int)(((byte)(13)))));
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(18)))), ((int)(((byte)(13)))));
            this.bunifuMaterialTextbox1.LineThickness = 6;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(243, 222);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(75, 64, 75, 64);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(843, 51);
            this.bunifuMaterialTextbox1.TabIndex = 27;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuSlider1
            // 
            this.bunifuSlider1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSlider1.BackgroudColor = System.Drawing.Color.DarkGray;
            this.bunifuSlider1.BorderRadius = 0;
            this.bunifuSlider1.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(18)))), ((int)(((byte)(13)))));
            this.bunifuSlider1.Location = new System.Drawing.Point(315, 333);
            this.bunifuSlider1.MaximumValue = 10;
            this.bunifuSlider1.Name = "bunifuSlider1";
            this.bunifuSlider1.Size = new System.Drawing.Size(411, 30);
            this.bunifuSlider1.TabIndex = 28;
            this.bunifuSlider1.Value = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans Light", 20F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(41, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 37);
            this.label4.TabIndex = 29;
            this.label4.Text = "Number of Results:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans Light", 20F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(308, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 37);
            this.label5.TabIndex = 30;
            this.label5.Text = "5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans Light", 20F);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(689, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 37);
            this.label7.TabIndex = 31;
            this.label7.Text = "15";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(783, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 37);
            this.label8.TabIndex = 32;
            this.label8.Text = "Current Value:";
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Font = new System.Drawing.Font("Open Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.valueLabel.Location = new System.Drawing.Point(978, 328);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(47, 37);
            this.valueLabel.TabIndex = 33;
            this.valueLabel.Text = "15";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Open Sans Light", 20F);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(41, 453);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 37);
            this.label9.TabIndex = 34;
            this.label9.Text = "Databases:";
            // 
            // arxivTrue
            // 
            this.arxivTrue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(18)))), ((int)(((byte)(13)))));
            this.arxivTrue.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.arxivTrue.Checked = true;
            this.arxivTrue.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(18)))), ((int)(((byte)(13)))));
            this.arxivTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.arxivTrue.ForeColor = System.Drawing.Color.White;
            this.arxivTrue.Location = new System.Drawing.Point(482, 470);
            this.arxivTrue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.arxivTrue.Name = "arxivTrue";
            this.arxivTrue.Size = new System.Drawing.Size(20, 20);
            this.arxivTrue.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Open Sans", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(387, 461);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 37);
            this.label10.TabIndex = 36;
            this.label10.Text = "arXiv";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(290, 443);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(696, 443);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(91, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Open Sans", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(800, 461);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 37);
            this.label11.TabIndex = 39;
            this.label11.Text = "CORE";
            // 
            // coreTrue
            // 
            this.coreTrue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(18)))), ((int)(((byte)(13)))));
            this.coreTrue.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.coreTrue.Checked = true;
            this.coreTrue.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(18)))), ((int)(((byte)(13)))));
            this.coreTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.coreTrue.ForeColor = System.Drawing.Color.White;
            this.coreTrue.Location = new System.Drawing.Point(888, 470);
            this.coreTrue.Margin = new System.Windows.Forms.Padding(4);
            this.coreTrue.Name = "coreTrue";
            this.coreTrue.Size = new System.Drawing.Size(20, 20);
            this.coreTrue.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Open Sans Light", 20F);
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(41, 558);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(209, 37);
            this.label12.TabIndex = 41;
            this.label12.Text = "Save To History:";
            // 
            // historyYes
            // 
            this.historyYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(18)))), ((int)(((byte)(13)))));
            this.historyYes.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.historyYes.Checked = true;
            this.historyYes.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(18)))), ((int)(((byte)(13)))));
            this.historyYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F);
            this.historyYes.ForeColor = System.Drawing.Color.White;
            this.historyYes.Location = new System.Drawing.Point(363, 571);
            this.historyYes.Margin = new System.Windows.Forms.Padding(39, 35, 39, 35);
            this.historyYes.Name = "historyYes";
            this.historyYes.Size = new System.Drawing.Size(20, 20);
            this.historyYes.TabIndex = 42;
            this.historyYes.OnChange += new System.EventHandler(this.historyYes_OnChange);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Open Sans SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(283, 558);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 37);
            this.label13.TabIndex = 43;
            this.label13.Text = "Yes";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Open Sans SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Location = new System.Drawing.Point(475, 558);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 37);
            this.label14.TabIndex = 45;
            this.label14.Text = "No";
            // 
            // historyNo
            // 
            this.historyNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(18)))), ((int)(((byte)(13)))));
            this.historyNo.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.historyNo.Checked = true;
            this.historyNo.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(18)))), ((int)(((byte)(13)))));
            this.historyNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F);
            this.historyNo.ForeColor = System.Drawing.Color.White;
            this.historyNo.Location = new System.Drawing.Point(555, 571);
            this.historyNo.Margin = new System.Windows.Forms.Padding(39, 35, 39, 35);
            this.historyNo.Name = "historyNo";
            this.historyNo.Size = new System.Drawing.Size(20, 20);
            this.historyNo.TabIndex = 44;
            this.historyNo.OnChange += new System.EventHandler(this.historyNo_OnChange);
            // 
            // searchButton
            // 
            this.searchButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(18)))), ((int)(((byte)(13)))));
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(18)))), ((int)(((byte)(13)))));
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchButton.BorderRadius = 0;
            this.searchButton.ButtonText = "Search!";
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.DisabledColor = System.Drawing.Color.Gray;
            this.searchButton.Iconcolor = System.Drawing.Color.Transparent;
            this.searchButton.Iconimage = null;
            this.searchButton.Iconimage_right = null;
            this.searchButton.Iconimage_right_Selected = null;
            this.searchButton.Iconimage_Selected = null;
            this.searchButton.IconMarginLeft = 0;
            this.searchButton.IconMarginRight = 0;
            this.searchButton.IconRightVisible = true;
            this.searchButton.IconRightZoom = 0D;
            this.searchButton.IconVisible = true;
            this.searchButton.IconZoom = 90D;
            this.searchButton.IsTab = false;
            this.searchButton.Location = new System.Drawing.Point(485, 635);
            this.searchButton.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.searchButton.Name = "searchButton";
            this.searchButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(18)))), ((int)(((byte)(13)))));
            this.searchButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(48)))), ((int)(((byte)(43)))));
            this.searchButton.OnHoverTextColor = System.Drawing.Color.White;
            this.searchButton.selected = true;
            this.searchButton.Size = new System.Drawing.Size(251, 56);
            this.searchButton.TabIndex = 46;
            this.searchButton.Text = "Search!";
            this.searchButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.searchButton.Textcolor = System.Drawing.Color.White;
            this.searchButton.TextFont = new System.Drawing.Font("Open Sans", 15F);
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(18)))), ((int)(((byte)(13)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(18)))), ((int)(((byte)(13)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Return";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(1087, 635);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(18)))), ((int)(((byte)(13)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(48)))), ((int)(((byte)(43)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = true;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(146, 56);
            this.bunifuFlatButton1.TabIndex = 47;
            this.bunifuFlatButton1.Text = "Return";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Open Sans", 15F);
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.Font = new System.Drawing.Font("Open Sans", 15F);
            this.errorMessage.ForeColor = System.Drawing.Color.Maroon;
            this.errorMessage.Location = new System.Drawing.Point(980, 461);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(0, 27);
            this.errorMessage.TabIndex = 48;
            // 
            // documentTimer
            // 
            this.documentTimer.Interval = 500;
            this.documentTimer.Tick += new System.EventHandler(this.documentTimer_Tick);
            // 
            // mergedTimer
            // 
            this.mergedTimer.Interval = 500;
            this.mergedTimer.Tick += new System.EventHandler(this.mergedTimer_Tick);
            // 
            // RetrieverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1250, 720);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.historyNo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.historyYes);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.coreTrue);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.arxivTrue);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bunifuSlider1);
            this.Controls.Add(this.bunifuMaterialTextbox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RetrieverForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RetrieverForm";
            this.Shown += new System.EventHandler(this.RetrieverForm_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private Bunifu.Framework.UI.BunifuSlider bunifuSlider1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuCheckbox arxivTrue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuCheckbox coreTrue;
        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuCheckbox historyYes;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private Bunifu.Framework.UI.BunifuCheckbox historyNo;
        private Bunifu.Framework.UI.BunifuFlatButton searchButton;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Label errorMessage;
        private System.Windows.Forms.Timer documentTimer;
        private System.Windows.Forms.Timer mergedTimer;
    }
}