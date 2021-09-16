namespace JARF.Controls
{
    partial class ColumnDisplay
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
            this.chkSelected = new System.Windows.Forms.CheckBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkSelected
            // 
            this.chkSelected.AutoSize = true;
            this.chkSelected.Location = new System.Drawing.Point(0, 3);
            this.chkSelected.Name = "chkSelected";
            this.chkSelected.Size = new System.Drawing.Size(15, 14);
            this.chkSelected.TabIndex = 0;
            this.chkSelected.UseVisualStyleBackColor = true;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(22, 4);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(35, 13);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "label1";
            // 
            // ColumnDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.chkSelected);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ColumnDisplay";
            this.Size = new System.Drawing.Size(182, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkSelected;
        private System.Windows.Forms.Label lblInfo;
    }
}
