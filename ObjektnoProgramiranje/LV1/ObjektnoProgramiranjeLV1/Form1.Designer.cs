namespace ObjektnoProgramiranjeLV1
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
            this.lblBtn1 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.lblBtn2 = new System.Windows.Forms.Label();
            this.lblLastClicked = new System.Windows.Forms.Label();
            this.btn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBtn1
            // 
            this.lblBtn1.AutoSize = true;
            this.lblBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBtn1.Location = new System.Drawing.Point(258, 134);
            this.lblBtn1.Name = "lblBtn1";
            this.lblBtn1.Size = new System.Drawing.Size(143, 17);
            this.lblBtn1.TabIndex = 1;
            this.lblBtn1.Text = "Tipka 1 nije pritisnuta";
            this.lblBtn1.TextChanged += new System.EventHandler(this.lblBtn1_TextChanged);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(482, 134);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "Tipka 1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lblBtn2
            // 
            this.lblBtn2.AutoSize = true;
            this.lblBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBtn2.Location = new System.Drawing.Point(258, 220);
            this.lblBtn2.Name = "lblBtn2";
            this.lblBtn2.Size = new System.Drawing.Size(143, 17);
            this.lblBtn2.TabIndex = 4;
            this.lblBtn2.Text = "Tipka 2 nije pritisnuta";
            this.lblBtn2.TextChanged += new System.EventHandler(this.lblBtn2_TextChanged);
            // 
            // lblLastClicked
            // 
            this.lblLastClicked.AutoSize = true;
            this.lblLastClicked.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastClicked.Location = new System.Drawing.Point(281, 286);
            this.lblLastClicked.Name = "lblLastClicked";
            this.lblLastClicked.Size = new System.Drawing.Size(209, 20);
            this.lblLastClicked.TabIndex = 5;
            this.lblLastClicked.Text = "Niti jedna tipka nije pritisnuta";
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(482, 220);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 6;
            this.btn2.Text = "Tipka 2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.lblLastClicked);
            this.Controls.Add(this.lblBtn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lblBtn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBtn1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lblBtn2;
        private System.Windows.Forms.Label lblLastClicked;
        private System.Windows.Forms.Button btn2;
    }
}

