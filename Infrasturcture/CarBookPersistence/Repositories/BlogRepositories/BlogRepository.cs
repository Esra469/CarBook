using CarBook.Application.Interfaces.BlogInterfaces;
using CarBook.Domain.Entities;
using CarBookPersistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookPersistence.Repositories.BlogRepositories
{
    public class BlogRepository : IBlogRepositoory
    {

        private readonly CarBookContext _carBoookContext;

        public BlogRepository(CarBookContext carBoookContext)
        {
            _carBoookContext = carBoookContext;
        }

        public List<Blog> GetAllBlogWithAuthor()
        {
            var values = _carBoookContext.Blogs.Include(x => x.Author).ToList();
            return values;
        }

        public List<Blog> GetBlogByAuthorId(int id)
        {
            var values = _carBoookContext.Blogs.Include(x => x.Author).Where(y => y.BlogID == id).ToList();
            return values;
        }

        public List<Blog> GetLast3BlogsWithAuthors()
        {
            var values = _carBoookContext.Blogs.Include(x => x.Author).OrderByDescending(x=>x.BlogID).Take(3).ToList();
            return values;
        }
    }
}
