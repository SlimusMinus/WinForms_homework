namespace Rectangle_Forms
{
    partial class Timercs
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
            components=new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Timercs));
            label2=new Label();
            Bt_stop=new Button();
            Bt_start=new Button();
            label1=new Label();
            timer1=new System.Windows.Forms.Timer(components);
            numerUP=new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numerUP).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.BackColor=Color.White;
            label2.Font=new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location=new Point(161, 156);
            label2.Name="label2";
            label2.Size=new Size(22, 25);
            label2.TabIndex=9;
            label2.Text="0";
            // 
            // Bt_stop
            // 
            Bt_stop.BackColor=Color.FromArgb(255, 128, 128);
            Bt_stop.Font=new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Bt_stop.Location=new Point(203, 102);
            Bt_stop.Name="Bt_stop";
            Bt_stop.Size=new Size(120, 32);
            Bt_stop.TabIndex=8;
            Bt_stop.Text="STOP";
            Bt_stop.UseVisualStyleBackColor=false;
            Bt_stop.Click+=Bt_stop_Click_1;
            // 
            // Bt_start
            // 
            Bt_start.BackColor=Color.FromArgb(128, 255, 128);
            Bt_start.Font=new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Bt_start.Location=new Point(27, 102);
            Bt_start.Name="Bt_start";
            Bt_start.Size=new Size(116, 32);
            Bt_start.TabIndex=7;
            Bt_start.Text="START";
            Bt_start.UseVisualStyleBackColor=false;
            Bt_start.Click+=Bt_start_Click_1;
            // 
            // label1
            // 
            label1.BackColor=SystemColors.InactiveCaption;
            label1.BorderStyle=BorderStyle.FixedSingle;
            label1.Location=new Point(27, 41);
            label1.Name="label1";
            label1.Size=new Size(116, 23);
            label1.TabIndex=6;
            label1.Text="Количество секунд";
            label1.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Interval=1000;
            timer1.Tick+=timer1_Tick_1;
            // 
            // numerUP
            // 
            numerUP.Location=new Point(203, 41);
            numerUP.Name="numerUP";
            numerUP.Size=new Size(120, 23);
            numerUP.TabIndex=10;
            // 
            // Timercs
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackgroundImage=(Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout=ImageLayout.Stretch;
            ClientSize=new Size(348, 213);
            Controls.Add(label2);
            Controls.Add(Bt_stop);
            Controls.Add(Bt_start);
            Controls.Add(label1);
            Controls.Add(numerUP);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            Icon=(Icon)resources.GetObject("$this.Icon");
            Name="Timercs";
            Text="Timercs";
            ((System.ComponentModel.ISupportInitialize)numerUP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button Bt_stop;
        private Button Bt_start;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private NumericUpDown numerUP;
    }
}