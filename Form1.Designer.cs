﻿namespace PacMAN
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.Hero = new System.Windows.Forms.PictureBox();
            this.Food = new System.Windows.Forms.PictureBox();
            this.Enemy = new System.Windows.Forms.PictureBox();
            this.TimerHeroMove = new System.Windows.Forms.Timer(this.components);
            this.TimerHeroAnimate = new System.Windows.Forms.Timer(this.components);
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.TimerEnemyAnimate = new System.Windows.Forms.Timer(this.components);
            this.TimerHeroMelt = new System.Windows.Forms.Timer(this.components);
            this.TimerEnemyMove = new System.Windows.Forms.Timer(this.components);
            this.LabelGameOver = new System.Windows.Forms.Label();
            this.buttonRestart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Hero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Food)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).BeginInit();
            this.SuspendLayout();
            // 
            // Hero
            // 
            this.Hero.BackColor = System.Drawing.Color.Fuchsia;
            this.Hero.Location = new System.Drawing.Point(65, 79);
            this.Hero.Name = "Hero";
            this.Hero.Size = new System.Drawing.Size(150, 150);
            this.Hero.TabIndex = 0;
            this.Hero.TabStop = false;
            this.Hero.Click += new System.EventHandler(this.Hero_Click);
            // 
            // Food
            // 
            this.Food.BackColor = System.Drawing.Color.Lime;
            this.Food.Location = new System.Drawing.Point(436, 51);
            this.Food.Name = "Food";
            this.Food.Size = new System.Drawing.Size(50, 50);
            this.Food.TabIndex = 1;
            this.Food.TabStop = false;
            this.Food.Click += new System.EventHandler(this.Food_Click);
            // 
            // Enemy
            // 
            this.Enemy.BackColor = System.Drawing.Color.Red;
            this.Enemy.Location = new System.Drawing.Point(593, 119);
            this.Enemy.Name = "Enemy";
            this.Enemy.Size = new System.Drawing.Size(80, 80);
            this.Enemy.TabIndex = 2;
            this.Enemy.TabStop = false;
            this.Enemy.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // TimerHeroMove
            // 
            this.TimerHeroMove.Interval = 20;
            this.TimerHeroMove.Tick += new System.EventHandler(this.TimerHeroMove_Tick);
            // 
            // TimerHeroAnimate
            // 
            this.TimerHeroAnimate.Tick += new System.EventHandler(this.TimerHeroAnimate_Tick);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ScoreLabel.Location = new System.Drawing.Point(12, 9);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(79, 29);
            this.ScoreLabel.TabIndex = 3;
            this.ScoreLabel.Text = "label1";
            // 
            // TimerEnemyAnimate
            // 
            this.TimerEnemyAnimate.Tick += new System.EventHandler(this.TimerEnemyAnimate_Tick);
            // 
            // TimerHeroMelt
            // 
            this.TimerHeroMelt.Tick += new System.EventHandler(this.TimerHeroMelt_Tick);
            // 
            // TimerEnemyMove
            // 
            this.TimerEnemyMove.Interval = 20;
            this.TimerEnemyMove.Tick += new System.EventHandler(this.TimerEnemyMove_Tick);
            // 
            // LabelGameOver
            // 
            this.LabelGameOver.AutoSize = true;
            this.LabelGameOver.Font = new System.Drawing.Font("MS Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelGameOver.ForeColor = System.Drawing.Color.Coral;
            this.LabelGameOver.Location = new System.Drawing.Point(236, 119);
            this.LabelGameOver.Name = "LabelGameOver";
            this.LabelGameOver.Size = new System.Drawing.Size(316, 64);
            this.LabelGameOver.TabIndex = 4;
            this.LabelGameOver.Text = "Game Over";
            this.LabelGameOver.Visible = false;
            // 
            // buttonRestart
            // 
            this.buttonRestart.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestart.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestart.Location = new System.Drawing.Point(294, 186);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(192, 61);
            this.buttonRestart.TabIndex = 5;
            this.buttonRestart.Text = "RESTART";
            this.buttonRestart.UseVisualStyleBackColor = false;
            this.buttonRestart.Visible = false;
            this.buttonRestart.Click += new System.EventHandler(this.ButtonRestart_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 371);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.LabelGameOver);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.Enemy);
            this.Controls.Add(this.Food);
            this.Controls.Add(this.Hero);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game";
            this.Text = "Pac-man Elements";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Hero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Food)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Hero;
        private System.Windows.Forms.PictureBox Food;
        private System.Windows.Forms.PictureBox Enemy;
        private System.Windows.Forms.Timer TimerHeroMove;
        private System.Windows.Forms.Timer TimerHeroAnimate;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Timer TimerEnemyAnimate;
        private System.Windows.Forms.Timer TimerHeroMelt;
        private System.Windows.Forms.Timer TimerEnemyMove;
        private System.Windows.Forms.Label LabelGameOver;
        private System.Windows.Forms.Button buttonRestart;
    }
}

