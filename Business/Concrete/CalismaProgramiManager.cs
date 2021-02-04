using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CalismaProgramiManager : ICalismaProgramiService
    {


         private ICalismaProgramiDal _calismaProgramiDal;

        public CalismaProgramiManager(ICalismaProgramiDal calismaProgramiDal)
        {
            _calismaProgramiDal = calismaProgramiDal;
        }



        public void Add(CalismaProgrami Program)
        {
            /*
            if (_calismaProgramiDal.Get(o => o.Id == Program.Id) == null)
            {
                _calismaProgramiDal.Add(Program);
            }
            else
            {
                throw new Exception("bu Kayıt Zaten Var");
            }
            */

            _calismaProgramiDal.Add(Program);
        }

        public void Delete(CalismaProgrami Program)
        {
            _calismaProgramiDal.Delete(Program);
        }

        public List<CalismaProgrami> GetAll()
        {
          return  _calismaProgramiDal.GetList().ToList();
        }

        public List<CalismaProgrami> GetByLessonrId(int id)
        {
            return _calismaProgramiDal.GetList(o => o.DersId == id).ToList();
        }

        public CalismaProgrami GetByİd(int id)
        {
            return _calismaProgramiDal.Get(o => o.Id == id);
        }

        public CalismaProgrami GetUserControl()
        {
            CalismaProgrami calismaProgrami = new CalismaProgrami
            {
                
            };

            return calismaProgrami;
 //           _calismaProgramiDal.GetList(o => o.DersId == id).ToList();
            
        }

        public void Update(CalismaProgrami Program)
        {
            _calismaProgramiDal.Update(Program);
        }
    }
}
