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
            this.selectButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.deleteALLButton = new System.Windows.Forms.Button();
            this.buttonPrim = new System.Windows.Forms.Button();
            this.buttonKruskal = new System.Windows.Forms.Button();
            this.buttonBoruvka = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sheet)).BeginInit();
            this.SuspendLayout();
            // 
            // sheet
            // 
            this.sheet.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.sheet.Location = new System.Drawing.Point(113, 12);
            this.sheet.Name = "sheet";
            this.sheet.Size = new System.Drawing.Size(799, 449);
            this.sheet.TabIndex = 0;
            this.sheet.TabStop = false;
            this.sheet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sheet_MouseClick);
            // 
            // drawVertexButton
            // 
            this.drawVertexButton.Location = new System.Drawing.Point(12, 87);
            this.drawVertexButton.Name = "drawVertexButton";
            this.drawVertexButton.Size = new System.Drawing.Size(95, 59);
            this.drawVertexButton.TabIndex = 1;
            this.drawVertexButton.Text = "Нарисовать вершину";
            this.drawVertexButton.UseVisualStyleBackColor = true;
            this.drawVertexButton.Click += new System.EventHandler(this.drawVertexButton_Click);
            // 
            // drawEdgeButton
            // 
            this.drawEdgeButton.Location = new System.Drawing.Point(12, 168);
            this.drawEdgeButton.Name = "drawEdgeButton";
            this.drawEdgeButton.Size = new System.Drawing.Size(95, 59);
            this.drawEdgeButton.TabIndex = 2;
            this.drawEdgeButton.Text = "Нарисовать ребро";
            this.drawEdgeButton.UseVisualStyleBackColor = true;
            this.drawEdgeButton.Click += new System.EventHandler(this.drawEdgeButton_Click);
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(12, 12);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(95, 59);
            this.selectButton.TabIndex = 3;
            this.selectButton.Text = "Выбрать";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(12, 246);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(95, 59);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // deleteALLButton
            // 
            this.deleteALLButton.Location = new System.Drawing.Point(12, 328);
            this.deleteALLButton.Name = "deleteALLButton";
            this.deleteALLButton.Size = new System.Drawing.Size(95, 59);
            this.deleteALLButton.TabIndex = 5;
            this.deleteALLButton.Text = "Удалить все";
            this.deleteALLButton.UseVisualStyleBackColor = true;
            this.deleteALLButton.Click += new System.EventHandler(this.deleteALLButton_Click);
            // 
            // buttonPrim
            // 
            this.buttonPrim.Location = new System.Drawing.Point(113, 467);
            this.buttonPrim.Name = "buttonPrim";
            this.buttonPrim.Size = new System.Drawing.Size(158, 62);
            this.buttonPrim.TabIndex = 6;
            this.buttonPrim.Text = "Решить Алгоритмом Прима";
            this.buttonPrim.UseVisualStyleBackColor = true;
            this.buttonPrim.Click += new System.EventHandler(this.buttonPrim_Click);
            // 
            // buttonKruskal
            // 
            this.buttonKruskal.Location = new System.Drawing.Point(419, 467);
            this.buttonKruskal.Name = "buttonKruskal";
            this.buttonKruskal.Size = new System.Drawing.Size(184, 62);
            this.buttonKruskal.TabIndex = 7;
            this.buttonKruskal.Text = "Решить Алгоритмом Крускала";
            this.buttonKruskal.UseVisualStyleBackColor = true;
            this.buttonKruskal.Click += new System.EventHandler(this.buttonKruskal_Click);
            // 
            // buttonBoruvka
            // 
            this.buttonBoruvka.Location = new System.Drawing.Point(726, 467);
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
            // DrawGraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 555);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonBoruvka);
            this.Controls.Add(this.buttonKruskal);
            this.Controls.Add(this.buttonPrim);
            this.Controls.Add(this.deleteALLButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.drawEdgeButton);
            this.Controls.Add(this.drawVertexButton);
            this.Controls.Add(this.sheet);
            this.Name = "DrawGraphForm";
            this.Text = "DrawGraf";
            ((System.ComponentModel.ISupportInitialize)(this.sheet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox sheet;
        private System.Windows.Forms.Button drawVertexButton;
        private System.Windows.Forms.Button drawEdgeButton;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button deleteALLButton;
        private System.Windows.Forms.Button buttonPrim;
        private System.Windows.Forms.Button buttonKruskal;
        private System.Windows.Forms.Button buttonBoruvka;
        private System.Windows.Forms.Button button1;
    }
}