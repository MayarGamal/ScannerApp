namespace ScannerGUI
{
    partial class ScannerApp
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
            this.InputText = new System.Windows.Forms.TextBox();
            this.GenerateBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Tokenstext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.resetbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputText
            // 
            this.InputText.Location = new System.Drawing.Point(33, 63);
            this.InputText.Multiline = true;
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(189, 226);
            this.InputText.TabIndex = 0;
            this.InputText.TextChanged += new System.EventHandler(this.InputText_TextChanged);
            // 
            // GenerateBtn
            // 
            this.GenerateBtn.Location = new System.Drawing.Point(93, 295);
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.Size = new System.Drawing.Size(75, 23);
            this.GenerateBtn.TabIndex = 1;
            this.GenerateBtn.Text = "Generate";
            this.GenerateBtn.UseVisualStyleBackColor = true;
            this.GenerateBtn.Click += new System.EventHandler(this.GenerateBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter your Code here";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Tokenstext
            // 
            this.Tokenstext.Location = new System.Drawing.Point(297, 63);
            this.Tokenstext.Multiline = true;
            this.Tokenstext.Name = "Tokenstext";
            this.Tokenstext.Size = new System.Drawing.Size(189, 226);
            this.Tokenstext.TabIndex = 3;
            this.Tokenstext.TextChanged += new System.EventHandler(this.Tokenstext_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Scanner:";
            // 
            // resetbtn
            // 
            this.resetbtn.Location = new System.Drawing.Point(216, 323);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(75, 29);
            this.resetbtn.TabIndex = 5;
            this.resetbtn.Text = "Reset";
            this.resetbtn.UseVisualStyleBackColor = true;
            this.resetbtn.Click += new System.EventHandler(this.resetbtn_Click);
            // 
            // ScannerApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 382);
            this.Controls.Add(this.resetbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tokenstext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GenerateBtn);
            this.Controls.Add(this.InputText);
            this.Name = "ScannerApp";
            this.Text = "Scanner App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputText;
        private System.Windows.Forms.Button GenerateBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tokenstext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button resetbtn;
    }
}

