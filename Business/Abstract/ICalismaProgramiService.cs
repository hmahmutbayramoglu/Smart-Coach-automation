using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICalismaProgramiService 
    {

        List<CalismaProgrami> GetAll();

        CalismaProgrami GetByİd(int id);

        List<CalismaProgrami> GetByLessonrId(int id);

        void Add(CalismaProgrami Program);

        void Delete(CalismaProgrami Program);

        void Update(CalismaProgrami Program);

        CalismaProgrami GetUserControl(); 

    }
}
