using System.Collections.Generic;
using GreyHoundRacing.Models;

namespace GreyHoundRacing
{
    partial class x
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(x));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Testing = new System.Windows.Forms.Label();
            this.DollarAmount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Bet_Amount = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.Button_Bets = new System.Windows.Forms.Button();
            this.RaceStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Alex_Bet_Label = new System.Windows.Forms.Label();
            this.Ringo_Bet_Label = new System.Windows.Forms.Label();
            this.Joe_Bet_Label = new System.Windows.Forms.Label();
            this.label_bets = new System.Windows.Forms.Label();
            this.Radio_Alex = new System.Windows.Forms.RadioButton();
            this.Radio_Ringo = new System.Windows.Forms.RadioButton();
            this.RadioJoe = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Dog1 = new System.Windows.Forms.PictureBox();
            this.Dog2 = new System.Windows.Forms.PictureBox();
            this.Dog3 = new System.Windows.Forms.PictureBox();
            this.Dog4 = new System.Windows.Forms.PictureBox();
            this.race_timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(594, 206);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Testing);
            this.groupBox1.Controls.Add(this.DollarAmount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.Bet_Amount);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.Button_Bets);
            this.groupBox1.Controls.Add(this.RaceStart);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Alex_Bet_Label);
            this.groupBox1.Controls.Add(this.Ringo_Bet_Label);
            this.groupBox1.Controls.Add(this.Joe_Bet_Label);
            this.groupBox1.Controls.Add(this.label_bets);
            this.groupBox1.Controls.Add(this.Radio_Alex);
            this.groupBox1.Controls.Add(this.Radio_Ringo);
            this.groupBox1.Controls.Add(this.RadioJoe);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 116);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting Parlor";
            // 
            // Testing
            // 
            this.Testing.AutoSize = true;
            this.Testing.Location = new System.Drawing.Point(175, 16);
            this.Testing.Name = "Testing";
            this.Testing.Size = new System.Drawing.Size(0, 13);
            this.Testing.TabIndex = 22;
            // 
            // DollarAmount
            // 
            this.DollarAmount.AutoSize = true;
            this.DollarAmount.Location = new System.Drawing.Point(285, 71);
            this.DollarAmount.Name = "DollarAmount";
            this.DollarAmount.Size = new System.Drawing.Size(26, 13);
            this.DollarAmount.TabIndex = 21;
            this.DollarAmount.Text = "Bet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Dog";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(325, 40);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(57, 20);
            this.numericUpDown1.TabIndex = 14;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Bet_Amount
            // 
            this.Bet_Amount.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Bet_Amount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Bet_Amount.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bet_Amount.Location = new System.Drawing.Point(386, 36);
            this.Bet_Amount.Name = "Bet_Amount";
            this.Bet_Amount.Size = new System.Drawing.Size(76, 29);
            this.Bet_Amount.TabIndex = 13;
            this.Bet_Amount.Text = "$--";
            this.Bet_Amount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(313, 65);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(152, 45);
            this.trackBar1.SmallChange = 5;
            this.trackBar1.TabIndex = 20;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Button_Bets
            // 
            this.Button_Bets.Location = new System.Drawing.Point(323, 12);
            this.Button_Bets.Name = "Button_Bets";
            this.Button_Bets.Size = new System.Drawing.Size(142, 20);
            this.Button_Bets.TabIndex = 10;
            this.Button_Bets.Text = "Bets";
            this.Button_Bets.UseVisualStyleBackColor = true;
            this.Button_Bets.Click += new System.EventHandler(this.Button_Bets_Click);
            // 
            // RaceStart
            // 
            this.RaceStart.Location = new System.Drawing.Point(471, 16);
            this.RaceStart.Name = "RaceStart";
            this.RaceStart.Size = new System.Drawing.Size(119, 89);
            this.RaceStart.TabIndex = 9;
            this.RaceStart.Text = "Race";
            this.RaceStart.UseVisualStyleBackColor = true;
            this.RaceStart.Click += new System.EventHandler(this.RaceStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
            // Alex_Bet_Label
            // 
            this.Alex_Bet_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Alex_Bet_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alex_Bet_Label.Location = new System.Drawing.Point(91, 77);
            this.Alex_Bet_Label.Name = "Alex_Bet_Label";
            this.Alex_Bet_Label.Size = new System.Drawing.Size(190, 19);
            this.Alex_Bet_Label.TabIndex = 7;
            // 
            // Ringo_Bet_Label
            // 
            this.Ringo_Bet_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Ringo_Bet_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ringo_Bet_Label.Location = new System.Drawing.Point(91, 60);
            this.Ringo_Bet_Label.Name = "Ringo_Bet_Label";
            this.Ringo_Bet_Label.Size = new System.Drawing.Size(190, 19);
            this.Ringo_Bet_Label.TabIndex = 6;
            // 
            // Joe_Bet_Label
            // 
            this.Joe_Bet_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Joe_Bet_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Joe_Bet_Label.Location = new System.Drawing.Point(91, 42);
            this.Joe_Bet_Label.Name = "Joe_Bet_Label";
            this.Joe_Bet_Label.Size = new System.Drawing.Size(190, 19);
            this.Joe_Bet_Label.TabIndex = 5;
            // 
            // label_bets
            // 
            this.label_bets.AutoSize = true;
            this.label_bets.Location = new System.Drawing.Point(170, 20);
            this.label_bets.Name = "label_bets";
            this.label_bets.Size = new System.Drawing.Size(32, 13);
            this.label_bets.TabIndex = 4;
            this.label_bets.Text = "Bets";
            // 
            // Radio_Alex
            // 
            this.Radio_Alex.AutoSize = true;
            this.Radio_Alex.Location = new System.Drawing.Point(9, 76);
            this.Radio_Alex.Name = "Radio_Alex";
            this.Radio_Alex.Size = new System.Drawing.Size(49, 17);
            this.Radio_Alex.TabIndex = 3;
            this.Radio_Alex.TabStop = true;
            this.Radio_Alex.Text = "Alex";
            this.Radio_Alex.UseVisualStyleBackColor = true;
            // 
            // Radio_Ringo
            // 
            this.Radio_Ringo.AutoSize = true;
            this.Radio_Ringo.Location = new System.Drawing.Point(9, 59);
            this.Radio_Ringo.Name = "Radio_Ringo";
            this.Radio_Ringo.Size = new System.Drawing.Size(58, 17);
            this.Radio_Ringo.TabIndex = 2;
            this.Radio_Ringo.TabStop = true;
            this.Radio_Ringo.Text = "Ringo";
            this.Radio_Ringo.UseVisualStyleBackColor = true;
            // 
            // RadioJoe
            // 
            this.RadioJoe.AutoSize = true;
            this.RadioJoe.Location = new System.Drawing.Point(9, 41);
            this.RadioJoe.Name = "RadioJoe";
            this.RadioJoe.Size = new System.Drawing.Size(45, 17);
            this.RadioJoe.TabIndex = 1;
            this.RadioJoe.TabStop = true;
            this.RadioJoe.Text = "Joe";
            this.RadioJoe.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minimum Bet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // Dog1
            // 
            this.Dog1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Dog1.Image = ((System.Drawing.Image)(resources.GetObject("Dog1.Image")));
            this.Dog1.Location = new System.Drawing.Point(18, 14);
            this.Dog1.Name = "Dog1";
            this.Dog1.Size = new System.Drawing.Size(84, 27);
            this.Dog1.TabIndex = 3;
            this.Dog1.TabStop = false;
            // 
            // Dog2
            // 
            this.Dog2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Dog2.Image = ((System.Drawing.Image)(resources.GetObject("Dog2.Image")));
            this.Dog2.Location = new System.Drawing.Point(18, 62);
            this.Dog2.Name = "Dog2";
            this.Dog2.Size = new System.Drawing.Size(84, 27);
            this.Dog2.TabIndex = 4;
            this.Dog2.TabStop = false;
            // 
            // Dog3
            // 
            this.Dog3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Dog3.Image = ((System.Drawing.Image)(resources.GetObject("Dog3.Image")));
            this.Dog3.Location = new System.Drawing.Point(18, 116);
            this.Dog3.Name = "Dog3";
            this.Dog3.Size = new System.Drawing.Size(84, 27);
            this.Dog3.TabIndex = 5;
            this.Dog3.TabStop = false;
            // 
            // Dog4
            // 
            this.Dog4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Dog4.Image = ((System.Drawing.Image)(resources.GetObject("Dog4.Image")));
            this.Dog4.Location = new System.Drawing.Point(18, 173);
            this.Dog4.Name = "Dog4";
            this.Dog4.Size = new System.Drawing.Size(84, 27);
            this.Dog4.TabIndex = 6;
            this.Dog4.TabStop = false;
            // 
            // race_timer
            // 
            this.race_timer.Tick += new System.EventHandler(this.RaceStart_Click);
            // 
            // x
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(620, 347);
            this.Controls.Add(this.Dog4);
            this.Controls.Add(this.Dog3);
            this.Controls.Add(this.Dog2);
            this.Controls.Add(this.Dog1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "x";
            this.Text = "GreyHoundRacing";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Alex_Bet_Label;
        private System.Windows.Forms.Label Ringo_Bet_Label;
        private System.Windows.Forms.Label Joe_Bet_Label;
        private System.Windows.Forms.Label label_bets;
        private System.Windows.Forms.RadioButton Radio_Alex;
        private System.Windows.Forms.RadioButton Radio_Ringo;
        private System.Windows.Forms.RadioButton RadioJoe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button Button_Bets;
        private System.Windows.Forms.Button RaceStart;
        private System.Windows.Forms.Label Bet_Amount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox Dog1;
        private System.Windows.Forms.PictureBox Dog2;
        private System.Windows.Forms.PictureBox Dog3;
        private System.Windows.Forms.PictureBox Dog4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label DollarAmount;
        private System.Windows.Forms.Label Testing;
        private System.Windows.Forms.Timer race_timer;
    }
}

