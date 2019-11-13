using System.Collections.Generic;
using BOL;

namespace DAL
{
    public interface IBlogsDb
    {
        void Delete(int Id);
        List<Blog> GetALL();
        Blog GetByID(int Id);
        void Insert(Blog blog);
        void Save();
        void Update(Blog blog);
    }
}