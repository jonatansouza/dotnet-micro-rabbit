﻿using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Application.Services {
    public class AccountService : IAccountService {
        private readonly IAccountRepository _respository;

        public AccountService(IAccountRepository respository) {
            _respository = respository;
        }
        public IEnumerable<Account> GetAccounts() {
            return _respository.GetAccounts();
        }
    }
}
