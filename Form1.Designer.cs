/*******************************************
 * 
 * Copyright (c) High School Blek, 2025
 * 
 * File:        Form1.Designer.cs
 * Author:      JustDrven
 * 
 *******************************************/

namespace praxe_desktop_client
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            VyberPodleCenyBtn = new RadioButton();
            VyberPodleKomodyBtn = new RadioButton();
            VyberPodleNazvuBtn = new RadioButton();
            OdInput = new TextBox();
            DoInput = new TextBox();
            NazevInput = new TextBox();
            ListBox1 = new ListBox();
            Button1 = new Button();
            GridView1 = new DataGridView();
            kosik1 = new ListBox();
            kosik2 = new ListBox();
            vkr = new Label();
            Button2 = new Button();
            JmenoInput = new TextBox();
            PrijmeniInput = new TextBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)GridView1).BeginInit();
            SuspendLayout();
            // 
            // VyberPodleCenyBtn
            // 
            VyberPodleCenyBtn.Location = new Point(30, 30);
            VyberPodleCenyBtn.Name = "VyberPodleCenyBtn";
            VyberPodleCenyBtn.Size = new Size(104, 24);
            VyberPodleCenyBtn.TabIndex = 0;
            VyberPodleCenyBtn.Text = "Výběr podle ceny";
            // 
            // VyberPodleKomodyBtn
            // 
            VyberPodleKomodyBtn.Location = new Point(30, 100);
            VyberPodleKomodyBtn.Name = "VyberPodleKomodyBtn";
            VyberPodleKomodyBtn.Size = new Size(104, 24);
            VyberPodleKomodyBtn.TabIndex = 3;
            VyberPodleKomodyBtn.Text = "Výběr podle komodity";
            // 
            // VyberPodleNazvuBtn
            // 
            VyberPodleNazvuBtn.Location = new Point(30, 300);
            VyberPodleNazvuBtn.Name = "VyberPodleNazvuBtn";
            VyberPodleNazvuBtn.Size = new Size(104, 24);
            VyberPodleNazvuBtn.TabIndex = 5;
            VyberPodleNazvuBtn.Text = "Výběr podle názvu";
            // 
            // OdInput
            // 
            OdInput.Location = new Point(30, 60);
            OdInput.Name = "OdInput";
            OdInput.Size = new Size(100, 23);
            OdInput.TabIndex = 1;
            // 
            // DoInput
            // 
            DoInput.Location = new Point(150, 60);
            DoInput.Name = "DoInput";
            DoInput.Size = new Size(100, 23);
            DoInput.TabIndex = 2;
            // 
            // NazevInput
            // 
            NazevInput.Location = new Point(30, 330);
            NazevInput.Name = "NazevInput";
            NazevInput.Size = new Size(100, 23);
            NazevInput.TabIndex = 6;
            // 
            // ListBox1
            // 
            ListBox1.ItemHeight = 15;
            ListBox1.Location = new Point(30, 130);
            ListBox1.Name = "ListBox1";
            ListBox1.Size = new Size(200, 139);
            ListBox1.TabIndex = 4;
            // 
            // Button1
            // 
            Button1.Location = new Point(30, 370);
            Button1.Name = "Button1";
            Button1.Size = new Size(75, 23);
            Button1.TabIndex = 7;
            Button1.Text = "Výběr";
            Button1.Click += Button1_Click;
            // 
            // GridView1
            // 
            GridView1.Location = new Point(260, 30);
            GridView1.Name = "GridView1";
            GridView1.Size = new Size(600, 250);
            GridView1.TabIndex = 8;
            GridView1.CellClick += GridView1_CellClick;
            // 
            // kosik1
            // 
            kosik1.ItemHeight = 15;
            kosik1.Location = new Point(30, 420);
            kosik1.Name = "kosik1";
            kosik1.Size = new Size(250, 109);
            kosik1.TabIndex = 9;
            // 
            // kosik2
            // 
            kosik2.ItemHeight = 15;
            kosik2.Location = new Point(300, 420);
            kosik2.Name = "kosik2";
            kosik2.Size = new Size(100, 109);
            kosik2.TabIndex = 10;
            // 
            // vkr
            // 
            vkr.Location = new Point(30, 550);
            vkr.Name = "vkr";
            vkr.Size = new Size(400, 25);
            vkr.TabIndex = 11;
            vkr.Text = "Celková hodnota objednavky: 0";
            // 
            // Button2
            // 
            Button2.Location = new Point(450, 490);
            Button2.Name = "Button2";
            Button2.Size = new Size(75, 23);
            Button2.TabIndex = 14;
            Button2.Text = "Objednej";
            Button2.Click += Button2_Click;
            // 
            // JmenoInput
            // 
            JmenoInput.Location = new Point(450, 420);
            JmenoInput.Name = "JmenoInput";
            JmenoInput.Size = new Size(100, 23);
            JmenoInput.TabIndex = 12;
            // 
            // PrijmeniInput
            // 
            PrijmeniInput.Location = new Point(450, 450);
            PrijmeniInput.Name = "PrijmeniInput";
            PrijmeniInput.Size = new Size(100, 23);
            PrijmeniInput.TabIndex = 13;
            // 
            // button3
            // 
            button3.Location = new Point(260, 292);
            button3.Name = "button3";
            button3.Size = new Size(600, 40);
            button3.TabIndex = 15;
            button3.Text = "Přehled Objednávek";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(900, 620);
            Controls.Add(button3);
            Controls.Add(VyberPodleCenyBtn);
            Controls.Add(OdInput);
            Controls.Add(DoInput);
            Controls.Add(VyberPodleKomodyBtn);
            Controls.Add(ListBox1);
            Controls.Add(VyberPodleNazvuBtn);
            Controls.Add(NazevInput);
            Controls.Add(Button1);
            Controls.Add(GridView1);
            Controls.Add(kosik1);
            Controls.Add(kosik2);
            Controls.Add(vkr);
            Controls.Add(JmenoInput);
            Controls.Add(PrijmeniInput);
            Controls.Add(Button2);
            Name = "Form1";
            Text = "Objednávky";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)GridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.RadioButton VyberPodleCenyBtn;
        private System.Windows.Forms.RadioButton VyberPodleKomodyBtn;
        private System.Windows.Forms.RadioButton VyberPodleNazvuBtn;
        private System.Windows.Forms.TextBox OdInput;
        private System.Windows.Forms.TextBox DoInput;
        private System.Windows.Forms.TextBox NazevInput;
        private System.Windows.Forms.ListBox ListBox1;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.DataGridView GridView1;
        private System.Windows.Forms.ListBox kosik1;
        private System.Windows.Forms.ListBox kosik2;
        private System.Windows.Forms.Label vkr;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.TextBox JmenoInput;
        private System.Windows.Forms.TextBox PrijmeniInput;
        private Button button3;
    }
}
