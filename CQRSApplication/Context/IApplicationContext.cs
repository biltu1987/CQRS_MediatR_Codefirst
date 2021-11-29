using CQRSApplication.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace CQRSApplication.Context
{
    public interface IApplicationContext
    {
        DbSet<Product> Products { get; set; }

        Task<int> SaveChanges();
    }
}