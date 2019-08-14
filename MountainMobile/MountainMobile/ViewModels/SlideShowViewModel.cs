using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using MvvmHelpers;
namespace MountainMobile.ViewModels
{
    public class SlideShowViewModel : BaseViewModel
    {
        public ObservableCollection<LocationModel> LocationPages { get; set; }
        private int currentIndex;

        public void MoveNext()
        {
            currentIndex = GetNextIndex();
            SetProperty(ref currentIndex, currentIndex);
        }

        public void MovePrevious()
        {
            currentIndex = GetPreviousIndex();
            SetProperty(ref currentIndex, currentIndex);
        }

        public LocationModel CurrentLocation
        {
            get
            {
                return LocationPages[currentIndex];
            }
        }

        public LocationModel NextLocation
        {
            get
            {
                return LocationPages[GetNextIndex()];
            }
        }

        public LocationModel PreviousLocation
        {
            get
            {
                return LocationPages[GetPreviousIndex()];
            }
        }

        private int GetNextIndex()
        {
            var nextIndex = currentIndex + 1;
            if (nextIndex > Location.LocationPages.Count - 1)
            {
                nextIndex = 0;
            }

            return nextIndex;
        }

        private int GetPreviousIndex()
        {
            var previousIndex = currentIndex - 1;
            if (previousIndex < 0)
            {
                previousIndex = Location.LocationPages.Count - 1;
            }

            return previousIndex;
        }


        public SlideShowViewModel()
        {
            LocationPages = new ObservableCollection<LocationModel>()
            {
                new LocationModel() {
                    Title ="Caribbean Cruise",
                    Description ="We don’t have proof, but evidence suggests that the Caribbean was made for cruising. This evidence is all around you — you’ll find in the Caribbean air, the sand and the water. And with more than 5,000 islands and cays spread across this amazing region, there’s a lot of paradise to see. So how do you choose where to visit on a Caribbean cruise? We recommend you just go and see for yourself! Best of all, the mild climate means it doesn’t even matter what time of year you go. A Carnival Caribbean cruise takes you to some of the coolest little hotspots… stretching across the world’s designated hotspot.",
                    ImageResource="MountainMobile.Images.Cruise.jpg"},

                 new LocationModel() {
                    Title ="Asheville, NC",
                    Description ="Quaint mountain town. Hipster haven. Beer City USA. Outdoorsman's retreat. College town. Bluegrass home. Culinary destination. Try as you might, it's impossible to give Asheville just one label. Located in western North Carolina just off the Blue Ridge Parkway, the city is an unexpected gem, where a vibrant arts scene intertwines with Southern traditions and beautiful scenery. It's safe to say, no matter what your interests, Asheville has something to offer you.",
                    ImageResource="MountainMobile.Images.Asheville.jpg"},

                 new LocationModel() {
                    Title ="Traverse City, MI",
                    Description ="Not too big. Not too small. Traverse City is a thriving yet relaxing vacation destination on Michigan’s Grand Traverse Bay that is just right , especially for active families in search of an unforgettable summertime retreat.",
                    ImageResource="MountainMobile.Images.TraverseCity.jpg"},

                 new LocationModel() {
                    Title ="St. Louis, MO",
                    Description ="There’s no longer a need to escape to the coast for a vacation rich in culture and experience. You can find all of that and more—at budget-friendly prices—right in the middle of the country in St. Louis. Thanks to the city’s low cost of living, tech startups and creative types are moving in, and St. Louis is doing an excellent job keeping up. With a vibrant food and drink scene and plenty of free activities, the Gateway to the West is the ideal destination for all kinds of travelers: families, couples, urban explorers, and more.",
                    ImageResource="MountainMobile.Images.StLouis.jpg"},

                 new LocationModel() {
                    Title ="Chicago, IL",
                    Description ="Chicago is a fantastic city for a long vacation. It’s an expansive urban setting, with many diverse neighborhoods that all have unique offerings in the way of sightseeing and attractions.",
                    ImageResource="MountainMobile.Images.Chicago.jpg"},

                 new LocationModel() {
                    Title ="Pigeon Forge, TN",
                    Description ="Pigeon Forge, Tennessee is a small town full of big surprises. From a 150-acre theme park to a 522,000-acre national park, this popular Smoky Mountain vacation destination is sure to delight the entire family.",
                    ImageResource="MountainMobile.Images.SmokyMountains.jpg"},

                 new LocationModel() {
                    Title ="South Haven, MI",
                    Description ="From the beautiful beaches along Lake Michigan to the eclectic eateries, award-winning wineries, quaint boutiques and the natural scenic surroundings - there's just something special about this place. South Haven and the surrounding West Michigan area offer much more than typical tourism, but a vacation getaway experience you'll never forget. ",
                    ImageResource="MountainMobile.Images.SouthHaven.jpg"},


            };
        }
    }

    public class LocationModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageResource { get; set; }
    }
}
