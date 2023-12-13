
namespace Tyuiu.MolodykhVY.Sprint7.V4
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
            this.ButtonLeftPanel = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonLeftPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.panel1.Controls.Add(this.ButtonLeftPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1098, 118);
            this.panel1.TabIndex = 0;
            // 
            // ButtonLeftPanel
            // 
            this.ButtonLeftPanel.Image = ((System.Drawing.Image)(resources.GetObject("ButtonLeftPanel.Image")));
            this.ButtonLeftPanel.Location = new System.Drawing.Point(18, 18);
            this.ButtonLeftPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonLeftPanel.Name = "ButtonLeftPanel";
            this.ButtonLeftPanel.Size = new System.Drawing.Size(75, 77);
            this.ButtonLeftPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonLeftPanel.TabIndex = 0;
            this.ButtonLeftPanel.TabStop = false;
            this.ButtonLeftPanel.MouseEnter += new System.EventHandler(this.ButtonLeftPanel_MouseEnter);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1098, 620);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.Text = "Library";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ButtonLeftPanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ButtonLeftPanel;
    }
}

