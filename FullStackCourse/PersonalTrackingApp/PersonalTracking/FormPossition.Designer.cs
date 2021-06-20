
namespace PersonalTracking
{
    partial class FormPossition
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
            this.labelPassition = new System.Windows.Forms.Label();
            this.txtPossition = new System.Windows.Forms.TextBox();
            this.labelDepartmentPossition = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPassition
            // 
            this.labelPassition.AutoSize = true;
            this.labelPassition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassition.Location = new System.Drawing.Point(12, 39);
            this.labelPassition.Name = "labelPassition";
            this.labelPassition.Size = new System.Drawing.Size(100, 25);
            this.labelPassition.TabIndex = 1;
            this.labelPassition.Text = "Possition";
            // 
            // txtPossition
            // 
            this.txtPossition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPossition.Location = new System.Drawing.Point(141, 34);
            this.txtPossition.Name = "txtPossition";
            this.txtPossition.Size = new System.Drawing.Size(207, 30);
            this.txtPossition.TabIndex = 0;
            // 
            // labelDepartmentPossition
            // 
            this.labelDepartmentPossition.AutoSize = true;
            this.labelDepartmentPossition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepartmentPossition.Location = new System.Drawing.Point(12, 89);
            this.labelDepartmentPossition.Name = "labelDepartmentPossition";
            this.labelDepartmentPossition.Size = new System.Drawing.Size(123, 25);
            this.labelDepartmentPossition.TabIndex = 1;
            this.labelDepartmentPossition.Text = "Department";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(141, 81);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(207, 33);
            this.cmbDepartment.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(141, 150);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(118, 35);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(17, 150);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 35);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // FormPossition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.labelDepartmentPossition);
            this.Controls.Add(this.txtPossition);
            this.Controls.Add(this.labelPassition);
            this.Name = "FormPossition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Possition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPassition;
        private System.Windows.Forms.TextBox txtPossition;
        private System.Windows.Forms.Label labelDepartmentPossition;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
    }
}