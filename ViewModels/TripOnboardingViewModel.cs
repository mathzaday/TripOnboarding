using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripOnboarding.Models;

namespace TripOnboarding.ViewModels
{
    public partial class TripOnboardingViewModel : ObservableObject
    {
        [ObservableProperty]
        private List<TripOnboardingItems> _items;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsLastPage))]
        [NotifyPropertyChangedFor(nameof(ShowButton))]
        private int _position;

        public bool IsLastPage => Position == Items.Count - 1;

        public bool ShowButton => !IsLastPage;

        public TripOnboardingViewModel()
        {
            Items = new List<TripOnboardingItems>
            {
                new TripOnboardingItems
                {
                    Titulo = "Explore \r\nExotic Destinations",
                    Descricao = "Embark on a virtual journey through stunning destinations worldwide.",
                    ImageURL = "explore.png"
                },
                new TripOnboardingItems
                {
                    Titulo = "Discover \r\nLocal Gems",
                    Descricao = "Uncover hidden gems and local favorites recommended by fellow travelers.",
                    ImageURL = "discovery.png"
                },
                new TripOnboardingItems
                {
                    Titulo = "Plan \r\nYour Perfect Trip",
                    Descricao = "Create personalized itineraries tailored to your preferences and interests.",
                    ImageURL = "train.png"
                },
                new TripOnboardingItems
                {
                    Titulo = "Capture and Share Memories",
                    Descricao = "Preserve your travel memories with our in-app photo and journaling features.",
                    ImageURL = "vacation.png"
                }
            };
        }
        [RelayCommand]
        private void NextPage()
        {
            if (Position < Items.Count - 1)
            {
                Position++;
            }
        }
    }
}
