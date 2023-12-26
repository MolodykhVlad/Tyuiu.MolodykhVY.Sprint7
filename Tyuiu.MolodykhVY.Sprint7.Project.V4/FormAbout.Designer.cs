
namespace Tyuiu.MolodykhVY.Sprint7.Project.V4
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.buttonClose_MVY = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxInfo_MVY = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose_MVY
            // 
            this.buttonClose_MVY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose_MVY.Location = new System.Drawing.Point(659, 542);
            this.buttonClose_MVY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonClose_MVY.Name = "buttonClose_MVY";
            this.buttonClose_MVY.Size = new System.Drawing.Size(293, 62);
            this.buttonClose_MVY.TabIndex = 3;
            this.buttonClose_MVY.Text = "Ок";
            this.buttonClose_MVY.UseVisualStyleBackColor = true;
            this.buttonClose_MVY.Click += new System.EventHandler(this.buttonClose_MVY_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxInfo_MVY
            // 
            this.textBoxInfo_MVY.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxInfo_MVY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInfo_MVY.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxInfo_MVY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInfo_MVY.Location = new System.Drawing.Point(372, 43);
            this.textBoxInfo_MVY.Multiline = true;
            this.textBoxInfo_MVY.Name = "textBoxInfo_MVY";
            this.textBoxInfo_MVY.ReadOnly = true;
            this.textBoxInfo_MVY.Size = new System.Drawing.Size(624, 629);
            this.textBoxInfo_MVY.TabIndex = 0;
            this.textBoxInfo_MVY.Text = resources.GetString("textBoxInfo_MVY.Text");
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 653);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonClose_MVY);
            this.Controls.Add(this.textBoxInfo_MVY);
            this.Name = "FormAbout";
            this.Text = "FormAbout";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonClose_MVY;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxInfo_MVY;
    }
}