namespace WaterManager.Controls
{
    partial class ucTextBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.errorProviderField = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelField = new System.Windows.Forms.Label();
            this.textBoxField = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderField)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProviderField
            // 
            this.errorProviderField.ContainerControl = this;
            // 
            // labelField
            // 
            this.labelField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelField.AutoSize = true;
            this.labelField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelField.Location = new System.Drawing.Point(3, 3);
            this.labelField.Name = "labelField";
            this.labelField.Size = new System.Drawing.Size(58, 13);
            this.labelField.TabIndex = 4;
            this.labelField.Text = "Label Field";
            this.labelField.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxField
            // 
            this.textBoxField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxField.Location = new System.Drawing.Point(91, 0);
            this.textBoxField.Name = "textBoxField";
            this.textBoxField.Size = new System.Drawing.Size(418, 20);
            this.textBoxField.TabIndex = 5;
            // 
            // ucTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxField);
            this.Controls.Add(this.labelField);
            this.Name = "ucTextBox";
            this.Size = new System.Drawing.Size(509, 20);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProviderField;
        private System.Windows.Forms.Label labelField;
        private System.Windows.Forms.TextBox textBoxField;
    }
}
