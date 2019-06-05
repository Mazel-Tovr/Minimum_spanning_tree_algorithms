namespace GraphicInterface
{
    partial class DrawGraphForm
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
            this.sheet = new System.Windows.Forms.PictureBox();
            this.drawVertexButton = new System.Windows.Forms.Button();
            this.drawEdgeButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.deleteALLButton = new System.Windows.Forms.Button();
            this.buttonPrim = new System.Windows.Forms.Button();
            this.buttonKruskal = new System.Windows.Forms.Button();
            this.buttonBoruvka = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sheet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // sheet
            // 
            this.sheet.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.sheet.Location = new System.Drawing.Point(113, 12);
            this.sheet.Name = "sheet";
            this.sheet.Size = new System.Drawing.Size(846, 449);
            this.sheet.TabIndex = 0;
            this.sheet.TabStop = false;
            this.sheet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sheet_MouseClick);
            // 
            // drawVertexButton
            // 
            this.drawVertexButton.Location = new System.Drawing.Point(12, 12);
            this.drawVertexButton.Name = "drawVertexButton";
            this.drawVertexButton.Size = new System.Drawing.Size(95, 59);
            this.drawVertexButton.TabIndex = 1;
            this.drawVertexButton.Text = "Нарисовать вершину";
            this.drawVertexButton.UseVisualStyleBackColor = true;
            this.drawVertexButton.Click += new System.EventHandler(this.drawVertexButton_Click);
            // 
            // drawEdgeButton
            // 
            this.drawEdgeButton.Location = new System.Drawing.Point(12, 113);
            this.drawEdgeButton.Name = "drawEdgeButton";
            this.drawEdgeButton.Size = new System.Drawing.Size(95, 59);
            this.drawEdgeButton.TabIndex = 2;
            this.drawEdgeButton.Text = "Нарисовать ребро";
            this.drawEdgeButton.UseVisualStyleBackColor = true;
            this.drawEdgeButton.Click += new System.EventHandler(this.drawEdgeButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(12, 213);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(95, 59);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // deleteALLButton
            // 
            this.deleteALLButton.Location = new System.Drawing.Point(12, 309);
            this.deleteALLButton.Name = "deleteALLButton";
            this.deleteALLButton.Size = new System.Drawing.Size(95, 59);
            this.deleteALLButton.TabIndex = 5;
            this.deleteALLButton.Text = "Удалить все";
            this.deleteALLButton.UseVisualStyleBackColor = true;
            this.deleteALLButton.Click += new System.EventHandler(this.deleteALLButton_Click);
            // 
            // buttonPrim
            // 
            this.buttonPrim.Location = new System.Drawing.Point(6, 8);
            this.buttonPrim.Name = "buttonPrim";
            this.buttonPrim.Size = new System.Drawing.Size(158, 62);
            this.buttonPrim.TabIndex = 6;
            this.buttonPrim.Text = "Решить Алгоритмом Прима";
            this.buttonPrim.UseVisualStyleBackColor = true;
            this.buttonPrim.Click += new System.EventHandler(this.buttonPrim_Click);
            // 
            // buttonKruskal
            // 
            this.buttonKruskal.Location = new System.Drawing.Point(6, 6);
            this.buttonKruskal.Name = "buttonKruskal";
            this.buttonKruskal.Size = new System.Drawing.Size(184, 62);
            this.buttonKruskal.TabIndex = 7;
            this.buttonKruskal.Text = "Решить Алгоритмом Крускала";
            this.buttonKruskal.UseVisualStyleBackColor = true;
            this.buttonKruskal.Click += new System.EventHandler(this.buttonKruskal_Click);
            // 
            // buttonBoruvka
            // 
            this.buttonBoruvka.Location = new System.Drawing.Point(0, 0);
            this.buttonBoruvka.Name = "buttonBoruvka";
            this.buttonBoruvka.Size = new System.Drawing.Size(186, 62);
            this.buttonBoruvka.TabIndex = 8;
            this.buttonBoruvka.Text = "Решить Алгоритмом Борувки";
            this.buttonBoruvka.UseVisualStyleBackColor = true;
            this.buttonBoruvka.Click += new System.EventHandler(this.buttonBoruvka_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 59);
            this.button1.TabIndex = 9;
            this.button1.Text = "Открыть другую форму";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.buttonPrim);
            this.groupBox1.Location = new System.Drawing.Point(12, 467);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 76);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(170, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 61);
            this.button2.TabIndex = 7;
            this.button2.Text = "иттерация прим";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.buttonKruskal);
            this.groupBox2.Location = new System.Drawing.Point(308, 469);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 68);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(196, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 61);
            this.button3.TabIndex = 8;
            this.button3.Text = "иттерация Крускал";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.buttonBoruvka);
            this.groupBox3.Location = new System.Drawing.Point(642, 476);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(321, 61);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(192, 1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 61);
            this.button4.TabIndex = 9;
            this.button4.Text = "иттерация Борувка";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // DrawGraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 555);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deleteALLButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.drawEdgeButton);
            this.Controls.Add(this.drawVertexButton);
            this.Controls.Add(this.sheet);
            this.Name = "DrawGraphForm";
            this.Text = "DrawGraf";
            ((System.ComponentModel.ISupportInitialize)(this.sheet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox sheet;
        private System.Windows.Forms.Button drawVertexButton;
        private System.Windows.Forms.Button drawEdgeButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button deleteALLButton;
        private System.Windows.Forms.Button buttonPrim;
        private System.Windows.Forms.Button buttonKruskal;
        private System.Windows.Forms.Button buttonBoruvka;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button4;
    }
}