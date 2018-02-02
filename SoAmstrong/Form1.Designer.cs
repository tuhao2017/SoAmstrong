namespace SoAmstrong
{
    partial class Form1
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
            this.btnXuly = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNhapSoN = new System.Windows.Forms.TextBox();
            this.txtketqua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKiemTraSon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnXuly
            // 
            this.btnXuly.Location = new System.Drawing.Point(43, 106);
            this.btnXuly.Name = "btnXuly";
            this.btnXuly.Size = new System.Drawing.Size(170, 23);
            this.btnXuly.TabIndex = 0;
            this.btnXuly.Text = "Kiểm tra từ 1 đến 1000";
            this.btnXuly.UseVisualStyleBackColor = true;
            this.btnXuly.Click += new System.EventHandler(this.btnXuly_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập số n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kết quả";
            // 
            // txtNhapSoN
            // 
            this.txtNhapSoN.Location = new System.Drawing.Point(106, 40);
            this.txtNhapSoN.Name = "txtNhapSoN";
            this.txtNhapSoN.Size = new System.Drawing.Size(166, 20);
            this.txtNhapSoN.TabIndex = 3;
            // 
            // txtketqua
            // 
            this.txtketqua.Location = new System.Drawing.Point(106, 69);
            this.txtketqua.Name = "txtketqua";
            this.txtketqua.Size = new System.Drawing.Size(166, 20);
            this.txtketqua.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kiểm tra số Amstrong";
            // 
            // btnKiemTraSon
            // 
            this.btnKiemTraSon.Location = new System.Drawing.Point(43, 136);
            this.btnKiemTraSon.Name = "btnKiemTraSon";
            this.btnKiemTraSon.Size = new System.Drawing.Size(170, 23);
            this.btnKiemTraSon.TabIndex = 6;
            this.btnKiemTraSon.Text = "Kiểm tra số n";
            this.btnKiemTraSon.UseVisualStyleBackColor = true;
            this.btnKiemTraSon.Click += new System.EventHandler(this.btnKiemTraSon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 184);
            this.Controls.Add(this.btnKiemTraSon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtketqua);
            this.Controls.Add(this.txtNhapSoN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXuly);
            this.Name = "Form1";
            this.Text = "Kiểm tra số Amstrong";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXuly;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNhapSoN;
        private System.Windows.Forms.TextBox txtketqua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKiemTraSon;
    }
}

