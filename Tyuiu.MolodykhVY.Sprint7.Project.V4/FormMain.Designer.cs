
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
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.PoiskYear = new System.Windows.Forms.Label();
            this.PoiskBook = new System.Windows.Forms.Label();
            this.PoiskAutor = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 170);
            this.panel1.TabIndex = 0;
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.groupBoxMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxMenu.BackgroundImage")));
            this.groupBoxMenu.Controls.Add(this.PoiskYear);
            this.groupBoxMenu.Controls.Add(this.PoiskBook);
            this.groupBoxMenu.Controls.Add(this.PoiskAutor);
            this.groupBoxMenu.Location = new System.Drawing.Point(12, 194);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Size = new System.Drawing.Size(258, 509);
            this.groupBoxMenu.TabIndex = 1;
            this.groupBoxMenu.TabStop = false;
            // 
            // PoiskYear
            // 
            this.PoiskYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PoiskYear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PoiskYear.Location = new System.Drawing.Point(7, 383);
            this.PoiskYear.Name = "PoiskYear";
            this.PoiskYear.Size = new System.Drawing.Size(245, 55);
            this.PoiskYear.TabIndex = 5;
            this.PoiskYear.Text = "Поиск по году";
            this.PoiskYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PoiskBook
            // 
            this.PoiskBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PoiskBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PoiskBook.Location = new System.Drawing.Point(7, 227);
            this.PoiskBook.Name = "PoiskBook";
            this.PoiskBook.Size = new System.Drawing.Size(245, 55);
            this.PoiskBook.TabIndex = 4;
            this.PoiskBook.Text = "Поиск Книги";
            this.PoiskBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PoiskAutor
            // 
            this.PoiskAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PoiskAutor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PoiskAutor.Location = new System.Drawing.Point(7, 85);
            this.PoiskAutor.Name = "PoiskAutor";
            this.PoiskAutor.Size = new System.Drawing.Size(245, 55);
            this.PoiskAutor.TabIndex = 3;
            this.PoiskAutor.Text = "Поиск автора";
            this.PoiskAutor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1944, 1067);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1920, 1050);
            this.Controls.Add(this.groupBoxMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.groupBoxMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxMenu;
        private System.Windows.Forms.Label PoiskYear;
        private System.Windows.Forms.Label PoiskBook;
        private System.Windows.Forms.Label PoiskAutor;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

