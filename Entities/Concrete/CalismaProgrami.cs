using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class CalismaProgrami : IEntity
    {

        #region Field

        private int _id;

        private int _kullaniciİd;

        private int _dersİd;

        private int _günİd;

        private Int16 _soruSayisi;

        private Int16 _dogruSayisi;

        private Int16 _yanlisSayisi;

        private Int16 _bosSayisi;

        private DateTime _tarih;

        private bool _durum;

        #endregion

        #region Property

        public int Id { get => _id; set => _id = value; }

        public int KullaniciId { get => _kullaniciİd; set => _kullaniciİd = value; }

        public int DersId { get => _dersİd; set => _dersİd = value; }

        public int GunId { get => _günİd; set => _günİd = value; }

        public short SoruSayisi { get => _soruSayisi; set => _soruSayisi = value; }

        public short DogruSayisi { get => _dogruSayisi; set => _dogruSayisi = value; }

        public short YanlisSayisi { get => _yanlisSayisi; set => _yanlisSayisi = value; }

        public short BosSayisi { get => _bosSayisi; set => _bosSayisi = value; }

        public DateTime Tarih { get => _tarih; set => _tarih = value; }

        public bool Durum { get => _durum; set => _durum = value; }

        #endregion
    }
}
