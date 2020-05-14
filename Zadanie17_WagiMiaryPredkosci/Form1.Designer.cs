namespace Zadanie17_WagiMiaryPredkosci
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
            this.numUpDown_Input = new System.Windows.Forms.NumericUpDown();
            this.listBox_UnitsToConvert = new System.Windows.Forms.ListBox();
            this.lbl_text = new System.Windows.Forms.Label();
            this.textBox_Conversion = new System.Windows.Forms.TextBox();
            this.lbl_UnitsInfo = new System.Windows.Forms.Label();
            this.btn_ClearEntry = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Input)).BeginInit();
            this.SuspendLayout();
            // 
            // numUpDown_Input
            // 
            this.numUpDown_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numUpDown_Input.Location = new System.Drawing.Point(14, 138);
            this.numUpDown_Input.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numUpDown_Input.Minimum = new decimal(new int[] {
            1410065408,
            2,
            0,
            -2147483648});
            this.numUpDown_Input.Name = "numUpDown_Input";
            this.numUpDown_Input.Size = new System.Drawing.Size(149, 29);
            this.numUpDown_Input.TabIndex = 0;
            this.numUpDown_Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // listBox_UnitsToConvert
            // 
            this.listBox_UnitsToConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox_UnitsToConvert.FormattingEnabled = true;
            this.listBox_UnitsToConvert.ItemHeight = 25;
            this.listBox_UnitsToConvert.Items.AddRange(new object[] {
            "Gram -> Ounce",
            "Ounce -> Gram",
            "Kilogram -> Pound",
            "Pound -> Kilogram",
            "Kilogram -> Russian Pound",
            "Russian Pound -> Kilogram",
            "Celsius -> Fahrenheit",
            "Farhenheit -> Celsius",
            "Kilometer per hour -> Knot",
            "Knot -> Kilometer per hour",
            "Meter -> Yard",
            "Yard -> Meter",
            "Liter - US Liqiud Gallon",
            "US Liquid Gallon - Liter"});
            this.listBox_UnitsToConvert.Location = new System.Drawing.Point(189, 12);
            this.listBox_UnitsToConvert.Name = "listBox_UnitsToConvert";
            this.listBox_UnitsToConvert.Size = new System.Drawing.Size(279, 354);
            this.listBox_UnitsToConvert.TabIndex = 1;
            this.listBox_UnitsToConvert.SelectedIndexChanged += new System.EventHandler(this.listBox_UnitsToConvert_SelectedIndexChanged);
            // 
            // lbl_text
            // 
            this.lbl_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_text.Location = new System.Drawing.Point(14, 42);
            this.lbl_text.Name = "lbl_text";
            this.lbl_text.Size = new System.Drawing.Size(153, 69);
            this.lbl_text.TabIndex = 2;
            this.lbl_text.Text = "Enter the value and choose which units you want to convert:";
            // 
            // textBox_Conversion
            // 
            this.textBox_Conversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_Conversion.Location = new System.Drawing.Point(494, 138);
            this.textBox_Conversion.Name = "textBox_Conversion";
            this.textBox_Conversion.Size = new System.Drawing.Size(222, 29);
            this.textBox_Conversion.TabIndex = 3;
            this.textBox_Conversion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_UnitsInfo
            // 
            this.lbl_UnitsInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_UnitsInfo.Location = new System.Drawing.Point(513, 179);
            this.lbl_UnitsInfo.Name = "lbl_UnitsInfo";
            this.lbl_UnitsInfo.Size = new System.Drawing.Size(181, 88);
            this.lbl_UnitsInfo.TabIndex = 4;
            this.lbl_UnitsInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_ClearEntry
            // 
            this.btn_ClearEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_ClearEntry.Location = new System.Drawing.Point(14, 213);
            this.btn_ClearEntry.Name = "btn_ClearEntry";
            this.btn_ClearEntry.Size = new System.Drawing.Size(153, 35);
            this.btn_ClearEntry.TabIndex = 5;
            this.btn_ClearEntry.Text = "Clear last entry";
            this.btn_ClearEntry.UseVisualStyleBackColor = true;
            this.btn_ClearEntry.Click += new System.EventHandler(this.btn_ClearEntry_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 378);
            this.Controls.Add(this.btn_ClearEntry);
            this.Controls.Add(this.lbl_UnitsInfo);
            this.Controls.Add(this.textBox_Conversion);
            this.Controls.Add(this.lbl_text);
            this.Controls.Add(this.listBox_UnitsToConvert);
            this.Controls.Add(this.numUpDown_Input);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(744, 416);
            this.MinimumSize = new System.Drawing.Size(744, 416);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unit Converter";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numUpDown_Input;
        private System.Windows.Forms.ListBox listBox_UnitsToConvert;
        private System.Windows.Forms.Label lbl_text;
        private System.Windows.Forms.TextBox textBox_Conversion;
        private System.Windows.Forms.Label lbl_UnitsInfo;
        private System.Windows.Forms.Button btn_ClearEntry;
    }
}

