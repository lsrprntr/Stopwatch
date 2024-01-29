namespace Stopwatch
{
    partial class Stopwatch
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
            this.components = new System.ComponentModel.Container();
            this.watchLabel = new System.Windows.Forms.Label();
            this.startbutton = new System.Windows.Forms.Button();
            this.stopbutton = new System.Windows.Forms.Button();
            this.resetbutton = new System.Windows.Forms.Button();
            this.formTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // watchLabel
            // 
            this.watchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watchLabel.Location = new System.Drawing.Point(12, 102);
            this.watchLabel.Name = "watchLabel";
            this.watchLabel.Size = new System.Drawing.Size(471, 122);
            this.watchLabel.TabIndex = 0;
            this.watchLabel.Text = "00:00.00";
            this.watchLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // startbutton
            // 
            this.startbutton.BackColor = System.Drawing.Color.White;
            this.startbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startbutton.Location = new System.Drawing.Point(44, 256);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(130, 87);
            this.startbutton.TabIndex = 1;
            this.startbutton.Text = "Start";
            this.startbutton.UseVisualStyleBackColor = false;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // stopbutton
            // 
            this.stopbutton.BackColor = System.Drawing.Color.White;
            this.stopbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopbutton.Location = new System.Drawing.Point(180, 256);
            this.stopbutton.Name = "stopbutton";
            this.stopbutton.Size = new System.Drawing.Size(130, 87);
            this.stopbutton.TabIndex = 2;
            this.stopbutton.Text = "Stop";
            this.stopbutton.UseVisualStyleBackColor = false;
            this.stopbutton.Click += new System.EventHandler(this.stopbutton_Click);
            // 
            // resetbutton
            // 
            this.resetbutton.BackColor = System.Drawing.Color.White;
            this.resetbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetbutton.Location = new System.Drawing.Point(316, 256);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(130, 87);
            this.resetbutton.TabIndex = 3;
            this.resetbutton.Text = "Reset";
            this.resetbutton.UseVisualStyleBackColor = false;
            this.resetbutton.Click += new System.EventHandler(this.resetbutton_Click);
            // 
            // formTimer
            // 
            this.formTimer.Interval = 10;
            this.formTimer.Tick += new System.EventHandler(this.formTimer_Tick);
            // 
            // Stopwatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(495, 450);
            this.Controls.Add(this.resetbutton);
            this.Controls.Add(this.stopbutton);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.watchLabel);
            this.Name = "Stopwatch";
            this.Text = "Stopwatch";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label watchLabel;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Button stopbutton;
        private System.Windows.Forms.Button resetbutton;
        private System.Windows.Forms.Timer formTimer;
    }
}

