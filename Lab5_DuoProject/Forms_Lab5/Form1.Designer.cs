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
            this.hoverBut = new Forms_Lab5.HoverButton();
            this.ellipseHoverBut = new Forms_Lab5.EllipseHoverButton();
            this.SuspendLayout();
            // 
            // hoverBut
            // 
            this.hoverBut.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoverBut.ForeColor = System.Drawing.Color.Black;
            this.hoverBut.Location = new System.Drawing.Point(12, 12);
            this.hoverBut.Name = "hoverBut";
            this.hoverBut.Size = new System.Drawing.Size(337, 337);
            this.hoverBut.TabIndex = 0;
            this.hoverBut.Text = " ";
            this.hoverBut.UseVisualStyleBackColor = true;
            // 
            // ellipseHoverBut
            // 
            this.ellipseHoverBut.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ellipseHoverBut.ForeColor = System.Drawing.Color.Black;
            this.ellipseHoverBut.Location = new System.Drawing.Point(359, 12);
            this.ellipseHoverBut.Name = "ellipseHoverBut";
            this.ellipseHoverBut.Size = new System.Drawing.Size(337, 337);
            this.ellipseHoverBut.TabIndex = 1;
            this.ellipseHoverBut.Text = " ";
            this.ellipseHoverBut.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 361);
            this.Controls.Add(this.ellipseHoverBut);
            this.Controls.Add(this.hoverBut);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private HoverButton hoverBut;
        private EllipseHoverButton ellipseHoverBut;
    }
}

