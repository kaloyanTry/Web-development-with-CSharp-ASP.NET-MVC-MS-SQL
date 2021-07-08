
namespace PersonalTracking
{
    partial class FormPermissionList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtDayAmount = new System.Windows.Forms.TextBox();
            this.groupBoxDate = new System.Windows.Forms.GroupBox();
            this.rbDelivery = new System.Windows.Forms.RadioButton();
            this.rbStart = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dpFinish = new System.Windows.Forms.DateTimePicker();
            this.dpStart = new System.Windows.Forms.DateTimePicker();
            this.labelFinish = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.labelTaskDate = new System.Windows.Forms.Label();
            this.panelForAdmin = new System.Windows.Forms.Panel();
            this.cmbPossition = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.labelDepartmentPossition = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.txtUserNo = new System.Windows.Forms.TextBox();
            this.labelUserNo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnDisaprove = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBoxDate.SuspendLayout();
            this.panelForAdmin.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panelForAdmin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 240);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnClear);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.txtDayAmount);
            this.panel3.Controls.Add(this.groupBoxDate);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.dpFinish);
            this.panel3.Controls.Add(this.dpStart);
            this.panel3.Controls.Add(this.labelFinish);
            this.panel3.Controls.Add(this.labelStart);
            this.panel3.Controls.Add(this.labelTaskDate);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(413, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(369, 240);
            this.panel3.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(171, 175);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 36);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(44, 175);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(121, 36);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtDayAmount
            // 
            this.txtDayAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDayAmount.Location = new System.Drawing.Point(157, 129);
            this.txtDayAmount.Name = "txtDayAmount";
            this.txtDayAmount.Size = new System.Drawing.Size(195, 30);
            this.txtDayAmount.TabIndex = 2;
            this.txtDayAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDayAmount_KeyPress);
            // 
            // groupBoxDate
            // 
            this.groupBoxDate.Controls.Add(this.rbDelivery);
            this.groupBoxDate.Controls.Add(this.rbStart);
            this.groupBoxDate.Location = new System.Drawing.Point(223, 33);
            this.groupBoxDate.Name = "groupBoxDate";
            this.groupBoxDate.Size = new System.Drawing.Size(129, 77);
            this.groupBoxDate.TabIndex = 20;
            this.groupBoxDate.TabStop = false;
            // 
            // rbDelivery
            // 
            this.rbDelivery.AutoSize = true;
            this.rbDelivery.Location = new System.Drawing.Point(6, 47);
            this.rbDelivery.Name = "rbDelivery";
            this.rbDelivery.Size = new System.Drawing.Size(114, 21);
            this.rbDelivery.TabIndex = 1;
            this.rbDelivery.TabStop = true;
            this.rbDelivery.Text = "Delivery Date";
            this.rbDelivery.UseVisualStyleBackColor = true;
            // 
            // rbStart
            // 
            this.rbStart.AutoSize = true;
            this.rbStart.Location = new System.Drawing.Point(6, 16);
            this.rbStart.Name = "rbStart";
            this.rbStart.Size = new System.Drawing.Size(93, 21);
            this.rbStart.TabIndex = 0;
            this.rbStart.TabStop = true;
            this.rbStart.Text = "Start Date";
            this.rbStart.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Day Amount";
            // 
            // dpFinish
            // 
            this.dpFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFinish.Location = new System.Drawing.Point(97, 78);
            this.dpFinish.Name = "dpFinish";
            this.dpFinish.Size = new System.Drawing.Size(120, 30);
            this.dpFinish.TabIndex = 1;
            // 
            // dpStart
            // 
            this.dpStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpStart.Location = new System.Drawing.Point(97, 44);
            this.dpStart.Name = "dpStart";
            this.dpStart.Size = new System.Drawing.Size(120, 30);
            this.dpStart.TabIndex = 0;
            // 
            // labelFinish
            // 
            this.labelFinish.AutoSize = true;
            this.labelFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinish.Location = new System.Drawing.Point(21, 85);
            this.labelFinish.Name = "labelFinish";
            this.labelFinish.Size = new System.Drawing.Size(70, 25);
            this.labelFinish.TabIndex = 23;
            this.labelFinish.Text = "Finish";
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStart.Location = new System.Drawing.Point(21, 49);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(58, 25);
            this.labelStart.TabIndex = 22;
            this.labelStart.Text = "Start";
            // 
            // labelTaskDate
            // 
            this.labelTaskDate.AutoSize = true;
            this.labelTaskDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaskDate.Location = new System.Drawing.Point(21, 13);
            this.labelTaskDate.Name = "labelTaskDate";
            this.labelTaskDate.Size = new System.Drawing.Size(169, 25);
            this.labelTaskDate.TabIndex = 21;
            this.labelTaskDate.Text = "Permission Date";
            // 
            // panelForAdmin
            // 
            this.panelForAdmin.Controls.Add(this.cmbPossition);
            this.panelForAdmin.Controls.Add(this.label1);
            this.panelForAdmin.Controls.Add(this.cmbDepartment);
            this.panelForAdmin.Controls.Add(this.labelDepartmentPossition);
            this.panelForAdmin.Controls.Add(this.txtSurname);
            this.panelForAdmin.Controls.Add(this.labelSurname);
            this.panelForAdmin.Controls.Add(this.txtName);
            this.panelForAdmin.Controls.Add(this.labelName);
            this.panelForAdmin.Controls.Add(this.txtUserNo);
            this.panelForAdmin.Controls.Add(this.labelUserNo);
            this.panelForAdmin.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelForAdmin.Location = new System.Drawing.Point(0, 0);
            this.panelForAdmin.Name = "panelForAdmin";
            this.panelForAdmin.Size = new System.Drawing.Size(415, 240);
            this.panelForAdmin.TabIndex = 0;
            // 
            // cmbPossition
            // 
            this.cmbPossition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPossition.FormattingEnabled = true;
            this.cmbPossition.Location = new System.Drawing.Point(156, 172);
            this.cmbPossition.Name = "cmbPossition";
            this.cmbPossition.Size = new System.Drawing.Size(199, 33);
            this.cmbPossition.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Possition";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(156, 131);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(200, 33);
            this.cmbDepartment.TabIndex = 3;
            // 
            // labelDepartmentPossition
            // 
            this.labelDepartmentPossition.AutoSize = true;
            this.labelDepartmentPossition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepartmentPossition.Location = new System.Drawing.Point(6, 129);
            this.labelDepartmentPossition.Name = "labelDepartmentPossition";
            this.labelDepartmentPossition.Size = new System.Drawing.Size(123, 25);
            this.labelDepartmentPossition.TabIndex = 24;
            this.labelDepartmentPossition.Text = "Department";
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(156, 90);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(200, 30);
            this.txtSurname.TabIndex = 2;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSurname.Location = new System.Drawing.Point(12, 90);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(99, 25);
            this.labelSurname.TabIndex = 20;
            this.labelSurname.Text = "Surname";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(156, 54);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 30);
            this.txtName.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(12, 54);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(68, 25);
            this.labelName.TabIndex = 22;
            this.labelName.Text = "Name";
            // 
            // txtUserNo
            // 
            this.txtUserNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserNo.Location = new System.Drawing.Point(156, 18);
            this.txtUserNo.Name = "txtUserNo";
            this.txtUserNo.Size = new System.Drawing.Size(200, 30);
            this.txtUserNo.TabIndex = 0;
            this.txtUserNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserNo_KeyPress);
            // 
            // labelUserNo
            // 
            this.labelUserNo.AutoSize = true;
            this.labelUserNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserNo.Location = new System.Drawing.Point(12, 18);
            this.labelUserNo.Name = "labelUserNo";
            this.labelUserNo.Size = new System.Drawing.Size(84, 25);
            this.labelUserNo.TabIndex = 21;
            this.labelUserNo.Text = "UserNo";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnApprove);
            this.panel2.Controls.Add(this.btnDisaprove);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnNew);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 477);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(782, 76);
            this.panel2.TabIndex = 0;
            // 
            // btnApprove
            // 
            this.btnApprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.Location = new System.Drawing.Point(3, 29);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(138, 35);
            this.btnApprove.TabIndex = 0;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            // 
            // btnDisaprove
            // 
            this.btnDisaprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisaprove.Location = new System.Drawing.Point(147, 29);
            this.btnDisaprove.Name = "btnDisaprove";
            this.btnDisaprove.Size = new System.Drawing.Size(147, 35);
            this.btnDisaprove.TabIndex = 1;
            this.btnDisaprove.Text = "Disapprove";
            this.btnDisaprove.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(625, 29);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 35);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(300, 29);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(78, 35);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(508, 29);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 35);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(384, 29);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(118, 35);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 240);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(782, 237);
            this.dataGridView1.TabIndex = 2;
            // 
            // FormPermissionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormPermissionList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Permission List";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBoxDate.ResumeLayout(false);
            this.groupBoxDate.PerformLayout();
            this.panelForAdmin.ResumeLayout(false);
            this.panelForAdmin.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnDisaprove;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelForAdmin;
        private System.Windows.Forms.ComboBox cmbPossition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label labelDepartmentPossition;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox txtUserNo;
        private System.Windows.Forms.Label labelUserNo;
        private System.Windows.Forms.TextBox txtDayAmount;
        private System.Windows.Forms.GroupBox groupBoxDate;
        private System.Windows.Forms.RadioButton rbDelivery;
        private System.Windows.Forms.RadioButton rbStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dpFinish;
        private System.Windows.Forms.DateTimePicker dpStart;
        private System.Windows.Forms.Label labelFinish;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label labelTaskDate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
    }
}