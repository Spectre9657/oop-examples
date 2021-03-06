﻿namespace _2048_Game
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.UpDate = new System.Windows.Forms.Timer(this.components);
            this.start = new System.Windows.Forms.PictureBox();
            this.scores = new System.Windows.Forms.Label();
            this.GameOwer = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bg = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameOwer)).BeginInit();
            this.bg.SuspendLayout();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.RoyalBlue;
            this.start.Location = new System.Drawing.Point(9, 6);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(260, 28);
            this.start.TabIndex = 3;
            this.start.TabStop = false;
            this.start.Click += new System.EventHandler(this.start_Click_1);
            // 
            // scores
            // 
            this.scores.AutoSize = true;
            this.scores.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.scores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scores.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.scores.Location = new System.Drawing.Point(133, 66);
            this.scores.Name = "scores";
            this.scores.Size = new System.Drawing.Size(19, 20);
            this.scores.TabIndex = 5;
            this.scores.Text = "0";
            this.scores.Visible = false;
            // 
            // GameOwer
            // 
            this.GameOwer.BackColor = System.Drawing.Color.Transparent;
            this.GameOwer.BackgroundImage = global::_2048_Game.Properties.Resources.gm;
            this.GameOwer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GameOwer.Enabled = false;
            this.GameOwer.Location = new System.Drawing.Point(-3, 186);
            this.GameOwer.Name = "GameOwer";
            this.GameOwer.Size = new System.Drawing.Size(284, 132);
            this.GameOwer.TabIndex = 6;
            this.GameOwer.TabStop = false;
            this.GameOwer.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.RoyalBlue;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(76, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Начать игру!";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // bg
            // 
            this.bg.Controls.Add(this.scores);
            this.bg.Location = new System.Drawing.Point(-1, 40);
            this.bg.Name = "bg";
            this.bg.Size = new System.Drawing.Size(284, 278);
            this.bg.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Начать игру заново";
            this.label1.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(279, 318);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GameOwer);
            this.Controls.Add(this.start);
            this.Controls.Add(this.bg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2048";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.K_D);
            ((System.ComponentModel.ISupportInitialize)(this.start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameOwer)).EndInit();
            this.bg.ResumeLayout(false);
            this.bg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer UpDate;
        private System.Windows.Forms.PictureBox start;
        private System.Windows.Forms.Label scores;
        private System.Windows.Forms.PictureBox GameOwer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel bg;
        private System.Windows.Forms.Label label1;
    }
}

