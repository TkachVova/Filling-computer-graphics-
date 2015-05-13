namespace Графика2
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.drawButton = new System.Windows.Forms.Button();
            this.rotateButton = new System.Windows.Forms.Button();
            this.scaleButton = new System.Windows.Forms.Button();
            this.transferButton = new System.Windows.Forms.Button();
            this.degreesToRotate = new System.Windows.Forms.NumericUpDown();
            this.rotateLabel = new System.Windows.Forms.Label();
            this.rotateCenterX = new System.Windows.Forms.NumericUpDown();
            this.rotateCenterY = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.scaleX = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.scaleY = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.transferX = new System.Windows.Forms.NumericUpDown();
            this.transferY = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.clearCurve = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.degreesToRotate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateCenterX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateCenterY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferY)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(900, 628);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // drawButton
            // 
            this.drawButton.Enabled = false;
            this.drawButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.drawButton.Location = new System.Drawing.Point(12, 646);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(150, 75);
            this.drawButton.TabIndex = 1;
            this.drawButton.Text = "Відобразити";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // rotateButton
            // 
            this.rotateButton.Enabled = false;
            this.rotateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.rotateButton.Location = new System.Drawing.Point(1022, 155);
            this.rotateButton.Name = "rotateButton";
            this.rotateButton.Size = new System.Drawing.Size(150, 75);
            this.rotateButton.TabIndex = 2;
            this.rotateButton.Text = "Повернути";
            this.rotateButton.UseVisualStyleBackColor = true;
            this.rotateButton.Click += new System.EventHandler(this.rotateButton_Click);
            // 
            // scaleButton
            // 
            this.scaleButton.Enabled = false;
            this.scaleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.scaleButton.Location = new System.Drawing.Point(1022, 378);
            this.scaleButton.Name = "scaleButton";
            this.scaleButton.Size = new System.Drawing.Size(150, 75);
            this.scaleButton.TabIndex = 3;
            this.scaleButton.Text = "Встановити";
            this.scaleButton.UseVisualStyleBackColor = true;
            this.scaleButton.Click += new System.EventHandler(this.scaleButton_Click);
            // 
            // transferButton
            // 
            this.transferButton.Enabled = false;
            this.transferButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.transferButton.Location = new System.Drawing.Point(1022, 606);
            this.transferButton.Name = "transferButton";
            this.transferButton.Size = new System.Drawing.Size(150, 75);
            this.transferButton.TabIndex = 4;
            this.transferButton.Text = "Зсунути";
            this.transferButton.UseVisualStyleBackColor = true;
            this.transferButton.Click += new System.EventHandler(this.transferButton_Click);
            // 
            // degreesToRotate
            // 
            this.degreesToRotate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.degreesToRotate.Location = new System.Drawing.Point(1052, 41);
            this.degreesToRotate.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.degreesToRotate.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.degreesToRotate.Name = "degreesToRotate";
            this.degreesToRotate.Size = new System.Drawing.Size(120, 32);
            this.degreesToRotate.TabIndex = 5;
            // 
            // rotateLabel
            // 
            this.rotateLabel.AutoSize = true;
            this.rotateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.rotateLabel.Location = new System.Drawing.Point(1074, 12);
            this.rotateLabel.Name = "rotateLabel";
            this.rotateLabel.Size = new System.Drawing.Size(98, 26);
            this.rotateLabel.TabIndex = 6;
            this.rotateLabel.Text = "Поворот";
            // 
            // rotateCenterX
            // 
            this.rotateCenterX.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.rotateCenterX.Location = new System.Drawing.Point(1052, 79);
            this.rotateCenterX.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.rotateCenterX.Name = "rotateCenterX";
            this.rotateCenterX.Size = new System.Drawing.Size(120, 32);
            this.rotateCenterX.TabIndex = 7;
            // 
            // rotateCenterY
            // 
            this.rotateCenterY.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.rotateCenterY.Location = new System.Drawing.Point(1052, 117);
            this.rotateCenterY.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.rotateCenterY.Name = "rotateCenterY";
            this.rotateCenterY.Size = new System.Drawing.Size(120, 32);
            this.rotateCenterY.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(1014, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(1013, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(988, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "Rad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Location = new System.Drawing.Point(1074, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "Масштаб";
            // 
            // scaleX
            // 
            this.scaleX.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.scaleX.Location = new System.Drawing.Point(1052, 302);
            this.scaleX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.scaleX.Name = "scaleX";
            this.scaleX.Size = new System.Drawing.Size(120, 32);
            this.scaleX.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.Location = new System.Drawing.Point(973, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "% (X):";
            // 
            // scaleY
            // 
            this.scaleY.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.scaleY.Location = new System.Drawing.Point(1052, 340);
            this.scaleY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.scaleY.Name = "scaleY";
            this.scaleY.Size = new System.Drawing.Size(120, 32);
            this.scaleY.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label6.Location = new System.Drawing.Point(973, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 26);
            this.label6.TabIndex = 16;
            this.label6.Text = "% (Y):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label7.Location = new System.Drawing.Point(1112, 501);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 26);
            this.label7.TabIndex = 17;
            this.label7.Text = "Зсув";
            // 
            // transferX
            // 
            this.transferX.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.transferX.Location = new System.Drawing.Point(1052, 530);
            this.transferX.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.transferX.Minimum = new decimal(new int[] {
            1200,
            0,
            0,
            -2147483648});
            this.transferX.Name = "transferX";
            this.transferX.Size = new System.Drawing.Size(120, 32);
            this.transferX.TabIndex = 18;
            // 
            // transferY
            // 
            this.transferY.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.transferY.Location = new System.Drawing.Point(1052, 568);
            this.transferY.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.transferY.Minimum = new decimal(new int[] {
            900,
            0,
            0,
            -2147483648});
            this.transferY.Name = "transferY";
            this.transferY.Size = new System.Drawing.Size(120, 32);
            this.transferY.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label8.Location = new System.Drawing.Point(1002, 530);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 26);
            this.label8.TabIndex = 20;
            this.label8.Text = "dX:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label9.Location = new System.Drawing.Point(1002, 568);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 26);
            this.label9.TabIndex = 21;
            this.label9.Text = "dY:";
            // 
            // clearCurve
            // 
            this.clearCurve.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.clearCurve.Location = new System.Drawing.Point(203, 646);
            this.clearCurve.Name = "clearCurve";
            this.clearCurve.Size = new System.Drawing.Size(150, 75);
            this.clearCurve.TabIndex = 22;
            this.clearCurve.Text = "Очистити";
            this.clearCurve.UseVisualStyleBackColor = true;
            this.clearCurve.Click += new System.EventHandler(this.clearCurve_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 733);
            this.Controls.Add(this.clearCurve);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.transferY);
            this.Controls.Add(this.transferX);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.scaleY);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.scaleX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rotateCenterY);
            this.Controls.Add(this.rotateCenterX);
            this.Controls.Add(this.rotateLabel);
            this.Controls.Add(this.degreesToRotate);
            this.Controls.Add(this.transferButton);
            this.Controls.Add(this.scaleButton);
            this.Controls.Add(this.rotateButton);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.degreesToRotate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateCenterX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateCenterY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Button rotateButton;
        private System.Windows.Forms.Button scaleButton;
        private System.Windows.Forms.Button transferButton;
        private System.Windows.Forms.NumericUpDown degreesToRotate;
        private System.Windows.Forms.Label rotateLabel;
        private System.Windows.Forms.NumericUpDown rotateCenterX;
        private System.Windows.Forms.NumericUpDown rotateCenterY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown scaleX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown scaleY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown transferX;
        private System.Windows.Forms.NumericUpDown transferY;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button clearCurve;
    }
}

