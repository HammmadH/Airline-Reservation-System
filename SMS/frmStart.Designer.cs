
namespace AMS
{
    partial class frmStart
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
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnPassenger = new System.Windows.Forms.Button();
            this.lblReg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEmployee
            // 
            this.btnEmployee.Location = new System.Drawing.Point(138, 127);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnEmployee.TabIndex = 22;
            this.btnEmployee.Text = "&Employee";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnPassenger
            // 
            this.btnPassenger.Location = new System.Drawing.Point(138, 187);
            this.btnPassenger.Name = "btnPassenger";
            this.btnPassenger.Size = new System.Drawing.Size(75, 23);
            this.btnPassenger.TabIndex = 23;
            this.btnPassenger.Text = "&Passenger";
            this.btnPassenger.UseVisualStyleBackColor = true;
            this.btnPassenger.Click += new System.EventHandler(this.btnPassenger_Click);
            // 
            // lblReg
            // 
            this.lblReg.AutoSize = true;
            this.lblReg.Location = new System.Drawing.Point(135, 42);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(63, 13);
            this.lblReg.TabIndex = 26;
            this.lblReg.Text = "Registration";
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 450);
            this.Controls.Add(this.lblReg);
            this.Controls.Add(this.btnPassenger);
            this.Controls.Add(this.btnEmployee);
            this.Name = "frmStart";
            this.Text = "frmStart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnPassenger;
        private System.Windows.Forms.Label lblReg;
    }
}