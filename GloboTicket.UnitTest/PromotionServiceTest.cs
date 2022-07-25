//using GloboTicket.Domain;
//using GloboTicket.Domain.Entities;
//using GloboTicket.Domain.Services;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Threading.Tasks;
//using Xunit;

//namespace GloboTicket.UnitTest
//{
//    public class PromotionServiceTest
//    {
//        private readonly PromotionService _promotionService;

//        public PromotionServiceTest()
//        {
//            var options = new DbContextOptionsBuilder<GloboTicketContext>()
//                .UseInMemoryDatabase(Guid.NewGuid().ToString())
//                .Options;
//            var context = new GloboTicketContext(options);
//            _promotionService = new(context);
//        }

//        [Fact]
//        public async Task CanBookAShowAsync()
//        {
//            Venue venue = await GivenVenue();
//            Act act = await GivenAct();
//            DateTimeOffset date = DateTimeOffset.Parse("2022-07-27Z");

//            Show show = await WhenBookShow(venue, act, date);

//            show.Venue.Name.Should().Be(venue.Name);
//            show.Act.Name.Should().Be(act.Name);
//        }
//    }
//}