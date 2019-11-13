using System.Collections.Generic;
using BOL;

namespace BLL
{
    public interface IBlogBS
    {
        void Delete(int Id);
        List<Blog> GetALL();
        Blog GetByID(int Id);
        void Insert(Blog blog);
        void Update(Blog blog);
    }
}