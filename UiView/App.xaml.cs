using AutoMapper;
using GameModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using UiView.Base;
using UiView.ViewModels;

namespace UiView
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private GameSession gameSession;
        private GameSessionViewModel gameSessionViewModel;
        public App()
        {
            //GameSession.update();
            Mapping.Create();
            gameSession = GameSession.Load();
            gameSessionViewModel = Mapper.Map<GameSession, GameSessionViewModel>(gameSession);
            var window = new MainWindow() { DataContext = gameSessionViewModel};
            window.Show();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            try
            {
                gameSession = Mapper.Map<GameSessionViewModel, GameSession>(gameSessionViewModel);
                gameSession.Save();
            }
            catch (Exception)
            {
                base.OnExit(e);
                throw;
            }
        }
    }
}
