
namespace AMS
{
    partial class frmEmployee
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
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEmployeePhNumber = new System.Windows.Forms.Label();
            this.txtEmployeePhNumber = new System.Windows.Forms.TextBox();
            this.lblEmployeeGender = new System.Windows.Forms.Label();
            this.lblEmployeeAge = new System.Windows.Forms.Label();
            this.txtEmployeeGender = new System.Windows.Forms.TextBox();
            this.txtEmployeeAge = new System.Windows.Forms.TextBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblEmployeeCNIC = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtEmployeeCNIC = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lblback = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(90, 88);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(18, 13);
            this.lblEmployeeID.TabIndex = 36;
            this.lblEmployeeID.Text = "ID";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(174, 85);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeID.TabIndex = 35;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(141, 333);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(236, 333);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 33;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Freestyle Script", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(91, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 32);
            this.label4.TabIndex = 32;
            this.label4.Text = "Employee Form";
            // 
            // lblEmployeePhNumber
            // 
            this.lblEmployeePhNumber.AutoSize = true;
            this.lblEmployeePhNumber.Location = new System.Drawing.Point(80, 301);
            this.lblEmployeePhNumber.Name = "lblEmployeePhNumber";
            this.lblEmployeePhNumber.Size = new System.Drawing.Size(78, 13);
            this.lblEmployeePhNumber.TabIndex = 31;
            this.lblEmployeePhNumber.Text = "Phone Number";
            // 
            // txtEmployeePhNumber
            // 
            this.txtEmployeePhNumber.Location = new System.Drawing.Point(174, 298);
            this.txtEmployeePhNumber.Name = "txtEmployeePhNumber";
            this.txtEmployeePhNumber.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeePhNumber.TabIndex = 30;
            // 
            // lblEmployeeGender
            // 
            this.lblEmployeeGender.AutoSize = true;
            this.lblEmployeeGender.Location = new System.Drawing.Point(90, 254);
            this.lblEmployeeGender.Name = "lblEmployeeGender";
            this.lblEmployeeGender.Size = new System.Drawing.Size(42, 13);
            this.lblEmployeeGender.TabIndex = 29;
            this.lblEmployeeGender.Text = "Gender";
            // 
            // lblEmployeeAge
            // 
            this.lblEmployeeAge.AutoSize = true;
            this.lblEmployeeAge.Location = new System.Drawing.Point(90, 212);
            this.lblEmployeeAge.Name = "lblEmployeeAge";
            this.lblEmployeeAge.Size = new System.Drawing.Size(26, 13);
            this.lblEmployeeAge.TabIndex = 28;
            this.lblEmployeeAge.Text = "Age";
            // 
            // txtEmployeeGender
            // 
            this.txtEmployeeGender.Location = new System.Drawing.Point(174, 251);
            this.txtEmployeeGender.Name = "txtEmployeeGender";
            this.txtEmployeeGender.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeGender.TabIndex = 27;
            // 
            // txtEmployeeAge
            // 
            this.txtEmployeeAge.Location = new System.Drawing.Point(174, 209);
            this.txtEmployeeAge.Name = "txtEmployeeAge";
            this.txtEmployeeAge.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeAge.TabIndex = 26;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(80, 165);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(88, 13);
            this.lblEmployeeName.TabIndex = 25;
            this.lblEmployeeName.Text = "Passenger Name";
            // 
            // lblEmployeeCNIC
            // 
            this.lblEmployeeCNIC.AutoSize = true;
            this.lblEmployeeCNIC.Location = new System.Drawing.Point(90, 123);
            this.lblEmployeeCNIC.Name = "lblEmployeeCNIC";
            this.lblEmployeeCNIC.Size = new System.Drawing.Size(32, 13);
            this.lblEmployeeCNIC.TabIndex = 24;
            this.lblEmployeeCNIC.Text = "CNIC";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(174, 162);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeName.TabIndex = 23;
            // 
            // txtEmployeeCNIC
            // 
            this.txtEmployeeCNIC.Location = new System.Drawing.Point(174, 120);
            this.txtEmployeeCNIC.Name = "txtEmployeeCNIC";
            this.txtEmployeeCNIC.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeCNIC.TabIndex = 22;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(46, 333);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 21;
            this.btnInsert.Text = "&Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lblback
            // 
            this.lblback.AutoSize = true;
            this.lblback.BackColor = System.Drawing.SystemColors.InfoText;
            this.lblback.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblback.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblback.Location = new System.Drawing.Point(288, 9);
            this.lblback.Name = "lblback";
            this.lblback.Size = new System.Drawing.Size(57, 22);
            this.lblback.TabIndex = 125;
            this.lblback.Text = "BACK";
            this.lblback.Click += new System.EventHandler(this.lblback_Click);
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 406);
            this.Controls.Add(this.lblback);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblEmployeePhNumber);
            this.Controls.Add(this.txtEmployeePhNumber);
            this.Controls.Add(this.lblEmployeeGender);
            this.Controls.Add(this.lblEmployeeAge);
            this.Controls.Add(this.txtEmployeeGender);
            this.Controls.Add(this.txtEmployeeAge);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.lblEmployeeCNIC);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.txtEmployeeCNIC);
            this.Controls.Add(this.btnInsert);
            this.Name = "frmEmployee";
            this.Text = "frmEmployee";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEmployeePhNumber;
        private System.Windows.Forms.TextBox txtEmployeePhNumber;
        private System.Windows.Forms.Label lblEmployeeGender;
        private System.Windows.Forms.Label lblEmployeeAge;
        private System.Windows.Forms.TextBox txtEmployeeGender;
        private System.Windows.Forms.TextBox txtEmployeeAge;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblEmployeeCNIC;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeCNIC;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label lblback;
    }
}