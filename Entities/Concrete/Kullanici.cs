using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Kullanici : IEntity
    {
        #region Field

        private int _id;

        private int _alanİd;

        private string _adi;

        private string _sifre;

        private bool _durum;

        #endregion

        #region Property

        public int Id { get => _id; set => _id = value; }

        public int Alanİd { get => _alanİd; set => _alanİd = value; }

        public string Adi { get => _adi; set => _adi = value; }

        public string Sifre { get => _sifre; set => _sifre = value; }

        public bool Durum { get => _durum; set => _durum = value; }

        #endregion
    }
}
