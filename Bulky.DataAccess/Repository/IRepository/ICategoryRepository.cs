﻿using System;
using Bulky.Models;
using BulkyWeb.Models;

namespace Bulky.DataAccess.Repository.IRepository
{
	public interface ICategoryRepository : IRepository<Category>
	{
		void Update(Category obj);
		void Save();
	}
}

