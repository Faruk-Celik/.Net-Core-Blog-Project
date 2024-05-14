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

		public void TAddBlog ( Blog blog )
		{
			throw new NotImplementedException();
		}

		public void TDeleteBlog ( Blog blog )
		{
			throw new NotImplementedException();
		}

		public List<Blog> TGetListWithCategory ()
		{
			return _blogDal.GetListWithCategory();
		}

		public Blog TGetById ( int id )
		{
			throw new NotImplementedException();
		}

		public List<Blog> TListAllBlog ()
		{
			return _blogDal.GetListAll();
		}

		public void TUpdateBlog ( Blog blog )
		{
			throw new NotImplementedException();
		}

		public List<Blog> TGetBlogById ( int id )
		{
			return _blogDal.GetListAll(x => x.BlogID == id);
		}
	}
}
