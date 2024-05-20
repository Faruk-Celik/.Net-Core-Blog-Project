
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager ( IBlogDal blogDal )
        {
            _blogDal = blogDal;
        }
        public List<Blog> TGetListWithCategory ()
        {
            return _blogDal.GetListWithCategory();
        }
        public List<Blog> TGetListWithCategoryByWriter ( int id )
        {
            return _blogDal.GetListWithCategoryByWriter(id);
        }


        public List<Blog> TListAllBlog ()
        {
            return _blogDal.GetListAll();
        }

        public List<Blog> TLast3BlogPost ()
        {
            return _blogDal.GetListAll().TakeLast(3).ToList();
        }


        public List<Blog> TGetBlogById ( int id )
        {
            return _blogDal.GetListAll(x => x.BlogID == id);
        }

        public List<Blog> TGetBlogByWriter ( int id )
        {
            return _blogDal.GetListAll(x => x.WriterID == id);


        }

        public void TAdd ( Blog t )
        {
            _blogDal.Insert(t);
        }

        public void TUpdate ( Blog t )
        {
            _blogDal.Update(t); 
        }

        public void TDelete ( Blog t )
        {
            _blogDal.Delete(t);
        }

        public List<Blog> TGetList ()
        {
            return _blogDal.GetListAll();
        }

        public Blog TGetById ( int id )
        {
            return _blogDal.GetById(id);
        }
    }
}
