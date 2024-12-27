namespace CourseWork1.Forms
{
    partial class MainForm
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
            this.ClientsButton = new System.Windows.Forms.Button();
            this.CompanyRepresentativesButton = new System.Windows.Forms.Button();
            this.ExcursionsButton = new System.Windows.Forms.Button();
            this.PointsButton = new System.Windows.Forms.Button();
            this.RoutesButton = new System.Windows.Forms.Button();
            this.TripsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClientsButton
            // 
            this.ClientsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientsButton.Location = new System.Drawing.Point(145, 137);
            this.ClientsButton.Margin = new System.Windows.Forms.Padding(4);
            this.ClientsButton.Name = "ClientsButton";
            this.ClientsButton.Size = new System.Drawing.Size(139, 57);
            this.ClientsButton.TabIndex = 0;
            this.ClientsButton.Text = "Клиенты";
            this.ClientsButton.UseVisualStyleBackColor = true;
            this.ClientsButton.Click += new System.EventHandler(this.ClientsButtonClick);
            // 
            // CompanyRepresentativesButton
            // 
            this.CompanyRepresentativesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompanyRepresentativesButton.Location = new System.Drawing.Point(368, 137);
            this.CompanyRepresentativesButton.Margin = new System.Windows.Forms.Padding(4);
            this.CompanyRepresentativesButton.Name = "CompanyRepresentativesButton";
            this.CompanyRepresentativesButton.Size = new System.Drawing.Size(164, 57);
            this.CompanyRepresentativesButton.TabIndex = 0;
            this.CompanyRepresentativesButton.Text = "Представители компании";
            this.CompanyRepresentativesButton.UseVisualStyleBackColor = true;
            this.CompanyRepresentativesButton.Click += new System.EventHandler(this.CompanyRepresentativesButtonClick);
            // 
            // ExcursionsButton
            // 
            this.ExcursionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExcursionsButton.Location = new System.Drawing.Point(384, 249);
            this.ExcursionsButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExcursionsButton.Name = "ExcursionsButton";
            this.ExcursionsButton.Size = new System.Drawing.Size(139, 57);
            this.ExcursionsButton.TabIndex = 0;
            this.ExcursionsButton.Text = "Экскурсии";
            this.ExcursionsButton.UseVisualStyleBackColor = true;
            this.ExcursionsButton.Click += new System.EventHandler(this.ExcursionsButtonClick);
            // 
            // PointsButton
            // 
            this.PointsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PointsButton.Location = new System.Drawing.Point(610, 137);
            this.PointsButton.Margin = new System.Windows.Forms.Padding(4);
            this.PointsButton.Name = "PointsButton";
            this.PointsButton.Size = new System.Drawing.Size(139, 57);
            this.PointsButton.TabIndex = 0;
            this.PointsButton.Text = "Пункты маршрутов";
            this.PointsButton.UseVisualStyleBackColor = true;
            this.PointsButton.Click += new System.EventHandler(this.PointsButtonClick);
            // 
            // RoutesButton
            // 
            this.RoutesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoutesButton.Location = new System.Drawing.Point(145, 249);
            this.RoutesButton.Margin = new System.Windows.Forms.Padding(4);
            this.RoutesButton.Name = "RoutesButton";
            this.RoutesButton.Size = new System.Drawing.Size(139, 57);
            this.RoutesButton.TabIndex = 0;
            this.RoutesButton.Text = "Маршруты";
            this.RoutesButton.UseVisualStyleBackColor = true;
            this.RoutesButton.Click += new System.EventHandler(this.RoutesButtonClick);
            // 
            // TripsButton
            // 
            this.TripsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TripsButton.Location = new System.Drawing.Point(610, 249);
            this.TripsButton.Margin = new System.Windows.Forms.Padding(4);
            this.TripsButton.Name = "TripsButton";
            this.TripsButton.Size = new System.Drawing.Size(139, 57);
            this.TripsButton.TabIndex = 0;
            this.TripsButton.Text = "Поездки";
            this.TripsButton.UseVisualStyleBackColor = true;
            this.TripsButton.Click += new System.EventHandler(this.TripsButtonClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 453);
            this.Controls.Add(this.TripsButton);
            this.Controls.Add(this.RoutesButton);
            this.Controls.Add(this.PointsButton);
            this.Controls.Add(this.ExcursionsButton);
            this.Controls.Add(this.CompanyRepresentativesButton);
            this.Controls.Add(this.ClientsButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Главная форма";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ClientsButton;
        private System.Windows.Forms.Button CompanyRepresentativesButton;
        private System.Windows.Forms.Button ExcursionsButton;
        private System.Windows.Forms.Button PointsButton;
        private System.Windows.Forms.Button RoutesButton;
        private System.Windows.Forms.Button TripsButton;
    }
}