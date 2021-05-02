
namespace Control
{
    partial class Urlbox
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
            this.btn_out = new System.Windows.Forms.Button();
            this.btn_in = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_out
            // 
            this.btn_out.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_out.Font = new System.Drawing.Font("新細明體", 18F);
            this.btn_out.Location = new System.Drawing.Point(12, 12);
            this.btn_out.Name = "btn_out";
            this.btn_out.Size = new System.Drawing.Size(245, 138);
            this.btn_out.TabIndex = 0;
            this.btn_out.Text = "網外";
            this.btn_out.UseVisualStyleBackColor = true;
            this.btn_out.Click += new System.EventHandler(this.btn_out_Click);
            // 
            // btn_in
            // 
            this.btn_in.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_in.Font = new System.Drawing.Font("新細明體", 18F);
            this.btn_in.Location = new System.Drawing.Point(263, 12);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(245, 138);
            this.btn_in.TabIndex = 1;
            this.btn_in.Text = "網內";
            this.btn_in.UseVisualStyleBackColor = true;
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Location = new System.Drawing.Point(433, 156);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 30);
            this.button3.TabIndex = 2;
            this.button3.Text = "取消";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Urlbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 191);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_in);
            this.Controls.Add(this.btn_out);
            this.Name = "Urlbox";
            this.Text = "IP/PORT";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_out;
        private System.Windows.Forms.Button btn_in;
        private System.Windows.Forms.Button button3;
    }
}