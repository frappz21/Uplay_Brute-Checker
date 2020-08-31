namespace WahtProject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btUploadFile = new System.Windows.Forms.Button();
            this.btUploadProxy = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.ResultFolderOpen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.badproxiesL = new System.Windows.Forms.Label();
            this.proxiesL = new System.Windows.Forms.Label();
            this.allaccountL = new System.Windows.Forms.Label();
            this.badL = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.goodL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numThread = new System.Windows.Forms.NumericUpDown();
            this.Restart = new System.Windows.Forms.Button();
            this.typeProxy = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnremains = new System.Windows.Forms.Button();
            this.TimerUpdateProxy = new System.Windows.Forms.Timer(this.components);
            this.Rebrute = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.numTimeUpdate = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.cbUpdateTime = new System.Windows.Forms.CheckBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbUseProxyLink = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BruteIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SaveBad = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numThread)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // btUploadFile
            // 
            this.btUploadFile.AllowDrop = true;
            this.btUploadFile.Location = new System.Drawing.Point(6, 19);
            this.btUploadFile.Name = "btUploadFile";
            this.btUploadFile.Size = new System.Drawing.Size(145, 23);
            this.btUploadFile.TabIndex = 0;
            this.btUploadFile.Text = "Загрузить Базу";
            this.btUploadFile.UseVisualStyleBackColor = true;
            this.btUploadFile.Click += new System.EventHandler(this.btUploadFile_Click);
            // 
            // btUploadProxy
            // 
            this.btUploadProxy.AllowDrop = true;
            this.btUploadProxy.Location = new System.Drawing.Point(6, 48);
            this.btUploadProxy.Name = "btUploadProxy";
            this.btUploadProxy.Size = new System.Drawing.Size(145, 23);
            this.btUploadProxy.TabIndex = 1;
            this.btUploadProxy.Text = "Загрузить Прокси";
            this.btUploadProxy.UseVisualStyleBackColor = true;
            this.btUploadProxy.Click += new System.EventHandler(this.btUploadProxy_Click);
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(6, 19);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(145, 23);
            this.btStart.TabIndex = 2;
            this.btStart.Text = "Старт";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(6, 48);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(145, 23);
            this.btStop.TabIndex = 3;
            this.btStop.Text = "Стоп";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // ResultFolderOpen
            // 
            this.ResultFolderOpen.Location = new System.Drawing.Point(6, 77);
            this.ResultFolderOpen.Name = "ResultFolderOpen";
            this.ResultFolderOpen.Size = new System.Drawing.Size(145, 23);
            this.ResultFolderOpen.TabIndex = 4;
            this.ResultFolderOpen.Text = "Папка с Результатами";
            this.ResultFolderOpen.UseVisualStyleBackColor = true;
            this.ResultFolderOpen.Click += new System.EventHandler(this.ResultFolderOpen_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.badproxiesL);
            this.groupBox1.Controls.Add(this.proxiesL);
            this.groupBox1.Controls.Add(this.allaccountL);
            this.groupBox1.Controls.Add(this.badL);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.goodL);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(189, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 99);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Статистика";
            // 
            // badproxiesL
            // 
            this.badproxiesL.AutoSize = true;
            this.badproxiesL.ForeColor = System.Drawing.Color.Red;
            this.badproxiesL.Location = new System.Drawing.Point(143, 67);
            this.badproxiesL.Name = "badproxiesL";
            this.badproxiesL.Size = new System.Drawing.Size(13, 13);
            this.badproxiesL.TabIndex = 11;
            this.badproxiesL.Text = "0";
            // 
            // proxiesL
            // 
            this.proxiesL.AutoSize = true;
            this.proxiesL.Location = new System.Drawing.Point(81, 16);
            this.proxiesL.Name = "proxiesL";
            this.proxiesL.Size = new System.Drawing.Size(13, 13);
            this.proxiesL.TabIndex = 10;
            this.proxiesL.Text = "0";
            // 
            // allaccountL
            // 
            this.allaccountL.AutoSize = true;
            this.allaccountL.Location = new System.Drawing.Point(81, 38);
            this.allaccountL.Name = "allaccountL";
            this.allaccountL.Size = new System.Drawing.Size(13, 13);
            this.allaccountL.TabIndex = 9;
            this.allaccountL.Text = "0";
            // 
            // badL
            // 
            this.badL.AutoSize = true;
            this.badL.ForeColor = System.Drawing.Color.Red;
            this.badL.Location = new System.Drawing.Point(232, 38);
            this.badL.Name = "badL";
            this.badL.Size = new System.Drawing.Size(13, 13);
            this.badL.TabIndex = 6;
            this.badL.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Хороших : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ошибки : ";
            // 
            // goodL
            // 
            this.goodL.AutoSize = true;
            this.goodL.ForeColor = System.Drawing.Color.Green;
            this.goodL.Location = new System.Drawing.Point(232, 16);
            this.goodL.Name = "goodL";
            this.goodL.Size = new System.Drawing.Size(13, 13);
            this.goodL.TabIndex = 7;
            this.goodL.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Прокси : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Плохих : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Загружено : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.numThread);
            this.groupBox2.Controls.Add(this.Restart);
            this.groupBox2.Controls.Add(this.typeProxy);
            this.groupBox2.Controls.Add(this.btUploadFile);
            this.groupBox2.Controls.Add(this.btUploadProxy);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(159, 195);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Настройка";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "BruteForce",
            "RegChecker"});
            this.comboBox1.Location = new System.Drawing.Point(7, 162);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // numThread
            // 
            this.numThread.Location = new System.Drawing.Point(7, 105);
            this.numThread.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numThread.Name = "numThread";
            this.numThread.Size = new System.Drawing.Size(144, 20);
            this.numThread.TabIndex = 17;
            this.numThread.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // Restart
            // 
            this.Restart.Location = new System.Drawing.Point(6, 133);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(145, 23);
            this.Restart.TabIndex = 17;
            this.Restart.Text = "Рестарт";
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // typeProxy
            // 
            this.typeProxy.FormattingEnabled = true;
            this.typeProxy.Items.AddRange(new object[] {
            "HTTP\\S",
            "SOCKS4",
            "SOCKS5"});
            this.typeProxy.Location = new System.Drawing.Point(7, 78);
            this.typeProxy.Name = "typeProxy";
            this.typeProxy.Size = new System.Drawing.Size(144, 21);
            this.typeProxy.TabIndex = 2;
            this.typeProxy.Text = "HTTP\\S";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnremains);
            this.groupBox3.Controls.Add(this.btStart);
            this.groupBox3.Controls.Add(this.btStop);
            this.groupBox3.Controls.Add(this.ResultFolderOpen);
            this.groupBox3.Location = new System.Drawing.Point(13, 213);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(158, 139);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Управление";
            // 
            // btnremains
            // 
            this.btnremains.Location = new System.Drawing.Point(6, 106);
            this.btnremains.Name = "btnremains";
            this.btnremains.Size = new System.Drawing.Size(145, 23);
            this.btnremains.TabIndex = 5;
            this.btnremains.Text = "Сохранить Остаток";
            this.btnremains.UseVisualStyleBackColor = true;
            this.btnremains.Click += new System.EventHandler(this.btnremains_Click);
            // 
            // TimerUpdateProxy
            // 
            this.TimerUpdateProxy.Tick += new System.EventHandler(this.TimerUpdateProxy_Tick);
            // 
            // Rebrute
            // 
            this.Rebrute.AutoSize = true;
            this.Rebrute.Checked = true;
            this.Rebrute.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Rebrute.Location = new System.Drawing.Point(199, 117);
            this.Rebrute.Name = "Rebrute";
            this.Rebrute.Size = new System.Drawing.Size(115, 17);
            this.Rebrute.TabIndex = 16;
            this.Rebrute.Text = "Перебрут ошибок";
            this.Rebrute.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Location = new System.Drawing.Point(189, 259);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(272, 68);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Автор";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Lime;
            this.label16.Location = new System.Drawing.Point(162, 43);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "LolzTeam";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(137, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Ссылка на профиль :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Telegram -  @leniawar";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Разработчик -  Leniawar";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.numTimeUpdate);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.cbUpdateTime);
            this.groupBox5.Controls.Add(this.txtUrl);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.cbUseProxyLink);
            this.groupBox5.Location = new System.Drawing.Point(189, 145);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(272, 108);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Дополнительные настройки прокси";
            // 
            // numTimeUpdate
            // 
            this.numTimeUpdate.Location = new System.Drawing.Point(133, 76);
            this.numTimeUpdate.Name = "numTimeUpdate";
            this.numTimeUpdate.Size = new System.Drawing.Size(38, 20);
            this.numTimeUpdate.TabIndex = 18;
            this.numTimeUpdate.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(177, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Минут";
            // 
            // cbUpdateTime
            // 
            this.cbUpdateTime.AutoSize = true;
            this.cbUpdateTime.Location = new System.Drawing.Point(7, 77);
            this.cbUpdateTime.Name = "cbUpdateTime";
            this.cbUpdateTime.Size = new System.Drawing.Size(125, 17);
            this.cbUpdateTime.TabIndex = 3;
            this.cbUpdateTime.Text = "Обновлять Каждые";
            this.cbUpdateTime.UseVisualStyleBackColor = true;
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(68, 41);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(183, 20);
            this.txtUrl.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Ссылка : ";
            // 
            // cbUseProxyLink
            // 
            this.cbUseProxyLink.AutoSize = true;
            this.cbUseProxyLink.Location = new System.Drawing.Point(7, 20);
            this.cbUseProxyLink.Name = "cbUseProxyLink";
            this.cbUseProxyLink.Size = new System.Drawing.Size(120, 17);
            this.cbUseProxyLink.TabIndex = 0;
            this.cbUseProxyLink.Text = "Прокси по ссылке";
            this.cbUseProxyLink.UseVisualStyleBackColor = true;
            this.cbUseProxyLink.CheckedChanged += new System.EventHandler(this.Proxylink_CheckedChanged);
            this.cbUseProxyLink.Click += new System.EventHandler(this.Proxylink_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "в трей";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // BruteIcon
            // 
            this.BruteIcon.BalloonTipText = "Uplay B/C By Leniawar";
            this.BruteIcon.BalloonTipTitle = "не забуть что я тут )";
            this.BruteIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("BruteIcon.Icon")));
            this.BruteIcon.Text = "notifyIcon1";
            this.BruteIcon.Visible = true;
            this.BruteIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(189, 333);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(272, 17);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 18;
            // 
            // SaveBad
            // 
            this.SaveBad.AutoSize = true;
            this.SaveBad.Location = new System.Drawing.Point(315, 117);
            this.SaveBad.Name = "SaveBad";
            this.SaveBad.Size = new System.Drawing.Size(100, 17);
            this.SaveBad.TabIndex = 19;
            this.SaveBad.Text = "Сохранить бед";
            this.SaveBad.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(468, 362);
            this.Controls.Add(this.SaveBad);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.Rebrute);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uplay B\\C by Leniawar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numThread)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btUploadFile;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button ResultFolderOpen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label proxiesL;
        private System.Windows.Forms.Label allaccountL;
        private System.Windows.Forms.Label goodL;
        private System.Windows.Forms.Label badL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox typeProxy;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnremains;
        private System.Windows.Forms.Label badproxiesL;
        private System.Windows.Forms.Timer TimerUpdateProxy;
        public System.Windows.Forms.Button btUploadProxy;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.CheckBox Rebrute;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.CheckBox cbUpdateTime;
        public System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.CheckBox cbUseProxyLink;
        private System.Windows.Forms.NumericUpDown numThread;
        private System.Windows.Forms.NumericUpDown numTimeUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NotifyIcon BruteIcon;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox SaveBad;
    }
}

