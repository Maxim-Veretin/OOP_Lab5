namespace Forms_Lab5
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
            this.hoverButton1 = new Forms_Lab5.HoverButton();
            this.ellipseHoverButton1 = new Forms_Lab5.EllipseHoverButton();
            this.SuspendLayout();
            // 
            // hoverButton1
            // 
            this.hoverButton1.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoverButton1.ForeColor = System.Drawing.Color.Black;
            this.hoverButton1.Location = new System.Drawing.Point(12, 12);
            this.hoverButton1.Name = "hoverButton1";
            this.hoverButton1.Size = new System.Drawing.Size(337, 337);
            this.hoverButton1.TabIndex = 0;
            this.hoverButton1.Text = "SSS";
            this.hoverButton1.UseVisualStyleBackColor = true;
            // 
            // ellipseHoverButton1
            // 
            this.ellipseHoverButton1.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ellipseHoverButton1.ForeColor = System.Drawing.Color.Black;
            this.ellipseHoverButton1.Location = new System.Drawing.Point(359, 12);
            this.ellipseHoverButton1.Name = "ellipseHoverButton1";
            this.ellipseHoverButton1.Size = new System.Drawing.Size(337, 337);
            this.ellipseHoverButton1.TabIndex = 1;
            this.ellipseHoverButton1.Text = "ellipseHoverButton1";
            this.ellipseHoverButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 361);
            this.Controls.Add(this.ellipseHoverButton1);
            this.Controls.Add(this.hoverButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private HoverButton hoverButton1;
        private EllipseHoverButton ellipseHoverButton1;
    }
}

