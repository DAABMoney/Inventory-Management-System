
namespace Inventory_Management_System
{
    partial class Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            this.lbuserlog = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gvProduct = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lbVin = new System.Windows.Forms.Label();
            this.lbCost = new System.Windows.Forms.Label();
            this.lbTransmission = new System.Windows.Forms.Label();
            this.lbPssngCapacity = new System.Windows.Forms.Label();
            this.lbMake = new System.Windows.Forms.Label();
            this.lbColour = new System.Windows.Forms.Label();
            this.lbModel = new System.Windows.Forms.Label();
            this.dptMFGDate = new System.Windows.Forms.Label();
            this.lbFuelTyp = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.DTPMfgDate = new System.Windows.Forms.DateTimePicker();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtColour = new System.Windows.Forms.TextBox();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.combobxTransmission = new System.Windows.Forms.ComboBox();
            this.combobxFuelTyp = new System.Windows.Forms.ComboBox();
            this.combobxStatus = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtVIN = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gvProduct)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lbuserlog
            // 
            this.lbuserlog.AutoSize = true;
            this.lbuserlog.Location = new System.Drawing.Point(17, 37);
            this.lbuserlog.Name = "lbuserlog";
            this.lbuserlog.Size = new System.Drawing.Size(54, 13);
            this.lbuserlog.TabIndex = 79;
            this.lbuserlog.Text = "Login Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 22);
            this.label1.TabIndex = 77;
            this.label1.Text = "RSnD Inventory Management System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(417, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 22);
            this.label3.TabIndex = 78;
            this.label3.Text = "Product Listing";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gvProduct
            // 
            this.gvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProduct.Location = new System.Drawing.Point(31, 112);
            this.gvProduct.Name = "gvProduct";
            this.gvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvProduct.Size = new System.Drawing.Size(1027, 252);
            this.gvProduct.TabIndex = 80;
            this.gvProduct.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvProduct_CellDoubleClick);
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
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.Location = new System.Drawing.Point(106, 3);
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
            this.btnDelete.Location = new System.Drawing.Point(209, 3);
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
            this.btnReset.Location = new System.Drawing.Point(321, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(96, 32);
            this.btnReset.TabIndex = 85;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lbVin
            // 
            this.lbVin.AutoSize = true;
            this.lbVin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVin.Location = new System.Drawing.Point(3, 0);
            this.lbVin.Name = "lbVin";
            this.lbVin.Size = new System.Drawing.Size(65, 19);
            this.lbVin.TabIndex = 86;
            this.lbVin.Text = "VIN No.";
            // 
            // lbCost
            // 
            this.lbCost.AutoSize = true;
            this.lbCost.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCost.Location = new System.Drawing.Point(337, 38);
            this.lbCost.Name = "lbCost";
            this.lbCost.Size = new System.Drawing.Size(38, 19);
            this.lbCost.TabIndex = 87;
            this.lbCost.Text = "Cost";
            // 
            // lbTransmission
            // 
            this.lbTransmission.AutoSize = true;
            this.lbTransmission.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTransmission.Location = new System.Drawing.Point(337, 70);
            this.lbTransmission.Name = "lbTransmission";
            this.lbTransmission.Size = new System.Drawing.Size(86, 19);
            this.lbTransmission.TabIndex = 88;
            this.lbTransmission.Text = "Transmission";
            // 
            // lbPssngCapacity
            // 
            this.lbPssngCapacity.AutoSize = true;
            this.lbPssngCapacity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPssngCapacity.Location = new System.Drawing.Point(337, 142);
            this.lbPssngCapacity.Name = "lbPssngCapacity";
            this.lbPssngCapacity.Size = new System.Drawing.Size(63, 19);
            this.lbPssngCapacity.TabIndex = 89;
            this.lbPssngCapacity.Text = "Capacity";
            // 
            // lbMake
            // 
            this.lbMake.AutoSize = true;
            this.lbMake.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMake.Location = new System.Drawing.Point(3, 106);
            this.lbMake.Name = "lbMake";
            this.lbMake.Size = new System.Drawing.Size(45, 19);
            this.lbMake.TabIndex = 90;
            this.lbMake.Text = "Make";
            // 
            // lbColour
            // 
            this.lbColour.AutoSize = true;
            this.lbColour.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbColour.Location = new System.Drawing.Point(3, 142);
            this.lbColour.Name = "lbColour";
            this.lbColour.Size = new System.Drawing.Size(51, 19);
            this.lbColour.TabIndex = 91;
            this.lbColour.Text = "Colour";
            // 
            // lbModel
            // 
            this.lbModel.AutoSize = true;
            this.lbModel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModel.Location = new System.Drawing.Point(3, 70);
            this.lbModel.Name = "lbModel";
            this.lbModel.Size = new System.Drawing.Size(49, 19);
            this.lbModel.TabIndex = 92;
            this.lbModel.Text = "Model";
            // 
            // dptMFGDate
            // 
            this.dptMFGDate.AutoSize = true;
            this.dptMFGDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dptMFGDate.Location = new System.Drawing.Point(337, 0);
            this.dptMFGDate.Name = "dptMFGDate";
            this.dptMFGDate.Size = new System.Drawing.Size(126, 19);
            this.dptMFGDate.TabIndex = 93;
            this.dptMFGDate.Text = "Manufactured Date";
            // 
            // lbFuelTyp
            // 
            this.lbFuelTyp.AutoSize = true;
            this.lbFuelTyp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFuelTyp.Location = new System.Drawing.Point(337, 106);
            this.lbFuelTyp.Name = "lbFuelTyp";
            this.lbFuelTyp.Size = new System.Drawing.Size(69, 19);
            this.lbFuelTyp.TabIndex = 94;
            this.lbFuelTyp.Text = "Fuel Type";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(3, 38);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(46, 19);
            this.lbStatus.TabIndex = 95;
            this.lbStatus.Text = "Status";
            // 
            // DTPMfgDate
            // 
            this.DTPMfgDate.Location = new System.Drawing.Point(501, 3);
            this.DTPMfgDate.Name = "DTPMfgDate";
            this.DTPMfgDate.Size = new System.Drawing.Size(200, 20);
            this.DTPMfgDate.TabIndex = 96;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(121, 73);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(185, 20);
            this.txtModel.TabIndex = 97;
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(501, 145);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(200, 20);
            this.txtCapacity.TabIndex = 98;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(501, 41);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(200, 20);
            this.txtCost.TabIndex = 99;
            this.txtCost.Validating += new System.ComponentModel.CancelEventHandler(this.txtCost_Validating);
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(121, 109);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(185, 20);
            this.txtMake.TabIndex = 100;
            // 
            // txtColour
            // 
            this.txtColour.Location = new System.Drawing.Point(121, 145);
            this.txtColour.Name = "txtColour";
            this.txtColour.Size = new System.Drawing.Size(185, 20);
            this.txtColour.TabIndex = 101;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // combobxTransmission
            // 
            this.combobxTransmission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobxTransmission.FormattingEnabled = true;
            this.combobxTransmission.Items.AddRange(new object[] {
            "Automatic",
            "Hybrid",
            "Manual"});
            this.combobxTransmission.Location = new System.Drawing.Point(501, 73);
            this.combobxTransmission.Name = "combobxTransmission";
            this.combobxTransmission.Size = new System.Drawing.Size(200, 21);
            this.combobxTransmission.TabIndex = 103;
            // 
            // combobxFuelTyp
            // 
            this.combobxFuelTyp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobxFuelTyp.FormattingEnabled = true;
            this.combobxFuelTyp.Items.AddRange(new object[] {
            "E85",
            "Ethanol",
            "Diesel",
            "Gasoline"});
            this.combobxFuelTyp.Location = new System.Drawing.Point(501, 109);
            this.combobxFuelTyp.Name = "combobxFuelTyp";
            this.combobxFuelTyp.Size = new System.Drawing.Size(200, 21);
            this.combobxFuelTyp.TabIndex = 104;
            // 
            // combobxStatus
            // 
            this.combobxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobxStatus.FormattingEnabled = true;
            this.combobxStatus.Items.AddRange(new object[] {
            "New",
            "Used"});
            this.combobxStatus.Location = new System.Drawing.Point(121, 41);
            this.combobxStatus.Name = "combobxStatus";
            this.combobxStatus.Size = new System.Drawing.Size(185, 21);
            this.combobxStatus.TabIndex = 105;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.2459F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.7541F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 276F));
            this.tableLayoutPanel1.Controls.Add(this.txtVIN, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtCapacity, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.combobxFuelTyp, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.combobxTransmission, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtCost, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtColour, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbModel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.DTPMfgDate, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtMake, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbMake, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbColour, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtModel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dptMFGDate, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbCost, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbTransmission, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbFuelTyp, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbPssngCapacity, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.combobxStatus, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbVin, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbStatus, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(96, 403);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.71429F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(775, 178);
            this.tableLayoutPanel1.TabIndex = 106;
            // 
            // txtVIN
            // 
            this.txtVIN.Location = new System.Drawing.Point(121, 3);
            this.txtVIN.Name = "txtVIN";
            this.txtVIN.Size = new System.Drawing.Size(185, 20);
            this.txtVIN.TabIndex = 110;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.Location = new System.Drawing.Point(441, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 32);
            this.btnClose.TabIndex = 107;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanel2.Controls.Add(this.btnAdd, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnClose, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnUpdate, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnDelete, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnReset, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(174, 596);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(569, 50);
            this.tableLayoutPanel2.TabIndex = 108;
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.AutoSize = true;
            this.lblUserInfo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserInfo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblUserInfo.Location = new System.Drawing.Point(400, 367);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(191, 15);
            this.lblUserInfo.TabIndex = 109;
            this.lblUserInfo.Text = "Double click to update information";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 922);
            this.Controls.Add(this.lblUserInfo);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.gvProduct);
            this.Controls.Add(this.lbuserlog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvProduct)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbuserlog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gvProduct;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lbVin;
        private System.Windows.Forms.Label lbCost;
        private System.Windows.Forms.Label lbTransmission;
        private System.Windows.Forms.Label lbPssngCapacity;
        private System.Windows.Forms.Label lbMake;
        private System.Windows.Forms.Label lbColour;
        private System.Windows.Forms.Label lbModel;
        private System.Windows.Forms.Label dptMFGDate;
        private System.Windows.Forms.Label lbFuelTyp;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.DateTimePicker DTPMfgDate;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtColour;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.ComboBox combobxTransmission;
        private System.Windows.Forms.ComboBox combobxFuelTyp;
        private System.Windows.Forms.ComboBox combobxStatus;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.TextBox txtVIN;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}