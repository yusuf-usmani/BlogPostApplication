using System.Collections.Generic;
using BOL;

namespace BLL
{
    public interface IUserBS
    {
        void Delete(int Id);
        IEnumerable<tbl_user> GetALL();
        tbl_user GetByID(int Id);
        void Insert(tbl_user user);
        void Update(tbl_user user);
    }
}