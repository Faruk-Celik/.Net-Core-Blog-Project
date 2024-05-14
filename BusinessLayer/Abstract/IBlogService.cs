using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IBlogService
	{
		void TAddBlog ( Blog blog );
		void TUpdateBlog ( Blog blog );
		void TDeleteBlog ( Blog blog );
		Blog TGetById ( int id );
		List<Blog> TListAllBlog ();
		List <Blog> TGetListWithCategory ();
		
	
	}
}
