using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B18_Ex05_1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GameSettingsForm gameSettingsForm = new GameSettingsForm();
            Application.Run(gameSettingsForm);
            int sizeOfBoard = gameSettingsForm.sizeOfBoard;
            string PlayerOneName = gameSettingsForm.nameOfPlayerOne;
            string PlayerTwoName = gameSettingsForm.nameOfPlayerTwo;
            if(gameSettingsForm.IsPassValidation == true)
            {
                Application.Run(new DamkaForm(sizeOfBoard, PlayerOneName, PlayerTwoName));
            }
        }
    }
}
