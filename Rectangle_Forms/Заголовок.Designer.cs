﻿namespace Rectangle_Forms
{
    partial class Заголовок
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
            button1=new Button();
            button2=new Button();
            button3=new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor=Color.Aqua;
            button1.Location=new Point(288, 87);
            button1.Name="button1";
            button1.Size=new Size(99, 69);
            button1.TabIndex=0;
            button1.Text="Задание прямоуголник";
            button1.UseVisualStyleBackColor=false;
            button1.Click+=button1_Click;
            // 
            // button2
            // 
            button2.BackColor=Color.Aqua;
            button2.Location=new Point(165, 87);
            button2.Name="button2";
            button2.Size=new Size(99, 69);
            button2.TabIndex=1;
            button2.Text="Таймер";
            button2.UseVisualStyleBackColor=false;
            button2.Click+=button2_Click;
            // 
            // button3
            // 
            button3.BackColor=Color.Aqua;
            button3.Location=new Point(40, 87);
            button3.Name="button3";
            button3.Size=new Size(99, 69);
            button3.TabIndex=2;
            button3.Text="Калькулятор";
            button3.UseVisualStyleBackColor=false;
            button3.Click+=button3_Click;
            // 
            // Заголовок
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.Moccasin;
            ClientSize=new Size(443, 252);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            Name="Заголовок";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Заголовок";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
    }
}