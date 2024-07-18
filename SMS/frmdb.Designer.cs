
namespace AMS
{
    partial class frmdb
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
            this.cboServer = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.lblpass = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.lbldb = new System.Windows.Forms.Label();
            this.lblserver = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboServer
            // 
            this.cboServer.FormattingEnabled = true;
            this.cboServer.Location = new System.Drawing.Point(364, 130);
            this.cboServer.Name = "cboServer";
            this.cboServer.Size = new System.Drawing.Size(138, 21);
            this.cboServer.TabIndex = 19;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(380, 298);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 18;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(364, 248);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(138, 20);
            this.txtpass.TabIndex = 17;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(364, 208);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(138, 20);
            this.txtUser.TabIndex = 16;
            // 
            // txtDB
            // 
            this.txtDB.Location = new System.Drawing.Point(364, 173);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(138, 20);
            this.txtDB.TabIndex = 15;
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Location = new System.Drawing.Point(298, 251);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(53, 13);
            this.lblpass.TabIndex = 14;
            this.lblpass.Text = "Password";
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Location = new System.Drawing.Point(298, 211);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(57, 13);
            this.lbluser.TabIndex = 13;
            this.lbluser.Text = "UserName";
            // 
            // lbldb
            // 
            this.lbldb.AutoSize = true;
            this.lbldb.Location = new System.Drawing.Point(298, 176);
            this.lbldb.Name = "lbldb";
            this.lbldb.Size = new System.Drawing.Size(57, 13);
            this.lbldb.TabIndex = 12;
            this.lbldb.Text = "DataBase ";
            // 
            // lblserver
            // 
            this.lblserver.AutoSize = true;
            this.lblserver.Location = new System.Drawing.Point(286, 133);
            this.lblserver.Name = "lblserver";
            this.lblserver.Size = new System.Drawing.Size(69, 13);
            this.lblserver.TabIndex = 11;
            this.lblserver.Text = "Server Name";
            // 
            // frmdb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboServer);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtDB);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.lbldb);
            this.Controls.Add(this.lblserver);
            this.Name = "frmdb";
            this.Text = "frmdb";
            this.Load += new System.EventHandler(this.frmdb_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboServer;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtDB;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label lbldb;
        private System.Windows.Forms.Label lblserver;
    }
}