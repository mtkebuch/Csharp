using System;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class CheckoutForm : Form
    {
        public Movie SelectedMovie { get; set; }
        private decimal TotalPrice = 0m;
        private DateTimePicker dateTimePickerExpiry;

        
        public delegate void PromoCodeValidationHandler(string code);
        public event PromoCodeValidationHandler OnPromoCodeValidated;

        public delegate void TicketCountChangedHandler(int count);
        public event TicketCountChangedHandler OnTicketCountChanged;

        public CheckoutForm(Movie selectedMovie)
        {
            InitializeComponent();
            SelectedMovie = selectedMovie;

            MessageBox.Show($"Selected Movie: {SelectedMovie.Name}");

            
            OnPromoCodeValidated += OnPromoCodeValidatedHandler;
            OnTicketCountChanged += OnTicketCountChangedHandler;
        }

        private void CheckoutForm_Load(object sender, EventArgs e)
        {
            labelMoviePrice.Text = $"Price per ticket: {SelectedMovie.Price:C}";
            numericUpDownTickets.ValueChanged += NumericUpDownTickets_ValueChanged;
            InitializePaymentFields();

            labelPromoCodeHint.Text = "Promo code: DISCOUNT10 for 10% off";
        }

        private void NumericUpDownTickets_ValueChanged(object sender, EventArgs e)
        {
            int ticketCount = (int)numericUpDownTickets.Value;
            OnTicketCountChanged?.Invoke(ticketCount);  
        }

        private void buttonApplyPromoCode_Click(object sender, EventArgs e)
        {
            OnPromoCodeValidated?.Invoke(textBoxPromoCode.Text);  
        }

        private void buttonCompletePurchase_Click(object sender, EventArgs e)
        {
            if (ValidateExpiryDate())
            {
                MessageBox.Show($"Purchase successful! Total: {TotalPrice:C}");
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid expiration date.");
            }
        }

        private bool ValidateExpiryDate()
        {
            bool isDateValid = DateTime.TryParseExact(textBoxCardExpiry.Text, "MM/yy", null, System.Globalization.DateTimeStyles.None, out DateTime expiryDate);
            bool isDateInFuture = isDateValid && expiryDate > DateTime.Now;

            return isDateInFuture;
        }

        private void InitializePaymentFields()
        {
            dateTimePickerExpiry = new DateTimePicker();
            dateTimePickerExpiry.Format = DateTimePickerFormat.Custom;
            dateTimePickerExpiry.CustomFormat = "MM/yy";
            dateTimePickerExpiry.Location = new System.Drawing.Point(17, 265);
            dateTimePickerExpiry.Size = new System.Drawing.Size(100, 22);
            this.Controls.Add(dateTimePickerExpiry);
        }

        
        private void OnPromoCodeValidatedHandler(string code)
        {
            if (code == "DISCOUNT10")
            {
                TotalPrice *= 0.9m;
                labelTotalPrice.Text = $"Total after discount: {TotalPrice:C}";
                MessageBox.Show("Promo code applied!");
            }
            else
            {
                MessageBox.Show("Invalid promo code.");
            }
        }

       
        private void OnTicketCountChangedHandler(int ticketCount)
        {
            TotalPrice = SelectedMovie.Price * ticketCount;
            labelTotalPrice.Text = $"Total: {TotalPrice:C}";
        }

        private void labelPromoCodeHint_Click(object sender, EventArgs e)
        {
        }

        private void textBoxPromoCode_TextChanged(object sender, EventArgs e)
        {
        }

        private void CheckoutForm_Load_1(object sender, EventArgs e)
        {

        }

        private void labelCardNumber_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCardNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelCardExpiry_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCardExpiry_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelCardCVC_Click(object sender, EventArgs e)
        {

        }

        private void labelCardInfo_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCardCVC_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPromoCode_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void labelPromoCodeHint_Click_1(object sender, EventArgs e)
        {

        }

        private void labelTotalPrice_Click(object sender, EventArgs e)
        {

        }

        private void labelMoviePrice_Click(object sender, EventArgs e)
        {

        }
    }
}
