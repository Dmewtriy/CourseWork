namespace CourseWork1.Forms
{
    partial class RoutePointForm
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.DurationTextBox = new System.Windows.Forms.TextBox();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.HotelNameTextBox = new System.Windows.Forms.TextBox();
            this.HotelNameLabel = new System.Windows.Forms.Label();
            this.HotelClassTextBox = new System.Windows.Forms.TextBox();
            this.HotelClassLabel = new System.Windows.Forms.Label();
            this.ExcursionsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(45, 62);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(72, 17);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Название";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(227, 61);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(200, 20);
            this.NameTextBox.TabIndex = 4;
            // 
            // DurationTextBox
            // 
            this.DurationTextBox.Location = new System.Drawing.Point(227, 104);
            this.DurationTextBox.Name = "DurationTextBox";
            this.DurationTextBox.Size = new System.Drawing.Size(200, 20);
            this.DurationTextBox.TabIndex = 4;
            // 
            // DurationLabel
            // 
            this.DurationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DurationLabel.Location = new System.Drawing.Point(12, 95);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(187, 39);
            this.DurationLabel.TabIndex = 5;
            this.DurationLabel.Text = "Длительность пребывания (в днях)";
            // 
            // HotelNameTextBox
            // 
            this.HotelNameTextBox.Location = new System.Drawing.Point(227, 151);
            this.HotelNameTextBox.Name = "HotelNameTextBox";
            this.HotelNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.HotelNameTextBox.TabIndex = 4;
            // 
            // HotelNameLabel
            // 
            this.HotelNameLabel.AutoSize = true;
            this.HotelNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HotelNameLabel.Location = new System.Drawing.Point(45, 152);
            this.HotelNameLabel.Name = "HotelNameLabel";
            this.HotelNameLabel.Size = new System.Drawing.Size(115, 17);
            this.HotelNameLabel.TabIndex = 5;
            this.HotelNameLabel.Text = "Название отеля";
            // 
            // HotelClassTextBox
            // 
            this.HotelClassTextBox.Location = new System.Drawing.Point(227, 210);
            this.HotelClassTextBox.Name = "HotelClassTextBox";
            this.HotelClassTextBox.Size = new System.Drawing.Size(200, 20);
            this.HotelClassTextBox.TabIndex = 4;
            // 
            // HotelClassLabel
            // 
            this.HotelClassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HotelClassLabel.Location = new System.Drawing.Point(45, 201);
            this.HotelClassLabel.Name = "HotelClassLabel";
            this.HotelClassLabel.Size = new System.Drawing.Size(154, 41);
            this.HotelClassLabel.TabIndex = 5;
            this.HotelClassLabel.Text = "Класс отеля (количество звёзд)";
            // 
            // ExcursionsLabel
            // 
            this.ExcursionsLabel.AutoSize = true;
            this.ExcursionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExcursionsLabel.Location = new System.Drawing.Point(489, 20);
            this.ExcursionsLabel.Name = "ExcursionsLabel";
            this.ExcursionsLabel.Size = new System.Drawing.Size(125, 17);
            this.ExcursionsLabel.TabIndex = 5;
            this.ExcursionsLabel.Text = "Список экскурсий";
            // 
            // RoutePointForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DurationLabel);
            this.Controls.Add(this.HotelClassLabel);
            this.Controls.Add(this.HotelNameLabel);
            this.Controls.Add(this.ExcursionsLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.DurationTextBox);
            this.Controls.Add(this.HotelClassTextBox);
            this.Controls.Add(this.HotelNameTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Name = "RoutePointForm";
            this.Text = "RoutePointForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox DurationTextBox;
        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.TextBox HotelNameTextBox;
        private System.Windows.Forms.Label HotelNameLabel;
        private System.Windows.Forms.TextBox HotelClassTextBox;
        private System.Windows.Forms.Label HotelClassLabel;
        private System.Windows.Forms.Label ExcursionsLabel;
    }
}