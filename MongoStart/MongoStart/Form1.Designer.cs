namespace MongoStart
{
    partial class Form1
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
            this.mongOn = new System.Windows.Forms.Button();
            this.mongOff = new System.Windows.Forms.Button();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mongOn
            // 
            this.mongOn.Location = new System.Drawing.Point(12, 273);
            this.mongOn.Name = "mongOn";
            this.mongOn.Size = new System.Drawing.Size(75, 23);
            this.mongOn.TabIndex = 0;
            this.mongOn.Text = "Turn It On";
            this.mongOn.UseVisualStyleBackColor = true;
            this.mongOn.Click += new System.EventHandler(this.mongOn_Click);
            // 
            // mongOff
            // 
            this.mongOff.Location = new System.Drawing.Point(600, 273);
            this.mongOff.Name = "mongOff";
            this.mongOff.Size = new System.Drawing.Size(75, 23);
            this.mongOff.TabIndex = 1;
            this.mongOff.Text = "Turn It Off";
            this.mongOff.UseVisualStyleBackColor = true;
            this.mongOff.Click += new System.EventHandler(this.mongOff_Click);
            // 
            // txtOut
            // 
            this.txtOut.Location = new System.Drawing.Point(12, 37);
            this.txtOut.Multiline = true;
            this.txtOut.Name = "txtOut";
            this.txtOut.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtOut.Size = new System.Drawing.Size(663, 200);
            this.txtOut.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Port:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(47, 6);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(70, 20);
            this.txtPort.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 308);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.mongOff);
            this.Controls.Add(this.mongOn);
            this.Name = "Form1";
            this.Text = "MongoDB Configuration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mongOn;
        private System.Windows.Forms.Button mongOff;
        private System.Windows.Forms.TextBox txtOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPort;
    }
}

