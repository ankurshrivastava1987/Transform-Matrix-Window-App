
namespace WinFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtColumn = new System.Windows.Forms.TextBox();
            this.txtAreaElements = new System.Windows.Forms.RichTextBox();
            this.txtAreaInputMatrix = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAreaOutputMatrix = new System.Windows.Forms.RichTextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRotation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Rows";
            // 
            // txtRows
            // 
            this.txtRows.Location = new System.Drawing.Point(282, 22);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(200, 39);
            this.txtRows.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of Column";
            // 
            // txtColumn
            // 
            this.txtColumn.Location = new System.Drawing.Point(282, 73);
            this.txtColumn.Name = "txtColumn";
            this.txtColumn.Size = new System.Drawing.Size(200, 39);
            this.txtColumn.TabIndex = 3;
            // 
            // txtAreaElements
            // 
            this.txtAreaElements.Location = new System.Drawing.Point(282, 131);
            this.txtAreaElements.Name = "txtAreaElements";
            this.txtAreaElements.Size = new System.Drawing.Size(1251, 211);
            this.txtAreaElements.TabIndex = 4;
            this.txtAreaElements.Text = "";
            // 
            // txtAreaInputMatrix
            // 
            this.txtAreaInputMatrix.Location = new System.Drawing.Point(273, 495);
            this.txtAreaInputMatrix.Name = "txtAreaInputMatrix";
            this.txtAreaInputMatrix.Size = new System.Drawing.Size(1251, 329);
            this.txtAreaInputMatrix.TabIndex = 5;
            this.txtAreaInputMatrix.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Matrix Elements";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 498);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Input Matrix";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 872);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Output Matrix";
            // 
            // txtAreaOutputMatrix
            // 
            this.txtAreaOutputMatrix.Location = new System.Drawing.Point(273, 869);
            this.txtAreaOutputMatrix.Name = "txtAreaOutputMatrix";
            this.txtAreaOutputMatrix.Size = new System.Drawing.Size(1260, 280);
            this.txtAreaOutputMatrix.TabIndex = 9;
            this.txtAreaOutputMatrix.Text = "";
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(787, 420);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(150, 46);
            this.btnExecute.TabIndex = 10;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "Rotation";
            // 
            // txtRotation
            // 
            this.txtRotation.Location = new System.Drawing.Point(282, 358);
            this.txtRotation.Name = "txtRotation";
            this.txtRotation.Size = new System.Drawing.Size(1251, 39);
            this.txtRotation.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1647, 1257);
            this.Controls.Add(this.txtRotation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.txtAreaOutputMatrix);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAreaInputMatrix);
            this.Controls.Add(this.txtAreaElements);
            this.Controls.Add(this.txtColumn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRows);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtColumn;
        private System.Windows.Forms.RichTextBox txtAreaElements;
        private System.Windows.Forms.RichTextBox txtAreaInputMatrix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtAreaOutputMatrix;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRotation;
    }
}

