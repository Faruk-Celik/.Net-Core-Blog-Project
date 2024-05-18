using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IBlogService:IGenericService<Blog>
    {
		

		List<Blog> TListAllBlog ();
		List <Blog> TGetListWithCategory ();
		List<Blog> TGetBlogByWriter ( int id );


	}
}
