
namespace Inventory_Management_System
{
    partial class User_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Login));
            this.txtbxpassword = new System.Windows.Forms.TextBox();
            this.Lbusername = new System.Windows.Forms.Label();
            this.Lbpassword = new System.Windows.Forms.Label();
            this.txtbxusername = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbuserlogin = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbxpassword
            // 
            this.txtbxpassword.Location = new System.Drawing.Point(106, 38);
            this.txtbxpassword.Name = "txtbxpassword";
            this.txtbxpassword.PasswordChar = '*';
            this.txtbxpassword.Size = new System.Drawing.Size(202, 20);
            this.txtbxpassword.TabIndex = 2;
            // 
            // Lbusername
            // 
            this.Lbusername.AutoSize = true;
            this.Lbusername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbusername.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Lbusername.Location = new System.Drawing.Point(3, 0);
            this.Lbusername.Name = "Lbusername";
            this.Lbusername.Size = new System.Drawing.Size(73, 19);
            this.Lbusername.TabIndex = 3;
            this.Lbusername.Text = "Username:";
            // 
            // Lbpassword
            // 
            this.Lbpassword.AutoSize = true;
            this.Lbpassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbpassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Lbpassword.Location = new System.Drawing.Point(3, 35);
            this.Lbpassword.Name = "Lbpassword";
            this.Lbpassword.Size = new System.Drawing.Size(72, 19);
            this.Lbpassword.TabIndex = 4;
            this.Lbpassword.Text = "Password:";
            this.Lbpassword.Click += new System.EventHandler(this.Lbpassword_Click);
            // 
            // txtbxusername
            // 
            this.txtbxusername.Location = new System.Drawing.Point(106, 3);
            this.txtbxusername.Name = "txtbxusername";
            this.txtbxusername.Size = new System.Drawing.Size(202, 20);
            this.txtbxusername.TabIndex = 1;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnlogin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(3, 3);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(125, 38);
            this.btnlogin.TabIndex = 5;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnexit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(174, 3);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(131, 38);
            this.btnexit.TabIndex = 6;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.48505F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.51495F));
            this.tableLayoutPanel1.Controls.Add(this.btnlogin, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnexit, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(44, 146);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(314, 48);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.9403F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.0597F));
            this.tableLayoutPanel2.Controls.Add(this.Lbpassword, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Lbusername, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtbxusername, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtbxpassword, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(37, 52);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(324, 71);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // lbuserlogin
            // 
            this.lbuserlogin.AutoSize = true;
            this.lbuserlogin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbuserlogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbuserlogin.Location = new System.Drawing.Point(33, 9);
            this.lbuserlogin.Name = "lbuserlogin";
            this.lbuserlogin.Size = new System.Drawing.Size(100, 22);
            this.lbuserlogin.TabIndex = 8;
            this.lbuserlogin.Text = "User Login";
            // 
            // User_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(407, 196);
            this.Controls.Add(this.lbuserlogin);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "User_Login";
            this.Text = "User Login";
            this.Load += new System.EventHandler(this.User_Login_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxpassword;
        private System.Windows.Forms.Label Lbusername;
        private System.Windows.Forms.Label Lbpassword;
        private System.Windows.Forms.TextBox txtbxusername;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbuserlogin;
    }
}