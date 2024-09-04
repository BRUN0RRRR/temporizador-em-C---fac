namespace temporizador
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            horasinp = new NumericUpDown();
            minutosinp = new NumericUpDown();
            segundoinp = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)horasinp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minutosinp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)segundoinp).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += tempo1;
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.BackColor = Color.CornflowerBlue;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.BackColor = Color.Red;
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            resources.ApplyResources(button3, "button3");
            button3.BackColor = Color.DarkKhaki;
            button3.Name = "button3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // horasinp
            // 
            resources.ApplyResources(horasinp, "horasinp");
            horasinp.Name = "horasinp";
            // 
            // minutosinp
            // 
            resources.ApplyResources(minutosinp, "minutosinp");
            minutosinp.Name = "minutosinp";
            // 
            // segundoinp
            // 
            resources.ApplyResources(segundoinp, "segundoinp");
            segundoinp.Name = "segundoinp";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(segundoinp);
            Controls.Add(minutosinp);
            Controls.Add(horasinp);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Show;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)horasinp).EndInit();
            ((System.ComponentModel.ISupportInitialize)minutosinp).EndInit();
            ((System.ComponentModel.ISupportInitialize)segundoinp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private Button button2;
        private Button button3;
        private NumericUpDown horasinp;
        private NumericUpDown minutosinp;
        private NumericUpDown segundoinp;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
