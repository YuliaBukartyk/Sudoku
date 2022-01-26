using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SudokuServer
{
    public interface IStrategy
    {
        void GenerateBoardWithLevel(string gameMode);
    }

    public class ChooseGameLevel : IStrategy
    {
        public void GenerateBoardWithLevel(string gameMode)
        {
            if (gameMode.Equals("easy"))
            {
                new BoardGeneratorStrategy(new EasyGame()).GenerateBoardWithLevel(gameMode);

            }
            else if (gameMode.Equals("normal"))
            {
                new BoardGeneratorStrategy(new NormalGame()).GenerateBoardWithLevel(gameMode);
            }
            else if (gameMode.Equals("hard"))
            {
                new BoardGeneratorStrategy(new HardGame()).GenerateBoardWithLevel(gameMode);

            }
            //BoardGenerator easySudokuBoard = new BoardGenerator(gameMode);

        }
    }



    public class EasyGame : IStrategy
    {
        public void GenerateBoardWithLevel(string gameMode)
        {
            // generate the board and hide 32 cells for easy game
            BoardGenerator easySudokuBoard = new BoardGenerator(32);
            
        }
    }

    public class NormalGame : IStrategy
    {
        public void GenerateBoardWithLevel(string gameMode)
        {
            // generate the board and hide 44 cells for easy game
            BoardGenerator easySudokuBoard = new BoardGenerator(44);

        }
    }

    public class HardGame : IStrategy
    {
        public void GenerateBoardWithLevel(string gameMode)
        {
            // generate the board and hide 50 cells for easy game
            BoardGenerator easySudokuBoard = new BoardGenerator(50);

        }
    }

    public class BoardGeneratorStrategy
    {
        private IStrategy _strategy;
        public BoardGeneratorStrategy(IStrategy chosenStrategy)
        {
            _strategy = chosenStrategy;
        }

        public void GenerateBoardWithLevel(string gameMode)
        {
            //string sudokuStringLevelMode = "";
            if (gameMode.Equals("easy"))
            {
                _strategy.GenerateBoardWithLevel(gameMode);
                
                
            }
            else if (gameMode.Equals("normal"))
            {
                _strategy.GenerateBoardWithLevel(gameMode);
            }
            else if (gameMode.Equals("hard"))
            {
                _strategy.GenerateBoardWithLevel(gameMode);
            }

            //_strategy.GenerateBoardWithLevel(gameMode);
            //sudokuStringLevelMode = result.ToString();
            //return sudokuStringLevelMode;
        }
    }

}
