namespace GraphicInterface
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.time1 = new System.Windows.Forms.Label();
            this.time2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Prim = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.verticalcount = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelTimeBoruvka5 = new System.Windows.Forms.Label();
            this.labelTimeBoruvka4 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.labelTimeBoruvka3 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.labelTimeBoruvka2 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.labelTimeBoruvka1 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelTimePrim5 = new System.Windows.Forms.Label();
            this.labelTimePrim4 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelTimePrim3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelTimePrim2 = new System.Windows.Forms.Label();
            this.labelTimePrim1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelTimeKruskal5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelTimeKruskal4 = new System.Windows.Forms.Label();
            this.labelTimeKruskal3 = new System.Windows.Forms.Label();
            this.labelTimeKruskal2 = new System.Windows.Forms.Label();
            this.labelTimeKruskal1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Prim.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // time1
            // 
            this.time1.AutoSize = true;
            this.time1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time1.Location = new System.Drawing.Point(101, 16);
            this.time1.Name = "time1";
            this.time1.Size = new System.Drawing.Size(96, 24);
            this.time1.TabIndex = 7;
            this.time1.Text = "Time Prim";
            // 
            // time2
            // 
            this.time2.AutoSize = true;
            this.time2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time2.Location = new System.Drawing.Point(87, 16);
            this.time2.Name = "time2";
            this.time2.Size = new System.Drawing.Size(119, 24);
            this.time2.TabIndex = 8;
            this.time2.Text = "Time Kruskal";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1113, 450);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Prim);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1105, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Алгоритмы";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Prim
            // 
            this.Prim.Controls.Add(this.button7);
            this.Prim.Controls.Add(this.button4);
            this.Prim.Controls.Add(this.listBox3);
            this.Prim.Controls.Add(this.listBox2);
            this.Prim.Controls.Add(this.button6);
            this.Prim.Controls.Add(this.label2);
            this.Prim.Controls.Add(this.verticalcount);
            this.Prim.Controls.Add(this.listBox1);
            this.Prim.Controls.Add(this.button1);
            this.Prim.Controls.Add(this.button3);
            this.Prim.Controls.Add(this.button2);
            this.Prim.Location = new System.Drawing.Point(10, 6);
            this.Prim.Name = "Prim";
            this.Prim.Size = new System.Drawing.Size(1001, 351);
            this.Prim.TabIndex = 5;
            this.Prim.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(780, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 52);
            this.button4.TabIndex = 13;
            this.button4.Text = "Решить Boruvka";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // listBox3
            // 
            this.listBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 24;
            this.listBox3.Location = new System.Drawing.Point(675, 125);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(311, 220);
            this.listBox3.TabIndex = 12;
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 24;
            this.listBox2.Location = new System.Drawing.Point(332, 125);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(311, 220);
            this.listBox2.TabIndex = 11;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(584, 20);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(104, 52);
            this.button6.TabIndex = 4;
            this.button6.Text = "Решить Kruskal";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Введите кол-во вершин";
            // 
            // verticalcount
            // 
            this.verticalcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.verticalcount.Location = new System.Drawing.Point(246, 84);
            this.verticalcount.Name = "verticalcount";
            this.verticalcount.Size = new System.Drawing.Size(100, 29);
            this.verticalcount.TabIndex = 9;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(19, 125);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(295, 220);
            this.listBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить граф";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(246, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 52);
            this.button3.TabIndex = 3;
            this.button3.Text = "Решить Prim";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(134, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 52);
            this.button2.TabIndex = 2;
            this.button2.Text = "Очистить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1105, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Время";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(438, 380);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(147, 41);
            this.button5.TabIndex = 24;
            this.button5.Text = "Вычислить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelTimeBoruvka5);
            this.groupBox3.Controls.Add(this.labelTimeBoruvka4);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.labelTimeBoruvka3);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.labelTimeBoruvka2);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.labelTimeBoruvka1);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Location = new System.Drawing.Point(678, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(330, 368);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Time Boruvka";
            // 
            // labelTimeBoruvka5
            // 
            this.labelTimeBoruvka5.AutoSize = true;
            this.labelTimeBoruvka5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimeBoruvka5.Location = new System.Drawing.Point(241, 304);
            this.labelTimeBoruvka5.Name = "labelTimeBoruvka5";
            this.labelTimeBoruvka5.Size = new System.Drawing.Size(24, 25);
            this.labelTimeBoruvka5.TabIndex = 24;
            this.labelTimeBoruvka5.Text = "0";
            // 
            // labelTimeBoruvka4
            // 
            this.labelTimeBoruvka4.AutoSize = true;
            this.labelTimeBoruvka4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimeBoruvka4.Location = new System.Drawing.Point(241, 259);
            this.labelTimeBoruvka4.Name = "labelTimeBoruvka4";
            this.labelTimeBoruvka4.Size = new System.Drawing.Size(24, 25);
            this.labelTimeBoruvka4.TabIndex = 22;
            this.labelTimeBoruvka4.Text = "0";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label25.Location = new System.Drawing.Point(6, 304);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(90, 25);
            this.label25.TabIndex = 23;
            this.label25.Text = "160 000";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(6, 259);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 25);
            this.label15.TabIndex = 14;
            this.label15.Text = "80 000";
            // 
            // labelTimeBoruvka3
            // 
            this.labelTimeBoruvka3.AutoSize = true;
            this.labelTimeBoruvka3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimeBoruvka3.Location = new System.Drawing.Point(241, 216);
            this.labelTimeBoruvka3.Name = "labelTimeBoruvka3";
            this.labelTimeBoruvka3.Size = new System.Drawing.Size(24, 25);
            this.labelTimeBoruvka3.TabIndex = 21;
            this.labelTimeBoruvka3.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(6, 216);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 25);
            this.label17.TabIndex = 13;
            this.label17.Text = "40 000";
            // 
            // labelTimeBoruvka2
            // 
            this.labelTimeBoruvka2.AutoSize = true;
            this.labelTimeBoruvka2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimeBoruvka2.Location = new System.Drawing.Point(241, 168);
            this.labelTimeBoruvka2.Name = "labelTimeBoruvka2";
            this.labelTimeBoruvka2.Size = new System.Drawing.Size(24, 25);
            this.labelTimeBoruvka2.TabIndex = 20;
            this.labelTimeBoruvka2.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(101, 16);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(126, 24);
            this.label19.TabIndex = 7;
            this.label19.Text = "Time Boruvka";
            // 
            // labelTimeBoruvka1
            // 
            this.labelTimeBoruvka1.AutoSize = true;
            this.labelTimeBoruvka1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimeBoruvka1.Location = new System.Drawing.Point(241, 119);
            this.labelTimeBoruvka1.Name = "labelTimeBoruvka1";
            this.labelTimeBoruvka1.Size = new System.Drawing.Size(24, 25);
            this.labelTimeBoruvka1.TabIndex = 19;
            this.labelTimeBoruvka1.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(6, 168);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(78, 25);
            this.label21.TabIndex = 12;
            this.label21.Text = "20 000";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.Location = new System.Drawing.Point(6, 119);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(78, 25);
            this.label22.TabIndex = 11;
            this.label22.Text = "10 000";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.Location = new System.Drawing.Point(217, 61);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(69, 29);
            this.label23.TabIndex = 10;
            this.label23.Text = "Time";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label24.Location = new System.Drawing.Point(22, 61);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(31, 29);
            this.label24.TabIndex = 9;
            this.label24.Text = "N";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelTimePrim5);
            this.groupBox2.Controls.Add(this.labelTimePrim4);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.labelTimePrim3);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.labelTimePrim2);
            this.groupBox2.Controls.Add(this.time1);
            this.groupBox2.Controls.Add(this.labelTimePrim1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(342, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 368);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Time Prim";
            // 
            // labelTimePrim5
            // 
            this.labelTimePrim5.AutoSize = true;
            this.labelTimePrim5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimePrim5.Location = new System.Drawing.Point(241, 304);
            this.labelTimePrim5.Name = "labelTimePrim5";
            this.labelTimePrim5.Size = new System.Drawing.Size(24, 25);
            this.labelTimePrim5.TabIndex = 22;
            this.labelTimePrim5.Text = "0";
            // 
            // labelTimePrim4
            // 
            this.labelTimePrim4.AutoSize = true;
            this.labelTimePrim4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimePrim4.Location = new System.Drawing.Point(241, 259);
            this.labelTimePrim4.Name = "labelTimePrim4";
            this.labelTimePrim4.Size = new System.Drawing.Size(24, 25);
            this.labelTimePrim4.TabIndex = 22;
            this.labelTimePrim4.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(6, 304);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 25);
            this.label18.TabIndex = 21;
            this.label18.Text = "160 000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "80 000";
            // 
            // labelTimePrim3
            // 
            this.labelTimePrim3.AutoSize = true;
            this.labelTimePrim3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimePrim3.Location = new System.Drawing.Point(241, 216);
            this.labelTimePrim3.Name = "labelTimePrim3";
            this.labelTimePrim3.Size = new System.Drawing.Size(24, 25);
            this.labelTimePrim3.TabIndex = 21;
            this.labelTimePrim3.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(6, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "40 000";
            // 
            // labelTimePrim2
            // 
            this.labelTimePrim2.AutoSize = true;
            this.labelTimePrim2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimePrim2.Location = new System.Drawing.Point(241, 168);
            this.labelTimePrim2.Name = "labelTimePrim2";
            this.labelTimePrim2.Size = new System.Drawing.Size(24, 25);
            this.labelTimePrim2.TabIndex = 20;
            this.labelTimePrim2.Text = "0";
            // 
            // labelTimePrim1
            // 
            this.labelTimePrim1.AutoSize = true;
            this.labelTimePrim1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimePrim1.Location = new System.Drawing.Point(241, 119);
            this.labelTimePrim1.Name = "labelTimePrim1";
            this.labelTimePrim1.Size = new System.Drawing.Size(24, 25);
            this.labelTimePrim1.TabIndex = 19;
            this.labelTimePrim1.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(6, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 25);
            this.label10.TabIndex = 12;
            this.label10.Text = "20 000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(6, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 25);
            this.label11.TabIndex = 11;
            this.label11.Text = "10 000";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(217, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 29);
            this.label13.TabIndex = 10;
            this.label13.Text = "Time";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(22, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 29);
            this.label14.TabIndex = 9;
            this.label14.Text = "N";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelTimeKruskal5);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.labelTimeKruskal4);
            this.groupBox1.Controls.Add(this.labelTimeKruskal3);
            this.groupBox1.Controls.Add(this.labelTimeKruskal2);
            this.groupBox1.Controls.Add(this.labelTimeKruskal1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.time2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 368);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Time Kruskal";
            // 
            // labelTimeKruskal5
            // 
            this.labelTimeKruskal5.AutoSize = true;
            this.labelTimeKruskal5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimeKruskal5.Location = new System.Drawing.Point(235, 304);
            this.labelTimeKruskal5.Name = "labelTimeKruskal5";
            this.labelTimeKruskal5.Size = new System.Drawing.Size(24, 25);
            this.labelTimeKruskal5.TabIndex = 20;
            this.labelTimeKruskal5.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(6, 304);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 25);
            this.label12.TabIndex = 19;
            this.label12.Text = "160 000";
            // 
            // labelTimeKruskal4
            // 
            this.labelTimeKruskal4.AutoSize = true;
            this.labelTimeKruskal4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimeKruskal4.Location = new System.Drawing.Point(235, 259);
            this.labelTimeKruskal4.Name = "labelTimeKruskal4";
            this.labelTimeKruskal4.Size = new System.Drawing.Size(24, 25);
            this.labelTimeKruskal4.TabIndex = 18;
            this.labelTimeKruskal4.Text = "0";
            // 
            // labelTimeKruskal3
            // 
            this.labelTimeKruskal3.AutoSize = true;
            this.labelTimeKruskal3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimeKruskal3.Location = new System.Drawing.Point(235, 216);
            this.labelTimeKruskal3.Name = "labelTimeKruskal3";
            this.labelTimeKruskal3.Size = new System.Drawing.Size(24, 25);
            this.labelTimeKruskal3.TabIndex = 17;
            this.labelTimeKruskal3.Text = "0";
            // 
            // labelTimeKruskal2
            // 
            this.labelTimeKruskal2.AutoSize = true;
            this.labelTimeKruskal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimeKruskal2.Location = new System.Drawing.Point(235, 168);
            this.labelTimeKruskal2.Name = "labelTimeKruskal2";
            this.labelTimeKruskal2.Size = new System.Drawing.Size(24, 25);
            this.labelTimeKruskal2.TabIndex = 16;
            this.labelTimeKruskal2.Text = "0";
            // 
            // labelTimeKruskal1
            // 
            this.labelTimeKruskal1.AutoSize = true;
            this.labelTimeKruskal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimeKruskal1.Location = new System.Drawing.Point(235, 119);
            this.labelTimeKruskal1.Name = "labelTimeKruskal1";
            this.labelTimeKruskal1.Size = new System.Drawing.Size(24, 25);
            this.labelTimeKruskal1.TabIndex = 15;
            this.labelTimeKruskal1.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "80 000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "40 000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "20 000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "10 000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(219, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "N";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(392, 19);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(104, 52);
            this.button7.TabIndex = 14;
            this.button7.Text = "Нарисовать Граф";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 446);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.Prim.ResumeLayout(false);
            this.Prim.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label time1;
        private System.Windows.Forms.Label time2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox Prim;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox verticalcount;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelTimeBoruvka4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelTimeBoruvka3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label labelTimeBoruvka2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label labelTimeBoruvka1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelTimePrim4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelTimePrim3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelTimePrim2;
        private System.Windows.Forms.Label labelTimePrim1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelTimeKruskal4;
        private System.Windows.Forms.Label labelTimeKruskal3;
        private System.Windows.Forms.Label labelTimeKruskal2;
        private System.Windows.Forms.Label labelTimeKruskal1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTimeBoruvka5;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label labelTimePrim5;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label labelTimeKruskal5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button7;
    }
}

