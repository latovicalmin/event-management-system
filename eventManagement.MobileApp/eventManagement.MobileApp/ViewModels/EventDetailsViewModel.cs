using eventManagement.Model;
using eventManagement.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eventManagement.MobileApp.ViewModels
{
    public class EventDetailsViewModel : BaseViewModel
    {
        private readonly APIService _participantsService = new APIService("participants");
        private readonly APIService _ratingsService = new APIService("ratings");
        private readonly APIService _eventsService = new APIService("events");
        public ObservableCollection<Event> EventsList { get; set; } = new ObservableCollection<Event>();

        public ICommand InitCommand { get; set; }
        public ICommand RateCommand { get; set; }
        public ICommand ParticipateCommand { get; set; }

        public Event Event { get; set; }
        public decimal? RatingValue { get; set; } = null;
        public bool RatingVisible { get; set; }
        public bool _alreadyParticipate = false;
        public bool _noParticipation = true;
        public bool _displayRatingInput = false;
        public string _averageRating = "0";
        public string _totalVotes = "0";

        public string AverageRating
        {
            get { return _averageRating; }
            set
            {
                SetProperty(ref _averageRating, value);
            }
        }

        public string TotalVotes
        {
            get { return _totalVotes; }
            set
            {
                SetProperty(ref _totalVotes, value);
            }
        }

        public bool AlreadyParticipate
        {
            get { return _alreadyParticipate; }
            set
            {
                SetProperty(ref _alreadyParticipate, value);
            }
        }

        public bool DisplayRatingInput
        {
            get { return _displayRatingInput; }
            set
            {
                SetProperty(ref _displayRatingInput, value);
            }
        }

        public bool NoParticipation
        {
            get { return _noParticipation; }
            set
            {
                SetProperty(ref _noParticipation, value);
            }
        }


        public EventDetailsViewModel()
        {
            InitCommand = new Command(async () => await Init());
            RateCommand = new Command(async () => await RateEvent());
            ParticipateCommand = new Command(async () => await Participate());
        }

        public async Task RateEvent()
        {
            if (RatingValue.HasValue == true && RatingValue > 0 && RatingValue <= 5)
            {
                Rating rating = new Rating()
                {
                    CreatedAt = DateTime.Now,
                    EventId = Event.EventId,
                    UserId = Global.LoggedUser.UserId,
                    Value = RatingValue.Value,
                };

                var entity = await _ratingsService.Insert<Rating>(rating);

                if (entity != null)
                {
                    await App.Current.MainPage.DisplayAlert("Info", "Hvala za ocjenu", "OK");
                    DisplayRatingInput = false;
                }
            }
        }

        public async Task Init()
        {
            RatingSearchRequest ratingRequest = new RatingSearchRequest()
            {
                EventId = Event.EventId,
                UserId = Global.LoggedUser.UserId,
            };

            var ratingList = await _ratingsService.Get<List<Rating>>(ratingRequest);
            if (ratingList != null && ratingList.Count > 0)
            {
                AverageRating = ratingList.Average(item => item.Value).ToString("0.00");
                TotalVotes = ratingList.Count.ToString();

                if (ratingList.Find(x => x.EventId == Event.EventId && x.UserId == Global.LoggedUser.UserId) != null)
                {
                    DisplayRatingInput = false;
                }
            } else
            {
                DisplayRatingInput = true;
            }

            ParticipantSearchRequest request = new ParticipantSearchRequest()
            {
                EventId = Event.EventId,
                UserId = Global.LoggedUser.UserId,
            };

            var list = await _participantsService.Get<List<Participants>>(request);

            if (list.Find(x => x.EventId == Event.EventId && x.UserId == Global.LoggedUser.UserId) != null)
            {
                AlreadyParticipate = true;
                NoParticipation = false;
            } else
            {
                AlreadyParticipate = false;
                NoParticipation = true;
            }
        }

        public async Task RemoveParticipate()
        {
            ParticipantSearchRequest request = new ParticipantSearchRequest()
            {
                EventId = Event.EventId,
                UserId = Global.LoggedUser.UserId,
            };

            var list = await _participantsService.Get<List<Participants>>(request);

            var entity = list.Find(x => x.EventId == Event.EventId && x.UserId == Global.LoggedUser.UserId);

            var response = await _participantsService.Remove<Participants>(entity.ParticipantId);

            if (response)
            {
                AlreadyParticipate = false;
                NoParticipation = true;
                await App.Current.MainPage.DisplayAlert("Info", "Uspješto ste otkazali vaš dolazak", "OK");
            }
        }

        public async Task Participate()
        {
            Participants participate = new Participants()
            {
                CreatedAt = DateTime.Now,
                EventId = Event.EventId,
                UserId = Global.LoggedUser.UserId,
            };

            var entity = await _participantsService.Insert<Participants>(participate);

            if (entity != null)
            {
                AlreadyParticipate = true;
                NoParticipation = false;
                await App.Current.MainPage.DisplayAlert("Dobrodošli", "Hvala na dolasku", "OK");
            }
        }

        public async void Recommend(int id)
        {
            var list = await _eventsService.GetRecommendedById<IEnumerable<Event>>(id);
            EventsList.Clear();

            foreach (var eventElement in list)
            {
                EventsList.Add(eventElement);
            }
        }
    }
}
