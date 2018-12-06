using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GameModel;
using UiView.ViewModels;

namespace UiView.Base
{
    class Mapping
    {
        public static void Create()
        {
            Mapper.CreateMap<GameSession, GameSessionViewModel>();
            Mapper.CreateMap<GameSessionViewModel, GameSession>();

            Mapper.CreateMap<EventsViewModel, Event>();
            Mapper.CreateMap<Event, EventsViewModel>();

            Mapper.CreateMap<PlatformViewModel, Platform>();
            Mapper.CreateMap<Platform, PlatformViewModel>();

        }
    }
}
