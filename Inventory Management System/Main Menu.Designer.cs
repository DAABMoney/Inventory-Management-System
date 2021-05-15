
namespace Inventory_Management_System
{
    partial class Main_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.customerRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomerRegistration = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCustomerInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductsOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddDeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lbstatus = new System.Windows.Forms.Label();
            this.btnlogout = new System.Windows.Forms.Button();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerRegistrationToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.supplierToolStripMenuItem,
            this.administratorToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip.Size = new System.Drawing.Size(1067, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // customerRegistrationToolStripMenuItem
            // 
            this.customerRegistrationToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.customerRegistrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CustomerRegistration,
            this.updateCustomerInfoToolStripMenuItem});
            this.customerRegistrationToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerRegistrationToolStripMenuItem.ForeColor = System.Drawing.SystemColors.InfoText;
            this.customerRegistrationToolStripMenuItem.Name = "customerRegistrationToolStripMenuItem";
            this.customerRegistrationToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.customerRegistrationToolStripMenuItem.Text = "Customer";
            // 
            // CustomerRegistration
            // 
            this.CustomerRegistration.BackColor = System.Drawing.SystemColors.Highlight;
            this.CustomerRegistration.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CustomerRegistration.Name = "CustomerRegistration";
            this.CustomerRegistration.Size = new System.Drawing.Size(194, 22);
            this.CustomerRegistration.Text = "Customer Registration";
            this.CustomerRegistration.Click += new System.EventHandler(this.customerRegistrationToolStripMenuItem1_Click);
            // 
            // updateCustomerInfoToolStripMenuItem
            // 
            this.updateCustomerInfoToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.updateCustomerInfoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.updateCustomerInfoToolStripMenuItem.Name = "updateCustomerInfoToolStripMenuItem";
            this.updateCustomerInfoToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.updateCustomerInfoToolStripMenuItem.Text = "Update Customer Info";
            this.updateCustomerInfoToolStripMenuItem.Click += new System.EventHandler(this.updateCustomerInfoToolStripMenuItem_Click);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProductsOrdersToolStripMenuItem,
            this.invoicesToolStripMenuItem});
            this.ordersToolStripMenuItem.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.ordersToolStripMenuItem.Text = "Purchases";
            // 
            // ProductsOrdersToolStripMenuItem
            // 
            this.ProductsOrdersToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.ProductsOrdersToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProductsOrdersToolStripMenuItem.Name = "ProductsOrdersToolStripMenuItem";
            this.ProductsOrdersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ProductsOrdersToolStripMenuItem.Text = "Products";
            this.ProductsOrdersToolStripMenuItem.Click += new System.EventHandler(this.ProductsOrdersToolStripMenuItem_Click);
            // 
            // invoicesToolStripMenuItem
            // 
            this.invoicesToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.invoicesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.invoicesToolStripMenuItem.Name = "invoicesToolStripMenuItem";
            this.invoicesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.invoicesToolStripMenuItem.Text = "Invoices";
            this.invoicesToolStripMenuItem.Click += new System.EventHandler(this.invoicesToolStripMenuItem_Click);
            // 
            // supplierToolStripMenuItem
            // 
            this.supplierToolStripMenuItem.ForeColor = System.Drawing.SystemColors.InfoText;
            this.supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            this.supplierToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.supplierToolStripMenuItem.Text = "Supplier";
            this.supplierToolStripMenuItem.Click += new System.EventHandler(this.supplierToolStripMenuItem_Click);
            // 
            // administratorToolStripMenuItem
            // 
            this.administratorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddDeleteUser});
            this.administratorToolStripMenuItem.ForeColor = System.Drawing.SystemColors.InfoText;
            this.administratorToolStripMenuItem.Name = "administratorToolStripMenuItem";
            this.administratorToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.administratorToolStripMenuItem.Text = "Administrator";
            // 
            // btnAddDeleteUser
            // 
            this.btnAddDeleteUser.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddDeleteUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddDeleteUser.Name = "btnAddDeleteUser";
            this.btnAddDeleteUser.Size = new System.Drawing.Size(184, 22);
            this.btnAddDeleteUser.Text = "Add or Remover User";
            this.btnAddDeleteUser.Click += new System.EventHandler(this.btnAddDeleteUser_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 714);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(1067, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // lbstatus
            // 
            this.lbstatus.AutoSize = true;
            this.lbstatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbstatus.Location = new System.Drawing.Point(245, 126);
            this.lbstatus.Name = "lbstatus";
            this.lbstatus.Size = new System.Drawing.Size(51, 19);
            this.lbstatus.TabIndex = 4;
            this.lbstatus.Text = "Status";
            this.lbstatus.Visible = false;
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnlogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogout.FlatAppearance.BorderSize = 0;
            this.btnlogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlogout.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnlogout.Location = new System.Drawing.Point(800, 0);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(86, 24);
            this.btnlogout.TabIndex = 6;
            this.btnlogout.Text = "Logoff";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.BackColor = System.Drawing.SystemColors.Highlight;
            this.lbDate.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbDate.Location = new System.Drawing.Point(565, 5);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(32, 15);
            this.lbDate.TabIndex = 11;
            this.lbDate.Text = "Date";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.BackColor = System.Drawing.SystemColors.Highlight;
            this.lbTime.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbTime.Location = new System.Drawing.Point(712, 5);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(35, 15);
            this.lbTime.TabIndex = 12;
            this.lbTime.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 736);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.lbstatus);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Main_Menu";
            this.Text = "Main Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Menu_FormClosing);
            this.Load += new System.EventHandler(this.Main_Menu_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem customerRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CustomerRegistration;
        private System.Windows.Forms.Label lbstatus;
        private System.Windows.Forms.ToolStripMenuItem updateCustomerInfoToolStripMenuItem;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductsOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAddDeleteUser;
    }
}



