using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        
        ICategoryDal _categoryDal;

        public CategoryManager ( ICategoryDal categoryDal )
        {
            _categoryDal = categoryDal;
        }

        public void TAddCategory ( Category category )
        {
            _categoryDal.Insert(category);
                
        }

        public void TDeleteCategory ( Category category )
        {
            _categoryDal.Delete(category);
        }

        public Category TGetById ( int id )
        {
           return _categoryDal.GetById(id);
            
        }

        public List<Category> TListAllCategory ()
        {
            return _categoryDal.GetListAll();
        }

        public void TUpdateCategory ( Category category )
        {
          _categoryDal.Update(category);
        }
    }
}
