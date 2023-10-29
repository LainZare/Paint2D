namespace Paint2D
{
    partial class ResizeDialog
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBoxWidth = new TextBox();
            textBoxHeight = new TextBox();
            label3 = new Label();
            textBoxError = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(140, 112);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "确定";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("更纱黑体 UI SC", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(95, 27);
            label1.Name = "label1";
            label1.Size = new Size(30, 24);
            label1.TabIndex = 1;
            label1.Text = "宽";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("更纱黑体 UI SC", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(258, 27);
            label2.Name = "label2";
            label2.Size = new Size(30, 24);
            label2.TabIndex = 2;
            label2.Text = "高";
            // 
            // textBoxWidth
            // 
            textBoxWidth.Location = new Point(45, 50);
            textBoxWidth.Name = "textBoxWidth";
            textBoxWidth.Size = new Size(125, 28);
            textBoxWidth.TabIndex = 3;
            textBoxWidth.Text = "0";
            textBoxWidth.KeyPress += textBoxWidth_KeyPress;
            // 
            // textBoxHeight
            // 
            textBoxHeight.Location = new Point(210, 50);
            textBoxHeight.Name = "textBoxHeight";
            textBoxHeight.Size = new Size(125, 28);
            textBoxHeight.TabIndex = 4;
            textBoxHeight.Text = "0";
            textBoxHeight.KeyPress += textBoxHeight_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(180, 55);
            label3.Name = "label3";
            label3.Size = new Size(20, 20);
            label3.TabIndex = 5;
            label3.Text = "×";
            // 
            // textBoxError
            // 
            textBoxError.BackColor = SystemColors.Control;
            textBoxError.BorderStyle = BorderStyle.None;
            textBoxError.ForeColor = Color.Red;
            textBoxError.Location = new Point(95, 78);
            textBoxError.Name = "textBoxError";
            textBoxError.Size = new Size(193, 21);
            textBoxError.TabIndex = 6;
            // 
            // ResizeDialog
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 153);
            Controls.Add(textBoxError);
            Controls.Add(label3);
            Controls.Add(textBoxHeight);
            Controls.Add(textBoxWidth);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            MaximizeBox = false;
            MaximumSize = new Size(400, 200);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            MinimumSize = new Size(400, 200);
            Name = "ResizeDialog";
            Text = "设置图像分辨率";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxError;
        internal TextBox textBoxWidth;
        internal TextBox textBoxHeight;
    }
}