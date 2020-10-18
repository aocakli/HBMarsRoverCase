using System;
using System.Collections.Generic;
using System.Text;

namespace HBMarsRoverCase
{
    public class Rover
    {
        public Rover(int X, int Y, Directions D)
        {
            pointX = X;
            pointY = Y;
            direction = D;
        }
        private int pointX { get; set; }
        private int pointY { get; set; }
        private Directions direction { get; set; }

        public void startAction(int maxX, int maxY, string moveOrder)
        {

            foreach (var order in moveOrder.ToCharArray())
            {
                switch (order)
                {
                    case 'M':
                        this.move();
                        break;
                    case 'L':
                        this.turnLeft();
                        break;
                    case 'R':
                        this.turnRight();
                        break;
                }
                if (this.getPointX() < 0 || this.getPointX() > maxX || this.getPointY() < 0 || this.getPointY() > maxY)
                {
                    Console.WriteLine("This rover is out of map");
                }
            }
        }
        private void turnLeft()
        {
            switch (this.direction)
            {
                case Directions.N:
                    direction = Directions.W;
                    break;
                case Directions.W:
                    direction = Directions.S;
                    break;
                case Directions.S:
                    direction = Directions.E;
                    break;
                case Directions.E:
                    direction = Directions.N;
                    break;
            }
        }
        private void turnRight()
        {
            switch (direction)
            {
                case Directions.N:
                    direction = Directions.E;
                    break;
                case Directions.E:
                    direction = Directions.S;
                    break;
                case Directions.S:
                    direction = Directions.W;
                    break;
                case Directions.W:
                    direction = Directions.N;
                    break;
            }
        }
        private void move()
        {
            switch (direction)
            {
                case Directions.N:
                    pointY++;
                    break;
                case Directions.E:
                    pointX++;
                    break;
                case Directions.S:
                    pointY--;
                    break;
                case Directions.W:
                    pointX--;
                    break;
            }
        }
        public int getPointX()
        {
            return pointX;
        }
        public int getPointY()
        {
            return pointY;
        }
        public Directions getDirection()
        {
            return direction;
        }
        public void sayLocation()
        {
            Console.WriteLine(this.getPointX().ToString() + " " + this.getPointY().ToString() + " " + this.getDirection());
        }
    }
    public enum Directions
    {
        N = 1,
        S,
        E,
        W
    }
}
