namespace WindowsFormsApp1
{
    partial class Form3
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Result_F = new System.Windows.Forms.Label();
            this.lbl_Result_K = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(352, 147);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 0;
            // 
            // btn_Send
            // 
            this.btn_Send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Send.Location = new System.Drawing.Point(352, 173);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(100, 25);
            this.btn_Send.TabIndex = 1;
            this.btn_Send.Text = "Enviar";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite uma temperatura em Celcius";
            // 
            // lbl_Result_F
            // 
            this.lbl_Result_F.AutoSize = true;
            this.lbl_Result_F.Location = new System.Drawing.Point(361, 241);
            this.lbl_Result_F.Name = "lbl_Result_F";
            this.lbl_Result_F.Size = new System.Drawing.Size(0, 13);
            this.lbl_Result_F.TabIndex = 3;
            // 
            // lbl_Result_K
            // 
            this.lbl_Result_K.AutoSize = true;
            this.lbl_Result_K.Location = new System.Drawing.Point(361, 280);
            this.lbl_Result_K.Name = "lbl_Result_K";
            this.lbl_Result_K.Size = new System.Drawing.Size(0, 13);
            this.lbl_Result_K.TabIndex = 4;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Result_K);
            this.Controls.Add(this.lbl_Result_F);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.textBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Result_F;
        private System.Windows.Forms.Label lbl_Result_K;
    }
}