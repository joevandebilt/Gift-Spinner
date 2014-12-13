namespace GiftPicker
{
    partial class frmGiftSpinner
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
            this.cmdSpin = new System.Windows.Forms.Button();
            this.cmdQuit = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.rbtFindOne = new System.Windows.Forms.RadioButton();
            this.rbtFindMany = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // cmdSpin
            // 
            this.cmdSpin.Location = new System.Drawing.Point(45, 86);
            this.cmdSpin.Name = "cmdSpin";
            this.cmdSpin.Size = new System.Drawing.Size(80, 39);
            this.cmdSpin.TabIndex = 0;
            this.cmdSpin.Text = "Find a Gift";
            this.cmdSpin.UseVisualStyleBackColor = true;
            this.cmdSpin.Click += new System.EventHandler(this.cmdSpin_Click);
            // 
            // cmdQuit
            // 
            this.cmdQuit.Location = new System.Drawing.Point(131, 86);
            this.cmdQuit.Name = "cmdQuit";
            this.cmdQuit.Size = new System.Drawing.Size(80, 39);
            this.cmdQuit.TabIndex = 1;
            this.cmdQuit.Text = "Quit";
            this.cmdQuit.UseVisualStyleBackColor = true;
            this.cmdQuit.Click += new System.EventHandler(this.cmdQuit_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(50, 22);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(138, 16);
            this.lblOutput.TabIndex = 2;
            this.lblOutput.Text = "Number of Attempts: 0";
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(240, 12);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(571, 113);
            this.rtbOutput.TabIndex = 3;
            this.rtbOutput.Text = "";
            // 
            // rbtFindOne
            // 
            this.rbtFindOne.AutoSize = true;
            this.rbtFindOne.Location = new System.Drawing.Point(45, 51);
            this.rbtFindOne.Name = "rbtFindOne";
            this.rbtFindOne.Size = new System.Drawing.Size(68, 17);
            this.rbtFindOne.TabIndex = 4;
            this.rbtFindOne.TabStop = true;
            this.rbtFindOne.Text = "Find One";
            this.rbtFindOne.UseVisualStyleBackColor = true;
            // 
            // rbtFindMany
            // 
            this.rbtFindMany.AutoSize = true;
            this.rbtFindMany.Location = new System.Drawing.Point(131, 51);
            this.rbtFindMany.Name = "rbtFindMany";
            this.rbtFindMany.Size = new System.Drawing.Size(74, 17);
            this.rbtFindMany.TabIndex = 5;
            this.rbtFindMany.TabStop = true;
            this.rbtFindMany.Text = "Find Many";
            this.rbtFindMany.UseVisualStyleBackColor = true;
            // 
            // frmGiftSpinner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 146);
            this.Controls.Add(this.rbtFindMany);
            this.Controls.Add(this.rbtFindOne);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.cmdQuit);
            this.Controls.Add(this.cmdSpin);
            this.Name = "frmGiftSpinner";
            this.Text = "Gift Spinner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdSpin;
        private System.Windows.Forms.Button cmdQuit;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.RadioButton rbtFindOne;
        private System.Windows.Forms.RadioButton rbtFindMany;
    }
}

