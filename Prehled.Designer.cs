/*******************************************
 * 
 * Copyright (c) High School Blek, 2025
 * 
 * File:        Prehled.Designer.cs
 * Author:      JustDrven
 * 
 *******************************************/

namespace praxe_desktop_client
{
    partial class Prehled
    {

        private System.ComponentModel.IContainer components = null;

     
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code


        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            JmInput = new TextBox();
            PrInput = new TextBox();
            button1 = new Button();
            PrehledVysledky = new DataGridView();
            PrehledId = new Label();
            PrehledJmenoAPrijmeni = new Label();
            PrehledHodnota = new Label();
            PrehledDatum = new Label();
            label7 = new Label();
            label8 = new Label();
            PrehledPolozky = new ListBox();
            ((System.ComponentModel.ISupportInitialize)PrehledVysledky).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 0;
            label1.Text = "Zadejte jméno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 1;
            label2.Text = "Zadejte příjmení";
            // 
            // JmInput
            // 
            JmInput.Location = new Point(111, 6);
            JmInput.Name = "JmInput";
            JmInput.Size = new Size(284, 23);
            JmInput.TabIndex = 2;
            // 
            // PrInput
            // 
            PrInput.Location = new Point(111, 35);
            PrInput.Name = "PrInput";
            PrInput.Size = new Size(284, 23);
            PrInput.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(401, 6);
            button1.Name = "button1";
            button1.Size = new Size(189, 53);
            button1.TabIndex = 4;
            button1.Text = "Vyhledat";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // PrehledVysledky
            // 
            PrehledVysledky.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PrehledVysledky.Location = new Point(12, 65);
            PrehledVysledky.Name = "PrehledVysledky";
            PrehledVysledky.Size = new Size(578, 211);
            PrehledVysledky.TabIndex = 5;
            PrehledVysledky.CellClick += PrehledVysledky_CellClick;
            // 
            // PrehledId
            // 
            PrehledId.AutoSize = true;
            PrehledId.Location = new Point(16, 335);
            PrehledId.Name = "PrehledId";
            PrehledId.Size = new Size(18, 15);
            PrehledId.TabIndex = 6;
            PrehledId.Text = "ID";
            // 
            // PrehledJmenoAPrijmeni
            // 
            PrehledJmenoAPrijmeni.AutoSize = true;
            PrehledJmenoAPrijmeni.Location = new Point(16, 362);
            PrehledJmenoAPrijmeni.Name = "PrehledJmenoAPrijmeni";
            PrehledJmenoAPrijmeni.Size = new Size(98, 15);
            PrehledJmenoAPrijmeni.TabIndex = 7;
            PrehledJmenoAPrijmeni.Text = "Jméno a příjmení";
            // 
            // PrehledHodnota
            // 
            PrehledHodnota.AutoSize = true;
            PrehledHodnota.Location = new Point(16, 413);
            PrehledHodnota.Name = "PrehledHodnota";
            PrehledHodnota.Size = new Size(54, 15);
            PrehledHodnota.TabIndex = 9;
            PrehledHodnota.Text = "Hodnota";
            // 
            // PrehledDatum
            // 
            PrehledDatum.AutoSize = true;
            PrehledDatum.Location = new Point(17, 388);
            PrehledDatum.Name = "PrehledDatum";
            PrehledDatum.Size = new Size(43, 15);
            PrehledDatum.TabIndex = 8;
            PrehledDatum.Text = "Datum";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(269, 322);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 10;
            label7.Text = "Položka";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(222, 288);
            label8.Name = "label8";
            label8.Size = new Size(117, 15);
            label8.TabIndex = 11;
            label8.Text = "Specifické informace";
            // 
            // PrehledPolozky
            // 
            PrehledPolozky.FormattingEnabled = true;
            PrehledPolozky.ItemHeight = 15;
            PrehledPolozky.Location = new Point(269, 350);
            PrehledPolozky.Name = "PrehledPolozky";
            PrehledPolozky.Size = new Size(321, 124);
            PrehledPolozky.TabIndex = 12;
            // 
            // Prehled
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 486);
            Controls.Add(PrehledPolozky);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(PrehledHodnota);
            Controls.Add(PrehledDatum);
            Controls.Add(PrehledJmenoAPrijmeni);
            Controls.Add(PrehledId);
            Controls.Add(PrehledVysledky);
            Controls.Add(button1);
            Controls.Add(PrInput);
            Controls.Add(JmInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Prehled";
            Text = "Prehled";
            ((System.ComponentModel.ISupportInitialize)PrehledVysledky).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox JmInput;
        private TextBox PrInput;
        private Button button1;
        private DataGridView PrehledVysledky;
        private Label PrehledId;
        private Label PrehledJmenoAPrijmeni;
        private Label PrehledHodnota;
        private Label PrehledDatum;
        private Label label7;
        private Label label8;
        private ListBox PrehledPolozky;
    }
}