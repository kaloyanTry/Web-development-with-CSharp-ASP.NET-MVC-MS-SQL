
namespace WinFormsPolymorphism
{
    partial class Form1
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
            this.btn1Parameter = new System.Windows.Forms.Button();
            this.txt1Parameter = new System.Windows.Forms.TextBox();
            this.btn2Parameter = new System.Windows.Forms.Button();
            this.btn3Parameter = new System.Windows.Forms.Button();
            this.btn4Parameter = new System.Windows.Forms.Button();
            this.btnVirtual = new System.Windows.Forms.Button();
            this.btnOverRiding = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1Parameter
            // 
            this.btn1Parameter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn1Parameter.Location = new System.Drawing.Point(307, 13);
            this.btn1Parameter.Name = "btn1Parameter";
            this.btn1Parameter.Size = new System.Drawing.Size(108, 33);
            this.btn1Parameter.TabIndex = 0;
            this.btn1Parameter.Text = "1Parameter";
            this.btn1Parameter.UseVisualStyleBackColor = true;
            this.btn1Parameter.Click += new System.EventHandler(this.btn1Parameter_Click);
            // 
            // txt1Parameter
            // 
            this.txt1Parameter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt1Parameter.Location = new System.Drawing.Point(13, 13);
            this.txt1Parameter.Multiline = true;
            this.txt1Parameter.Name = "txt1Parameter";
            this.txt1Parameter.Size = new System.Drawing.Size(240, 381);
            this.txt1Parameter.TabIndex = 1;
            // 
            // btn2Parameter
            // 
            this.btn2Parameter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn2Parameter.Location = new System.Drawing.Point(307, 61);
            this.btn2Parameter.Name = "btn2Parameter";
            this.btn2Parameter.Size = new System.Drawing.Size(108, 33);
            this.btn2Parameter.TabIndex = 2;
            this.btn2Parameter.Text = "2Parameter";
            this.btn2Parameter.UseVisualStyleBackColor = true;
            this.btn2Parameter.Click += new System.EventHandler(this.btn2Parameter_Click);
            // 
            // btn3Parameter
            // 
            this.btn3Parameter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn3Parameter.Location = new System.Drawing.Point(307, 112);
            this.btn3Parameter.Name = "btn3Parameter";
            this.btn3Parameter.Size = new System.Drawing.Size(108, 33);
            this.btn3Parameter.TabIndex = 3;
            this.btn3Parameter.Text = "3Parameter";
            this.btn3Parameter.UseVisualStyleBackColor = true;
            this.btn3Parameter.Click += new System.EventHandler(this.btn3Parameter_Click);
            // 
            // btn4Parameter
            // 
            this.btn4Parameter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn4Parameter.Location = new System.Drawing.Point(307, 162);
            this.btn4Parameter.Name = "btn4Parameter";
            this.btn4Parameter.Size = new System.Drawing.Size(108, 33);
            this.btn4Parameter.TabIndex = 4;
            this.btn4Parameter.Text = "4Parameter";
            this.btn4Parameter.UseVisualStyleBackColor = true;
            this.btn4Parameter.Click += new System.EventHandler(this.btn4Parameter_Click);
            // 
            // btnVirtual
            // 
            this.btnVirtual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVirtual.Location = new System.Drawing.Point(307, 313);
            this.btnVirtual.Name = "btnVirtual";
            this.btnVirtual.Size = new System.Drawing.Size(129, 31);
            this.btnVirtual.TabIndex = 5;
            this.btnVirtual.Text = "Virtual";
            this.btnVirtual.UseVisualStyleBackColor = true;
            this.btnVirtual.Click += new System.EventHandler(this.btnVirtual_Click);
            // 
            // btnOverRiding
            // 
            this.btnOverRiding.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOverRiding.Location = new System.Drawing.Point(307, 363);
            this.btnOverRiding.Name = "btnOverRiding";
            this.btnOverRiding.Size = new System.Drawing.Size(129, 31);
            this.btnOverRiding.TabIndex = 6;
            this.btnOverRiding.Text = "OverRiding";
            this.btnOverRiding.UseVisualStyleBackColor = true;
            this.btnOverRiding.Click += new System.EventHandler(this.btnOverRiding_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 450);
            this.Controls.Add(this.btnOverRiding);
            this.Controls.Add(this.btnVirtual);
            this.Controls.Add(this.btn4Parameter);
            this.Controls.Add(this.btn3Parameter);
            this.Controls.Add(this.btn2Parameter);
            this.Controls.Add(this.txt1Parameter);
            this.Controls.Add(this.btn1Parameter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1Parameter;
        private System.Windows.Forms.TextBox txt1Parameter;
        private System.Windows.Forms.Button btn2Parameter;
        private System.Windows.Forms.Button btn3Parameter;
        private System.Windows.Forms.Button btn4Parameter;
        private System.Windows.Forms.Button btnVirtual;
        private System.Windows.Forms.Button btnOverRiding;
    }
}

