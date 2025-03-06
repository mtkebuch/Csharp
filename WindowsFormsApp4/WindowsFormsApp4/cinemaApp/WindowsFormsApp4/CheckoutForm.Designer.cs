using System.Windows.Forms;
namespace WindowsFormsApp4
{
    partial class CheckoutForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelMoviePrice;
        private Label labelTotalPrice;
        private NumericUpDown numericUpDownTickets;
        private Button buttonApplyPromoCode;
        private TextBox textBoxPromoCode;
        private Button buttonCompletePurchase;
        private Label labelCardInfo;
        private TextBox textBoxCardNumber;
        private TextBox textBoxCardExpiry;
        private TextBox textBoxCardCVC;
        private Label labelCardNumber;
        private Label labelCardExpiry;
        private Label labelCardCVC;
        private Label labelPromoCodeHint; 

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelMoviePrice = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.numericUpDownTickets = new System.Windows.Forms.NumericUpDown();
            this.buttonApplyPromoCode = new System.Windows.Forms.Button();
            this.textBoxPromoCode = new System.Windows.Forms.TextBox();
            this.buttonCompletePurchase = new System.Windows.Forms.Button();
            this.labelCardInfo = new System.Windows.Forms.Label();
            this.textBoxCardNumber = new System.Windows.Forms.TextBox();
            this.textBoxCardExpiry = new System.Windows.Forms.TextBox();
            this.textBoxCardCVC = new System.Windows.Forms.TextBox();
            this.labelCardNumber = new System.Windows.Forms.Label();
            this.labelCardExpiry = new System.Windows.Forms.Label();
            this.labelCardCVC = new System.Windows.Forms.Label();
            this.labelPromoCodeHint = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMoviePrice
            // 
            this.labelMoviePrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoviePrice.ForeColor = System.Drawing.Color.DarkRed;
            this.labelMoviePrice.Location = new System.Drawing.Point(8, 11);
            this.labelMoviePrice.Name = "labelMoviePrice";
            this.labelMoviePrice.Size = new System.Drawing.Size(416, 41);
            this.labelMoviePrice.TabIndex = 1;
            this.labelMoviePrice.Text = "Price ";
            this.labelMoviePrice.Click += new System.EventHandler(this.labelMoviePrice_Click);
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPrice.ForeColor = System.Drawing.Color.DarkRed;
            this.labelTotalPrice.Location = new System.Drawing.Point(8, 77);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(417, 32);
            this.labelTotalPrice.TabIndex = 3;
            this.labelTotalPrice.Text = "Total: $0.00";
            this.labelTotalPrice.Click += new System.EventHandler(this.labelTotalPrice_Click);
            // 
            // numericUpDownTickets
            // 
            this.numericUpDownTickets.BackColor = System.Drawing.Color.MistyRose;
            this.numericUpDownTickets.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownTickets.ForeColor = System.Drawing.Color.DarkRed;
            this.numericUpDownTickets.Location = new System.Drawing.Point(12, 34);
            this.numericUpDownTickets.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownTickets.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTickets.Name = "numericUpDownTickets";
            this.numericUpDownTickets.Size = new System.Drawing.Size(220, 32);
            this.numericUpDownTickets.TabIndex = 2;
            this.numericUpDownTickets.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTickets.ValueChanged += new System.EventHandler(this.NumericUpDownTickets_ValueChanged);
            // 
            // buttonApplyPromoCode
            // 
            this.buttonApplyPromoCode.BackColor = System.Drawing.Color.White;
            this.buttonApplyPromoCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonApplyPromoCode.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApplyPromoCode.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonApplyPromoCode.Location = new System.Drawing.Point(12, 198);
            this.buttonApplyPromoCode.Name = "buttonApplyPromoCode";
            this.buttonApplyPromoCode.Size = new System.Drawing.Size(220, 35);
            this.buttonApplyPromoCode.TabIndex = 5;
            this.buttonApplyPromoCode.Text = "Apply Promo Code";
            this.buttonApplyPromoCode.UseVisualStyleBackColor = false;
            this.buttonApplyPromoCode.Click += new System.EventHandler(this.buttonApplyPromoCode_Click);
            // 
            // textBoxPromoCode
            // 
            this.textBoxPromoCode.BackColor = System.Drawing.Color.MistyRose;
            this.textBoxPromoCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPromoCode.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPromoCode.Location = new System.Drawing.Point(12, 149);
            this.textBoxPromoCode.Name = "textBoxPromoCode";
            this.textBoxPromoCode.Size = new System.Drawing.Size(343, 32);
            this.textBoxPromoCode.TabIndex = 1;
            this.textBoxPromoCode.TextChanged += new System.EventHandler(this.textBoxPromoCode_TextChanged_1);
            // 
            // buttonCompletePurchase
            // 
            this.buttonCompletePurchase.BackColor = System.Drawing.Color.White;
            this.buttonCompletePurchase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCompletePurchase.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCompletePurchase.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonCompletePurchase.Location = new System.Drawing.Point(12, 538);
            this.buttonCompletePurchase.Name = "buttonCompletePurchase";
            this.buttonCompletePurchase.Size = new System.Drawing.Size(251, 38);
            this.buttonCompletePurchase.TabIndex = 6;
            this.buttonCompletePurchase.Text = "Complete Purchase";
            this.buttonCompletePurchase.UseVisualStyleBackColor = false;
            this.buttonCompletePurchase.Click += new System.EventHandler(this.buttonCompletePurchase_Click);
            // 
            // labelCardInfo
            // 
            this.labelCardInfo.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCardInfo.ForeColor = System.Drawing.Color.Crimson;
            this.labelCardInfo.Location = new System.Drawing.Point(4, 246);
            this.labelCardInfo.Name = "labelCardInfo";
            this.labelCardInfo.Size = new System.Drawing.Size(334, 50);
            this.labelCardInfo.TabIndex = 7;
            this.labelCardInfo.Text = "Enter Card Info";
            this.labelCardInfo.Click += new System.EventHandler(this.labelCardInfo_Click);
            // 
            // textBoxCardNumber
            // 
            this.textBoxCardNumber.BackColor = System.Drawing.Color.MistyRose;
            this.textBoxCardNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCardNumber.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCardNumber.Location = new System.Drawing.Point(12, 327);
            this.textBoxCardNumber.Name = "textBoxCardNumber";
            this.textBoxCardNumber.Size = new System.Drawing.Size(343, 32);
            this.textBoxCardNumber.TabIndex = 9;
            this.textBoxCardNumber.TextChanged += new System.EventHandler(this.textBoxCardNumber_TextChanged);
            // 
            // textBoxCardExpiry
            // 
            this.textBoxCardExpiry.BackColor = System.Drawing.Color.MistyRose;
            this.textBoxCardExpiry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCardExpiry.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCardExpiry.Location = new System.Drawing.Point(12, 408);
            this.textBoxCardExpiry.Name = "textBoxCardExpiry";
            this.textBoxCardExpiry.Size = new System.Drawing.Size(83, 32);
            this.textBoxCardExpiry.TabIndex = 10;
            this.textBoxCardExpiry.TextChanged += new System.EventHandler(this.textBoxCardExpiry_TextChanged);
            // 
            // textBoxCardCVC
            // 
            this.textBoxCardCVC.BackColor = System.Drawing.Color.MistyRose;
            this.textBoxCardCVC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCardCVC.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCardCVC.Location = new System.Drawing.Point(12, 483);
            this.textBoxCardCVC.Name = "textBoxCardCVC";
            this.textBoxCardCVC.Size = new System.Drawing.Size(83, 32);
            this.textBoxCardCVC.TabIndex = 11;
            this.textBoxCardCVC.TextChanged += new System.EventHandler(this.textBoxCardCVC_TextChanged);
            // 
            // labelCardNumber
            // 
            this.labelCardNumber.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCardNumber.ForeColor = System.Drawing.Color.DarkRed;
            this.labelCardNumber.Location = new System.Drawing.Point(8, 296);
            this.labelCardNumber.Name = "labelCardNumber";
            this.labelCardNumber.Size = new System.Drawing.Size(475, 28);
            this.labelCardNumber.TabIndex = 12;
            this.labelCardNumber.Text = "Card Number";
            this.labelCardNumber.Click += new System.EventHandler(this.labelCardNumber_Click);
            // 
            // labelCardExpiry
            // 
            this.labelCardExpiry.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCardExpiry.ForeColor = System.Drawing.Color.DarkRed;
            this.labelCardExpiry.Location = new System.Drawing.Point(8, 367);
            this.labelCardExpiry.Name = "labelCardExpiry";
            this.labelCardExpiry.Size = new System.Drawing.Size(347, 26);
            this.labelCardExpiry.TabIndex = 13;
            this.labelCardExpiry.Text = "Expiry (MM/YY)";
            this.labelCardExpiry.Click += new System.EventHandler(this.labelCardExpiry_Click);
            // 
            // labelCardCVC
            // 
            this.labelCardCVC.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCardCVC.ForeColor = System.Drawing.Color.DarkRed;
            this.labelCardCVC.Location = new System.Drawing.Point(13, 448);
            this.labelCardCVC.Name = "labelCardCVC";
            this.labelCardCVC.Size = new System.Drawing.Size(255, 32);
            this.labelCardCVC.TabIndex = 14;
            this.labelCardCVC.Text = "CVC";
            this.labelCardCVC.Click += new System.EventHandler(this.labelCardCVC_Click);
            // 
            // labelPromoCodeHint
            // 
            this.labelPromoCodeHint.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPromoCodeHint.ForeColor = System.Drawing.Color.DarkRed;
            this.labelPromoCodeHint.Location = new System.Drawing.Point(8, 109);
            this.labelPromoCodeHint.Name = "labelPromoCodeHint";
            this.labelPromoCodeHint.Size = new System.Drawing.Size(520, 27);
            this.labelPromoCodeHint.TabIndex = 15;
            this.labelPromoCodeHint.Text = "Promo code: DISCOUNT10 for 10% off";
            this.labelPromoCodeHint.Click += new System.EventHandler(this.labelPromoCodeHint_Click_1);
            // 
            // CheckoutForm
            // 
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(403, 602);
            this.Controls.Add(this.labelCardCVC);
            this.Controls.Add(this.labelCardExpiry);
            this.Controls.Add(this.labelCardNumber);
            this.Controls.Add(this.textBoxCardCVC);
            this.Controls.Add(this.textBoxCardExpiry);
            this.Controls.Add(this.textBoxCardNumber);
            this.Controls.Add(this.labelCardInfo);
            this.Controls.Add(this.buttonCompletePurchase);
            this.Controls.Add(this.textBoxPromoCode);
            this.Controls.Add(this.buttonApplyPromoCode);
            this.Controls.Add(this.numericUpDownTickets);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.labelMoviePrice);
            this.Controls.Add(this.labelPromoCodeHint);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CheckoutForm";
            this.Load += new System.EventHandler(this.CheckoutForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}