namespace StarkAirlines
{
    partial class FlightTbl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightTbl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Fcode = new System.Windows.Forms.RichTextBox();
            this.Fseatnum = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Fsource = new System.Windows.Forms.ComboBox();
            this.Fdest = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AddFlights = new System.Windows.Forms.Button();
            this.ResetFlight = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Fdate = new System.Windows.Forms.DateTimePicker();
            this.ViewFlights = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 144);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LawnGreen;
            this.label1.Location = new System.Drawing.Point(160, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Flight Code";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LawnGreen;
            this.label2.Location = new System.Drawing.Point(160, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Source";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LawnGreen;
            this.label3.Location = new System.Drawing.Point(160, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Destination";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LawnGreen;
            this.label4.Location = new System.Drawing.Point(157, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 58);
            this.label4.TabIndex = 5;
            this.label4.Text = "Number of Seats";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Fcode
            // 
            this.Fcode.Location = new System.Drawing.Point(322, 205);
            this.Fcode.Name = "Fcode";
            this.Fcode.Size = new System.Drawing.Size(166, 30);
            this.Fcode.TabIndex = 7;
            this.Fcode.Text = "";
            // 
            // Fseatnum
            // 
            this.Fseatnum.Location = new System.Drawing.Point(322, 379);
            this.Fseatnum.Name = "Fseatnum";
            this.Fseatnum.Size = new System.Drawing.Size(166, 30);
            this.Fseatnum.TabIndex = 8;
            this.Fseatnum.Text = "";
            // 
            // Fsource
            // 
            this.Fsource.FormattingEnabled = true;
            this.Fsource.Items.AddRange(new object[] {
            "Sioux Falls"});
            this.Fsource.Location = new System.Drawing.Point(322, 261);
            this.Fsource.Name = "Fsource";
            this.Fsource.Size = new System.Drawing.Size(166, 21);
            this.Fsource.TabIndex = 9;
            // 
            // Fdest
            // 
            this.Fdest.FormattingEnabled = true;
            this.Fdest.Items.AddRange(new object[] {
            "Washington D.C.",
            "Miami",
            "Tronto",
            "Barcenola"});
            this.Fdest.Location = new System.Drawing.Point(322, 307);
            this.Fdest.Name = "Fdest";
            this.Fdest.Size = new System.Drawing.Size(166, 21);
            this.Fdest.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 144);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(151, 404);
            this.panel3.TabIndex = 11;
            // 
            // AddFlights
            // 
            this.AddFlights.BackColor = System.Drawing.Color.MediumPurple;
            this.AddFlights.Font = new System.Drawing.Font("Franklin Gothic Heavy", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFlights.ForeColor = System.Drawing.Color.DarkRed;
            this.AddFlights.Location = new System.Drawing.Point(292, 441);
            this.AddFlights.Margin = new System.Windows.Forms.Padding(0);
            this.AddFlights.Name = "AddFlights";
            this.AddFlights.Size = new System.Drawing.Size(96, 36);
            this.AddFlights.TabIndex = 0;
            this.AddFlights.Text = "Add";
            this.AddFlights.UseVisualStyleBackColor = false;
            this.AddFlights.Click += new System.EventHandler(this.button1_Click);
            // 
            // ResetFlight
            // 
            this.ResetFlight.BackColor = System.Drawing.Color.MediumPurple;
            this.ResetFlight.Font = new System.Drawing.Font("Franklin Gothic Heavy", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetFlight.ForeColor = System.Drawing.Color.DarkRed;
            this.ResetFlight.Location = new System.Drawing.Point(180, 441);
            this.ResetFlight.Margin = new System.Windows.Forms.Padding(0);
            this.ResetFlight.Name = "ResetFlight";
            this.ResetFlight.Size = new System.Drawing.Size(96, 36);
            this.ResetFlight.TabIndex = 12;
            this.ResetFlight.Text = "Reset";
            this.ResetFlight.UseVisualStyleBackColor = false;
            this.ResetFlight.Click += new System.EventHandler(this.ResetFlight_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LawnGreen;
            this.label5.Location = new System.Drawing.Point(255, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 30);
            this.label5.TabIndex = 13;
            this.label5.Text = "Add New Flights";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LawnGreen;
            this.label6.Location = new System.Drawing.Point(157, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 37);
            this.label6.TabIndex = 14;
            this.label6.Text = "TakeOfDate";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Fdate
            // 
            this.Fdate.Location = new System.Drawing.Point(322, 341);
            this.Fdate.Name = "Fdate";
            this.Fdate.Size = new System.Drawing.Size(166, 20);
            this.Fdate.TabIndex = 15;
            // 
            // ViewFlights
            // 
            this.ViewFlights.BackColor = System.Drawing.Color.MediumPurple;
            this.ViewFlights.Font = new System.Drawing.Font("Franklin Gothic Heavy", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewFlights.ForeColor = System.Drawing.Color.DarkRed;
            this.ViewFlights.Location = new System.Drawing.Point(270, 493);
            this.ViewFlights.Margin = new System.Windows.Forms.Padding(0);
            this.ViewFlights.Name = "ViewFlights";
            this.ViewFlights.Size = new System.Drawing.Size(118, 46);
            this.ViewFlights.TabIndex = 16;
            this.ViewFlights.Text = "View Flights";
            this.ViewFlights.UseVisualStyleBackColor = false;
            this.ViewFlights.Click += new System.EventHandler(this.ViewFlights_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.MediumPurple;
            this.Back.Font = new System.Drawing.Font("Franklin Gothic Heavy", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.DarkRed;
            this.Back.Location = new System.Drawing.Point(401, 441);
            this.Back.Margin = new System.Windows.Forms.Padding(0);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(96, 36);
            this.Back.TabIndex = 17;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Clikc);
            // 
            // FlightTbl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(506, 548);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.ViewFlights);
            this.Controls.Add(this.Fdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ResetFlight);
            this.Controls.Add(this.AddFlights);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Fdest);
            this.Controls.Add(this.Fsource);
            this.Controls.Add(this.Fseatnum);
            this.Controls.Add(this.Fcode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FlightTbl";
            this.Text = "Flights";
            this.Load += new System.EventHandler(this.Flights_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox Fcode;
        private System.Windows.Forms.RichTextBox Fseatnum;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox Fsource;
        private System.Windows.Forms.ComboBox Fdest;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button AddFlights;
        private System.Windows.Forms.Button ResetFlight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker Fdate;
        private System.Windows.Forms.Button ViewFlights;
        private System.Windows.Forms.Button Back;
    }
}