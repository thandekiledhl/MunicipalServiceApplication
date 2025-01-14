using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

namespace MunicipalServiceApplication
{
    public partial class Local : Window
    {
        private EventManager eventManager;

        public Local()
        {
            InitializeComponent();
            eventManager = new EventManager();
            InitializeData();
        }

        private void InitializeData()
        {
            eventManager.AddEvent(new Event { Name = "Music Concert", Date = new DateTime(2024, 11, 5), Category = "Entertainment" });
            eventManager.AddEvent(new Event { Name = "Art Expo", Date = new DateTime(2024, 10, 20), Category = "Art" });
            eventManager.AddEvent(new Event { Name = "Charity Run", Date = new DateTime(2024, 10, 25), Category = "Fitness" });
            eventManager.AddEvent(new Event { Name = "Book Fair", Date = new DateTime(2024, 11, 1), Category = "Education" });

            eventManager.AddAnnouncement(new Announcement { Title = "City Council Meeting", Description = "Monthly meeting to discuss municipal plans.", Date = new DateTime(2024, 10, 22) });
            eventManager.AddAnnouncement(new Announcement { Title = "Water Supply Interruption", Description = "Scheduled maintenance, water will be unavailable from 8 AM to 3 PM.", Date = new DateTime(2024, 10, 23) });
            eventManager.AddAnnouncement(new Announcement { Title = "Park Renovation", Description = "Renovation work in Spruitview Park will begin on November 10.", Date = new DateTime(2024, 11, 10) });
            eventManager.AddAnnouncement(new Announcement { Title = "Holiday Closure", Description = "Municipal offices will be closed for the holidays from December 24 to December 26.", Date = new DateTime(2024, 12, 24) });

            foreach (var category in eventManager.GetUniqueCategories())
            {
                categoryComboBox.Items.Add(category);
            }

            // Display upcoming events
            DisplayEvents(eventManager.GetAllUpcomingEvents());

            // Display announcements
            DisplayAnnouncements(eventManager.GetAllAnnouncements());
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string selectedCategory = categoryComboBox.SelectedItem as string;
            DateTime? selectedDate = datePicker.SelectedDate;

            var filteredEvents = eventManager.SearchEvents(selectedCategory, selectedDate);
            DisplayEvents(filteredEvents);
        }

        private void DisplayEvents(List<Event> events)
        {
            eventsListView.ItemsSource = events;
        }

        private void DisplayAnnouncements(List<Announcement> announcements)
        {
            announcementsListView.ItemsSource = announcements;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow objMainWindow = new MainWindow();
            this.Visibility = Visibility.Hidden;
            objMainWindow.Show();
        }
    }

    public class Announcement
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }

    public class Event
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; }
    }

    public class EventManager
    {
        private SortedDictionary<DateTime, List<Event>> eventsByDate;
        private Dictionary<string, List<Event>> eventsByCategory;
        private List<Announcement> announcements;  // List to store announcements
        private Queue<Event> eventQueue;  // Queue for processing upcoming events
        private HashSet<string> uniqueCategories;  // Set to hold unique categories
        private HashSet<DateTime> uniqueDates;  // Set to hold unique dates
        private SortedDictionary<int, List<Event>> priorityQueue;  // Priority queue to handle high-priority events

        public EventManager()
        {
            eventsByDate = new SortedDictionary<DateTime, List<Event>>();
            eventsByCategory = new Dictionary<string, List<Event>>();
            announcements = new List<Announcement>();
            eventQueue = new Queue<Event>();
            uniqueCategories = new HashSet<string>();
            uniqueDates = new HashSet<DateTime>();
            priorityQueue = new SortedDictionary<int, List<Event>>();  // Priority - lower number = higher priority
        }

        public void AddEvent(Event newEvent, int priority = 0)
        {
            // SortedDictionary
            if (!eventsByDate.ContainsKey(newEvent.Date))
                eventsByDate[newEvent.Date] = new List<Event>();
            eventsByDate[newEvent.Date].Add(newEvent);

            // Dictionary
            if (!eventsByCategory.ContainsKey(newEvent.Category))
                eventsByCategory[newEvent.Category] = new List<Event>();
            eventsByCategory[newEvent.Category].Add(newEvent);

            // Add event to queue for upcoming processing
            eventQueue.Enqueue(newEvent);

            //Set
            uniqueCategories.Add(newEvent.Category);

            // Set
            uniqueDates.Add(newEvent.Date);

            // Add event to priority queue - SortedDictionary 
            if (!priorityQueue.ContainsKey(priority))
                priorityQueue[priority] = new List<Event>();
            priorityQueue[priority].Add(newEvent);
        }

        public void AddAnnouncement(Announcement newAnnouncement)
        {
            announcements.Add(newAnnouncement);
        }

        public List<Announcement> GetAllAnnouncements()
        {
            return announcements;
        }

        public List<Event> GetAllUpcomingEvents()
        {
            var upcomingEvents = new List<Event>();
            foreach (var eventsOnDate in eventsByDate)
            {
                upcomingEvents.AddRange(eventsOnDate.Value);
            }
            return upcomingEvents;
        }

        public List<Event> SearchEvents(string category, DateTime? date)
        {
            var filteredEvents = new List<Event>();

            if (!string.IsNullOrEmpty(category) && eventsByCategory.ContainsKey(category))
            {
                filteredEvents.AddRange(eventsByCategory[category]);
            }

            if (date.HasValue && eventsByDate.ContainsKey(date.Value))
            {
                filteredEvents = filteredEvents.FindAll(e => e.Date.Date == date.Value.Date);
            }

            return filteredEvents;
        }

        public List<string> GetUniqueCategories()
        {
            return uniqueCategories.ToList();
        }

        public List<DateTime> GetUniqueDates()
        {
            return uniqueDates.ToList();
        }

        // Processes events from the priority queue
        public List<Event> ProcessPriorityEvents()
        {
            var processedEvents = new List<Event>();
            foreach (var priorityLevel in priorityQueue.Keys)
            {
                processedEvents.AddRange(priorityQueue[priorityLevel]);
            }
            return processedEvents;
        }
    }

    public class CategoryColourConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string category = value as string;
            switch (category)
            {
                case "Entertainment":
                    return Brushes.LightBlue;
                case "Art":
                    return Brushes.LightCoral;
                case "Fitness":
                    return Brushes.LightGreen;
                case "Education":
                    return Brushes.LightGoldenrodYellow;
                default:
                    return Brushes.White;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
