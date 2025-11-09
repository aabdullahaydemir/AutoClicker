using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.BookingDto;
using SignalRApi.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var values = _bookingService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateBooking(CreateBookingDto createBookingDto)
        {
            Booking booking = new Booking()
            {
                Mail = createBookingDto.Mail,
                Date = createBookingDto.Date,
                Name = createBookingDto.Name,
                PersonCount = createBookingDto.PersonCount,
                Phone = createBookingDto.Phone,

            };
            _bookingService.TAdd(booking);
            return Ok("Rezarvasyon Yapıldı");
        }
        [HttpDelete]
        public IActionResult DeleteBooking(int id)
        {
            var value = _bookingService.TGEtByID(id);
            _bookingService.TDelete(value);
            return Ok("Rezarvasyon Silindi");
        }
        [HttpPut]
        public IActionResult UpdateBooking(UpdateBookingDto updateBookingDto)
        {
            Booking booking = new Booking()
            {
                Mail = updateBookingDto.Mail,
                BookingID = updateBookingDto.BookingID,
                Name = updateBookingDto.Name,
                PersonCount = updateBookingDto.PersonCount,
                Phone = updateBookingDto.Phone,
                Date = updateBookingDto.Date
            };
            _bookingService.TUpdate(booking);
            return Ok("Rezarvasyon Güncellendi");
        }

        [HttpGet("GetBooking")]
        public IActionResult GetBooking(int id)
        {
            var value = _bookingService.TGEtByID(id);
            return Ok(value);
        }
    }
    
    
    
} 

   

