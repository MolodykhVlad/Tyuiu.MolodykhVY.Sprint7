﻿
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoisk)).BeginInit();
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
            this.groupBoxMenu.Location = new System.Drawing.Point(12, 106);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Size = new System.Drawing.Size(258, 517);
            this.groupBoxMenu.TabIndex = 1;
            this.groupBoxMenu.TabStop = false;
            this.groupBoxMenu.Text = "groupBox1";
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxPoisk;
        private System.Windows.Forms.PictureBox ButtonMenu;
        private System.Windows.Forms.PictureBox pictureBoxPoisk;
        private System.Windows.Forms.GroupBox groupBoxMenu;
    }
}
