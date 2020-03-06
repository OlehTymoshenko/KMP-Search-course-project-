namespace Course_proj_KMP_serch
{
    partial class Interface_prog
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interface_prog));
            this.groupBoxSetParams = new System.Windows.Forms.GroupBox();
            this.richTextBoxText = new System.Windows.Forms.RichTextBox();
            this.labelTextInput = new System.Windows.Forms.Label();
            this.labelSubStrInput = new System.Windows.Forms.Label();
            this.textBoxSubsrting = new System.Windows.Forms.TextBox();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.labelResultStr = new System.Windows.Forms.Label();
            this.labelResultPosition = new System.Windows.Forms.Label();
            this.labelStaticInStr = new System.Windows.Forms.Label();
            this.labelStaticInPosition = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonSearch = new System.Windows.Forms.Button();
            this.BGW = new System.ComponentModel.BackgroundWorker();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.buttonReadFromFIle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.buttonSaveInFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.buttonUndo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.buttonRedo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.buttonHelp = new System.Windows.Forms.ToolStripButton();
            this.groupBoxSetParams.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSetParams
            // 
            this.groupBoxSetParams.Controls.Add(this.richTextBoxText);
            this.groupBoxSetParams.Controls.Add(this.labelTextInput);
            this.groupBoxSetParams.Controls.Add(this.labelSubStrInput);
            this.groupBoxSetParams.Controls.Add(this.textBoxSubsrting);
            this.groupBoxSetParams.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxSetParams.ForeColor = System.Drawing.Color.Aquamarine;
            this.groupBoxSetParams.Location = new System.Drawing.Point(19, 42);
            this.groupBoxSetParams.Name = "groupBoxSetParams";
            this.groupBoxSetParams.Size = new System.Drawing.Size(636, 247);
            this.groupBoxSetParams.TabIndex = 1;
            this.groupBoxSetParams.TabStop = false;
            this.groupBoxSetParams.Text = "Настройка параметров";
            // 
            // richTextBoxText
            // 
            this.richTextBoxText.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.richTextBoxText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.richTextBoxText.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxText.Location = new System.Drawing.Point(76, 23);
            this.richTextBoxText.Name = "richTextBoxText";
            this.richTextBoxText.Size = new System.Drawing.Size(536, 176);
            this.richTextBoxText.TabIndex = 6;
            this.richTextBoxText.Text = "";
            this.richTextBoxText.WordWrap = false;
            this.richTextBoxText.TextChanged += new System.EventHandler(this.TextContainers_TextChanged);
            this.richTextBoxText.DoubleClick += new System.EventHandler(this.richTextBoxText_DoubleClick);
            // 
            // labelTextInput
            // 
            this.labelTextInput.AutoSize = true;
            this.labelTextInput.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextInput.ForeColor = System.Drawing.Color.Transparent;
            this.labelTextInput.Location = new System.Drawing.Point(8, 106);
            this.labelTextInput.Name = "labelTextInput";
            this.labelTextInput.Size = new System.Drawing.Size(44, 19);
            this.labelTextInput.TabIndex = 3;
            this.labelTextInput.Text = "Текст";
            // 
            // labelSubStrInput
            // 
            this.labelSubStrInput.AutoSize = true;
            this.labelSubStrInput.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSubStrInput.ForeColor = System.Drawing.Color.Transparent;
            this.labelSubStrInput.Location = new System.Drawing.Point(5, 206);
            this.labelSubStrInput.Name = "labelSubStrInput";
            this.labelSubStrInput.Size = new System.Drawing.Size(69, 19);
            this.labelSubStrInput.TabIndex = 2;
            this.labelSubStrInput.Text = "Образец";
            // 
            // textBoxSubsrting
            // 
            this.textBoxSubsrting.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxSubsrting.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSubsrting.Location = new System.Drawing.Point(76, 204);
            this.textBoxSubsrting.Name = "textBoxSubsrting";
            this.textBoxSubsrting.Size = new System.Drawing.Size(536, 23);
            this.textBoxSubsrting.TabIndex = 1;
            this.textBoxSubsrting.TextChanged += new System.EventHandler(this.TextContainers_TextChanged);
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.labelResultStr);
            this.groupBoxResult.Controls.Add(this.labelResultPosition);
            this.groupBoxResult.Controls.Add(this.labelStaticInStr);
            this.groupBoxResult.Controls.Add(this.labelStaticInPosition);
            this.groupBoxResult.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxResult.ForeColor = System.Drawing.Color.Aquamarine;
            this.groupBoxResult.Location = new System.Drawing.Point(19, 289);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(574, 67);
            this.groupBoxResult.TabIndex = 2;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Результат поиска";
            // 
            // labelResultStr
            // 
            this.labelResultStr.AutoSize = true;
            this.labelResultStr.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResultStr.ForeColor = System.Drawing.Color.Transparent;
            this.labelResultStr.Location = new System.Drawing.Point(119, 42);
            this.labelResultStr.Name = "labelResultStr";
            this.labelResultStr.Size = new System.Drawing.Size(0, 15);
            this.labelResultStr.TabIndex = 4;
            // 
            // labelResultPosition
            // 
            this.labelResultPosition.AutoSize = true;
            this.labelResultPosition.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResultPosition.ForeColor = System.Drawing.Color.Transparent;
            this.labelResultPosition.Location = new System.Drawing.Point(119, 23);
            this.labelResultPosition.Name = "labelResultPosition";
            this.labelResultPosition.Size = new System.Drawing.Size(0, 15);
            this.labelResultPosition.TabIndex = 3;
            // 
            // labelStaticInStr
            // 
            this.labelStaticInStr.AutoSize = true;
            this.labelStaticInStr.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStaticInStr.ForeColor = System.Drawing.Color.Transparent;
            this.labelStaticInStr.Location = new System.Drawing.Point(11, 42);
            this.labelStaticInStr.Name = "labelStaticInStr";
            this.labelStaticInStr.Size = new System.Drawing.Size(104, 15);
            this.labelStaticInStr.TabIndex = 2;
            this.labelStaticInStr.Text = "Найден в строке: ";
            // 
            // labelStaticInPosition
            // 
            this.labelStaticInPosition.AutoSize = true;
            this.labelStaticInPosition.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStaticInPosition.ForeColor = System.Drawing.Color.Transparent;
            this.labelStaticInPosition.Location = new System.Drawing.Point(11, 23);
            this.labelStaticInPosition.Name = "labelStaticInPosition";
            this.labelStaticInPosition.Size = new System.Drawing.Size(112, 15);
            this.labelStaticInPosition.TabIndex = 0;
            this.labelStaticInPosition.Text = "Найден в позиции:";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSearch.BackgroundImage")));
            this.buttonSearch.Location = new System.Drawing.Point(599, 296);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(59, 60);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // BGW
            // 
            this.BGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGW_DoWork);
            this.BGW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGW_RunWorkerCompleted);
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 1000;
            this.toolTip.IsBalloon = true;
            this.toolTip.ReshowDelay = 100;
            this.toolTip.ShowAlways = true;
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.buttonReadFromFIle,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.toolStripLabel6,
            this.buttonSaveInFile,
            this.toolStripSeparator2,
            this.toolStripLabel3,
            this.buttonUndo,
            this.toolStripSeparator3,
            this.toolStripLabel4,
            this.buttonRedo,
            this.toolStripSeparator4,
            this.toolStripLabel5,
            this.buttonHelp});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(670, 25);
            this.toolStrip.TabIndex = 7;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(135, 22);
            this.toolStripLabel1.Text = "Считать текст из файла";
            // 
            // buttonReadFromFIle
            // 
            this.buttonReadFromFIle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonReadFromFIle.Image = ((System.Drawing.Image)(resources.GetObject("buttonReadFromFIle.Image")));
            this.buttonReadFromFIle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonReadFromFIle.Name = "buttonReadFromFIle";
            this.buttonReadFromFIle.Size = new System.Drawing.Size(23, 22);
            this.buttonReadFromFIle.Text = "toolStripButton1";
            this.buttonReadFromFIle.Click += new System.EventHandler(this.buttonReadFromFIle_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(137, 22);
            this.toolStripLabel6.Text = "Сохранить текст в файл";
            // 
            // buttonSaveInFile
            // 
            this.buttonSaveInFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonSaveInFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveInFile.Image")));
            this.buttonSaveInFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonSaveInFile.Name = "buttonSaveInFile";
            this.buttonSaveInFile.Size = new System.Drawing.Size(23, 22);
            this.buttonSaveInFile.Text = "toolStripButton2";
            this.buttonSaveInFile.Click += new System.EventHandler(this.buttonSaveInFile_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(78, 22);
            this.toolStripLabel3.Text = "Назад (undo)";
            // 
            // buttonUndo
            // 
            this.buttonUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonUndo.Image = ((System.Drawing.Image)(resources.GetObject("buttonUndo.Image")));
            this.buttonUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Size = new System.Drawing.Size(23, 22);
            this.buttonUndo.Text = "toolStripButton3";
            this.buttonUndo.Click += new System.EventHandler(this.buttonUndo_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(81, 22);
            this.toolStripLabel4.Text = "Вперед (redo)";
            // 
            // buttonRedo
            // 
            this.buttonRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonRedo.Image = ((System.Drawing.Image)(resources.GetObject("buttonRedo.Image")));
            this.buttonRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonRedo.Name = "buttonRedo";
            this.buttonRedo.Size = new System.Drawing.Size(23, 22);
            this.buttonRedo.Text = "toolStripButton4";
            this.buttonRedo.Click += new System.EventHandler(this.buttonRedo_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(53, 22);
            this.toolStripLabel5.Text = "Справка";
            // 
            // buttonHelp
            // 
            this.buttonHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonHelp.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp.Image")));
            this.buttonHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(23, 22);
            this.buttonHelp.Text = "toolStripButton5";
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // Interface_prog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(670, 370);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.groupBoxSetParams);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Interface_prog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Substring Searching v1.0";
            this.groupBoxSetParams.ResumeLayout(false);
            this.groupBoxSetParams.PerformLayout();
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.GroupBox groupBoxSetParams;
        public System.Windows.Forms.GroupBox groupBoxResult;
        public System.Windows.Forms.Button buttonSearch;
        public System.Windows.Forms.RichTextBox richTextBoxText;
        public System.Windows.Forms.TextBox textBoxSubsrting;
        public System.Windows.Forms.Label labelStaticInPosition;
        public System.Windows.Forms.Label labelResultStr;
        public System.Windows.Forms.Label labelResultPosition;
        public System.Windows.Forms.Label labelStaticInStr;
        public System.Windows.Forms.ErrorProvider errorProvider;
        public System.ComponentModel.BackgroundWorker BGW;
        public System.Windows.Forms.ToolTip toolTip;
        public System.Windows.Forms.Label labelTextInput;
        public System.Windows.Forms.Label labelSubStrInput;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        public System.Windows.Forms.ToolStrip toolStrip;
        public System.Windows.Forms.ToolStripButton buttonReadFromFIle;
        public System.Windows.Forms.ToolStripButton buttonSaveInFile;
        public System.Windows.Forms.ToolStripButton buttonUndo;
        public System.Windows.Forms.ToolStripButton buttonRedo;
        public System.Windows.Forms.ToolStripButton buttonHelp;
    }
}

