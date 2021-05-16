
namespace Inventory_Management_System
{
    partial class Add_or_Delete_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_or_Delete_User));
            this.lbuserlog = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gvadddeleteuser = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.lbFirstNm = new System.Windows.Forms.Label();
            this.lbLastNm = new System.Windows.Forms.Label();
            this.lbUserNm = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbCfmPswrd = new System.Windows.Forms.Label();
            this.lbRole = new System.Windows.Forms.Label();
            this.combobxRole = new System.Windows.Forms.ComboBox();
            this.txtUserNm = new System.Windows.Forms.TextBox();
            this.txtFirstNm = new System.Windows.Forms.TextBox();
            this.txtPswrd = new System.Windows.Forms.TextBox();
            this.txtLastNm = new System.Windows.Forms.TextBox();
            this.txtCfmpswrd = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbmatch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvadddeleteuser)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbuserlog
            // 
            this.lbuserlog.AutoSize = true;
            this.lbuserlog.Location = new System.Drawing.Point(14, 37);
            this.lbuserlog.Name = "lbuserlog";
            this.lbuserlog.Size = new System.Drawing.Size(54, 13);
            this.lbuserlog.TabIndex = 85;
            this.lbuserlog.Text = "Login Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 22);
            this.label1.TabIndex = 83;
            this.label1.Text = "RSnD Inventory Management System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(380, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 22);
            this.label3.TabIndex = 84;
            this.label3.Text = "Add or Delete User";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gvadddeleteuser
            // 
            this.gvadddeleteuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvadddeleteuser.Location = new System.Drawing.Point(164, 101);
            this.gvadddeleteuser.Name = "gvadddeleteuser";
            this.gvadddeleteuser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvadddeleteuser.Size = new System.Drawing.Size(524, 168);
            this.gvadddeleteuser.TabIndex = 86;
            this.gvadddeleteuser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvadddeleteuser_CellContentClick);
            this.gvadddeleteuser.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvadddeleteuser_CellDoubleClick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.14634F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.85366F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tableLayoutPanel3.Controls.Add(this.btnAdd, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnClose, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnUpdate, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnDelete, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnReset, 3, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(146, 467);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(569, 50);
            this.tableLayoutPanel3.TabIndex = 111;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 32);
            this.btnAdd.TabIndex = 82;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.Location = new System.Drawing.Point(437, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 32);
            this.btnClose.TabIndex = 107;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.Location = new System.Drawing.Point(119, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 32);
            this.btnUpdate.TabIndex = 83;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(217, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 32);
            this.btnDelete.TabIndex = 84;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReset.Location = new System.Drawing.Point(326, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(96, 32);
            this.btnReset.TabIndex = 85;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.AutoSize = true;
            this.lblUserInfo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserInfo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblUserInfo.Location = new System.Drawing.Point(335, 272);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(191, 15);
            this.lblUserInfo.TabIndex = 112;
            this.lblUserInfo.Text = "Double click to update information";
            // 
            // lbFirstNm
            // 
            this.lbFirstNm.AutoSize = true;
            this.lbFirstNm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFirstNm.Location = new System.Drawing.Point(3, 0);
            this.lbFirstNm.Name = "lbFirstNm";
            this.lbFirstNm.Size = new System.Drawing.Size(77, 19);
            this.lbFirstNm.TabIndex = 113;
            this.lbFirstNm.Text = "First Name";
            // 
            // lbLastNm
            // 
            this.lbLastNm.AutoSize = true;
            this.lbLastNm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLastNm.Location = new System.Drawing.Point(3, 43);
            this.lbLastNm.Name = "lbLastNm";
            this.lbLastNm.Size = new System.Drawing.Size(76, 19);
            this.lbLastNm.TabIndex = 114;
            this.lbLastNm.Text = "Last Name";
            // 
            // lbUserNm
            // 
            this.lbUserNm.AutoSize = true;
            this.lbUserNm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserNm.Location = new System.Drawing.Point(3, 86);
            this.lbUserNm.Name = "lbUserNm";
            this.lbUserNm.Size = new System.Drawing.Size(79, 19);
            this.lbUserNm.TabIndex = 115;
            this.lbUserNm.Text = "User Name";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(336, 0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(69, 19);
            this.lbPassword.TabIndex = 116;
            this.lbPassword.Text = "Password";
            // 
            // lbCfmPswrd
            // 
            this.lbCfmPswrd.AutoSize = true;
            this.lbCfmPswrd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCfmPswrd.Location = new System.Drawing.Point(336, 43);
            this.lbCfmPswrd.Name = "lbCfmPswrd";
            this.lbCfmPswrd.Size = new System.Drawing.Size(122, 19);
            this.lbCfmPswrd.TabIndex = 117;
            this.lbCfmPswrd.Text = "Confirm Password";
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.Location = new System.Drawing.Point(336, 86);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(37, 19);
            this.lbRole.TabIndex = 118;
            this.lbRole.Text = "Role";
            // 
            // combobxRole
            // 
            this.combobxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobxRole.FormattingEnabled = true;
            this.combobxRole.Items.AddRange(new object[] {
            "Admin",
            "Client"});
            this.combobxRole.Location = new System.Drawing.Point(467, 89);
            this.combobxRole.Name = "combobxRole";
            this.combobxRole.Size = new System.Drawing.Size(160, 27);
            this.combobxRole.TabIndex = 119;
            // 
            // txtUserNm
            // 
            this.txtUserNm.Location = new System.Drawing.Point(109, 89);
            this.txtUserNm.Name = "txtUserNm";
            this.txtUserNm.Size = new System.Drawing.Size(180, 26);
            this.txtUserNm.TabIndex = 120;
            // 
            // txtFirstNm
            // 
            this.txtFirstNm.Location = new System.Drawing.Point(109, 3);
            this.txtFirstNm.Name = "txtFirstNm";
            this.txtFirstNm.Size = new System.Drawing.Size(180, 26);
            this.txtFirstNm.TabIndex = 121;
            // 
            // txtPswrd
            // 
            this.txtPswrd.Location = new System.Drawing.Point(467, 3);
            this.txtPswrd.Name = "txtPswrd";
            this.txtPswrd.PasswordChar = '*';
            this.txtPswrd.Size = new System.Drawing.Size(160, 26);
            this.txtPswrd.TabIndex = 122;
            // 
            // txtLastNm
            // 
            this.txtLastNm.Location = new System.Drawing.Point(109, 46);
            this.txtLastNm.Name = "txtLastNm";
            this.txtLastNm.Size = new System.Drawing.Size(180, 26);
            this.txtLastNm.TabIndex = 123;
            // 
            // txtCfmpswrd
            // 
            this.txtCfmpswrd.Location = new System.Drawing.Point(467, 46);
            this.txtCfmpswrd.Name = "txtCfmpswrd";
            this.txtCfmpswrd.PasswordChar = '*';
            this.txtCfmpswrd.Size = new System.Drawing.Size(160, 26);
            this.txtCfmpswrd.TabIndex = 124;
            this.txtCfmpswrd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCfmpswrd_KeyUp);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.82957F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.17043F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 172F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.Controls.Add(this.lbmatch, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbFirstNm, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtUserNm, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtLastNm, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCfmpswrd, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtFirstNm, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtPswrd, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbLastNm, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbPassword, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbUserNm, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbCfmPswrd, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbRole, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.combobxRole, 3, 2);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(43, 316);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(777, 131);
            this.tableLayoutPanel1.TabIndex = 125;
            // 
            // lbmatch
            // 
            this.lbmatch.AutoSize = true;
            this.lbmatch.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmatch.Location = new System.Drawing.Point(639, 43);
            this.lbmatch.Name = "lbmatch";
            this.lbmatch.Size = new System.Drawing.Size(19, 15);
            this.lbmatch.TabIndex = 126;
            this.lbmatch.Text = "....";
            // 
            // Add_or_Delete_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 558);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblUserInfo);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.gvadddeleteuser);
            this.Controls.Add(this.lbuserlog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_or_Delete_User";
            this.Text = "Add or Delete User";
            this.Load += new System.EventHandler(this.Add_or_Delete_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvadddeleteuser)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbuserlog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gvadddeleteuser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.Label lbFirstNm;
        private System.Windows.Forms.Label lbLastNm;
        private System.Windows.Forms.Label lbUserNm;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbCfmPswrd;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.ComboBox combobxRole;
        private System.Windows.Forms.TextBox txtUserNm;
        private System.Windows.Forms.TextBox txtFirstNm;
        private System.Windows.Forms.TextBox txtPswrd;
        private System.Windows.Forms.TextBox txtLastNm;
        private System.Windows.Forms.TextBox txtCfmpswrd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbmatch;
    }
}