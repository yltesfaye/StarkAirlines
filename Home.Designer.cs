namespace StarkAirlines
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Flights = new System.Windows.Forms.Button();
            this.Passengers = new System.Windows.Forms.Button();
            this.Tickets = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 375);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(530, 75);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 144);
            this.panel1.TabIndex = 2;
            // 
            // Flights
            // 
            this.Flights.Location = new System.Drawing.Point(29, 305);
            this.Flights.Name = "Flights";
            this.Flights.Size = new System.Drawing.Size(96, 37);
            this.Flights.TabIndex = 0;
            this.Flights.Text = "Flights";
            this.Flights.UseVisualStyleBackColor = true;
            this.Flights.Click += new System.EventHandler(this.Flights_Click);
            // 
            // Passengers
            // 
            this.Passengers.Location = new System.Drawing.Point(147, 305);
            this.Passengers.Name = "Passengers";
            this.Passengers.Size = new System.Drawing.Size(96, 37);
            this.Passengers.TabIndex = 4;
            this.Passengers.Text = "Passengers";
            this.Passengers.UseVisualStyleBackColor = true;
            this.Passengers.Click += new System.EventHandler(this.Passengers_Click);
            // 
            // Tickets
            // 
            this.Tickets.Location = new System.Drawing.Point(263, 305);
            this.Tickets.Name = "Tickets";
            this.Tickets.Size = new System.Drawing.Size(96, 37);
            this.Tickets.TabIndex = 5;
            this.Tickets.Text = "Tickets";
            this.Tickets.UseVisualStyleBackColor = true;
            this.Tickets.Click += new System.EventHandler(this.Tickets_click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(384, 305);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 37);
            this.button4.TabIndex = 6;
            this.button4.Text = "Cancellation";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Cancel_click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(530, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Tickets);
            this.Controls.Add(this.Passengers);
            this.Controls.Add(this.Flights);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Flights;
        private System.Windows.Forms.Button Passengers;
        private System.Windows.Forms.Button Tickets;
        private System.Windows.Forms.Button button4;
    }
}