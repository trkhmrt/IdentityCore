using System;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
	public class CustomerAccountManager:ICustomerAccountService
	{
		private readonly ICustomerAccountDal customerAccountDal;

        public CustomerAccountManager(ICustomerAccountDal customerAccountDal)
        {
            this.customerAccountDal = customerAccountDal;
        }

        public void TDelete(CustomerAccount t)
        {
            customerAccountDal.Delete(t);
        }

        public CustomerAccount TGetByID(int id)
        {
            return customerAccountDal.GetByID(id);
        }

        public List<CustomerAccount> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInser(CustomerAccount t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(CustomerAccount t)
        {
            throw new NotImplementedException();
        }
    }
}

