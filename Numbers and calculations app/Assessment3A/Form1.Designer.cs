namespace Assessment3A
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
            this.pic5CentCoin = new System.Windows.Forms.PictureBox();
            this.pic50CentCoin = new System.Windows.Forms.PictureBox();
            this.pic10CentCoin = new System.Windows.Forms.PictureBox();
            this.pic25CentCoin = new System.Windows.Forms.PictureBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lbl50Cents = new System.Windows.Forms.Label();
            this.lbl25Cents = new System.Windows.Forms.Label();
            this.lbl10Cents = new System.Windows.Forms.Label();
            this.lbl5Cents = new System.Windows.Forms.Label();
            this.lblWelcomeMessage = new System.Windows.Forms.Label();
            this.lblTotalOutPut = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic5CentCoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic50CentCoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic10CentCoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic25CentCoin)).BeginInit();
            this.SuspendLayout();
            // 
            // pic5CentCoin
            // 
            this.pic5CentCoin.Image = global::Assessment3A.Properties.Resources._5cents;
            this.pic5CentCoin.Location = new System.Drawing.Point(99, 100);
            this.pic5CentCoin.Name = "pic5CentCoin";
            this.pic5CentCoin.Size = new System.Drawing.Size(100, 75);
            this.pic5CentCoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic5CentCoin.TabIndex = 0;
            this.pic5CentCoin.TabStop = false;
            this.pic5CentCoin.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pic50CentCoin
            // 
            this.pic50CentCoin.Image = global::Assessment3A.Properties.Resources._50cents;
            this.pic50CentCoin.Location = new System.Drawing.Point(368, 283);
            this.pic50CentCoin.Name = "pic50CentCoin";
            this.pic50CentCoin.Size = new System.Drawing.Size(100, 75);
            this.pic50CentCoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic50CentCoin.TabIndex = 1;
            this.pic50CentCoin.TabStop = false;
            this.pic50CentCoin.Click += new System.EventHandler(this.pic50CentCoin_Click);
            // 
            // pic10CentCoin
            // 
            this.pic10CentCoin.Image = global::Assessment3A.Properties.Resources._10cents;
            this.pic10CentCoin.Location = new System.Drawing.Point(368, 100);
            this.pic10CentCoin.Name = "pic10CentCoin";
            this.pic10CentCoin.Size = new System.Drawing.Size(100, 75);
            this.pic10CentCoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic10CentCoin.TabIndex = 2;
            this.pic10CentCoin.TabStop = false;
            this.pic10CentCoin.Click += new System.EventHandler(this.pic10CentCoin_Click);
            // 
            // pic25CentCoin
            // 
            this.pic25CentCoin.Image = global::Assessment3A.Properties.Resources._25cents;
            this.pic25CentCoin.Location = new System.Drawing.Point(99, 283);
            this.pic25CentCoin.Name = "pic25CentCoin";
            this.pic25CentCoin.Size = new System.Drawing.Size(100, 75);
            this.pic25CentCoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic25CentCoin.TabIndex = 3;
            this.pic25CentCoin.TabStop = false;
            this.pic25CentCoin.Click += new System.EventHandler(this.pic25CentCoin_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(774, 182);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(101, 24);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTotal.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl50Cents
            // 
            this.lbl50Cents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.lbl50Cents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl50Cents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl50Cents.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl50Cents.Location = new System.Drawing.Point(368, 377);
            this.lbl50Cents.Name = "lbl50Cents";
            this.lbl50Cents.Size = new System.Drawing.Size(100, 23);
            this.lbl50Cents.TabIndex = 5;
            this.lbl50Cents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl50Cents.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl25Cents
            // 
            this.lbl25Cents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.lbl25Cents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl25Cents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl25Cents.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl25Cents.Location = new System.Drawing.Point(99, 377);
            this.lbl25Cents.Name = "lbl25Cents";
            this.lbl25Cents.Size = new System.Drawing.Size(100, 23);
            this.lbl25Cents.TabIndex = 6;
            this.lbl25Cents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl25Cents.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl10Cents
            // 
            this.lbl10Cents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.lbl10Cents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl10Cents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl10Cents.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl10Cents.Location = new System.Drawing.Point(368, 198);
            this.lbl10Cents.Name = "lbl10Cents";
            this.lbl10Cents.Size = new System.Drawing.Size(100, 23);
            this.lbl10Cents.TabIndex = 7;
            this.lbl10Cents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl10Cents.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbl5Cents
            // 
            this.lbl5Cents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.lbl5Cents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl5Cents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5Cents.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl5Cents.Location = new System.Drawing.Point(99, 198);
            this.lbl5Cents.Name = "lbl5Cents";
            this.lbl5Cents.Size = new System.Drawing.Size(100, 23);
            this.lbl5Cents.TabIndex = 8;
            this.lbl5Cents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl5Cents.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblWelcomeMessage
            // 
            this.lblWelcomeMessage.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeMessage.Location = new System.Drawing.Point(94, -9);
            this.lblWelcomeMessage.Name = "lblWelcomeMessage";
            this.lblWelcomeMessage.Size = new System.Drawing.Size(374, 94);
            this.lblWelcomeMessage.TabIndex = 9;
            this.lblWelcomeMessage.Text = "Welcome! \r\nPlease click on the icons below";
            this.lblWelcomeMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWelcomeMessage.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblTotalOutPut
            // 
            this.lblTotalOutPut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.lblTotalOutPut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalOutPut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOutPut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalOutPut.Location = new System.Drawing.Point(721, 217);
            this.lblTotalOutPut.Name = "lblTotalOutPut";
            this.lblTotalOutPut.Size = new System.Drawing.Size(223, 40);
            this.lblTotalOutPut.TabIndex = 10;
            this.lblTotalOutPut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTotalOutPut.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(47)))), ((int)(((byte)(56)))));
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReset.Location = new System.Drawing.Point(721, 283);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 37);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(47)))), ((int)(((byte)(56)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(839, 283);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(105, 35);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(179)))), ((int)(((byte)(142)))));
            this.ClientSize = new System.Drawing.Size(1036, 476);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblTotalOutPut);
            this.Controls.Add(this.lblWelcomeMessage);
            this.Controls.Add(this.lbl5Cents);
            this.Controls.Add(this.lbl10Cents);
            this.Controls.Add(this.lbl25Cents);
            this.Controls.Add(this.lbl50Cents);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.pic25CentCoin);
            this.Controls.Add(this.pic10CentCoin);
            this.Controls.Add(this.pic50CentCoin);
            this.Controls.Add(this.pic5CentCoin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic5CentCoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic50CentCoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic10CentCoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic25CentCoin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic5CentCoin;
        private System.Windows.Forms.PictureBox pic50CentCoin;
        private System.Windows.Forms.PictureBox pic10CentCoin;
        private System.Windows.Forms.PictureBox pic25CentCoin;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lbl50Cents;
        private System.Windows.Forms.Label lbl25Cents;
        private System.Windows.Forms.Label lbl10Cents;
        private System.Windows.Forms.Label lbl5Cents;
        private System.Windows.Forms.Label lblWelcomeMessage;
        private System.Windows.Forms.Label lblTotalOutPut;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
    }
}

