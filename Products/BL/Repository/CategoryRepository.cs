﻿using AutoMapper;
using Products.BL.Models;
using Products.EDM;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Products.BL.Repository
{
    public class CategoryRepository : Repository<Category>
    {
        #region Constructors

        public CategoryRepository(ProductsEntities context) : base(context)
        {
        }

        #endregion

        #region Methods

        public bool IsExisting(string name)
        {
            return GetAll(c => c.Name == name).Any();
        }

        public int Add(string name)
        {
            if (IsExisting(name))
            {
                throw new ArgumentException("هذا الصنف موجود");
            }
            var added = Insert(new Category { Name = name });
            Complete();
            return added.Id;
        }

        public void Edit(int id, string value)
        {
            var category = Get(id);
            category.Name = value;
        }

        public IEnumerable<CategoryModel> GetCategoriesForCombo()
        {
            return Mapper.Map<IEnumerable<Category>, IEnumerable<CategoryModel>>(GetAll());
        }

        public IEnumerable<CategoryModel> GetCategoriesForGrid()
        {
            return Mapper.Map<IEnumerable<Category>, IEnumerable<CategoryModel>>(GetAll());
        }

        #endregion
    }
}
