
namespace Hotel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAmount = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtNumberNights = new System.Windows.Forms.TextBox();
            this.btnEmail = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblTitle4 = new System.Windows.Forms.Label();
            this.lblTitle3 = new System.Windows.Forms.Label();
            this.txtNumPeople = new System.Windows.Forms.TextBox();
            this.txtPriceRoom = new System.Windows.Forms.TextBox();
            this.txtExtra = new System.Windows.Forms.TextBox();
            this.Emails = new System.Windows.Forms.ListBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblOutputDiscount = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAmount
            // 
            this.btnAmount.Location = new System.Drawing.Point(12, 406);
            this.btnAmount.Name = "btnAmount";
            this.btnAmount.Size = new System.Drawing.Size(112, 34);
            this.btnAmount.TabIndex = 0;
            this.btnAmount.Text = "Calculate";
            this.btnAmount.UseVisualStyleBackColor = true;
            this.btnAmount.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(12, 326);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(224, 25);
            this.lblOutput.TabIndex = 1;
            this.lblOutput.Text = "Amount to pay per person";
            // 
            // txtNumberNights
            // 
            this.txtNumberNights.Location = new System.Drawing.Point(177, 83);
            this.txtNumberNights.Name = "txtNumberNights";
            this.txtNumberNights.Size = new System.Drawing.Size(150, 31);
            this.txtNumberNights.TabIndex = 2;
            // 
            // btnEmail
            // 
            this.btnEmail.Location = new System.Drawing.Point(419, 136);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(166, 34);
            this.btnEmail.TabIndex = 3;
            this.btnEmail.Text = "Enter";
            this.btnEmail.UseVisualStyleBackColor = true;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter name and email address";
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.Location = new System.Drawing.Point(12, 89);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(153, 25);
            this.lblTitle1.TabIndex = 9;
            this.lblTitle1.Text = "Number of nights";
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Location = new System.Drawing.Point(12, 144);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(159, 25);
            this.lblTitle2.TabIndex = 10;
            this.lblTitle2.Text = "Number of people";
            this.lblTitle2.Click += new System.EventHandler(this.lblTitle2_Click);
            // 
            // lblTitle4
            // 
            this.lblTitle4.AutoSize = true;
            this.lblTitle4.Location = new System.Drawing.Point(12, 246);
            this.lblTitle4.Name = "lblTitle4";
            this.lblTitle4.Size = new System.Drawing.Size(127, 25);
            this.lblTitle4.TabIndex = 11;
            this.lblTitle4.Text = "Extra expenses";
            // 
            // lblTitle3
            // 
            this.lblTitle3.AutoSize = true;
            this.lblTitle3.Location = new System.Drawing.Point(12, 196);
            this.lblTitle3.Name = "lblTitle3";
            this.lblTitle3.Size = new System.Drawing.Size(150, 25);
            this.lblTitle3.TabIndex = 12;
            this.lblTitle3.Text = "Price of the room";
            // 
            // txtNumPeople
            // 
            this.txtNumPeople.Location = new System.Drawing.Point(177, 138);
            this.txtNumPeople.Name = "txtNumPeople";
            this.txtNumPeople.Size = new System.Drawing.Size(150, 31);
            this.txtNumPeople.TabIndex = 13;
            // 
            // txtPriceRoom
            // 
            this.txtPriceRoom.Location = new System.Drawing.Point(177, 190);
            this.txtPriceRoom.Name = "txtPriceRoom";
            this.txtPriceRoom.Size = new System.Drawing.Size(150, 31);
            this.txtPriceRoom.TabIndex = 14;
            // 
            // txtExtra
            // 
            this.txtExtra.Location = new System.Drawing.Point(177, 240);
            this.txtExtra.Name = "txtExtra";
            this.txtExtra.Size = new System.Drawing.Size(150, 31);
            this.txtExtra.TabIndex = 15;
            // 
            // Emails
            // 
            this.Emails.FormattingEnabled = true;
            this.Emails.ItemHeight = 25;
            this.Emails.Location = new System.Drawing.Point(419, 196);
            this.Emails.Name = "Emails";
            this.Emails.Size = new System.Drawing.Size(318, 129);
            this.Emails.TabIndex = 16;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(419, 83);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(166, 31);
            this.txtEmail.TabIndex = 17;
            // 
            // lblOutputDiscount
            // 
            this.lblOutputDiscount.AutoSize = true;
            this.lblOutputDiscount.Location = new System.Drawing.Point(12, 351);
            this.lblOutputDiscount.Name = "lblOutputDiscount";
            this.lblOutputDiscount.Size = new System.Drawing.Size(82, 25);
            this.lblOutputDiscount.TabIndex = 18;
            this.lblOutputDiscount.Text = "Discount";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(419, 362);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(166, 34);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Enter Amounts";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 300);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(119, 25);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "Total Amount";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblOutputDiscount);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.Emails);
            this.Controls.Add(this.txtExtra);
            this.Controls.Add(this.txtPriceRoom);
            this.Controls.Add(this.txtNumPeople);
            this.Controls.Add(this.lblTitle3);
            this.Controls.Add(this.lblTitle4);
            this.Controls.Add(this.lblTitle2);
            this.Controls.Add(this.lblTitle1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.txtNumberNights);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnAmount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAmount;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtNumberNights;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Label lblTitle4;
        private System.Windows.Forms.Label lblTitle3;
        private System.Windows.Forms.TextBox txtNumPeople;
        private System.Windows.Forms.TextBox txtPriceRoom;
        private System.Windows.Forms.TextBox txtExtra;
        private System.Windows.Forms.ListBox Emails;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblOutputDiscount;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
    }
}

