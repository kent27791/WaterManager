namespace WaterManager
{
    partial class Main
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
            this.groupBoxLeft = new System.Windows.Forms.GroupBox();
            this.buttonCheckInfo = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.labelMonth = new System.Windows.Forms.Label();
            this.groupBoxRight = new System.Windows.Forms.GroupBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonChecking = new System.Windows.Forms.Button();
            this.textBoxAddressChecking = new System.Windows.Forms.TextBox();
            this.labelAddressChecking = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ucTextBoxNumberCheckout = new WaterManager.Controls.ucTextBox();
            this.ucTextBoxNumberTax = new WaterManager.Controls.ucTextBox();
            this.ucTextBoxNumberPrice = new WaterManager.Controls.ucTextBox();
            this.ucTextBoxWaterNumberUsed = new WaterManager.Controls.ucTextBox();
            this.ucTextBoxWaterNumberNew = new WaterManager.Controls.ucTextBox();
            this.ucTextBoxWaterNumberOld = new WaterManager.Controls.ucTextBox();
            this.ucTextBoxCustomerAddress = new WaterManager.Controls.ucTextBox();
            this.ucTextBoxCustomerName = new WaterManager.Controls.ucTextBox();
            this.ucTextBoxCustomerId = new WaterManager.Controls.ucTextBox();
            this.groupBoxLeft.SuspendLayout();
            this.groupBoxRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLeft
            // 
            this.groupBoxLeft.AutoSize = true;
            this.groupBoxLeft.Controls.Add(this.label2);
            this.groupBoxLeft.Controls.Add(this.label1);
            this.groupBoxLeft.Controls.Add(this.buttonCheckInfo);
            this.groupBoxLeft.Controls.Add(this.buttonAdd);
            this.groupBoxLeft.Controls.Add(this.comboBoxMonth);
            this.groupBoxLeft.Controls.Add(this.labelMonth);
            this.groupBoxLeft.Controls.Add(this.ucTextBoxWaterNumberNew);
            this.groupBoxLeft.Controls.Add(this.ucTextBoxWaterNumberOld);
            this.groupBoxLeft.Controls.Add(this.ucTextBoxCustomerAddress);
            this.groupBoxLeft.Controls.Add(this.ucTextBoxCustomerName);
            this.groupBoxLeft.Controls.Add(this.ucTextBoxCustomerId);
            this.groupBoxLeft.Location = new System.Drawing.Point(5, 12);
            this.groupBoxLeft.Name = "groupBoxLeft";
            this.groupBoxLeft.Size = new System.Drawing.Size(347, 253);
            this.groupBoxLeft.TabIndex = 0;
            this.groupBoxLeft.TabStop = false;
            this.groupBoxLeft.Text = "Nhập thông tin sử dụng nước";
            // 
            // buttonCheckInfo
            // 
            this.buttonCheckInfo.Location = new System.Drawing.Point(184, 211);
            this.buttonCheckInfo.Name = "buttonCheckInfo";
            this.buttonCheckInfo.Size = new System.Drawing.Size(122, 23);
            this.buttonCheckInfo.TabIndex = 8;
            this.buttonCheckInfo.Text = "Kiểm tra thông tin";
            this.buttonCheckInfo.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(96, 211);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Thêm mới";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Location = new System.Drawing.Point(96, 164);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(210, 21);
            this.comboBoxMonth.TabIndex = 6;
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.Location = new System.Drawing.Point(7, 167);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(38, 13);
            this.labelMonth.TabIndex = 5;
            this.labelMonth.Text = "Tháng";
            // 
            // groupBoxRight
            // 
            this.groupBoxRight.Controls.Add(this.buttonExit);
            this.groupBoxRight.Controls.Add(this.buttonChecking);
            this.groupBoxRight.Controls.Add(this.textBoxAddressChecking);
            this.groupBoxRight.Controls.Add(this.labelAddressChecking);
            this.groupBoxRight.Controls.Add(this.ucTextBoxNumberCheckout);
            this.groupBoxRight.Controls.Add(this.ucTextBoxNumberTax);
            this.groupBoxRight.Controls.Add(this.ucTextBoxNumberPrice);
            this.groupBoxRight.Controls.Add(this.ucTextBoxWaterNumberUsed);
            this.groupBoxRight.Location = new System.Drawing.Point(375, 12);
            this.groupBoxRight.Name = "groupBoxRight";
            this.groupBoxRight.Size = new System.Drawing.Size(347, 253);
            this.groupBoxRight.TabIndex = 1;
            this.groupBoxRight.TabStop = false;
            this.groupBoxRight.Text = "Thông tin hóa đón nước";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(236, 211);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(68, 23);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "Thoát";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // buttonChecking
            // 
            this.buttonChecking.Location = new System.Drawing.Point(95, 211);
            this.buttonChecking.Name = "buttonChecking";
            this.buttonChecking.Size = new System.Drawing.Size(124, 23);
            this.buttonChecking.TabIndex = 10;
            this.buttonChecking.Text = "Tính hóa đơn";
            this.buttonChecking.UseVisualStyleBackColor = true;
            // 
            // textBoxAddressChecking
            // 
            this.textBoxAddressChecking.Location = new System.Drawing.Point(95, 134);
            this.textBoxAddressChecking.Multiline = true;
            this.textBoxAddressChecking.Name = "textBoxAddressChecking";
            this.textBoxAddressChecking.Size = new System.Drawing.Size(212, 61);
            this.textBoxAddressChecking.TabIndex = 9;
            // 
            // labelAddressChecking
            // 
            this.labelAddressChecking.AutoSize = true;
            this.labelAddressChecking.Location = new System.Drawing.Point(6, 134);
            this.labelAddressChecking.Name = "labelAddressChecking";
            this.labelAddressChecking.Size = new System.Drawing.Size(83, 13);
            this.labelAddressChecking.TabIndex = 8;
            this.labelAddressChecking.Text = "Nơi gửi hóa đơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "(m3)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "(m3)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(685, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "(m3)";
            // 
            // ucTextBoxNumberCheckout
            // 
            this.ucTextBoxNumberCheckout.Location = new System.Drawing.Point(5, 108);
            this.ucTextBoxNumberCheckout.Name = "ucTextBoxNumberCheckout";
            this.ucTextBoxNumberCheckout.Size = new System.Drawing.Size(302, 20);
            this.ucTextBoxNumberCheckout.TabIndex = 7;
            // 
            // ucTextBoxNumberTax
            // 
            this.ucTextBoxNumberTax.Location = new System.Drawing.Point(6, 82);
            this.ucTextBoxNumberTax.Name = "ucTextBoxNumberTax";
            this.ucTextBoxNumberTax.Size = new System.Drawing.Size(300, 20);
            this.ucTextBoxNumberTax.TabIndex = 6;
            // 
            // ucTextBoxNumberPrice
            // 
            this.ucTextBoxNumberPrice.Location = new System.Drawing.Point(5, 56);
            this.ucTextBoxNumberPrice.Name = "ucTextBoxNumberPrice";
            this.ucTextBoxNumberPrice.Size = new System.Drawing.Size(302, 20);
            this.ucTextBoxNumberPrice.TabIndex = 5;
            // 
            // ucTextBoxWaterNumberUsed
            // 
            this.ucTextBoxWaterNumberUsed.Location = new System.Drawing.Point(6, 30);
            this.ucTextBoxWaterNumberUsed.Name = "ucTextBoxWaterNumberUsed";
            this.ucTextBoxWaterNumberUsed.Size = new System.Drawing.Size(301, 20);
            this.ucTextBoxWaterNumberUsed.TabIndex = 4;
            // 
            // ucTextBoxWaterNumberNew
            // 
            this.ucTextBoxWaterNumberNew.Location = new System.Drawing.Point(6, 134);
            this.ucTextBoxWaterNumberNew.Name = "ucTextBoxWaterNumberNew";
            this.ucTextBoxWaterNumberNew.Size = new System.Drawing.Size(300, 20);
            this.ucTextBoxWaterNumberNew.TabIndex = 4;
            // 
            // ucTextBoxWaterNumberOld
            // 
            this.ucTextBoxWaterNumberOld.Location = new System.Drawing.Point(6, 108);
            this.ucTextBoxWaterNumberOld.Name = "ucTextBoxWaterNumberOld";
            this.ucTextBoxWaterNumberOld.Size = new System.Drawing.Size(300, 20);
            this.ucTextBoxWaterNumberOld.TabIndex = 3;
            // 
            // ucTextBoxCustomerAddress
            // 
            this.ucTextBoxCustomerAddress.Location = new System.Drawing.Point(7, 82);
            this.ucTextBoxCustomerAddress.Name = "ucTextBoxCustomerAddress";
            this.ucTextBoxCustomerAddress.Size = new System.Drawing.Size(300, 20);
            this.ucTextBoxCustomerAddress.TabIndex = 2;
            // 
            // ucTextBoxCustomerName
            // 
            this.ucTextBoxCustomerName.Location = new System.Drawing.Point(6, 56);
            this.ucTextBoxCustomerName.Name = "ucTextBoxCustomerName";
            this.ucTextBoxCustomerName.Size = new System.Drawing.Size(300, 20);
            this.ucTextBoxCustomerName.TabIndex = 1;
            // 
            // ucTextBoxCustomerId
            // 
            this.ucTextBoxCustomerId.Location = new System.Drawing.Point(7, 30);
            this.ucTextBoxCustomerId.Name = "ucTextBoxCustomerId";
            this.ucTextBoxCustomerId.Size = new System.Drawing.Size(301, 20);
            this.ucTextBoxCustomerId.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 278);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBoxRight);
            this.Controls.Add(this.groupBoxLeft);
            this.Name = "Main";
            this.Text = "s";
            this.groupBoxLeft.ResumeLayout(false);
            this.groupBoxLeft.PerformLayout();
            this.groupBoxRight.ResumeLayout(false);
            this.groupBoxRight.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLeft;
        private Controls.ucTextBox ucTextBoxCustomerId;
        private Controls.ucTextBox ucTextBoxWaterNumberNew;
        private Controls.ucTextBox ucTextBoxWaterNumberOld;
        private Controls.ucTextBox ucTextBoxCustomerAddress;
        private Controls.ucTextBox ucTextBoxCustomerName;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.Button buttonCheckInfo;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.GroupBox groupBoxRight;
        private Controls.ucTextBox ucTextBoxNumberCheckout;
        private Controls.ucTextBox ucTextBoxNumberTax;
        private Controls.ucTextBox ucTextBoxNumberPrice;
        private Controls.ucTextBox ucTextBoxWaterNumberUsed;
        private System.Windows.Forms.TextBox textBoxAddressChecking;
        private System.Windows.Forms.Label labelAddressChecking;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonChecking;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

