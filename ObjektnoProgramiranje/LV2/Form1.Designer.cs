namespace OPLV2
{
    partial class Form1
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
            this.gbObject = new System.Windows.Forms.GroupBox();
            this.rbPoly = new System.Windows.Forms.RadioButton();
            this.rbSquare = new System.Windows.Forms.RadioButton();
            this.rbLine = new System.Windows.Forms.RadioButton();
            this.rbCircle = new System.Windows.Forms.RadioButton();
            this.rbEllip = new System.Windows.Forms.RadioButton();
            this.gbColor = new System.Windows.Forms.GroupBox();
            this.rbBlue = new System.Windows.Forms.RadioButton();
            this.rbRed = new System.Windows.Forms.RadioButton();
            this.rbBlack = new System.Windows.Forms.RadioButton();
            this.gbObject.SuspendLayout();
            this.gbColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbObject
            // 
            this.gbObject.Controls.Add(this.rbPoly);
            this.gbObject.Controls.Add(this.rbSquare);
            this.gbObject.Controls.Add(this.rbLine);
            this.gbObject.Controls.Add(this.rbCircle);
            this.gbObject.Controls.Add(this.rbEllip);
            this.gbObject.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbObject.Location = new System.Drawing.Point(687, 69);
            this.gbObject.Name = "gbObject";
            this.gbObject.Size = new System.Drawing.Size(101, 143);
            this.gbObject.TabIndex = 0;
            this.gbObject.TabStop = false;
            this.gbObject.Text = "Graf. objekti";
            // 
            // rbPoly
            // 
            this.rbPoly.AutoSize = true;
            this.rbPoly.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbPoly.Location = new System.Drawing.Point(7, 111);
            this.rbPoly.Name = "rbPoly";
            this.rbPoly.Size = new System.Drawing.Size(60, 17);
            this.rbPoly.TabIndex = 4;
            this.rbPoly.TabStop = true;
            this.rbPoly.Text = "Poligon";
            this.rbPoly.UseVisualStyleBackColor = true;
            // 
            // rbSquare
            // 
            this.rbSquare.AutoSize = true;
            this.rbSquare.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbSquare.Location = new System.Drawing.Point(7, 88);
            this.rbSquare.Name = "rbSquare";
            this.rbSquare.Size = new System.Drawing.Size(82, 17);
            this.rbSquare.TabIndex = 3;
            this.rbSquare.TabStop = true;
            this.rbSquare.Text = "Pravokutnik";
            this.rbSquare.UseVisualStyleBackColor = true;
            // 
            // rbLine
            // 
            this.rbLine.AutoSize = true;
            this.rbLine.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbLine.Location = new System.Drawing.Point(7, 65);
            this.rbLine.Name = "rbLine";
            this.rbLine.Size = new System.Drawing.Size(49, 17);
            this.rbLine.TabIndex = 2;
            this.rbLine.TabStop = true;
            this.rbLine.Text = "Linija";
            this.rbLine.UseVisualStyleBackColor = true;
            // 
            // rbCircle
            // 
            this.rbCircle.AutoSize = true;
            this.rbCircle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbCircle.Location = new System.Drawing.Point(6, 42);
            this.rbCircle.Name = "rbCircle";
            this.rbCircle.Size = new System.Drawing.Size(66, 17);
            this.rbCircle.TabIndex = 1;
            this.rbCircle.TabStop = true;
            this.rbCircle.Text = "Kruznica";
            this.rbCircle.UseVisualStyleBackColor = true;
            // 
            // rbEllip
            // 
            this.rbEllip.AutoSize = true;
            this.rbEllip.Checked = true;
            this.rbEllip.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbEllip.Location = new System.Drawing.Point(6, 19);
            this.rbEllip.Name = "rbEllip";
            this.rbEllip.Size = new System.Drawing.Size(53, 17);
            this.rbEllip.TabIndex = 0;
            this.rbEllip.TabStop = true;
            this.rbEllip.Text = "Elipsa";
            this.rbEllip.UseVisualStyleBackColor = true;
            // 
            // gbColor
            // 
            this.gbColor.Controls.Add(this.rbBlue);
            this.gbColor.Controls.Add(this.rbRed);
            this.gbColor.Controls.Add(this.rbBlack);
            this.gbColor.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbColor.Location = new System.Drawing.Point(687, 233);
            this.gbColor.Name = "gbColor";
            this.gbColor.Size = new System.Drawing.Size(101, 100);
            this.gbColor.TabIndex = 1;
            this.gbColor.TabStop = false;
            this.gbColor.Text = "Boja";
            // 
            // rbBlue
            // 
            this.rbBlue.AutoSize = true;
            this.rbBlue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbBlue.Location = new System.Drawing.Point(6, 65);
            this.rbBlue.Name = "rbBlue";
            this.rbBlue.Size = new System.Drawing.Size(52, 17);
            this.rbBlue.TabIndex = 2;
            this.rbBlue.TabStop = true;
            this.rbBlue.Text = "Plava";
            this.rbBlue.UseVisualStyleBackColor = true;
            // 
            // rbRed
            // 
            this.rbRed.AutoSize = true;
            this.rbRed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbRed.Location = new System.Drawing.Point(6, 42);
            this.rbRed.Name = "rbRed";
            this.rbRed.Size = new System.Drawing.Size(59, 17);
            this.rbRed.TabIndex = 1;
            this.rbRed.TabStop = true;
            this.rbRed.Text = "Crvena";
            this.rbRed.UseVisualStyleBackColor = true;
            // 
            // rbBlack
            // 
            this.rbBlack.AutoSize = true;
            this.rbBlack.Checked = true;
            this.rbBlack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbBlack.Location = new System.Drawing.Point(6, 19);
            this.rbBlack.Name = "rbBlack";
            this.rbBlack.Size = new System.Drawing.Size(47, 17);
            this.rbBlack.TabIndex = 0;
            this.rbBlack.TabStop = true;
            this.rbBlack.Text = "Crna";
            this.rbBlack.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbColor);
            this.Controls.Add(this.gbObject);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.gbObject.ResumeLayout(false);
            this.gbObject.PerformLayout();
            this.gbColor.ResumeLayout(false);
            this.gbColor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbObject;
        private System.Windows.Forms.RadioButton rbCircle;
        private System.Windows.Forms.RadioButton rbEllip;
        private System.Windows.Forms.GroupBox gbColor;
        private System.Windows.Forms.RadioButton rbPoly;
        private System.Windows.Forms.RadioButton rbSquare;
        private System.Windows.Forms.RadioButton rbLine;
        private System.Windows.Forms.RadioButton rbBlue;
        private System.Windows.Forms.RadioButton rbRed;
        private System.Windows.Forms.RadioButton rbBlack;
    }
}

