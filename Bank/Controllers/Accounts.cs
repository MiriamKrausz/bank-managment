using Bank.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bank.Controllers
{
    [Route("bank/[controller]")]
    [ApiController]
    public class Accounts : ControllerBase
    {

        private readonly List<Bank_Account> _dataContext_Accounts;
        public Accounts(DataContext dataContext)
        {
            _dataContext_Accounts = dataContext.Bank_AccountList;
        }


        // GET: api/<Accounts>
        [HttpGet]
        public IEnumerable<Bank_Account> Get()
        {
            return _dataContext_Accounts;
        }

        // GET api/<Accounts>/5
        [HttpGet("{AccountNumber}")]
        public Bank_Account Get(int AccountNumber)
        {
            return _dataContext_Accounts.Find(e => e.AccountNumber == AccountNumber);
        }

        // POST api/<Accounts>
        [HttpPost]
        public void Post([FromBody] Bank_Account new_account)
        {
            _dataContext_Accounts.Add(new_account);
        }

        // PUT api/<Accounts>/5
        [HttpPut("{accountNumber}")]
        public void Put(int accountNumber, [FromBody] Bank_Account account_for_update)
        {
            Bank_Account b_a = _dataContext_Accounts.Find(e => e.AccountNumber == accountNumber);
            if (b_a != null)
            {
                b_a.BankNumber = account_for_update.BankNumber;
                b_a.AccountNumber = account_for_update.AccountNumber;
                b_a.BranchNumber = account_for_update.BranchNumber;
                b_a.OwnersName = account_for_update.OwnersName;
                b_a.OwnersId = account_for_update.OwnersId;
            }
        }


        [HttpPut("{accountNumber,ownersName}")]
        public void Put(int accountNumber, string ownersName, [FromBody] Bank_Account account_for_update)
        {
            Bank_Account b_a = _dataContext_Accounts.Find(e => e.AccountNumber == accountNumber && e.OwnersName == ownersName);
            if (b_a != null)
            {
                b_a.OwnersName = account_for_update.OwnersName;
            }
        }

        // DELETE api/<Accounts>/5
        [HttpDelete("{accountNumber}")]
        public void Delete(int accountNumber)
        {
            Bank_Account b_a = _dataContext_Accounts.Find(e => e.AccountNumber == accountNumber);
            _dataContext_Accounts.Remove(b_a);
        }
    }
}
