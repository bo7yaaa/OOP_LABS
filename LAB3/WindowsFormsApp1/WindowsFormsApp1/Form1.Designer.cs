namespace FigureCalculator
{
    partial class Form1
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
            this.BtnRectangle = new System.Windows.Forms.Button();
            this.BtnCircle = new System.Windows.Forms.Button();
            this.BtnTrapezium = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnRectangle
            // 
            this.BtnRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnRectangle.Location = new System.Drawing.Point(305, 87);
            this.BtnRectangle.Name = "BtnRectangle";
            this.BtnRectangle.Size = new System.Drawing.Size(159, 85);
            this.BtnRectangle.TabIndex = 0;
            this.BtnRectangle.Text = "Прямокутник";
            this.BtnRectangle.UseVisualStyleBackColor = true;
            this.BtnRectangle.Click += new System.EventHandler(this.BtnRectangle_Click_1);
            // 
            // BtnCircle
            // 
            this.BtnCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnCircle.Location = new System.Drawing.Point(305, 178);
            this.BtnCircle.Name = "BtnCircle";
            this.BtnCircle.Size = new System.Drawing.Size(159, 85);
            this.BtnCircle.TabIndex = 1;
            this.BtnCircle.Text = "Коло";
            this.BtnCircle.UseVisualStyleBackColor = true;
            this.BtnCircle.Click += new System.EventHandler(this.BtnCircle_Click_1);
            // 
            // BtnTrapezium
            // 
            this.BtnTrapezium.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnTrapezium.Location = new System.Drawing.Point(305, 269);
            this.BtnTrapezium.Name = "BtnTrapezium";
            this.BtnTrapezium.Size = new System.Drawing.Size(159, 85);
            this.BtnTrapezium.TabIndex = 2;
            this.BtnTrapezium.Text = "Трапеція";
            this.BtnTrapezium.UseVisualStyleBackColor = true;
            this.BtnTrapezium.Click += new System.EventHandler(this.BtnTrapezium_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnTrapezium);
            this.Controls.Add(this.BtnCircle);
            this.Controls.Add(this.BtnRectangle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnRectangle;
        private System.Windows.Forms.Button BtnCircle;
        private System.Windows.Forms.Button BtnTrapezium;
    }
}

