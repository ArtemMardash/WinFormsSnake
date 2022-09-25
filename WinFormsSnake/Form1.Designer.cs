namespace WinFormsSnake
{
    partial class SnakeForm1
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Startbutton1 = new System.Windows.Forms.Button();
            this.Snapbutton2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Snake = new System.Windows.Forms.TabPage();
            this.Settings1 = new System.Windows.Forms.TabPage();
            this.FoodSize = new System.Windows.Forms.GroupBox();
            this.Food_SizenumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.defaultSize = new System.Windows.Forms.RadioButton();
            this.Food_SizeRadioButton = new System.Windows.Forms.RadioButton();
            this.Font = new System.Windows.Forms.GroupBox();
            this.defaultFont = new System.Windows.Forms.RadioButton();
            this.BlueFont = new System.Windows.Forms.RadioButton();
            this.WhiteFont = new System.Windows.Forms.RadioButton();
            this.RedFont = new System.Windows.Forms.RadioButton();
            this.SnakeBody = new System.Windows.Forms.GroupBox();
            this.DefaultBody = new System.Windows.Forms.RadioButton();
            this.BlueBody = new System.Windows.Forms.RadioButton();
            this.WhiteBody = new System.Windows.Forms.RadioButton();
            this.RedBody = new System.Windows.Forms.RadioButton();
            this.SnakeColour = new System.Windows.Forms.GroupBox();
            this.DefaultHead = new System.Windows.Forms.RadioButton();
            this.BlueHead = new System.Windows.Forms.RadioButton();
            this.WhiteHead = new System.Windows.Forms.RadioButton();
            this.RedHead = new System.Windows.Forms.RadioButton();
            this.FoodColour = new System.Windows.Forms.GroupBox();
            this.DefaultFood = new System.Windows.Forms.RadioButton();
            this.BlueFood = new System.Windows.Forms.RadioButton();
            this.WhiteFood = new System.Windows.Forms.RadioButton();
            this.RedFood = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Snake.SuspendLayout();
            this.Settings1.SuspendLayout();
            this.FoodSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Food_SizenumericUpDown1)).BeginInit();
            this.Font.SuspendLayout();
            this.SnakeBody.SuspendLayout();
            this.SnakeColour.SuspendLayout();
            this.FoodColour.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox1.Location = new System.Drawing.Point(316, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(660, 433);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdatePictureBox1_Paint);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Startbutton1
            // 
            this.Startbutton1.BackColor = System.Drawing.Color.OrangeRed;
            this.Startbutton1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Startbutton1.Location = new System.Drawing.Point(61, 27);
            this.Startbutton1.Name = "Startbutton1";
            this.Startbutton1.Size = new System.Drawing.Size(112, 34);
            this.Startbutton1.TabIndex = 1;
            this.Startbutton1.Text = "Start";
            this.Startbutton1.UseVisualStyleBackColor = false;
            this.Startbutton1.Click += new System.EventHandler(this.Startbutton1_Click);
            // 
            // Snapbutton2
            // 
            this.Snapbutton2.Location = new System.Drawing.Point(61, 89);
            this.Snapbutton2.Name = "Snapbutton2";
            this.Snapbutton2.Size = new System.Drawing.Size(112, 34);
            this.Snapbutton2.TabIndex = 2;
            this.Snapbutton2.Text = "Snap";
            this.Snapbutton2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "There is zero apple was ate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Record: ";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.Snake);
            this.tabControl1.Controls.Add(this.Settings1);
            this.tabControl1.Location = new System.Drawing.Point(-5, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 526);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 5;
            // 
            // Snake
            // 
            this.Snake.BackColor = System.Drawing.Color.Yellow;
            this.Snake.Controls.Add(this.Startbutton1);
            this.Snake.Controls.Add(this.pictureBox1);
            this.Snake.Controls.Add(this.label2);
            this.Snake.Controls.Add(this.Snapbutton2);
            this.Snake.Controls.Add(this.label1);
            this.Snake.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Snake.Location = new System.Drawing.Point(4, 34);
            this.Snake.Name = "Snake";
            this.Snake.Padding = new System.Windows.Forms.Padding(3);
            this.Snake.Size = new System.Drawing.Size(992, 488);
            this.Snake.TabIndex = 0;
            this.Snake.Text = "Snake";
            // 
            // Settings1
            // 
            this.Settings1.Controls.Add(this.FoodSize);
            this.Settings1.Controls.Add(this.Font);
            this.Settings1.Controls.Add(this.SnakeBody);
            this.Settings1.Controls.Add(this.SnakeColour);
            this.Settings1.Controls.Add(this.FoodColour);
            this.Settings1.Location = new System.Drawing.Point(4, 34);
            this.Settings1.Name = "Settings1";
            this.Settings1.Padding = new System.Windows.Forms.Padding(3);
            this.Settings1.Size = new System.Drawing.Size(992, 488);
            this.Settings1.TabIndex = 1;
            this.Settings1.Text = "Settings";
            this.Settings1.UseVisualStyleBackColor = true;
            // 
            // FoodSize
            // 
            this.FoodSize.Controls.Add(this.Food_SizenumericUpDown1);
            this.FoodSize.Controls.Add(this.defaultSize);
            this.FoodSize.Controls.Add(this.Food_SizeRadioButton);
            this.FoodSize.Location = new System.Drawing.Point(706, 6);
            this.FoodSize.Name = "FoodSize";
            this.FoodSize.Size = new System.Drawing.Size(280, 177);
            this.FoodSize.TabIndex = 6;
            this.FoodSize.TabStop = false;
            this.FoodSize.Text = "Size of food";
            // 
            // Food_SizenumericUpDown1
            // 
            this.Food_SizenumericUpDown1.Location = new System.Drawing.Point(14, 65);
            this.Food_SizenumericUpDown1.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.Food_SizenumericUpDown1.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.Food_SizenumericUpDown1.Name = "Food_SizenumericUpDown1";
            this.Food_SizenumericUpDown1.Size = new System.Drawing.Size(180, 31);
            this.Food_SizenumericUpDown1.TabIndex = 2;
            this.Food_SizenumericUpDown1.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.Food_SizenumericUpDown1.Visible = false;
            // 
            // defaultSize
            // 
            this.defaultSize.AutoSize = true;
            this.defaultSize.Location = new System.Drawing.Point(14, 102);
            this.defaultSize.Name = "defaultSize";
            this.defaultSize.Size = new System.Drawing.Size(92, 29);
            this.defaultSize.TabIndex = 1;
            this.defaultSize.TabStop = true;
            this.defaultSize.Text = "default";
            this.defaultSize.UseVisualStyleBackColor = true;
            this.defaultSize.CheckedChanged += new System.EventHandler(this.defaultSize_CheckedChanged);
            // 
            // Food_SizeRadioButton
            // 
            this.Food_SizeRadioButton.AutoSize = true;
            this.Food_SizeRadioButton.Location = new System.Drawing.Point(14, 30);
            this.Food_SizeRadioButton.Name = "Food_SizeRadioButton";
            this.Food_SizeRadioButton.Size = new System.Drawing.Size(98, 29);
            this.Food_SizeRadioButton.TabIndex = 0;
            this.Food_SizeRadioButton.TabStop = true;
            this.Food_SizeRadioButton.Text = "My Size";
            this.Food_SizeRadioButton.UseVisualStyleBackColor = true;
            this.Food_SizeRadioButton.CheckedChanged += new System.EventHandler(this.Food_SizeRadioButton_CheckedChanged);
            // 
            // Font
            // 
            this.Font.Controls.Add(this.defaultFont);
            this.Font.Controls.Add(this.BlueFont);
            this.Font.Controls.Add(this.WhiteFont);
            this.Font.Controls.Add(this.RedFont);
            this.Font.Location = new System.Drawing.Point(345, 209);
            this.Font.Name = "Font";
            this.Font.Size = new System.Drawing.Size(280, 177);
            this.Font.TabIndex = 5;
            this.Font.TabStop = false;
            this.Font.Text = "Font";
            // 
            // defaultFont
            // 
            this.defaultFont.AutoSize = true;
            this.defaultFont.Location = new System.Drawing.Point(14, 135);
            this.defaultFont.Name = "defaultFont";
            this.defaultFont.Size = new System.Drawing.Size(92, 29);
            this.defaultFont.TabIndex = 3;
            this.defaultFont.TabStop = true;
            this.defaultFont.Text = "default";
            this.defaultFont.UseVisualStyleBackColor = true;
            this.defaultFont.CheckedChanged += new System.EventHandler(this.defaultFont_CheckedChanged);
            // 
            // BlueFont
            // 
            this.BlueFont.AutoSize = true;
            this.BlueFont.Location = new System.Drawing.Point(14, 100);
            this.BlueFont.Name = "BlueFont";
            this.BlueFont.Size = new System.Drawing.Size(70, 29);
            this.BlueFont.TabIndex = 2;
            this.BlueFont.TabStop = true;
            this.BlueFont.Text = "Blue";
            this.BlueFont.UseVisualStyleBackColor = true;
            this.BlueFont.CheckedChanged += new System.EventHandler(this.BlueFont_CheckedChanged);
            // 
            // WhiteFont
            // 
            this.WhiteFont.AutoSize = true;
            this.WhiteFont.Location = new System.Drawing.Point(14, 65);
            this.WhiteFont.Name = "WhiteFont";
            this.WhiteFont.Size = new System.Drawing.Size(83, 29);
            this.WhiteFont.TabIndex = 1;
            this.WhiteFont.TabStop = true;
            this.WhiteFont.Text = "White";
            this.WhiteFont.UseVisualStyleBackColor = true;
            this.WhiteFont.CheckedChanged += new System.EventHandler(this.WhiteFont_CheckedChanged);
            // 
            // RedFont
            // 
            this.RedFont.AutoSize = true;
            this.RedFont.Location = new System.Drawing.Point(14, 30);
            this.RedFont.Name = "RedFont";
            this.RedFont.Size = new System.Drawing.Size(67, 29);
            this.RedFont.TabIndex = 0;
            this.RedFont.TabStop = true;
            this.RedFont.Text = "Red";
            this.RedFont.UseVisualStyleBackColor = true;
            this.RedFont.CheckedChanged += new System.EventHandler(this.RedFont_CheckedChanged);
            // 
            // SnakeBody
            // 
            this.SnakeBody.Controls.Add(this.DefaultBody);
            this.SnakeBody.Controls.Add(this.BlueBody);
            this.SnakeBody.Controls.Add(this.WhiteBody);
            this.SnakeBody.Controls.Add(this.RedBody);
            this.SnakeBody.Location = new System.Drawing.Point(13, 209);
            this.SnakeBody.Name = "SnakeBody";
            this.SnakeBody.Size = new System.Drawing.Size(280, 177);
            this.SnakeBody.TabIndex = 4;
            this.SnakeBody.TabStop = false;
            this.SnakeBody.Text = "Colour of snake\'s body";
            // 
            // DefaultBody
            // 
            this.DefaultBody.AutoSize = true;
            this.DefaultBody.Location = new System.Drawing.Point(14, 135);
            this.DefaultBody.Name = "DefaultBody";
            this.DefaultBody.Size = new System.Drawing.Size(92, 29);
            this.DefaultBody.TabIndex = 3;
            this.DefaultBody.TabStop = true;
            this.DefaultBody.Text = "default";
            this.DefaultBody.UseVisualStyleBackColor = true;
            this.DefaultBody.CheckedChanged += new System.EventHandler(this.DefaultBody_CheckedChanged);
            // 
            // BlueBody
            // 
            this.BlueBody.AutoSize = true;
            this.BlueBody.Location = new System.Drawing.Point(14, 100);
            this.BlueBody.Name = "BlueBody";
            this.BlueBody.Size = new System.Drawing.Size(70, 29);
            this.BlueBody.TabIndex = 2;
            this.BlueBody.TabStop = true;
            this.BlueBody.Text = "Blue";
            this.BlueBody.UseVisualStyleBackColor = true;
            this.BlueBody.CheckedChanged += new System.EventHandler(this.BlueBody_CheckedChanged);
            // 
            // WhiteBody
            // 
            this.WhiteBody.AutoSize = true;
            this.WhiteBody.Location = new System.Drawing.Point(14, 65);
            this.WhiteBody.Name = "WhiteBody";
            this.WhiteBody.Size = new System.Drawing.Size(83, 29);
            this.WhiteBody.TabIndex = 1;
            this.WhiteBody.TabStop = true;
            this.WhiteBody.Text = "White";
            this.WhiteBody.UseVisualStyleBackColor = true;
            this.WhiteBody.CheckedChanged += new System.EventHandler(this.WhiteBody_CheckedChanged);
            // 
            // RedBody
            // 
            this.RedBody.AutoSize = true;
            this.RedBody.Location = new System.Drawing.Point(14, 30);
            this.RedBody.Name = "RedBody";
            this.RedBody.Size = new System.Drawing.Size(67, 29);
            this.RedBody.TabIndex = 0;
            this.RedBody.TabStop = true;
            this.RedBody.Text = "Red";
            this.RedBody.UseVisualStyleBackColor = true;
            this.RedBody.CheckedChanged += new System.EventHandler(this.RedBody_CheckedChanged);
            // 
            // SnakeColour
            // 
            this.SnakeColour.Controls.Add(this.DefaultHead);
            this.SnakeColour.Controls.Add(this.BlueHead);
            this.SnakeColour.Controls.Add(this.WhiteHead);
            this.SnakeColour.Controls.Add(this.RedHead);
            this.SnakeColour.Location = new System.Drawing.Point(345, 6);
            this.SnakeColour.Name = "SnakeColour";
            this.SnakeColour.Size = new System.Drawing.Size(280, 177);
            this.SnakeColour.TabIndex = 1;
            this.SnakeColour.TabStop = false;
            this.SnakeColour.Text = "Colour of snake\'s head";
            // 
            // DefaultHead
            // 
            this.DefaultHead.AutoSize = true;
            this.DefaultHead.Location = new System.Drawing.Point(14, 135);
            this.DefaultHead.Name = "DefaultHead";
            this.DefaultHead.Size = new System.Drawing.Size(92, 29);
            this.DefaultHead.TabIndex = 3;
            this.DefaultHead.TabStop = true;
            this.DefaultHead.Text = "default";
            this.DefaultHead.UseVisualStyleBackColor = true;
            this.DefaultHead.CheckedChanged += new System.EventHandler(this.DefaultHead_CheckedChanged);
            // 
            // BlueHead
            // 
            this.BlueHead.AutoSize = true;
            this.BlueHead.Location = new System.Drawing.Point(14, 100);
            this.BlueHead.Name = "BlueHead";
            this.BlueHead.Size = new System.Drawing.Size(70, 29);
            this.BlueHead.TabIndex = 2;
            this.BlueHead.TabStop = true;
            this.BlueHead.Text = "Blue";
            this.BlueHead.UseVisualStyleBackColor = true;
            this.BlueHead.CheckedChanged += new System.EventHandler(this.BlueHead_CheckedChanged);
            // 
            // WhiteHead
            // 
            this.WhiteHead.AutoSize = true;
            this.WhiteHead.Location = new System.Drawing.Point(14, 65);
            this.WhiteHead.Name = "WhiteHead";
            this.WhiteHead.Size = new System.Drawing.Size(83, 29);
            this.WhiteHead.TabIndex = 1;
            this.WhiteHead.TabStop = true;
            this.WhiteHead.Text = "White";
            this.WhiteHead.UseVisualStyleBackColor = true;
            this.WhiteHead.CheckedChanged += new System.EventHandler(this.WhiteHead_CheckedChanged);
            // 
            // RedHead
            // 
            this.RedHead.AutoSize = true;
            this.RedHead.Location = new System.Drawing.Point(14, 30);
            this.RedHead.Name = "RedHead";
            this.RedHead.Size = new System.Drawing.Size(67, 29);
            this.RedHead.TabIndex = 0;
            this.RedHead.TabStop = true;
            this.RedHead.Text = "Red";
            this.RedHead.UseVisualStyleBackColor = true;
            this.RedHead.CheckedChanged += new System.EventHandler(this.RedHead_CheckedChanged);
            // 
            // FoodColour
            // 
            this.FoodColour.Controls.Add(this.DefaultFood);
            this.FoodColour.Controls.Add(this.BlueFood);
            this.FoodColour.Controls.Add(this.WhiteFood);
            this.FoodColour.Controls.Add(this.RedFood);
            this.FoodColour.Location = new System.Drawing.Point(13, 6);
            this.FoodColour.Name = "FoodColour";
            this.FoodColour.Size = new System.Drawing.Size(280, 177);
            this.FoodColour.TabIndex = 0;
            this.FoodColour.TabStop = false;
            this.FoodColour.Text = "Food Colour";
            // 
            // DefaultFood
            // 
            this.DefaultFood.AutoSize = true;
            this.DefaultFood.Location = new System.Drawing.Point(14, 135);
            this.DefaultFood.Name = "DefaultFood";
            this.DefaultFood.Size = new System.Drawing.Size(92, 29);
            this.DefaultFood.TabIndex = 3;
            this.DefaultFood.TabStop = true;
            this.DefaultFood.Text = "default";
            this.DefaultFood.UseVisualStyleBackColor = true;
            this.DefaultFood.CheckedChanged += new System.EventHandler(this.DefaultFood_CheckedChanged);
            // 
            // BlueFood
            // 
            this.BlueFood.AutoSize = true;
            this.BlueFood.Location = new System.Drawing.Point(14, 100);
            this.BlueFood.Name = "BlueFood";
            this.BlueFood.Size = new System.Drawing.Size(70, 29);
            this.BlueFood.TabIndex = 2;
            this.BlueFood.TabStop = true;
            this.BlueFood.Text = "Blue";
            this.BlueFood.UseVisualStyleBackColor = true;
            this.BlueFood.CheckedChanged += new System.EventHandler(this.BlueFood_CheckedChanged);
            // 
            // WhiteFood
            // 
            this.WhiteFood.AutoSize = true;
            this.WhiteFood.Location = new System.Drawing.Point(14, 65);
            this.WhiteFood.Name = "WhiteFood";
            this.WhiteFood.Size = new System.Drawing.Size(83, 29);
            this.WhiteFood.TabIndex = 1;
            this.WhiteFood.TabStop = true;
            this.WhiteFood.Text = "White";
            this.WhiteFood.UseVisualStyleBackColor = true;
            this.WhiteFood.CheckedChanged += new System.EventHandler(this.WhiteFood_CheckedChanged);
            // 
            // RedFood
            // 
            this.RedFood.AutoSize = true;
            this.RedFood.ForeColor = System.Drawing.Color.Black;
            this.RedFood.Location = new System.Drawing.Point(14, 30);
            this.RedFood.Name = "RedFood";
            this.RedFood.Size = new System.Drawing.Size(67, 29);
            this.RedFood.TabIndex = 0;
            this.RedFood.TabStop = true;
            this.RedFood.Text = "Red";
            this.RedFood.UseVisualStyleBackColor = true;
            this.RedFood.CheckedChanged += new System.EventHandler(this.RedFood_CheckedChanged);
            // 
            // SnakeForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1007, 517);
            this.Controls.Add(this.tabControl1);
            this.Name = "SnakeForm1";
            this.Text = "Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SnakeForm1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SnakeForm1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Snake.ResumeLayout(false);
            this.Snake.PerformLayout();
            this.Settings1.ResumeLayout(false);
            this.FoodSize.ResumeLayout(false);
            this.FoodSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Food_SizenumericUpDown1)).EndInit();
            this.Font.ResumeLayout(false);
            this.Font.PerformLayout();
            this.SnakeBody.ResumeLayout(false);
            this.SnakeBody.PerformLayout();
            this.SnakeColour.ResumeLayout(false);
            this.SnakeColour.PerformLayout();
            this.FoodColour.ResumeLayout(false);
            this.FoodColour.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Button Startbutton1;
        private Button Snapbutton2;
        private Label label1;
        private Label label2;
        private TabControl tabControl1;
        private TabPage Snake;
        private TabPage Settings1;
        private GroupBox FoodSize;
        private NumericUpDown Food_SizenumericUpDown1;
        private RadioButton defaultSize;
        private RadioButton Food_SizeRadioButton;
        private GroupBox Font;
        private RadioButton defaultFont;
        private RadioButton BlueFont;
        private RadioButton WhiteFont;
        private RadioButton RedFont;
        private GroupBox SnakeBody;
        private RadioButton DefaultBody;
        private RadioButton BlueBody;
        private RadioButton WhiteBody;
        private RadioButton RedBody;
        private GroupBox SnakeColour;
        private RadioButton DefaultHead;
        private RadioButton BlueHead;
        private RadioButton WhiteHead;
        private RadioButton RedHead;
        private GroupBox FoodColour;
        private RadioButton DefaultFood;
        private RadioButton BlueFood;
        private RadioButton WhiteFood;
        private RadioButton RedFood;
    }
}