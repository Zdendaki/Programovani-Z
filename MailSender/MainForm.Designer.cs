namespace MailSender
{
    partial class MainForm
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Sender = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Recipient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Subject = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Message = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.SenderName = new System.Windows.Forms.TextBox();
            this.RecipientName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Odesílatel:";
            // 
            // Sender
            // 
            this.Sender.Location = new System.Drawing.Point(12, 25);
            this.Sender.Name = "Sender";
            this.Sender.Size = new System.Drawing.Size(222, 20);
            this.Sender.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adresát:";
            // 
            // Recipient
            // 
            this.Recipient.Location = new System.Drawing.Point(12, 69);
            this.Recipient.Name = "Recipient";
            this.Recipient.Size = new System.Drawing.Size(222, 20);
            this.Recipient.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Předmět:";
            // 
            // Subject
            // 
            this.Subject.Location = new System.Drawing.Point(12, 113);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(460, 20);
            this.Subject.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Zpráva:";
            // 
            // Message
            // 
            this.Message.Location = new System.Drawing.Point(12, 157);
            this.Message.Multiline = true;
            this.Message.Name = "Message";
            this.Message.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Message.Size = new System.Drawing.Size(460, 138);
            this.Message.TabIndex = 7;
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(397, 301);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 23);
            this.SendButton.TabIndex = 8;
            this.SendButton.Text = "Odeslat";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // SenderName
            // 
            this.SenderName.Location = new System.Drawing.Point(240, 25);
            this.SenderName.Name = "SenderName";
            this.SenderName.Size = new System.Drawing.Size(232, 20);
            this.SenderName.TabIndex = 9;
            // 
            // RecipientName
            // 
            this.RecipientName.Location = new System.Drawing.Point(240, 69);
            this.RecipientName.Name = "RecipientName";
            this.RecipientName.Size = new System.Drawing.Size(232, 20);
            this.RecipientName.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Jméno:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Jméno:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 336);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RecipientName);
            this.Controls.Add(this.SenderName);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Subject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Recipient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Sender);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Odesílání mailů";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Sender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Recipient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Subject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Message;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.TextBox SenderName;
        private System.Windows.Forms.TextBox RecipientName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

