using BusinessLayer.Abstract;
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
        private readonly EfCategoryRepository _efCategoryRepository;

        public CategoryManager ( EfCategoryRepository efCategoryRepository )
        {
            _efCategoryRepository = efCategoryRepository;
        }
    

        public void TAddCategory ( Category category )
        {
            _efCategoryRepository.Insert(category);
                
        }

        public void TDeleteCategory ( Category category )
        {
            _efCategoryRepository.Delete(category);
        }

        public Category TGetById ( int id )
        {
           return _efCategoryRepository.GetById(id);
            
        }

        public List<Category> TListAllCategory ()
        {
            return _efCategoryRepository.GetListAll();
        }

        public void TUpdateCategory ( Category category )
        {
          _efCategoryRepository.Update(category);
        }
    }
}
