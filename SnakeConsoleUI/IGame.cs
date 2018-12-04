using System;

namespace SnakeConsoleUI
{
    public interface IGame
    {
        void Initialization();
        void Start();
        void Step();
        void Stop();
        void Instruction(Direction direction);
        Action<Point, Item> Draw { get; set; }


        GameState State { get; }

    }
}