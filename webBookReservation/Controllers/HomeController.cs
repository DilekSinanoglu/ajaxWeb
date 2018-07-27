using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace webBookReservation.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //Student student = new Student() { Id = 1, Name = "Dilek", SName = "Sinanoğlu", Grade = "3" };
        // Book book = new Book() { ISBN = 123456789, Title = "Bin Muhteşem Güneş", Detail = "En çok satanlar listesinde 20. sırada" };


        static List<Reservation> reservationList;

        static HomeController()
        {
            reservationList = new List<Reservation>();
            Reservation reservation = new Reservation()
            {
                Id = 1,
                Doyoureserve = true,
                Book = new Book() { ISBN = 123456789, Title = "Bin Muhteşem Güneş", Detail = "En çok satanlar listesinde 20. sırada" },
                Student = new Student() { Id = 1, Name = "Dilek", SName = "Sinanoğlu", Grade = "3" },
                Date = DateTime.Now.Year
            };


            Reservation reservation2 = new Reservation()
            {
                Id = 2,
                Doyoureserve = true,
                Book = new Book() { ISBN = 698523642, Title = "Uçurtma Avcısı", Detail = "En çok satanlar listesinde 10. sırada" },
                Student = new Student() { Id = 2, Name = "Melek", SName = "Gün", Grade = "2" },
                Date = DateTime.Now.Year
            };
            reservationList.Add(reservation);
            reservationList.Add(reservation2);
        }

        public ActionResult Index()
        {
           
            //View mwtodunun parametrelerin arasına bir değişken vermek 
            //o değişkenni model yöntemi ile viewa gönder demektir.
            return View(reservationList);
        }

        [HttpPost]//parametre gönderdiğimiz için bu atributeyi yazdık.Ajaxın kuralı
        public void Delete(int id)
        {
            Reservation reserv = reservationList.FirstOrDefault(x => x.Id == id);
            reservationList.Remove(reserv);    
        }
    }
}