﻿using BOL;
using DAL;
using System.Collections.Generic;

namespace BLL
{
    /// <summary>
    /// User service layer
    /// </summary>
    public class UserBS : IUserBS
    {

        private IUserDb userDb;

        public UserBS(IUserDb _userDb)
        {
            userDb = _userDb;
        }

        public IEnumerable<tbl_user> GetALL()
        {
            return userDb.GetALL();
        }
        public tbl_user GetByID(int Id)
        {
            return userDb.GetByID(Id);
        }
        public void Insert(tbl_user user)
        {
            userDb.Insert(user);
        }
        public void Delete(int Id)
        {
            userDb.Delete(Id);
        }
        public void Update(tbl_user user)
        {
            userDb.Update(user);
        }
    }
}
