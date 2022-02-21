namespace DiceBR
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
            this.components = new System.ComponentModel.Container();
            this.lblCloseBtn = new System.Windows.Forms.Label();
            this.picDice = new System.Windows.Forms.PictureBox();
            this.btnRoll = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtOption1 = new System.Windows.Forms.TextBox();
            this.txtOption4 = new System.Windows.Forms.TextBox();
            this.txtOption2 = new System.Windows.Forms.TextBox();
            this.txtOption5 = new System.Windows.Forms.TextBox();
            this.txtOption3 = new System.Windows.Forms.TextBox();
            this.txtOption6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tmrTimer = new System.Windows.Forms.Timer(this.components);
            this.prgProgress = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.picDice)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCloseBtn
            // 
            this.lblCloseBtn.AutoSize = true;
            this.lblCloseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCloseBtn.ForeColor = System.Drawing.Color.Snow;
            this.lblCloseBtn.Location = new System.Drawing.Point(756, 9);
            this.lblCloseBtn.Name = "lblCloseBtn";
            this.lblCloseBtn.Size = new System.Drawing.Size(32, 31);
            this.lblCloseBtn.TabIndex = 0;
            this.lblCloseBtn.Text = "X";
            this.lblCloseBtn.Click += new System.EventHandler(this.lblCloseBtn_Click);
            // 
            // picDice
            // 
            this.picDice.Image = global::DiceBR.Properties.Resources.Alea_1;
            this.picDice.Location = new System.Drawing.Point(325, 48);
            this.picDice.Name = "picDice";
            this.picDice.Size = new System.Drawing.Size(169, 143);
            this.picDice.TabIndex = 1;
            this.picDice.TabStop = false;
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(242, 228);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(75, 23);
            this.btnRoll.TabIndex = 2;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(444, 228);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtOption1
            // 
            this.txtOption1.Location = new System.Drawing.Point(147, 273);
            this.txtOption1.Name = "txtOption1";
            this.txtOption1.Size = new System.Drawing.Size(170, 22);
            this.txtOption1.TabIndex = 4;
            // 
            // txtOption4
            // 
            this.txtOption4.Location = new System.Drawing.Point(444, 273);
            this.txtOption4.Name = "txtOption4";
            this.txtOption4.Size = new System.Drawing.Size(170, 22);
            this.txtOption4.TabIndex = 5;
            // 
            // txtOption2
            // 
            this.txtOption2.Location = new System.Drawing.Point(147, 330);
            this.txtOption2.Name = "txtOption2";
            this.txtOption2.Size = new System.Drawing.Size(170, 22);
            this.txtOption2.TabIndex = 6;
            // 
            // txtOption5
            // 
            this.txtOption5.Location = new System.Drawing.Point(444, 330);
            this.txtOption5.Name = "txtOption5";
            this.txtOption5.Size = new System.Drawing.Size(170, 22);
            this.txtOption5.TabIndex = 7;
            // 
            // txtOption3
            // 
            this.txtOption3.Location = new System.Drawing.Point(147, 383);
            this.txtOption3.Name = "txtOption3";
            this.txtOption3.Size = new System.Drawing.Size(170, 22);
            this.txtOption3.TabIndex = 8;
            // 
            // txtOption6
            // 
            this.txtOption6.Location = new System.Drawing.Point(444, 383);
            this.txtOption6.Name = "txtOption6";
            this.txtOption6.Size = new System.Drawing.Size(170, 22);
            this.txtOption6.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(124, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "1.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(124, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "2.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(124, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "3.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(421, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "4.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(421, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "5.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(421, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "6.";
            // 
            // tmrTimer
            // 
            this.tmrTimer.Tick += new System.EventHandler(this.tmrTimer_Tick);
            // 
            // prgProgress
            // 
            this.prgProgress.Location = new System.Drawing.Point(242, 197);
            this.prgProgress.Name = "prgProgress";
            this.prgProgress.Size = new System.Drawing.Size(277, 23);
            this.prgProgress.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.prgProgress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOption6);
            this.Controls.Add(this.txtOption3);
            this.Controls.Add(this.txtOption5);
            this.Controls.Add(this.txtOption2);
            this.Controls.Add(this.txtOption4);
            this.Controls.Add(this.txtOption1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.picDice);
            this.Controls.Add(this.lblCloseBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picDice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCloseBtn;
        private System.Windows.Forms.PictureBox picDice;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtOption1;
        private System.Windows.Forms.TextBox txtOption4;
        private System.Windows.Forms.TextBox txtOption2;
        private System.Windows.Forms.TextBox txtOption5;
        private System.Windows.Forms.TextBox txtOption3;
        private System.Windows.Forms.TextBox txtOption6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer tmrTimer;
        private System.Windows.Forms.ProgressBar prgProgress;
    }
}

