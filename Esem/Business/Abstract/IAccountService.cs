﻿using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAccountService
    {
        Account Get(string username);
        List<Account> GetAccountsWithoutMe(int accountId);
    }
}
