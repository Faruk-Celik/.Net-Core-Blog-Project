using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        void TAddCategory ( Category category );
        void TUpdateCategory ( Category category );
        void TDeleteCategory ( Category category );
        Category TGetById ( int id );
        List<Category> TListAllCategory ();

    }
}
