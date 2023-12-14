
namespace Tyuiu.MolodykhVY.Sprint7.Project.V4
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxPoisk = new System.Windows.Forms.TextBox();
            this.ButtonMenu = new System.Windows.Forms.PictureBox();
            this.pictureBoxPoisk = new System.Windows.Forms.PictureBox();
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.LeftPanel1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoisk)).BeginInit();
            this.groupBoxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.panel1.Controls.Add(this.textBoxPoisk);
            this.panel1.Controls.Add(this.ButtonMenu);
            this.panel1.Controls.Add(this.pictureBoxPoisk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 100);
            this.panel1.TabIndex = 0;
            // 
            // textBoxPoisk
            // 
            this.textBoxPoisk.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxPoisk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.textBoxPoisk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPoisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPoisk.ForeColor = System.Drawing.Color.White;
            this.textBoxPoisk.Location = new System.Drawing.Point(759, 36);
            this.textBoxPoisk.Multiline = true;
            this.textBoxPoisk.Name = "textBoxPoisk";
            this.textBoxPoisk.Size = new System.Drawing.Size(448, 29);
            this.textBoxPoisk.TabIndex = 2;
            // 
            // ButtonMenu
            // 
            this.ButtonMenu.Image = ((System.Drawing.Image)(resources.GetObject("ButtonMenu.Image")));
            this.ButtonMenu.Location = new System.Drawing.Point(23, 12);
            this.ButtonMenu.Name = "ButtonMenu";
            this.ButtonMenu.Size = new System.Drawing.Size(82, 73);
            this.ButtonMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonMenu.TabIndex = 1;
            this.ButtonMenu.TabStop = false;
            this.ButtonMenu.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBoxPoisk
            // 
            this.pictureBoxPoisk.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxPoisk.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPoisk.Image")));
            this.pictureBoxPoisk.Location = new System.Drawing.Point(709, 3);
            this.pictureBoxPoisk.Name = "pictureBoxPoisk";
            this.pictureBoxPoisk.Size = new System.Drawing.Size(523, 94);
            this.pictureBoxPoisk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPoisk.TabIndex = 0;
            this.pictureBoxPoisk.TabStop = false;
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.groupBoxMenu.Controls.Add(this.label3);
            this.groupBoxMenu.Controls.Add(this.label2);
            this.groupBoxMenu.Controls.Add(this.label1);
            this.groupBoxMenu.Controls.Add(this.LeftPanel1);
            this.groupBoxMenu.Location = new System.Drawing.Point(12, 106);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Size = new System.Drawing.Size(258, 517);
            this.groupBoxMenu.TabIndex = 1;
            this.groupBoxMenu.TabStop = false;
            this.groupBoxMenu.Text = "groupBox1";
            // 
            // LeftPanel1
            // 
            this.LeftPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeftPanel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LeftPanel1.Location = new System.Drawing.Point(7, 53);
            this.LeftPanel1.Name = "LeftPanel1";
            this.LeftPanel1.Size = new System.Drawing.Size(245, 55);
            this.LeftPanel1.TabIndex = 3;
            this.LeftPanel1.Text = "Поиск автора";
            this.LeftPanel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(7, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 55);
            this.label1.TabIndex = 4;
            this.label1.Text = "Поиск автора";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(4, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 55);
            this.label2.TabIndex = 5;
            this.label2.Text = "Поиск автора";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(6, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 55);
            this.label3.TabIndex = 6;
            this.label3.Text = "Поиск автора";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1920, 1050);
            this.Controls.Add(this.groupBoxMenu);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoisk)).EndInit();
            this.groupBoxMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxPoisk;
        private System.Windows.Forms.PictureBox ButtonMenu;
        private System.Windows.Forms.PictureBox pictureBoxPoisk;
        private System.Windows.Forms.GroupBox groupBoxMenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LeftPanel1;
    }
}

