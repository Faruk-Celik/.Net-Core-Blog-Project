using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface ICommentService
	{
		void TAddComment ( Comment comment );
		//void TDeleteComment ( Comment comment );
	//	void TUpdateComment ( Comment comment );
		//List<Comment> TGetListWithBlog ( int id );
		//Comment TGetById ( int id );
		List<Comment> TListAllComment (int id);
	}
}
