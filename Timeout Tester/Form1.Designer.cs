namespace Timeout_Tester
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.filterBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownTimeout = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCnfNum = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCnfTime = new System.Windows.Forms.NumericUpDown();
            this.outputBox = new System.Windows.Forms.GroupBox();
            this.valueBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonOn = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxConfirmedValue = new System.Windows.Forms.TextBox();
            this.textBoxTimeout = new System.Windows.Forms.TextBox();
            this.textBoxConfirmationTime = new System.Windows.Forms.TextBox();
            this.textBoxConfirmationCount = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.filterBox.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCnfNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCnfTime)).BeginInit();
            this.outputBox.SuspendLayout();
            this.valueBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.filterBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.outputBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.valueBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(415, 466);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // filterBox
            // 
            this.filterBox.Controls.Add(this.tableLayoutPanel3);
            this.filterBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterBox.Location = new System.Drawing.Point(3, 142);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(409, 180);
            this.filterBox.TabIndex = 0;
            this.filterBox.TabStop = false;
            this.filterBox.Text = "Filter";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.numericUpDownTimeout, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.numericUpDownCnfNum, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.numericUpDownCnfTime, 1, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(403, 161);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 55);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirmation Time";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 53);
            this.label2.TabIndex = 1;
            this.label2.Text = "Confirmation Number";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Timeout";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numericUpDownTimeout
            // 
            this.numericUpDownTimeout.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDownTimeout.Location = new System.Drawing.Point(204, 16);
            this.numericUpDownTimeout.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownTimeout.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDownTimeout.Name = "numericUpDownTimeout";
            this.numericUpDownTimeout.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownTimeout.TabIndex = 3;
            this.numericUpDownTimeout.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // numericUpDownCnfNum
            // 
            this.numericUpDownCnfNum.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDownCnfNum.Location = new System.Drawing.Point(204, 69);
            this.numericUpDownCnfNum.Name = "numericUpDownCnfNum";
            this.numericUpDownCnfNum.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownCnfNum.TabIndex = 4;
            // 
            // numericUpDownCnfTime
            // 
            this.numericUpDownCnfTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDownCnfTime.Location = new System.Drawing.Point(204, 123);
            this.numericUpDownCnfTime.Name = "numericUpDownCnfTime";
            this.numericUpDownCnfTime.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownCnfTime.TabIndex = 5;
            // 
            // outputBox
            // 
            this.outputBox.Controls.Add(this.tableLayoutPanel4);
            this.outputBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputBox.Location = new System.Drawing.Point(3, 328);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(409, 135);
            this.outputBox.TabIndex = 1;
            this.outputBox.TabStop = false;
            this.outputBox.Text = "Output";
            // 
            // valueBox
            // 
            this.valueBox.Controls.Add(this.tableLayoutPanel2);
            this.valueBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueBox.Location = new System.Drawing.Point(3, 3);
            this.valueBox.Name = "valueBox";
            this.valueBox.Size = new System.Drawing.Size(409, 133);
            this.valueBox.TabIndex = 2;
            this.valueBox.TabStop = false;
            this.valueBox.Text = "Value";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.radioButtonOn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.radioButton2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(403, 114);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // radioButtonOn
            // 
            this.radioButtonOn.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonOn.AutoSize = true;
            this.radioButtonOn.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.radioButtonOn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonOn.Location = new System.Drawing.Point(3, 3);
            this.radioButtonOn.Name = "radioButtonOn";
            this.radioButtonOn.Size = new System.Drawing.Size(195, 51);
            this.radioButtonOn.TabIndex = 0;
            this.radioButtonOn.Text = "O&n";
            this.radioButtonOn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonOn.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton2.Location = new System.Drawing.Point(204, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(196, 51);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "O&ff";
            this.radioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.button1, 2);
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(20, 60);
            this.button1.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(363, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "&Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.textBoxConfirmedValue, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBoxTimeout, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.textBoxConfirmationTime, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.textBoxConfirmationCount, 1, 3);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(403, 116);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Confirmed Value";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Timeout";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "Confirmation Time";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 29);
            this.label7.TabIndex = 3;
            this.label7.Text = "Confirmation Count";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxConfirmedValue
            // 
            this.textBoxConfirmedValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxConfirmedValue.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxConfirmedValue.Location = new System.Drawing.Point(204, 4);
            this.textBoxConfirmedValue.Name = "textBoxConfirmedValue";
            this.textBoxConfirmedValue.ReadOnly = true;
            this.textBoxConfirmedValue.Size = new System.Drawing.Size(100, 20);
            this.textBoxConfirmedValue.TabIndex = 4;
            // 
            // textBoxTimeout
            // 
            this.textBoxTimeout.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxTimeout.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxTimeout.Location = new System.Drawing.Point(204, 33);
            this.textBoxTimeout.Name = "textBoxTimeout";
            this.textBoxTimeout.ReadOnly = true;
            this.textBoxTimeout.Size = new System.Drawing.Size(100, 20);
            this.textBoxTimeout.TabIndex = 5;
            // 
            // textBoxConfirmationTime
            // 
            this.textBoxConfirmationTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxConfirmationTime.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxConfirmationTime.Location = new System.Drawing.Point(204, 62);
            this.textBoxConfirmationTime.Name = "textBoxConfirmationTime";
            this.textBoxConfirmationTime.ReadOnly = true;
            this.textBoxConfirmationTime.Size = new System.Drawing.Size(100, 20);
            this.textBoxConfirmationTime.TabIndex = 6;
            // 
            // textBoxConfirmationCount
            // 
            this.textBoxConfirmationCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxConfirmationCount.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxConfirmationCount.Location = new System.Drawing.Point(204, 91);
            this.textBoxConfirmationCount.Name = "textBoxConfirmationCount";
            this.textBoxConfirmationCount.ReadOnly = true;
            this.textBoxConfirmationCount.Size = new System.Drawing.Size(100, 20);
            this.textBoxConfirmationCount.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 466);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.filterBox.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCnfNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCnfTime)).EndInit();
            this.outputBox.ResumeLayout(false);
            this.valueBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox filterBox;
        private System.Windows.Forms.GroupBox outputBox;
        private System.Windows.Forms.GroupBox valueBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton radioButtonOn;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownTimeout;
        private System.Windows.Forms.NumericUpDown numericUpDownCnfNum;
        private System.Windows.Forms.NumericUpDown numericUpDownCnfTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxConfirmedValue;
        private System.Windows.Forms.TextBox textBoxTimeout;
        private System.Windows.Forms.TextBox textBoxConfirmationTime;
        private System.Windows.Forms.TextBox textBoxConfirmationCount;
    }
}

