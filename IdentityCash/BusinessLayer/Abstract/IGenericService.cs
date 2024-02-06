﻿using System;
namespace BusinessLayer.Abstract
{
	public interface IGenericService<T> where T : class
	{
        void TInser(T t);

        void TDelete(T t);

        void TUpdate(T t);

        T TGetByID(int id);

        List<T> TGetList();
    }
}

