using System;

namespace unit034_枚举练习
{
    enum GameState
    {
        Menu,Running,Pause,Fail,Success
        //后边的值会根据前边的值进行自增。
        //假设：Menu=10,Running,Pause,Fail,Success
        //则对应的：Running=11

    }
    class Program
    {
        static void Main(string[] args)
        {
            GameState gameState = GameState.Fail;
            GameState gameState2 = GameState.Success;
            Console.WriteLine(Convert.ToInt32(gameState));
            int number = (int)gameState;
            int number2 = (int)gameState2;
        }
    }
}
