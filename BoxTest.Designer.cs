namespace _3DRenderer
{
    partial class BoxTest
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
            this.tbZ = new System.Windows.Forms.TrackBar();
            this.tbY = new System.Windows.Forms.TrackBar();
            this.tbX = new System.Windows.Forms.TrackBar();
            this.lblZ = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.DrawingArea = new System.Windows.Forms.PictureBox();
            this.cbAnimateX = new System.Windows.Forms.CheckBox();
            this.cbAnimateY = new System.Windows.Forms.CheckBox();
            this.cbAnimateZ = new System.Windows.Forms.CheckBox();
            this.tAnimator = new System.Windows.Forms.Timer(this.components);
            this.tbSpeed = new System.Windows.Forms.TrackBar();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblSizeX = new System.Windows.Forms.Label();
            this.tbSizeX = new System.Windows.Forms.TrackBar();
            this.tbSizeY = new System.Windows.Forms.TrackBar();
            this.lblSizeY = new System.Windows.Forms.Label();
            this.tbSizeZ = new System.Windows.Forms.TrackBar();
            this.lblSizeZ = new System.Windows.Forms.Label();
            this.cbSyncSize = new System.Windows.Forms.CheckBox();
            this.cubeColor = new System.Windows.Forms.ColorDialog();
            this.btnColor = new System.Windows.Forms.Button();
            this.lblColor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawingArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSizeX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSizeY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSizeZ)).BeginInit();
            this.SuspendLayout();
            // 
            // tbZ
            // 
            this.tbZ.AutoSize = false;
            this.tbZ.Location = new System.Drawing.Point(27, 376);
            this.tbZ.Maximum = 360;
            this.tbZ.Minimum = -360;
            this.tbZ.Name = "tbZ";
            this.tbZ.Size = new System.Drawing.Size(222, 19);
            this.tbZ.TabIndex = 20;
            this.tbZ.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbZ.Scroll += new System.EventHandler(this.tZ_Scroll);
            // 
            // tbY
            // 
            this.tbY.AutoSize = false;
            this.tbY.Location = new System.Drawing.Point(27, 351);
            this.tbY.Maximum = 360;
            this.tbY.Minimum = -360;
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(222, 19);
            this.tbY.TabIndex = 19;
            this.tbY.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbY.Scroll += new System.EventHandler(this.tY_Scroll);
            // 
            // tbX
            // 
            this.tbX.AutoSize = false;
            this.tbX.Location = new System.Drawing.Point(27, 326);
            this.tbX.Maximum = 360;
            this.tbX.Minimum = -360;
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(222, 19);
            this.tbX.TabIndex = 18;
            this.tbX.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbX.Scroll += new System.EventHandler(this.tX_Scroll);
            // 
            // lblZ
            // 
            this.lblZ.AutoSize = true;
            this.lblZ.Location = new System.Drawing.Point(12, 380);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(17, 13);
            this.lblZ.TabIndex = 17;
            this.lblZ.Text = "Z:";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(12, 354);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(17, 13);
            this.lblY.TabIndex = 16;
            this.lblY.Text = "Y:";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(12, 328);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(17, 13);
            this.lblX.TabIndex = 15;
            this.lblX.Text = "X:";
            // 
            // DrawingArea
            // 
            this.DrawingArea.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DrawingArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DrawingArea.Location = new System.Drawing.Point(12, 25);
            this.DrawingArea.Name = "DrawingArea";
            this.DrawingArea.Size = new System.Drawing.Size(300, 300);
            this.DrawingArea.TabIndex = 14;
            this.DrawingArea.TabStop = false;
            this.DrawingArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawingArea_MouseDown);
            this.DrawingArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawingArea_MouseMove);
            this.DrawingArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawingArea_MouseUp);
            // 
            // cbAnimateX
            // 
            this.cbAnimateX.AutoSize = true;
            this.cbAnimateX.Location = new System.Drawing.Point(248, 327);
            this.cbAnimateX.Name = "cbAnimateX";
            this.cbAnimateX.Size = new System.Drawing.Size(64, 17);
            this.cbAnimateX.TabIndex = 21;
            this.cbAnimateX.Text = "Animate";
            this.cbAnimateX.UseVisualStyleBackColor = true;
            // 
            // cbAnimateY
            // 
            this.cbAnimateY.AutoSize = true;
            this.cbAnimateY.Location = new System.Drawing.Point(248, 353);
            this.cbAnimateY.Name = "cbAnimateY";
            this.cbAnimateY.Size = new System.Drawing.Size(64, 17);
            this.cbAnimateY.TabIndex = 22;
            this.cbAnimateY.Text = "Animate";
            this.cbAnimateY.UseVisualStyleBackColor = true;
            // 
            // cbAnimateZ
            // 
            this.cbAnimateZ.AutoSize = true;
            this.cbAnimateZ.Location = new System.Drawing.Point(248, 379);
            this.cbAnimateZ.Name = "cbAnimateZ";
            this.cbAnimateZ.Size = new System.Drawing.Size(64, 17);
            this.cbAnimateZ.TabIndex = 23;
            this.cbAnimateZ.Text = "Animate";
            this.cbAnimateZ.UseVisualStyleBackColor = true;
            // 
            // tAnimator
            // 
            this.tAnimator.Enabled = true;
            this.tAnimator.Interval = 1;
            this.tAnimator.Tick += new System.EventHandler(this.tAnimator_Tick);
            // 
            // tbSpeed
            // 
            this.tbSpeed.AutoSize = false;
            this.tbSpeed.Location = new System.Drawing.Point(53, 401);
            this.tbSpeed.Maximum = 5;
            this.tbSpeed.Minimum = -5;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(196, 19);
            this.tbSpeed.TabIndex = 25;
            this.tbSpeed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbSpeed.Value = 1;
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(12, 401);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(41, 13);
            this.lblSpeed.TabIndex = 24;
            this.lblSpeed.Text = "Speed:";
            // 
            // lblSizeX
            // 
            this.lblSizeX.AutoSize = true;
            this.lblSizeX.Location = new System.Drawing.Point(12, 424);
            this.lblSizeX.Name = "lblSizeX";
            this.lblSizeX.Size = new System.Drawing.Size(40, 13);
            this.lblSizeX.TabIndex = 26;
            this.lblSizeX.Text = "Size X:";
            // 
            // tbSizeX
            // 
            this.tbSizeX.AutoSize = false;
            this.tbSizeX.Location = new System.Drawing.Point(53, 424);
            this.tbSizeX.Maximum = 250;
            this.tbSizeX.Minimum = 1;
            this.tbSizeX.Name = "tbSizeX";
            this.tbSizeX.Size = new System.Drawing.Size(196, 19);
            this.tbSizeX.TabIndex = 27;
            this.tbSizeX.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbSizeX.Value = 50;
            this.tbSizeX.Scroll += new System.EventHandler(this.tbSizeX_Scroll);
            // 
            // tbSizeY
            // 
            this.tbSizeY.AutoSize = false;
            this.tbSizeY.Enabled = false;
            this.tbSizeY.Location = new System.Drawing.Point(53, 449);
            this.tbSizeY.Maximum = 250;
            this.tbSizeY.Minimum = 1;
            this.tbSizeY.Name = "tbSizeY";
            this.tbSizeY.Size = new System.Drawing.Size(196, 19);
            this.tbSizeY.TabIndex = 29;
            this.tbSizeY.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbSizeY.Value = 50;
            this.tbSizeY.Scroll += new System.EventHandler(this.tbSizeY_Scroll);
            // 
            // lblSizeY
            // 
            this.lblSizeY.AutoSize = true;
            this.lblSizeY.Location = new System.Drawing.Point(12, 449);
            this.lblSizeY.Name = "lblSizeY";
            this.lblSizeY.Size = new System.Drawing.Size(40, 13);
            this.lblSizeY.TabIndex = 28;
            this.lblSizeY.Text = "Size Y:";
            // 
            // tbSizeZ
            // 
            this.tbSizeZ.AutoSize = false;
            this.tbSizeZ.Enabled = false;
            this.tbSizeZ.Location = new System.Drawing.Point(53, 474);
            this.tbSizeZ.Maximum = 250;
            this.tbSizeZ.Minimum = 1;
            this.tbSizeZ.Name = "tbSizeZ";
            this.tbSizeZ.Size = new System.Drawing.Size(196, 19);
            this.tbSizeZ.TabIndex = 31;
            this.tbSizeZ.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbSizeZ.Value = 50;
            this.tbSizeZ.Scroll += new System.EventHandler(this.tbSizeZ_Scroll);
            // 
            // lblSizeZ
            // 
            this.lblSizeZ.AutoSize = true;
            this.lblSizeZ.Location = new System.Drawing.Point(12, 474);
            this.lblSizeZ.Name = "lblSizeZ";
            this.lblSizeZ.Size = new System.Drawing.Size(40, 13);
            this.lblSizeZ.TabIndex = 30;
            this.lblSizeZ.Text = "Size Z:";
            // 
            // cbSyncSize
            // 
            this.cbSyncSize.AutoSize = true;
            this.cbSyncSize.Checked = true;
            this.cbSyncSize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSyncSize.Location = new System.Drawing.Point(248, 423);
            this.cbSyncSize.Name = "cbSyncSize";
            this.cbSyncSize.Size = new System.Drawing.Size(73, 17);
            this.cbSyncSize.TabIndex = 32;
            this.cbSyncSize.Text = "Sync Size";
            this.cbSyncSize.UseVisualStyleBackColor = true;
            this.cbSyncSize.CheckedChanged += new System.EventHandler(this.cbSyncSize_CheckedChanged);
            // 
            // cubeColor
            // 
            this.cubeColor.AnyColor = true;
            this.cubeColor.FullOpen = true;
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Black;
            this.btnColor.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnColor.FlatAppearance.BorderSize = 2;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.Location = new System.Drawing.Point(288, 468);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(25, 25);
            this.btnColor.TabIndex = 33;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(255, 474);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(34, 13);
            this.lblColor.TabIndex = 34;
            this.lblColor.Text = "Color:";
            // 
            // BoxTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 504);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.cbSyncSize);
            this.Controls.Add(this.tbSizeZ);
            this.Controls.Add(this.lblSizeZ);
            this.Controls.Add(this.tbSizeY);
            this.Controls.Add(this.lblSizeY);
            this.Controls.Add(this.tbSizeX);
            this.Controls.Add(this.lblSizeX);
            this.Controls.Add(this.tbSpeed);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.cbAnimateZ);
            this.Controls.Add(this.cbAnimateY);
            this.Controls.Add(this.cbAnimateX);
            this.Controls.Add(this.tbZ);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.lblZ);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.DrawingArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BoxTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3D Renderer | Box Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawingArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSizeX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSizeY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSizeZ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar tbZ;
        private System.Windows.Forms.TrackBar tbY;
        private System.Windows.Forms.TrackBar tbX;
        private System.Windows.Forms.Label lblZ;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.PictureBox DrawingArea;
        private System.Windows.Forms.CheckBox cbAnimateX;
        private System.Windows.Forms.CheckBox cbAnimateY;
        private System.Windows.Forms.CheckBox cbAnimateZ;
        private System.Windows.Forms.Timer tAnimator;
        private System.Windows.Forms.TrackBar tbSpeed;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblSizeX;
        private System.Windows.Forms.TrackBar tbSizeX;
        private System.Windows.Forms.TrackBar tbSizeY;
        private System.Windows.Forms.Label lblSizeY;
        private System.Windows.Forms.TrackBar tbSizeZ;
        private System.Windows.Forms.Label lblSizeZ;
        private System.Windows.Forms.CheckBox cbSyncSize;
        private System.Windows.Forms.ColorDialog cubeColor;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Label lblColor;
    }
}

