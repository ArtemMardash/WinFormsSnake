namespace WinFormsSnake
{
    public partial class SnakeForm1 : Form
    {
        private Circle food = new Circle();
        private List<Circle> snake = new List<Circle>();
        int maxWidth;
        int maxHeight;

        int score;
        int highScore;

        int foodSize = 15;

        Brush snakeHeadColor, snakeBodyColour, foodColour;

        Color fontColour;

        Random random = new Random();

        bool goUp;
        bool goDown;
        bool goLeft;
        bool goRight;

        public SnakeForm1()
        {
            InitializeComponent();
            new Settings(foodSize);
            fontColour = Color.Lime;
            snakeHeadColor = Brushes.Black;
            snakeBodyColour = Brushes.DarkBlue;
            foodColour = Brushes.Red;
        }


        private void RestartGame()
        {
            snake.Clear();

            maxWidth = pictureBox1.Width / Settings1.Width - 1;
            maxHeight = pictureBox1.Height / Settings1.Height - 1;

            foodSize = Convert.ToInt32(Food_SizenumericUpDown1.Value);
            new Settings(foodSize);

            Startbutton1.Enabled = false;
            Snapbutton2.Enabled = false;
            tabControl1.Enabled = false;

            score = 0;
            label1.Text = "score: " + score;

            Circle head = new Circle { X = foodSize, Y = foodSize };
            snake.Add(head);

            for (int i = 0; i < 10; i++)
            {
                Circle body = new Circle();
                snake.Add(body);
            }
            food = new Circle { X = random.Next(2, 20), Y = random.Next(2, 20) };
            timer1.Start();

        }

        private void EatFood()
        {
            Circle body = new Circle { X = snake[snake.Count - 1].X, Y = snake[snake.Count - 1].Y };
            score += 1;
            label1.Text = "score: " + score;
            snake.Add(body);
            food = new Circle { X = random.Next(2, maxWidth), Y = random.Next(2, maxHeight) };
            if(snake.Count %3 == 0 && timer1.Interval > 30)
            {
                timer1.Interval -= 15;
            }
        }

        private void GameOver()
        {
            timer1.Stop();
            Startbutton1.Enabled = true;
            Snapbutton2.Enabled = true;
            tabControl1.Enabled = true;
            if(score > highScore)
            {
                highScore = score;
                label2.Text = "Record: " + highScore;
            }
        }

        private void Startbutton1_Click(object sender, EventArgs e)
        {
            RestartGame();

        }

        private void SnakeForm1_KeyDown(object sender, KeyEventArgs e)
        {
            if((e.KeyCode == Keys.Left) && (WinFormsSnake.Settings.direction != "right"))
            {
                goLeft = true;
            }
            if(e.KeyCode == Keys.Right && WinFormsSnake.Settings.direction != "left")
            {
                goRight = true;
            }
            if(e.KeyCode == Keys.Up && WinFormsSnake.Settings.direction != "down")
            {
                goUp = true;
            }
            if(e.KeyCode == Keys.Down && WinFormsSnake.Settings.direction != "up")
            {
                goDown = true;
            }
        }

        private void SnakeForm1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if(e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if(e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if(e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
        }
        #region FoodColour
        private void RedFood_CheckedChanged(object sender, EventArgs e)
        {
            foodColour = Brushes.Red;
        }

        private void WhiteFood_CheckedChanged(object sender, EventArgs e)
        {
            foodColour = Brushes.White;
        }

        private void BlueFood_CheckedChanged(object sender, EventArgs e)
        {
            foodColour = Brushes.Blue;
        }

        private void DefaultFood_CheckedChanged(object sender, EventArgs e)
        {
            foodColour = Brushes.Red;
        }
        #endregion

        #region Headcolour

        private void RedHead_CheckedChanged(object sender, EventArgs e)
        {
            snakeHeadColor = Brushes.Red;
        }

        private void WhiteHead_CheckedChanged(object sender, EventArgs e)
        {
            snakeHeadColor = Brushes.White;
        }

        private void BlueHead_CheckedChanged(object sender, EventArgs e)
        {
            snakeHeadColor = Brushes.Blue;
        }

        private void DefaultHead_CheckedChanged(object sender, EventArgs e)
        {
            snakeHeadColor = Brushes.Black;
        }
        #endregion

        #region BodyColour
        private void RedBody_CheckedChanged(object sender, EventArgs e)
        {
            snakeBodyColour = Brushes.Red;
        }

        private void WhiteBody_CheckedChanged(object sender, EventArgs e)
        {
            snakeBodyColour = Brushes.White;
        }

        private void BlueBody_CheckedChanged(object sender, EventArgs e)
        {
            snakeBodyColour = Brushes.Blue;
        }

        private void DefaultBody_CheckedChanged(object sender, EventArgs e)
        {
            snakeBodyColour = Brushes.DarkBlue;
        }
        #endregion

        #region FontColour
        private void RedFont_CheckedChanged(object sender, EventArgs e)
        {
            fontColour = Color.Red;
        }

        private void WhiteFont_CheckedChanged(object sender, EventArgs e)
        {
            fontColour = Color.White;
        }

        private void BlueFont_CheckedChanged(object sender, EventArgs e)
        {
            fontColour = Color.Blue;
        }

        private void defaultFont_CheckedChanged(object sender, EventArgs e)
        {
            fontColour = Color.Lime;
        }
        #endregion

        #region FoodSize
        private void Food_SizeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Food_SizenumericUpDown1.Visible = true;
        }

        private void defaultSize_CheckedChanged(object sender, EventArgs e)
        {
            Food_SizenumericUpDown1.Value = 15;
        }

        #endregion

        private void UpdatePictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            Brush snakeColour;

            maxWidth = pictureBox1.Width/Settings1.Width - 1;
            maxHeight = pictureBox1.Height/Settings1.Height - 1;

            pictureBox1.BackColor = fontColour;

            for(int i = 0; i < snake.Count; i++)
            {
                if(i==0)
                {
                    snakeColour = snakeHeadColor;
                }
                else
                {
                    snakeColour = snakeBodyColour;
                }
                canvas.FillEllipse(snakeColour, new Rectangle
                    (
                    snake[i].X * Settings.Width,
                    snake[i].Y * Settings.Height,
                     Settings.Width,
                     Settings.Height
                    )
                    );
            }
            canvas.FillEllipse(foodColour, new Rectangle
                (
                food.X * Settings.Width,
                food.Y * Settings.Height,
                 Settings.Width,
                 Settings.Height
                )
                );
        }

        //private void UpdatePictureBoxGraphics(object sender, PaintEventArgs e)
        //{
        //    Graphics canvas = e.Graphics;
        //    Brush snakeColour;

        //    maxWidth = pictureBox.Width / Settings.Width - 1;
        //    maxHeight = pictureBox.Height / Settings.Height - 1;

        //    pictureBox.BackColor = fontColor;

        //    for (int i = 0; i < snake.Count; i++)
        //    {
        //        if (i == 0)
        //        {
        //            snakeColour = snakeHeadColor;
        //        }
        //        else
        //        {
        //            snakeColour = snakeBodyColor;
        //        }

        //        canvas.FillEllipse(snakeColour, new Rectangle
        //            (
        //            snake[i].X * Settings.Width,
        //            snake[i].Y * Settings.Height,
        //            Settings.Width, Settings.Height
        //            ));
        //    }


        //    canvas.FillEllipse(foodColor, new Rectangle
        //    (
        //    food.X * Settings.Width,
        //    food.Y * Settings.Height,
        //    Settings.Width, Settings.Height
        //    ));
        //}


        private void timer1_Tick(object sender, EventArgs e)
        {
            if(goLeft )
            {
                Settings.direction = "left";

            }
            if(goRight)
            {
                Settings.direction = "right";
            }
            if(goDown)
            {
                Settings.direction = "down";
            }
            if(goUp)
            {
                Settings.direction = "up";
            }
            for (int i = snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (Settings.direction)
                    {
                        case "left":
                            snake[i].X--;
                            break;
                        case "right":
                            snake[i].X++;
                            break;
                        case "down":
                            snake[i].Y++;
                            break;
                        case "up":
                            snake[i].Y--;
                            break;
                    }
                    if (snake[i].X < 0)
                    {
                        snake[i].X = maxWidth;
                    }
                    if (snake[i].X > maxWidth)
                    {
                        snake[i].X = 0;
                    }
                    if (snake[i].Y < 0)
                    {
                        snake[i].Y = maxHeight;
                    }
                    if (snake[i].Y > maxHeight)
                    {
                        snake[i].Y = 0;
                    }
                    if (snake[i].X == food.X && snake[i].Y == food.Y)
                    {
                        EatFood();
                    }
                    for (int j = 1; j < snake.Count; j++)
                    {
                        if (snake[i].X == snake[j].X && snake[i].Y == snake[j].Y)
                        {
                            GameOver();
                        }
                    }
                }
                else
                {
                    snake[i].X = snake[i - 1].X;
                    snake[i].Y = snake[i - 1].Y;
                }
            }
            pictureBox1.Invalidate();
        }
    }
}