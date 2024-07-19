using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace caasWebApp
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        // Define your DbSets (tables) here
        public DbSet<Providers> Provider { get; set; }
        //public required  DbSet<Clients> Client { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Attachments> attachments { get; set; }
        public DbSet<Requests> Requests { get; set; }
        public DbSet<Bids> bid { get; set; }
    }

    public class Providers : BaseTable
    {

        public required string companyName { get; set; }
        public required string POCName { get; set; }
        public required string CRNumber { get; set; }


    }



    //public    class Clients : BaseTable
    //{



    ////    public required    string fullName { get; set; }






    //}

    public class Users : BaseTable
    {
        public required string UserName { get; set; }
        public required string Email { get; set; }
        public required string PhoneNumber { get; set; }

        public required string fullName { get; set; }
        public required string passwordHashed { get; set; }

        public required string UserType { get; set; }

    }

    public class Requests : BaseTable
    {
        public required long ClientID { get; set; }

        public required int RequestStatus { get; set; }

        public required string description { get; set; }
        public required string RequestName { get; set; }

    }


    public class Bids : BaseTable
    {
        public required long requestID { get; set; }
        public required long prices { get; set; } = 0;
        public required long BidStatus { get; set; }

        public required long ProviderID { get; set; }

    }

    public class Attachments
    {
        public required Guid Id { get; set; }
        public required string contentType { get; set; }
        public required string filename { get; set; }

        public required byte[] stream { get; set; }
    }

    public class BaseTable
    {
        public required int Id { get; set; }
        public required DateTime creationDate { get; set; }
        public required DateTime lastUpdateDate { get; set; }

        public required int recordStatus { get; set; }


    }
}
