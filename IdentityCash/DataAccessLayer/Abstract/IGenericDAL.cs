﻿using System;
namespace DataAccessLayer.Abstract
{
	public interface IGenericDAL<T> where T: class 
	{
		void Inser(T t);

		void Delete(T t);

		void Update(T t);

		T GetByID(int id);

		List<T> GetList();

	}
}

