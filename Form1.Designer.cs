namespace RgbConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.toConvert_text = new System.Windows.Forms.TextBox();
            this.convert_btn = new System.Windows.Forms.Button();
            this.converted_text = new System.Windows.Forms.TextBox();
            this.copy_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inverse_check = new System.Windows.Forms.CheckBox();
            this.noArma3_check = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(649, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Color converter: From 255 rgb format to Arma 3 Format";
            // 
            // toConvert_text
            // 
            this.toConvert_text.Location = new System.Drawing.Point(17, 125);
            this.toConvert_text.Name = "toConvert_text";
            this.toConvert_text.Size = new System.Drawing.Size(603, 26);
            this.toConvert_text.TabIndex = 1;
            // 
            // convert_btn
            // 
            this.convert_btn.Location = new System.Drawing.Point(626, 123);
            this.convert_btn.Name = "convert_btn";
            this.convert_btn.Size = new System.Drawing.Size(131, 31);
            this.convert_btn.TabIndex = 2;
            this.convert_btn.Text = "Convert";
            this.convert_btn.UseVisualStyleBackColor = true;
            this.convert_btn.Click += new System.EventHandler(this.convert_btn_Click);
            // 
            // converted_text
            // 
            this.converted_text.Location = new System.Drawing.Point(17, 185);
            this.converted_text.Name = "converted_text";
            this.converted_text.Size = new System.Drawing.Size(603, 26);
            this.converted_text.TabIndex = 3;
            // 
            // copy_btn
            // 
            this.copy_btn.Location = new System.Drawing.Point(626, 183);
            this.copy_btn.Name = "copy_btn";
            this.copy_btn.Size = new System.Drawing.Size(131, 31);
            this.copy_btn.TabIndex = 4;
            this.copy_btn.Text = "Copy";
            this.copy_btn.UseVisualStyleBackColor = true;
            this.copy_btn.Click += new System.EventHandler(this.copy_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inverse_check);
            this.groupBox1.Controls.Add(this.noArma3_check);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(17, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 136);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // inverse_check
            // 
            this.inverse_check.AutoSize = true;
            this.inverse_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inverse_check.Location = new System.Drawing.Point(19, 76);
            this.inverse_check.Name = "inverse_check";
            this.inverse_check.Size = new System.Drawing.Size(364, 33);
            this.inverse_check.TabIndex = 1;
            this.inverse_check.Text = "Reverse process (1 --> 255)";
            this.inverse_check.UseVisualStyleBackColor = true;
            // 
            // noArma3_check
            // 
            this.noArma3_check.AutoSize = true;
            this.noArma3_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noArma3_check.Location = new System.Drawing.Point(19, 37);
            this.noArma3_check.Name = "noArma3_check";
            this.noArma3_check.Size = new System.Drawing.Size(401, 33);
            this.noArma3_check.TabIndex = 0;
            this.noArma3_check.Text = "Do not convert in arma 3 format";
            this.noArma3_check.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(888, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "By MrFreex";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1046, 415);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.copy_btn);
            this.Controls.Add(this.converted_text);
            this.Controls.Add(this.convert_btn);
            this.Controls.Add(this.toConvert_text);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Color Converter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox toConvert_text;
        private System.Windows.Forms.Button convert_btn;
        private System.Windows.Forms.TextBox converted_text;
        private System.Windows.Forms.Button copy_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox inverse_check;
        private System.Windows.Forms.CheckBox noArma3_check;
        private System.Windows.Forms.Label label2;
    }
}

