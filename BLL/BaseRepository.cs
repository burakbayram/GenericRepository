using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BaseRepository<TEntity> where TEntity : class
    {
        OgrenciContext db;
        public BaseRepository(OgrenciContext db)
        {
            this.db = db;

        }
        public List<TEntity> HepsiniGetir()
        {
            return db.Set<TEntity>().ToList();
        }
        public bool Ekle(TEntity yeni)
        {
            db.Set<TEntity>().Add(yeni);
            int r = db.SaveChanges();
            return r > 0;

        }
        public TEntity GetById(int id)
        {
            return db.Set<TEntity>().Find(id);

        }

        public void Delete(int id)
        {
            var sil = GetById(id);
            db.Set<TEntity>().Remove(sil);
            db.SaveChanges();
        }
        public void Update(TEntity yeni)//Ikayit yeni)
        {
            Type t = typeof(TEntity);
            ///t.name classsın adının getiryor
            PropertyInfo p = t.GetProperty(t.Name + "Id");///kullnamıyoruz cunki interface ıhtıyacımız var
            //birinide egitmıd ,birnde ogrenci id oldugu içiçn ortak bi yazım olması gerekir
            int id = (int)p.GetValue(yeni);
            var eski = GetById(id);
            db.Entry(eski).CurrentValues.SetValues(yeni);///Enrty veritabanında kaydı buluyor
            db.SaveChanges();
        }
    }
}
