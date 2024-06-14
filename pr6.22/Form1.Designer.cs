namespace pr6._22
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStartEngine = new System.Windows.Forms.Button();
            this.btnStopEngine = new System.Windows.Forms.Button();
            this.btnSupplyFuel = new System.Windows.Forms.Button();
            this.btnCutOffFuel = new System.Windows.Forms.Button();
            this.btntTurnOnLights = new System.Windows.Forms.Button();
            this.btnTurnOffLights = new System.Windows.Forms.Button();
            this.btnRunDiagnostics = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartEngine
            // 
            this.btnStartEngine.Location = new System.Drawing.Point(510, 26);
            this.btnStartEngine.Name = "btnStartEngine";
            this.btnStartEngine.Size = new System.Drawing.Size(112, 34);
            this.btnStartEngine.TabIndex = 0;
            this.btnStartEngine.Text = "Запуск ";
            this.btnStartEngine.UseVisualStyleBackColor = true;
            this.btnStartEngine.Click += new System.EventHandler(this.btnStartEngine_Click);
            // 
            // btnStopEngine
            // 
            this.btnStopEngine.Location = new System.Drawing.Point(510, 193);
            this.btnStopEngine.Name = "btnStopEngine";
            this.btnStopEngine.Size = new System.Drawing.Size(112, 31);
            this.btnStopEngine.TabIndex = 1;
            this.btnStopEngine.Text = "Заглушить";
            this.btnStopEngine.UseVisualStyleBackColor = true;
            this.btnStopEngine.Click += new System.EventHandler(this.btnStopEngine_Click);
            // 
            // btnSupplyFuel
            // 
            this.btnSupplyFuel.Location = new System.Drawing.Point(510, 151);
            this.btnSupplyFuel.Name = "btnSupplyFuel";
            this.btnSupplyFuel.Size = new System.Drawing.Size(112, 34);
            this.btnSupplyFuel.TabIndex = 2;
            this.btnSupplyFuel.Text = "Подача топлива";
            this.btnSupplyFuel.UseVisualStyleBackColor = true;
            this.btnSupplyFuel.Click += new System.EventHandler(this.btnSupplyFuel_Click);
            // 
            // btnCutOffFuel
            // 
            this.btnCutOffFuel.Location = new System.Drawing.Point(511, 236);
            this.btnCutOffFuel.Name = "btnCutOffFuel";
            this.btnCutOffFuel.Size = new System.Drawing.Size(112, 34);
            this.btnCutOffFuel.TabIndex = 3;
            this.btnCutOffFuel.Text = "Выключить подачу топлива";
            this.btnCutOffFuel.UseVisualStyleBackColor = true;
            this.btnCutOffFuel.Click += new System.EventHandler(this.btnCutOffFuel_Click);
            // 
            // btntTurnOnLights
            // 
            this.btntTurnOnLights.Location = new System.Drawing.Point(510, 69);
            this.btntTurnOnLights.Name = "btntTurnOnLights";
            this.btntTurnOnLights.Size = new System.Drawing.Size(112, 34);
            this.btntTurnOnLights.TabIndex = 4;
            this.btntTurnOnLights.Text = "Включить фары";
            this.btntTurnOnLights.UseVisualStyleBackColor = true;
            this.btntTurnOnLights.Click += new System.EventHandler(this.btntTurnOnLights_Click);
            // 
            // btnTurnOffLights
            // 
            this.btnTurnOffLights.Location = new System.Drawing.Point(510, 112);
            this.btnTurnOffLights.Name = "btnTurnOffLights";
            this.btnTurnOffLights.Size = new System.Drawing.Size(112, 31);
            this.btnTurnOffLights.TabIndex = 5;
            this.btnTurnOffLights.Text = "Выключить фары";
            this.btnTurnOffLights.UseVisualStyleBackColor = true;
            this.btnTurnOffLights.Click += new System.EventHandler(this.btnTurnOffLights_Click);
            // 
            // btnRunDiagnostics
            // 
            this.btnRunDiagnostics.Location = new System.Drawing.Point(510, 278);
            this.btnRunDiagnostics.Name = "btnRunDiagnostics";
            this.btnRunDiagnostics.Size = new System.Drawing.Size(112, 34);
            this.btnRunDiagnostics.TabIndex = 6;
            this.btnRunDiagnostics.Text = "Диагностика";
            this.btnRunDiagnostics.UseVisualStyleBackColor = true;
            this.btnRunDiagnostics.Click += new System.EventHandler(this.btnRunDiagnostics_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(780, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(73, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(637, 369);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.btnSupplyFuel);
            this.tabPage1.Controls.Add(this.btnRunDiagnostics);
            this.tabPage1.Controls.Add(this.btnStartEngine);
            this.tabPage1.Controls.Add(this.btnTurnOffLights);
            this.tabPage1.Controls.Add(this.btnStopEngine);
            this.tabPage1.Controls.Add(this.btntTurnOnLights);
            this.tabPage1.Controls.Add(this.btnCutOffFuel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(629, 343);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Автомобиль";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(501, 333);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(780, 485);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.Location = new System.Drawing.Point(296, 430);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(159, 47);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Выйти из машины";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 489);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(780, 489);
            this.Name = "Form1";
            this.Text = "Автомобиль";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartEngine;
        private System.Windows.Forms.Button btnStopEngine;
        private System.Windows.Forms.Button btnSupplyFuel;
        private System.Windows.Forms.Button btnCutOffFuel;
        private System.Windows.Forms.Button btntTurnOnLights;
        private System.Windows.Forms.Button btnTurnOffLights;
        private System.Windows.Forms.Button btnRunDiagnostics;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnBack;
    }
}

