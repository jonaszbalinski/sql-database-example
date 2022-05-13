namespace sql_database_example
{
    partial class FormEditPerson
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.buttonAddCar = new System.Windows.Forms.Button();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelMark = new System.Windows.Forms.Label();
            this.textBoxMark = new System.Windows.Forms.TextBox();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.listBoxCars = new System.Windows.Forms.ListBox();
            this.labelListOfCars = new System.Windows.Forms.Label();
            this.buttonDeleteCar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(118, 50);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(199, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(36, 154);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(281, 41);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(118, 105);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 3;
            // 
            // labelName
            // 
            this.labelName.Location = new System.Drawing.Point(12, 45);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(100, 32);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Name:";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDate
            // 
            this.labelDate.Location = new System.Drawing.Point(12, 102);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(100, 33);
            this.labelDate.TabIndex = 5;
            this.labelDate.Text = "DL date: ";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAddCar
            // 
            this.buttonAddCar.Location = new System.Drawing.Point(389, 154);
            this.buttonAddCar.Name = "buttonAddCar";
            this.buttonAddCar.Size = new System.Drawing.Size(274, 41);
            this.buttonAddCar.TabIndex = 6;
            this.buttonAddCar.Text = "Add car";
            this.buttonAddCar.UseVisualStyleBackColor = true;
            this.buttonAddCar.Click += new System.EventHandler(this.buttonAddCar_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.Location = new System.Drawing.Point(358, 102);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(100, 33);
            this.labelPrice.TabIndex = 8;
            this.labelPrice.Text = "Price:";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMark
            // 
            this.labelMark.Location = new System.Drawing.Point(358, 45);
            this.labelMark.Name = "labelMark";
            this.labelMark.Size = new System.Drawing.Size(100, 32);
            this.labelMark.TabIndex = 7;
            this.labelMark.Text = "Mark:";
            this.labelMark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxMark
            // 
            this.textBoxMark.Location = new System.Drawing.Point(464, 50);
            this.textBoxMark.Name = "textBoxMark";
            this.textBoxMark.Size = new System.Drawing.Size(199, 22);
            this.textBoxMark.TabIndex = 9;
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.Location = new System.Drawing.Point(464, 108);
            this.numericUpDownPrice.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(200, 22);
            this.numericUpDownPrice.TabIndex = 10;
            // 
            // listBoxCars
            // 
            this.listBoxCars.FormattingEnabled = true;
            this.listBoxCars.ItemHeight = 16;
            this.listBoxCars.Location = new System.Drawing.Point(185, 264);
            this.listBoxCars.Name = "listBoxCars";
            this.listBoxCars.Size = new System.Drawing.Size(330, 164);
            this.listBoxCars.TabIndex = 11;
            // 
            // labelListOfCars
            // 
            this.labelListOfCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelListOfCars.Location = new System.Drawing.Point(287, 225);
            this.labelListOfCars.Name = "labelListOfCars";
            this.labelListOfCars.Size = new System.Drawing.Size(130, 36);
            this.labelListOfCars.TabIndex = 12;
            this.labelListOfCars.Text = "Car list";
            this.labelListOfCars.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonDeleteCar
            // 
            this.buttonDeleteCar.Location = new System.Drawing.Point(272, 437);
            this.buttonDeleteCar.Name = "buttonDeleteCar";
            this.buttonDeleteCar.Size = new System.Drawing.Size(162, 41);
            this.buttonDeleteCar.TabIndex = 14;
            this.buttonDeleteCar.Text = "Delete car";
            this.buttonDeleteCar.UseVisualStyleBackColor = true;
            this.buttonDeleteCar.Click += new System.EventHandler(this.buttonDeleteCar_Click);
            // 
            // FormEditPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 503);
            this.Controls.Add(this.buttonDeleteCar);
            this.Controls.Add(this.labelListOfCars);
            this.Controls.Add(this.listBoxCars);
            this.Controls.Add(this.numericUpDownPrice);
            this.Controls.Add(this.textBoxMark);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelMark);
            this.Controls.Add(this.buttonAddCar);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxName);
            this.Name = "FormEditPerson";
            this.Text = "FormEditPerson";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button buttonAddCar;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelMark;
        private System.Windows.Forms.TextBox textBoxMark;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.ListBox listBoxCars;
        private System.Windows.Forms.Label labelListOfCars;
        private System.Windows.Forms.Button buttonDeleteCar;
    }
}