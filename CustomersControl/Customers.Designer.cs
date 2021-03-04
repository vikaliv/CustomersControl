
namespace CustomersControl
{
    partial class Customers
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbCustomers = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnGetOrders = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.pnlCustomersData = new System.Windows.Forms.Panel();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.gbOrders = new System.Windows.Forms.GroupBox();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.numPercent = new System.Windows.Forms.NumericUpDown();
            this.btnGetRiskCustomers = new System.Windows.Forms.Button();
            this.gbPayments = new System.Windows.Forms.GroupBox();
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbCustomers.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.pnlCustomersData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.gbOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPercent)).BeginInit();
            this.gbPayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gbCustomers, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbOrders, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gbPayments, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1083, 633);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gbCustomers
            // 
            this.gbCustomers.Controls.Add(this.tableLayoutPanel2);
            this.gbCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCustomers.Location = new System.Drawing.Point(3, 3);
            this.gbCustomers.Name = "gbCustomers";
            this.gbCustomers.Size = new System.Drawing.Size(1077, 310);
            this.gbCustomers.TabIndex = 0;
            this.gbCustomers.TabStop = false;
            this.gbCustomers.Text = "Customers";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.pnlFilter, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pnlCustomersData, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.32432F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.67567F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1071, 288);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.btnGetRiskCustomers);
            this.pnlFilter.Controls.Add(this.numPercent);
            this.pnlFilter.Controls.Add(this.btnUpdate);
            this.pnlFilter.Controls.Add(this.btnGetOrders);
            this.pnlFilter.Controls.Add(this.btnRun);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilter.Location = new System.Drawing.Point(3, 3);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(1065, 64);
            this.pnlFilter.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(205, 19);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(161, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnGetOrders
            // 
            this.btnGetOrders.Location = new System.Drawing.Point(372, 19);
            this.btnGetOrders.Name = "btnGetOrders";
            this.btnGetOrders.Size = new System.Drawing.Size(126, 23);
            this.btnGetOrders.TabIndex = 1;
            this.btnGetOrders.Text = "Get Customer Orders";
            this.btnGetOrders.UseVisualStyleBackColor = true;
            this.btnGetOrders.Click += new System.EventHandler(this.btnGetOrders_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(38, 19);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(161, 23);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Get Customers";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // pnlCustomersData
            // 
            this.pnlCustomersData.Controls.Add(this.dgvCustomers);
            this.pnlCustomersData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCustomersData.Location = new System.Drawing.Point(3, 73);
            this.pnlCustomersData.Name = "pnlCustomersData";
            this.pnlCustomersData.Size = new System.Drawing.Size(1065, 212);
            this.pnlCustomersData.TabIndex = 1;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomers.Location = new System.Drawing.Point(0, 0);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowTemplate.Height = 25;
            this.dgvCustomers.Size = new System.Drawing.Size(1065, 212);
            this.dgvCustomers.TabIndex = 0;
            // 
            // gbOrders
            // 
            this.gbOrders.Controls.Add(this.dgvOrders);
            this.gbOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbOrders.Location = new System.Drawing.Point(3, 319);
            this.gbOrders.Name = "gbOrders";
            this.gbOrders.Size = new System.Drawing.Size(1077, 152);
            this.gbOrders.TabIndex = 1;
            this.gbOrders.TabStop = false;
            this.gbOrders.Text = "Orders with Products";
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.Location = new System.Drawing.Point(3, 19);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowTemplate.Height = 25;
            this.dgvOrders.Size = new System.Drawing.Size(1071, 130);
            this.dgvOrders.TabIndex = 0;
            // 
            // numPercent
            // 
            this.numPercent.Location = new System.Drawing.Point(538, 19);
            this.numPercent.Name = "numPercent";
            this.numPercent.Size = new System.Drawing.Size(120, 23);
            this.numPercent.TabIndex = 3;
            // 
            // btnGetRiskCustomers
            // 
            this.btnGetRiskCustomers.Location = new System.Drawing.Point(693, 19);
            this.btnGetRiskCustomers.Name = "btnGetRiskCustomers";
            this.btnGetRiskCustomers.Size = new System.Drawing.Size(133, 23);
            this.btnGetRiskCustomers.TabIndex = 4;
            this.btnGetRiskCustomers.Text = "Get Risk Cuatomers";
            this.btnGetRiskCustomers.UseVisualStyleBackColor = true;
            this.btnGetRiskCustomers.Click += new System.EventHandler(this.btnGetRiskCustomers_Click);
            // 
            // gbPayments
            // 
            this.gbPayments.Controls.Add(this.dgvPayments);
            this.gbPayments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPayments.Location = new System.Drawing.Point(3, 477);
            this.gbPayments.Name = "gbPayments";
            this.gbPayments.Size = new System.Drawing.Size(1077, 153);
            this.gbPayments.TabIndex = 2;
            this.gbPayments.TabStop = false;
            this.gbPayments.Text = "Payments";
            // 
            // dgvPayments
            // 
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPayments.Location = new System.Drawing.Point(3, 19);
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.RowTemplate.Height = 25;
            this.dgvPayments.Size = new System.Drawing.Size(1071, 131);
            this.dgvPayments.TabIndex = 0;
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 633);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Customers";
            this.Text = "Customers";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbCustomers.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pnlFilter.ResumeLayout(false);
            this.pnlCustomersData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.gbOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPercent)).EndInit();
            this.gbPayments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbCustomers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Panel pnlCustomersData;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.GroupBox gbOrders;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Button btnGetOrders;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnGetRiskCustomers;
        private System.Windows.Forms.NumericUpDown numPercent;
        private System.Windows.Forms.GroupBox gbPayments;
        private System.Windows.Forms.DataGridView dgvPayments;
    }
}

