partial class MovieForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Forms Designer generated code

    private void InitializeComponent()
    {
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.listBoxMovies = new System.Windows.Forms.ListBox();
            this.buttonPlaceOrder = new System.Windows.Forms.Button();
            this.labelGenre = new System.Windows.Forms.Label();
            this.buttonSortByRating = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.BackColor = System.Drawing.Color.Snow;
            this.comboBoxGenre.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxGenre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGenre.ForeColor = System.Drawing.Color.Black;
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Location = new System.Drawing.Point(140, 285);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(137, 32);
            this.comboBoxGenre.TabIndex = 0;
            this.comboBoxGenre.SelectedIndexChanged += new System.EventHandler(this.comboBoxGenre_SelectedIndexChanged);
            // 
            // listBoxMovies
            // 
            this.listBoxMovies.BackColor = System.Drawing.Color.MistyRose;
            this.listBoxMovies.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMovies.ForeColor = System.Drawing.Color.DarkRed;
            this.listBoxMovies.FormattingEnabled = true;
            this.listBoxMovies.ItemHeight = 24;
            this.listBoxMovies.Location = new System.Drawing.Point(56, 12);
            this.listBoxMovies.Name = "listBoxMovies";
            this.listBoxMovies.Size = new System.Drawing.Size(296, 220);
            this.listBoxMovies.TabIndex = 1;
            this.listBoxMovies.SelectedIndexChanged += new System.EventHandler(this.listBoxMovies_SelectedIndexChanged);
            // 
            // buttonPlaceOrder
            // 
            this.buttonPlaceOrder.BackColor = System.Drawing.Color.White;
            this.buttonPlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPlaceOrder.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlaceOrder.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonPlaceOrder.Location = new System.Drawing.Point(140, 405);
            this.buttonPlaceOrder.Name = "buttonPlaceOrder";
            this.buttonPlaceOrder.Size = new System.Drawing.Size(114, 43);
            this.buttonPlaceOrder.TabIndex = 3;
            this.buttonPlaceOrder.Text = "Next";
            this.buttonPlaceOrder.UseVisualStyleBackColor = false;
            this.buttonPlaceOrder.Click += new System.EventHandler(this.buttonPlaceOrder_Click);
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.BackColor = System.Drawing.Color.Ivory;
            this.labelGenre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenre.ForeColor = System.Drawing.Color.DarkRed;
            this.labelGenre.Location = new System.Drawing.Point(68, 288);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(66, 24);
            this.labelGenre.TabIndex = 11;
            this.labelGenre.Text = "Genre:";
            // 
            // buttonSortByRating
            // 
            this.buttonSortByRating.BackColor = System.Drawing.Color.MistyRose;
            this.buttonSortByRating.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSortByRating.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSortByRating.ForeColor = System.Drawing.Color.Maroon;
            this.buttonSortByRating.Location = new System.Drawing.Point(72, 334);
            this.buttonSortByRating.Name = "buttonSortByRating";
            this.buttonSortByRating.Size = new System.Drawing.Size(236, 51);
            this.buttonSortByRating.TabIndex = 12;
            this.buttonSortByRating.Text = "Sort by Rating";
            this.buttonSortByRating.UseVisualStyleBackColor = false;
            this.buttonSortByRating.Click += new System.EventHandler(this.buttonSortByRating_Click);
            // 
            // MovieForm
            // 
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(415, 492);
            this.Controls.Add(this.buttonSortByRating);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.buttonPlaceOrder);
            this.Controls.Add(this.listBoxMovies);
            this.Controls.Add(this.comboBoxGenre);
            this.Name = "MovieForm";
            this.Text = "Movie List";
            this.Load += new System.EventHandler(this.MovieForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox comboBoxGenre;
    private System.Windows.Forms.ListBox listBoxMovies;
    private System.Windows.Forms.Button buttonPlaceOrder;
    private System.Windows.Forms.Label labelGenre;
    private System.Windows.Forms.Button buttonSortByRating;
}
