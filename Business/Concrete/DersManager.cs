using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class DersManager : IDersService
    {

        private IDersDal _dersDal;

        public DersManager(IDersDal dersDal)
        {
            _dersDal = dersDal;
        }

        public void Add(Ders ders)
        {
            if (_dersDal.Get(o => o.Adi == ders.Adi) == null)
                _dersDal.Add(ders);
            else
                throw new Exception("Bu Ders Zaten Kayıtlı !");

        }

        public void Delete(Ders ders)
        {
            _dersDal.Delete(ders);
        }

        public List<Ders> GetAll()
        {
           return _dersDal.GetList().ToList();
        }

        public List<Ders> GetById(int id)
        {
            return _dersDal.GetList(o => o.Id == id).ToList();
        }

        public void Update(Ders ders)
        {
            _dersDal.Update(ders);

        }
    }
}
