using System;

namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            Tablero juegoNuevo = new Tablero();
            ImprimirTablero dibujoJuego = new ImprimirTablero();
            LogicaJuego logicaJuegoNuevo = new LogicaJuego();

            string url = @"../../assets/board.txt";

            juegoNuevo.BuildBoard(url);

            bool[,] copiaJuego = juegoNuevo.GetBoard;


            while (true)
            {
                dibujoJuego.Print(copiaJuego);
                copiaJuego = logicaJuegoNuevo.GameLogic(copiaJuego);
            }


        }
    }
}
