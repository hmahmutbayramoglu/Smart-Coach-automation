using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Ders : IEntity
    {
        #region Field

        private int _id;

        private string _alanİd;

        private string _adi;

        #endregion

        #region Property

        public int Id { get => _id; set => _id = value; }

        public string Alanİd { get => _alanİd; set => _alanİd = value; }

        public string Adi { get => _adi; set => _adi = value; }

        #endregion
    }
}
