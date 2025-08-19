using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class Point
{
    public int X;
    public int Y;
    public Point(int x, int y) { X = x; Y = y; }
    public bool Equals(Point other) => other != null && X == other.X && Y == other.Y;
}

class Program
{
    static int width = 40, height = 20, score = 0, foodEaten = 0;
    static List<Point> snake = new List<Point>();
    static Point direction = new Point(1, 0);
    static Point food, bigFood = null;
    static int bigFoodTimer = 0;
    static int bigFoodScore = 50;
    static bool justAte = false;
    static double speedMs = 120;

    static void Main()
    {
        Console.CursorVisible = false;
        Console.SetWindowSize(width, height);
        InitializeGame();

        DateTime lastMove = DateTime.Now;

        while (true)
        {
            if (Console.KeyAvailable) Input();

            if ((DateTime.Now - lastMove).TotalMilliseconds >= speedMs)
            {
                Move();
                if (CheckSelfCollision())
                {
                    Console.Clear();
                    Console.SetCursorPosition(width / 2 - 5, height / 2);
                    Console.WriteLine($"Game Over! Score: {score}");
                    break;
                }

                Draw();
                lastMove = DateTime.Now;
                speedMs = Math.Max(40, speedMs - 0.2); // Gradual speed increase
            }

            Thread.Sleep(1);
        }
    }

    static void InitializeGame()
    {
        snake.Clear();
        snake.Add(new Point(width / 2, height / 2));
        GenerateFood();
    }

    static void Draw()
    {
        Console.Clear();
        Console.SetCursorPosition(0, 0);
        Console.WriteLine($"Score: {score}");

        // Draw big food if exists
        if (bigFood != null)
        {
            Console.SetCursorPosition(bigFood.X, bigFood.Y);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("B");
            Console.ResetColor();
            Console.SetCursorPosition(0, 1);
            Console.WriteLine($"Big Food: {bigFoodScore} pts, Time Left: {bigFoodTimer}");
        }
        else
        {
            // Draw regular food
            Console.SetCursorPosition(food.X, food.Y);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("@");
            Console.ResetColor();
        }

        // Snake
        foreach (var part in snake)
        {
            Console.SetCursorPosition(part.X, part.Y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("O");
        }

        Console.ResetColor();
    }

    static void Input()
    {
        var key = Console.ReadKey(true).Key;

        if (key == ConsoleKey.UpArrow && direction.Y != 1)
            direction = new Point(0, -1);
        else if (key == ConsoleKey.DownArrow && direction.Y != -1)
            direction = new Point(0, 1);
        else if (key == ConsoleKey.LeftArrow && direction.X != 1)
            direction = new Point(-1, 0);
        else if (key == ConsoleKey.RightArrow && direction.X != -1)
            direction = new Point(1, 0);
    }

    static void Move()
    {
        Point head = snake.Last();
        Point newHead = new Point(head.X + direction.X, head.Y + direction.Y);

        // Apply screen wrapping
        newHead.X = (newHead.X + width) % width;
        newHead.Y = (newHead.Y + height) % height;

        // Eat big food
        if (bigFood != null && newHead.X == bigFood.X && newHead.Y == bigFood.Y)
        {
            snake.Add(newHead);
            score += bigFoodScore;
            bigFood = null;
            justAte = true;
            GenerateFood(); // After big food, generate normal food
            return;
        }

        // Eat normal food
        if (bigFood == null && newHead.X == food.X && newHead.Y == food.Y)
        {
            snake.Add(newHead);
            score += 10;
            foodEaten++;
            justAte = true;

            if (foodEaten % 5 == 0)
                GenerateBigFood();
            else
                GenerateFood();

            return;
        }

        // Normal move
        snake.Add(newHead);
        snake.RemoveAt(0);

        // Big food countdown
        if (bigFood != null)
        {
            bigFoodTimer--;
            bigFoodScore = Math.Max(10, bigFoodScore - 2); // Reduce reward

            if (bigFoodTimer <= 0)
            {
                food = new Point(bigFood.X, bigFood.Y); // Replace with normal food
                bigFood = null;
            }
        }
    }

    static bool CheckSelfCollision()
    {
        Point head = snake.Last();
        for (int i = 0; i < snake.Count - 1; i++)
        {
            if (head.X == snake[i].X && head.Y == snake[i].Y)
                return true;
        }
        return false;
    }

    static void GenerateFood()
    {
        Random rand = new Random();
        Point newFood;
        do
        {
            newFood = new Point(rand.Next(0, width), rand.Next(0, height));
        } while (snake.Any(p => p.X == newFood.X && p.Y == newFood.Y));
        food = newFood;
    }

    static void GenerateBigFood()
    {
        Random rand = new Random();
        Point newBig;
        do
        {
            newBig = new Point(rand.Next(0, width), rand.Next(0, height));
        } while (
            snake.Any(p => p.X == newBig.X && p.Y == newBig.Y)
            || (food.X == newBig.X && food.Y == newBig.Y)
        );

        bigFood = newBig;
        bigFoodTimer = 25; // Lasts for 25 moves
        bigFoodScore = 50; // Start at max reward
    }
}
