using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsGame1
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            Game1 game = new Game1();
            game.Run();

        }
    }
#endif
}

