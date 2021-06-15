
namespace Encapsulation
{
    partial class FormEncapsulation
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
            this.labelID = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.txtEmployeeAge = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.txtEmployeePosition = new System.Windows.Forms.TextBox();
            this.labelPosition = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelID.Location = new System.Drawing.Point(46, 46);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(131, 28);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "Employee ID";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmployeeID.Location = new System.Drawing.Point(261, 40);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(218, 30);
            this.txtEmployeeID.TabIndex = 1;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmployeeName.Location = new System.Drawing.Point(261, 83);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(218, 30);
            this.txtEmployeeName.TabIndex = 3;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(46, 89);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(166, 28);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Employee Name";
            // 
            // txtEmployeeAge
            // 
            this.txtEmployeeAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmployeeAge.Location = new System.Drawing.Point(261, 130);
            this.txtEmployeeAge.Name = "txtEmployeeAge";
            this.txtEmployeeAge.Size = new System.Drawing.Size(218, 30);
            this.txtEmployeeAge.TabIndex = 5;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAge.Location = new System.Drawing.Point(46, 136);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(147, 28);
            this.labelAge.TabIndex = 4;
            this.labelAge.Text = "Employee Age";
            // 
            // txtEmployeePosition
            // 
            this.txtEmployeePosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmployeePosition.Location = new System.Drawing.Point(261, 179);
            this.txtEmployeePosition.Name = "txtEmployeePosition";
            this.txtEmployeePosition.Size = new System.Drawing.Size(218, 30);
            this.txtEmployeePosition.TabIndex = 7;
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPosition.Location = new System.Drawing.Point(46, 185);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(186, 28);
            this.labelPosition.TabIndex = 6;
            this.labelPosition.Text = "Employee Position";
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSend.Location = new System.Drawing.Point(156, 238);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(99, 36);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // FormEncapsulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 450);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtEmployeePosition);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.txtEmployeeAge);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.labelID);
            this.Name = "FormEncapsulation";
            this.Text = "FormEncapsulation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox txtEmployeeAge;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox txtEmployeePosition;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Button btnSend;
    }
}

