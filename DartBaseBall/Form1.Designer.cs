namespace DartBaseBall
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
            this.SingleButton = new System.Windows.Forms.Button();
            this.DoubleButton = new System.Windows.Forms.Button();
            this.TripleButton = new System.Windows.Forms.Button();
            this.HomerunButton = new System.Windows.Forms.Button();
            this.StrikeButton = new System.Windows.Forms.Button();
            this.BallButton = new System.Windows.Forms.Button();
            this.OutButton = new System.Windows.Forms.Button();
            this.FoulButton = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape4 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.SecondBase = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.FirstBase = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.ThirdBase = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.label1 = new System.Windows.Forms.Label();
            this.StrikeLabel = new System.Windows.Forms.Label();
            this.BallLabel = new System.Windows.Forms.Label();
            this.OutLabel = new System.Windows.Forms.Label();
            this.SafeHitButton = new System.Windows.Forms.Button();
            this.DoublePlayButton = new System.Windows.Forms.Button();
            this.StolenBaseButton = new System.Windows.Forms.Button();
            this.SacrificeButton = new System.Windows.Forms.Button();
            this.T1I1 = new System.Windows.Forms.Label();
            this.T2I1 = new System.Windows.Forms.Label();
            this.T2I2 = new System.Windows.Forms.Label();
            this.T1I2 = new System.Windows.Forms.Label();
            this.T2I4 = new System.Windows.Forms.Label();
            this.T1I4 = new System.Windows.Forms.Label();
            this.T2I3 = new System.Windows.Forms.Label();
            this.T1I3 = new System.Windows.Forms.Label();
            this.T2I6 = new System.Windows.Forms.Label();
            this.T1I6 = new System.Windows.Forms.Label();
            this.T2I5 = new System.Windows.Forms.Label();
            this.T1I5 = new System.Windows.Forms.Label();
            this.T1I7 = new System.Windows.Forms.Label();
            this.T2I7 = new System.Windows.Forms.Label();
            this.T1I8 = new System.Windows.Forms.Label();
            this.T2I8 = new System.Windows.Forms.Label();
            this.T2Total = new System.Windows.Forms.Label();
            this.T1Total = new System.Windows.Forms.Label();
            this.T2I9 = new System.Windows.Forms.Label();
            this.T1I9 = new System.Windows.Forms.Label();
            this.Inning1 = new System.Windows.Forms.Label();
            this.Inning9 = new System.Windows.Forms.Label();
            this.Inning7 = new System.Windows.Forms.Label();
            this.Inning6 = new System.Windows.Forms.Label();
            this.Inning5 = new System.Windows.Forms.Label();
            this.Inning3 = new System.Windows.Forms.Label();
            this.Inning4 = new System.Windows.Forms.Label();
            this.Inning8 = new System.Windows.Forms.Label();
            this.Inning2 = new System.Windows.Forms.Label();
            this.TeamOnePointerLabel = new System.Windows.Forms.Label();
            this.TeamTwoPointerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SingleButton
            // 
            this.SingleButton.Location = new System.Drawing.Point(706, 472);
            this.SingleButton.Name = "SingleButton";
            this.SingleButton.Size = new System.Drawing.Size(75, 23);
            this.SingleButton.TabIndex = 0;
            this.SingleButton.Text = "Single";
            this.SingleButton.UseVisualStyleBackColor = true;
            this.SingleButton.Click += new System.EventHandler(this.SingleButton_Click);
            // 
            // DoubleButton
            // 
            this.DoubleButton.Location = new System.Drawing.Point(706, 501);
            this.DoubleButton.Name = "DoubleButton";
            this.DoubleButton.Size = new System.Drawing.Size(75, 23);
            this.DoubleButton.TabIndex = 1;
            this.DoubleButton.Text = "Double";
            this.DoubleButton.UseVisualStyleBackColor = true;
            this.DoubleButton.Click += new System.EventHandler(this.DoubleButton_Click);
            // 
            // TripleButton
            // 
            this.TripleButton.ForeColor = System.Drawing.Color.Red;
            this.TripleButton.Location = new System.Drawing.Point(706, 530);
            this.TripleButton.Name = "TripleButton";
            this.TripleButton.Size = new System.Drawing.Size(75, 23);
            this.TripleButton.TabIndex = 2;
            this.TripleButton.Text = "Triple";
            this.TripleButton.UseVisualStyleBackColor = true;
            // 
            // HomerunButton
            // 
            this.HomerunButton.ForeColor = System.Drawing.Color.Red;
            this.HomerunButton.Location = new System.Drawing.Point(706, 559);
            this.HomerunButton.Name = "HomerunButton";
            this.HomerunButton.Size = new System.Drawing.Size(75, 23);
            this.HomerunButton.TabIndex = 3;
            this.HomerunButton.Text = "Homer!";
            this.HomerunButton.UseVisualStyleBackColor = true;
            // 
            // StrikeButton
            // 
            this.StrikeButton.Location = new System.Drawing.Point(787, 472);
            this.StrikeButton.Name = "StrikeButton";
            this.StrikeButton.Size = new System.Drawing.Size(75, 23);
            this.StrikeButton.TabIndex = 4;
            this.StrikeButton.Text = "Strike";
            this.StrikeButton.UseVisualStyleBackColor = true;
            this.StrikeButton.Click += new System.EventHandler(this.StrikeButton_Click);
            // 
            // BallButton
            // 
            this.BallButton.Location = new System.Drawing.Point(787, 501);
            this.BallButton.Name = "BallButton";
            this.BallButton.Size = new System.Drawing.Size(75, 23);
            this.BallButton.TabIndex = 5;
            this.BallButton.Text = "Ball";
            this.BallButton.UseVisualStyleBackColor = true;
            this.BallButton.Click += new System.EventHandler(this.BallButton_Click);
            // 
            // OutButton
            // 
            this.OutButton.Location = new System.Drawing.Point(787, 530);
            this.OutButton.Name = "OutButton";
            this.OutButton.Size = new System.Drawing.Size(75, 23);
            this.OutButton.TabIndex = 6;
            this.OutButton.Text = "Out";
            this.OutButton.UseVisualStyleBackColor = true;
            this.OutButton.Click += new System.EventHandler(this.OutButton_Click);
            // 
            // FoulButton
            // 
            this.FoulButton.Location = new System.Drawing.Point(787, 559);
            this.FoulButton.Name = "FoulButton";
            this.FoulButton.Size = new System.Drawing.Size(75, 23);
            this.FoulButton.TabIndex = 7;
            this.FoulButton.Text = "Foul";
            this.FoulButton.UseVisualStyleBackColor = true;
            this.FoulButton.Click += new System.EventHandler(this.FoulButton_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape4,
            this.SecondBase,
            this.FirstBase,
            this.ThirdBase});
            this.shapeContainer1.Size = new System.Drawing.Size(875, 594);
            this.shapeContainer1.TabIndex = 8;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape4
            // 
            this.rectangleShape4.BackColor = System.Drawing.Color.White;
            this.rectangleShape4.FillColor = System.Drawing.Color.White;
            this.rectangleShape4.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape4.Location = new System.Drawing.Point(187, 419);
            this.rectangleShape4.Name = "rectangleShape4";
            this.rectangleShape4.Size = new System.Drawing.Size(75, 75);
            // 
            // SecondBase
            // 
            this.SecondBase.BackColor = System.Drawing.Color.White;
            this.SecondBase.FillColor = System.Drawing.Color.White;
            this.SecondBase.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.SecondBase.Location = new System.Drawing.Point(187, 119);
            this.SecondBase.Name = "SecondBase";
            this.SecondBase.Size = new System.Drawing.Size(75, 75);
            // 
            // FirstBase
            // 
            this.FirstBase.BackColor = System.Drawing.Color.White;
            this.FirstBase.FillColor = System.Drawing.Color.White;
            this.FirstBase.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.FirstBase.Location = new System.Drawing.Point(312, 269);
            this.FirstBase.Name = "FirstBase";
            this.FirstBase.Size = new System.Drawing.Size(75, 75);
            // 
            // ThirdBase
            // 
            this.ThirdBase.BackColor = System.Drawing.Color.White;
            this.ThirdBase.FillColor = System.Drawing.Color.White;
            this.ThirdBase.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.ThirdBase.Location = new System.Drawing.Point(62, 269);
            this.ThirdBase.Name = "ThirdBase";
            this.ThirdBase.Size = new System.Drawing.Size(75, 75);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(490, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Strikes:                            Balls:                              Outs:";
            // 
            // StrikeLabel
            // 
            this.StrikeLabel.BackColor = System.Drawing.Color.Black;
            this.StrikeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 51.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StrikeLabel.ForeColor = System.Drawing.Color.White;
            this.StrikeLabel.Location = new System.Drawing.Point(494, 34);
            this.StrikeLabel.Name = "StrikeLabel";
            this.StrikeLabel.Size = new System.Drawing.Size(93, 75);
            this.StrikeLabel.TabIndex = 10;
            this.StrikeLabel.Text = " 3";
            // 
            // BallLabel
            // 
            this.BallLabel.BackColor = System.Drawing.Color.Black;
            this.BallLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 51.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BallLabel.ForeColor = System.Drawing.Color.White;
            this.BallLabel.Location = new System.Drawing.Point(611, 34);
            this.BallLabel.Name = "BallLabel";
            this.BallLabel.Size = new System.Drawing.Size(93, 75);
            this.BallLabel.TabIndex = 11;
            this.BallLabel.Text = " 3";
            // 
            // OutLabel
            // 
            this.OutLabel.BackColor = System.Drawing.Color.Black;
            this.OutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 51.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutLabel.ForeColor = System.Drawing.Color.White;
            this.OutLabel.Location = new System.Drawing.Point(728, 34);
            this.OutLabel.Name = "OutLabel";
            this.OutLabel.Size = new System.Drawing.Size(93, 75);
            this.OutLabel.TabIndex = 12;
            this.OutLabel.Text = " 3";
            // 
            // SafeHitButton
            // 
            this.SafeHitButton.Location = new System.Drawing.Point(625, 559);
            this.SafeHitButton.Name = "SafeHitButton";
            this.SafeHitButton.Size = new System.Drawing.Size(75, 23);
            this.SafeHitButton.TabIndex = 16;
            this.SafeHitButton.Text = "Safe Hit";
            this.SafeHitButton.UseVisualStyleBackColor = true;
            this.SafeHitButton.Click += new System.EventHandler(this.SafeHitButton_Click);
            // 
            // DoublePlayButton
            // 
            this.DoublePlayButton.ForeColor = System.Drawing.Color.Red;
            this.DoublePlayButton.Location = new System.Drawing.Point(625, 530);
            this.DoublePlayButton.Name = "DoublePlayButton";
            this.DoublePlayButton.Size = new System.Drawing.Size(75, 23);
            this.DoublePlayButton.TabIndex = 15;
            this.DoublePlayButton.Text = "Double Play";
            this.DoublePlayButton.UseVisualStyleBackColor = true;
            // 
            // StolenBaseButton
            // 
            this.StolenBaseButton.ForeColor = System.Drawing.Color.Red;
            this.StolenBaseButton.Location = new System.Drawing.Point(625, 501);
            this.StolenBaseButton.Name = "StolenBaseButton";
            this.StolenBaseButton.Size = new System.Drawing.Size(75, 23);
            this.StolenBaseButton.TabIndex = 14;
            this.StolenBaseButton.Text = "Steal";
            this.StolenBaseButton.UseVisualStyleBackColor = true;
            // 
            // SacrificeButton
            // 
            this.SacrificeButton.Location = new System.Drawing.Point(625, 472);
            this.SacrificeButton.Name = "SacrificeButton";
            this.SacrificeButton.Size = new System.Drawing.Size(75, 23);
            this.SacrificeButton.TabIndex = 13;
            this.SacrificeButton.Text = "Sacrifice";
            this.SacrificeButton.UseVisualStyleBackColor = true;
            this.SacrificeButton.Click += new System.EventHandler(this.SacrificeButton_Click);
            // 
            // T1I1
            // 
            this.T1I1.BackColor = System.Drawing.Color.Black;
            this.T1I1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T1I1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.T1I1.Location = new System.Drawing.Point(444, 208);
            this.T1I1.Name = "T1I1";
            this.T1I1.Size = new System.Drawing.Size(30, 27);
            this.T1I1.TabIndex = 18;
            this.T1I1.Text = "0";
            // 
            // T2I1
            // 
            this.T2I1.BackColor = System.Drawing.Color.Black;
            this.T2I1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T2I1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.T2I1.Location = new System.Drawing.Point(444, 269);
            this.T2I1.Name = "T2I1";
            this.T2I1.Size = new System.Drawing.Size(30, 27);
            this.T2I1.TabIndex = 19;
            this.T2I1.Text = "0";
            // 
            // T2I2
            // 
            this.T2I2.BackColor = System.Drawing.Color.Black;
            this.T2I2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T2I2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.T2I2.Location = new System.Drawing.Point(479, 269);
            this.T2I2.Name = "T2I2";
            this.T2I2.Size = new System.Drawing.Size(30, 27);
            this.T2I2.TabIndex = 21;
            this.T2I2.Text = "0";
            // 
            // T1I2
            // 
            this.T1I2.BackColor = System.Drawing.Color.Black;
            this.T1I2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T1I2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.T1I2.Location = new System.Drawing.Point(479, 208);
            this.T1I2.Name = "T1I2";
            this.T1I2.Size = new System.Drawing.Size(30, 27);
            this.T1I2.TabIndex = 20;
            this.T1I2.Text = "0";
            // 
            // T2I4
            // 
            this.T2I4.BackColor = System.Drawing.Color.Black;
            this.T2I4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T2I4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.T2I4.Location = new System.Drawing.Point(549, 269);
            this.T2I4.Name = "T2I4";
            this.T2I4.Size = new System.Drawing.Size(30, 27);
            this.T2I4.TabIndex = 25;
            this.T2I4.Text = "0";
            this.T2I4.Click += new System.EventHandler(this.T2I4_Click);
            // 
            // T1I4
            // 
            this.T1I4.BackColor = System.Drawing.Color.Black;
            this.T1I4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T1I4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.T1I4.Location = new System.Drawing.Point(549, 208);
            this.T1I4.Name = "T1I4";
            this.T1I4.Size = new System.Drawing.Size(30, 27);
            this.T1I4.TabIndex = 24;
            this.T1I4.Text = "0";
            // 
            // T2I3
            // 
            this.T2I3.BackColor = System.Drawing.Color.Black;
            this.T2I3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T2I3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.T2I3.Location = new System.Drawing.Point(514, 269);
            this.T2I3.Name = "T2I3";
            this.T2I3.Size = new System.Drawing.Size(30, 27);
            this.T2I3.TabIndex = 23;
            this.T2I3.Text = "0";
            // 
            // T1I3
            // 
            this.T1I3.BackColor = System.Drawing.Color.Black;
            this.T1I3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T1I3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.T1I3.Location = new System.Drawing.Point(514, 208);
            this.T1I3.Name = "T1I3";
            this.T1I3.Size = new System.Drawing.Size(30, 27);
            this.T1I3.TabIndex = 22;
            this.T1I3.Text = "0";
            // 
            // T2I6
            // 
            this.T2I6.BackColor = System.Drawing.Color.Black;
            this.T2I6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T2I6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.T2I6.Location = new System.Drawing.Point(619, 269);
            this.T2I6.Name = "T2I6";
            this.T2I6.Size = new System.Drawing.Size(30, 27);
            this.T2I6.TabIndex = 29;
            this.T2I6.Text = "0";
            // 
            // T1I6
            // 
            this.T1I6.BackColor = System.Drawing.Color.Black;
            this.T1I6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T1I6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.T1I6.Location = new System.Drawing.Point(619, 208);
            this.T1I6.Name = "T1I6";
            this.T1I6.Size = new System.Drawing.Size(30, 27);
            this.T1I6.TabIndex = 28;
            this.T1I6.Text = "0";
            // 
            // T2I5
            // 
            this.T2I5.BackColor = System.Drawing.Color.Black;
            this.T2I5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T2I5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.T2I5.Location = new System.Drawing.Point(584, 269);
            this.T2I5.Name = "T2I5";
            this.T2I5.Size = new System.Drawing.Size(30, 27);
            this.T2I5.TabIndex = 27;
            this.T2I5.Text = "0";
            // 
            // T1I5
            // 
            this.T1I5.BackColor = System.Drawing.Color.Black;
            this.T1I5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T1I5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.T1I5.Location = new System.Drawing.Point(584, 208);
            this.T1I5.Name = "T1I5";
            this.T1I5.Size = new System.Drawing.Size(30, 27);
            this.T1I5.TabIndex = 26;
            this.T1I5.Text = "0";
            // 
            // T1I7
            // 
            this.T1I7.BackColor = System.Drawing.Color.Black;
            this.T1I7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T1I7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.T1I7.Location = new System.Drawing.Point(654, 208);
            this.T1I7.Name = "T1I7";
            this.T1I7.Size = new System.Drawing.Size(30, 27);
            this.T1I7.TabIndex = 30;
            this.T1I7.Text = "0";
            // 
            // T2I7
            // 
            this.T2I7.BackColor = System.Drawing.Color.Black;
            this.T2I7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T2I7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.T2I7.Location = new System.Drawing.Point(654, 269);
            this.T2I7.Name = "T2I7";
            this.T2I7.Size = new System.Drawing.Size(30, 27);
            this.T2I7.TabIndex = 31;
            this.T2I7.Text = "0";
            // 
            // T1I8
            // 
            this.T1I8.BackColor = System.Drawing.Color.Black;
            this.T1I8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T1I8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.T1I8.Location = new System.Drawing.Point(689, 208);
            this.T1I8.Name = "T1I8";
            this.T1I8.Size = new System.Drawing.Size(30, 27);
            this.T1I8.TabIndex = 32;
            this.T1I8.Text = "0";
            // 
            // T2I8
            // 
            this.T2I8.BackColor = System.Drawing.Color.Black;
            this.T2I8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T2I8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.T2I8.Location = new System.Drawing.Point(689, 269);
            this.T2I8.Name = "T2I8";
            this.T2I8.Size = new System.Drawing.Size(30, 27);
            this.T2I8.TabIndex = 33;
            this.T2I8.Text = "0";
            // 
            // T2Total
            // 
            this.T2Total.BackColor = System.Drawing.Color.Black;
            this.T2Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T2Total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.T2Total.Location = new System.Drawing.Point(794, 269);
            this.T2Total.Name = "T2Total";
            this.T2Total.Size = new System.Drawing.Size(54, 27);
            this.T2Total.TabIndex = 37;
            // 
            // T1Total
            // 
            this.T1Total.BackColor = System.Drawing.Color.Black;
            this.T1Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T1Total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.T1Total.Location = new System.Drawing.Point(794, 208);
            this.T1Total.Name = "T1Total";
            this.T1Total.Size = new System.Drawing.Size(54, 27);
            this.T1Total.TabIndex = 36;
            // 
            // T2I9
            // 
            this.T2I9.BackColor = System.Drawing.Color.Black;
            this.T2I9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T2I9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.T2I9.Location = new System.Drawing.Point(724, 269);
            this.T2I9.Name = "T2I9";
            this.T2I9.Size = new System.Drawing.Size(30, 27);
            this.T2I9.TabIndex = 35;
            this.T2I9.Text = "0";
            // 
            // T1I9
            // 
            this.T1I9.BackColor = System.Drawing.Color.Black;
            this.T1I9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T1I9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.T1I9.Location = new System.Drawing.Point(724, 208);
            this.T1I9.Name = "T1I9";
            this.T1I9.Size = new System.Drawing.Size(30, 27);
            this.T1I9.TabIndex = 34;
            this.T1I9.Text = "0";
            // 
            // Inning1
            // 
            this.Inning1.AutoSize = true;
            this.Inning1.Location = new System.Drawing.Point(453, 307);
            this.Inning1.Name = "Inning1";
            this.Inning1.Size = new System.Drawing.Size(13, 13);
            this.Inning1.TabIndex = 39;
            this.Inning1.Text = "^";
            // 
            // Inning9
            // 
            this.Inning9.AutoSize = true;
            this.Inning9.Location = new System.Drawing.Point(733, 307);
            this.Inning9.Name = "Inning9";
            this.Inning9.Size = new System.Drawing.Size(13, 13);
            this.Inning9.TabIndex = 40;
            this.Inning9.Text = "^";
            this.Inning9.Visible = false;
            // 
            // Inning7
            // 
            this.Inning7.AutoSize = true;
            this.Inning7.Location = new System.Drawing.Point(663, 307);
            this.Inning7.Name = "Inning7";
            this.Inning7.Size = new System.Drawing.Size(13, 13);
            this.Inning7.TabIndex = 41;
            this.Inning7.Text = "^";
            this.Inning7.Visible = false;
            // 
            // Inning6
            // 
            this.Inning6.AutoSize = true;
            this.Inning6.Location = new System.Drawing.Point(628, 307);
            this.Inning6.Name = "Inning6";
            this.Inning6.Size = new System.Drawing.Size(13, 13);
            this.Inning6.TabIndex = 42;
            this.Inning6.Text = "^";
            this.Inning6.Visible = false;
            // 
            // Inning5
            // 
            this.Inning5.AutoSize = true;
            this.Inning5.Location = new System.Drawing.Point(593, 307);
            this.Inning5.Name = "Inning5";
            this.Inning5.Size = new System.Drawing.Size(13, 13);
            this.Inning5.TabIndex = 43;
            this.Inning5.Text = "^";
            this.Inning5.Visible = false;
            // 
            // Inning3
            // 
            this.Inning3.AutoSize = true;
            this.Inning3.Location = new System.Drawing.Point(523, 307);
            this.Inning3.Name = "Inning3";
            this.Inning3.Size = new System.Drawing.Size(13, 13);
            this.Inning3.TabIndex = 44;
            this.Inning3.Text = "^";
            this.Inning3.Visible = false;
            // 
            // Inning4
            // 
            this.Inning4.AutoSize = true;
            this.Inning4.Location = new System.Drawing.Point(558, 307);
            this.Inning4.Name = "Inning4";
            this.Inning4.Size = new System.Drawing.Size(13, 13);
            this.Inning4.TabIndex = 45;
            this.Inning4.Text = "^";
            this.Inning4.Visible = false;
            // 
            // Inning8
            // 
            this.Inning8.AutoSize = true;
            this.Inning8.Location = new System.Drawing.Point(698, 307);
            this.Inning8.Name = "Inning8";
            this.Inning8.Size = new System.Drawing.Size(13, 13);
            this.Inning8.TabIndex = 46;
            this.Inning8.Text = "^";
            this.Inning8.Visible = false;
            // 
            // Inning2
            // 
            this.Inning2.AutoSize = true;
            this.Inning2.Location = new System.Drawing.Point(488, 307);
            this.Inning2.Name = "Inning2";
            this.Inning2.Size = new System.Drawing.Size(13, 13);
            this.Inning2.TabIndex = 47;
            this.Inning2.Text = "^";
            this.Inning2.Visible = false;
            // 
            // TeamOnePointerLabel
            // 
            this.TeamOnePointerLabel.AutoSize = true;
            this.TeamOnePointerLabel.Location = new System.Drawing.Point(416, 216);
            this.TeamOnePointerLabel.Name = "TeamOnePointerLabel";
            this.TeamOnePointerLabel.Size = new System.Drawing.Size(19, 13);
            this.TeamOnePointerLabel.TabIndex = 48;
            this.TeamOnePointerLabel.Text = "-->";
            // 
            // TeamTwoPointerLabel
            // 
            this.TeamTwoPointerLabel.AutoSize = true;
            this.TeamTwoPointerLabel.Location = new System.Drawing.Point(416, 277);
            this.TeamTwoPointerLabel.Name = "TeamTwoPointerLabel";
            this.TeamTwoPointerLabel.Size = new System.Drawing.Size(19, 13);
            this.TeamTwoPointerLabel.TabIndex = 49;
            this.TeamTwoPointerLabel.Text = "-->";
            this.TeamTwoPointerLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 594);
            this.Controls.Add(this.TeamTwoPointerLabel);
            this.Controls.Add(this.TeamOnePointerLabel);
            this.Controls.Add(this.Inning2);
            this.Controls.Add(this.Inning8);
            this.Controls.Add(this.Inning4);
            this.Controls.Add(this.Inning3);
            this.Controls.Add(this.Inning5);
            this.Controls.Add(this.Inning6);
            this.Controls.Add(this.Inning7);
            this.Controls.Add(this.Inning9);
            this.Controls.Add(this.Inning1);
            this.Controls.Add(this.T2Total);
            this.Controls.Add(this.T1Total);
            this.Controls.Add(this.T2I9);
            this.Controls.Add(this.T1I9);
            this.Controls.Add(this.T2I8);
            this.Controls.Add(this.T1I8);
            this.Controls.Add(this.T2I7);
            this.Controls.Add(this.T1I7);
            this.Controls.Add(this.T2I6);
            this.Controls.Add(this.T1I6);
            this.Controls.Add(this.T2I5);
            this.Controls.Add(this.T1I5);
            this.Controls.Add(this.T2I4);
            this.Controls.Add(this.T1I4);
            this.Controls.Add(this.T2I3);
            this.Controls.Add(this.T1I3);
            this.Controls.Add(this.T2I2);
            this.Controls.Add(this.T1I2);
            this.Controls.Add(this.T2I1);
            this.Controls.Add(this.T1I1);
            this.Controls.Add(this.SafeHitButton);
            this.Controls.Add(this.DoublePlayButton);
            this.Controls.Add(this.StolenBaseButton);
            this.Controls.Add(this.SacrificeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FoulButton);
            this.Controls.Add(this.OutButton);
            this.Controls.Add(this.BallButton);
            this.Controls.Add(this.StrikeButton);
            this.Controls.Add(this.HomerunButton);
            this.Controls.Add(this.TripleButton);
            this.Controls.Add(this.DoubleButton);
            this.Controls.Add(this.SingleButton);
            this.Controls.Add(this.OutLabel);
            this.Controls.Add(this.BallLabel);
            this.Controls.Add(this.StrikeLabel);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Form1";
            this.Text = "Dart Baseball";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SingleButton;
        private System.Windows.Forms.Button DoubleButton;
        private System.Windows.Forms.Button TripleButton;
        private System.Windows.Forms.Button HomerunButton;
        private System.Windows.Forms.Button StrikeButton;
        private System.Windows.Forms.Button BallButton;
        private System.Windows.Forms.Button OutButton;
        private System.Windows.Forms.Button FoulButton;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape4;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape SecondBase;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape FirstBase;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape ThirdBase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label StrikeLabel;
        private System.Windows.Forms.Label BallLabel;
        private System.Windows.Forms.Label OutLabel;
        private System.Windows.Forms.Button SafeHitButton;
        private System.Windows.Forms.Button DoublePlayButton;
        private System.Windows.Forms.Button StolenBaseButton;
        private System.Windows.Forms.Button SacrificeButton;
        private System.Windows.Forms.Label T1I1;
        private System.Windows.Forms.Label T2I1;
        private System.Windows.Forms.Label T2I2;
        private System.Windows.Forms.Label T1I2;
        private System.Windows.Forms.Label T2I4;
        private System.Windows.Forms.Label T1I4;
        private System.Windows.Forms.Label T2I3;
        private System.Windows.Forms.Label T1I3;
        private System.Windows.Forms.Label T2I6;
        private System.Windows.Forms.Label T1I6;
        private System.Windows.Forms.Label T2I5;
        private System.Windows.Forms.Label T1I5;
        private System.Windows.Forms.Label T1I7;
        private System.Windows.Forms.Label T2I7;
        private System.Windows.Forms.Label T1I8;
        private System.Windows.Forms.Label T2I8;
        private System.Windows.Forms.Label T2Total;
        private System.Windows.Forms.Label T1Total;
        private System.Windows.Forms.Label T2I9;
        private System.Windows.Forms.Label T1I9;
        private System.Windows.Forms.Label Inning1;
        private System.Windows.Forms.Label Inning9;
        private System.Windows.Forms.Label Inning7;
        private System.Windows.Forms.Label Inning6;
        private System.Windows.Forms.Label Inning5;
        private System.Windows.Forms.Label Inning3;
        private System.Windows.Forms.Label Inning4;
        private System.Windows.Forms.Label Inning8;
        private System.Windows.Forms.Label Inning2;
        private System.Windows.Forms.Label TeamOnePointerLabel;
        private System.Windows.Forms.Label TeamTwoPointerLabel;
    }
}

