using BOL;
using DAL;
using System.Collections.Generic;

namespace BLL
{
    /// <summary>
    /// Blog service layer
    /// </summary>
    public class BlogBS : IBlogBS
    {
        private IBlogsDb blogDb;

        public BlogBS(IBlogsDb _blogDb)
        {
            blogDb = _blogDb;
        }

        public List<Blog> GetALL()
        {
            return blogDb.GetALL();
        }
        public Blog GetByID(int Id)
        {
            return blogDb.GetByID(Id);
        }
        public void Insert(Blog blog)
        {
            blogDb.Insert(blog);
        }
        public void Delete(int Id)
        {
            blogDb.Delete(Id);
        }
        public void Update(Blog blog)
        {
            blogDb.Update(blog);
        }
    }
}
