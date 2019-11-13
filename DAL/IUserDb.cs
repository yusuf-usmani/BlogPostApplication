using System.Collections.Generic;
using BOL;

namespace DAL
{
    public interface IUserDb
    {
        void Delete(int Id);
        IEnumerable<tbl_user> GetALL();
        tbl_user GetByID(int Id);
        void Insert(tbl_user user);
        void Save();
        void Update(tbl_user user);
    }
}