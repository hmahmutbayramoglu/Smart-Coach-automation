using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IDersService
    {
        List<Ders> GetAll();

        List<Ders> GetById(int id);

        void Add(Ders ders);

        void Delete(Ders ders);

        void Update(Ders ders);
    }
}
