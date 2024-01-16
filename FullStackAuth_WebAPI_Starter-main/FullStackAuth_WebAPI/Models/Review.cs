using System;


namespace FullStackAuth_WebAPI.Models
{
    public class Review
    {


        public int Id { get; set; }
        public string BookId { get; set; }
        public string ReviewBody { get; set; }
        public double Rating { get; set; }

        

        public string UserId { get; set; }
        public User User { get; set; }



        







    }




}


