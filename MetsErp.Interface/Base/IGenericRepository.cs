using System.Linq;
using System.Linq.Expressions;

namespace Scrumler.Interface.Base
{
    /// <summary>
    /// Bu interface bizim için oluşturacağımız GenericRepository'nin neleri içermesi gerektiğini belirtiyor.
    /// EntityBase den kalıtım almış bir sınıfı buraya vermemiz gerekiyor.
    /// </summary>
    /// <typeparam name="T">where diyerek T nin EntityBase den türemiş bir sınıf olması gerektiği kısıtını koda ekliyoruz</typeparam>
    public interface IGenericRepository<T> where T : IEntityBase
    {
        /// <summary>
        /// Geriye içinde linq ile arama yapılabilecek bir queryable döndürür
        /// </summary>
        /// <returns></returns>
        IQueryable<T> GetAll(Expression<System.Func<T, object>> includePart = null, Expression<System.Func<T, bool>> wherePart = null);

        IQueryable<TResult> GetWithSelect<TResult>(Expression<System.Func<T, TResult>> selectPart, Expression<System.Func<T, object>> includePart = null, Expression<System.Func<T, bool>> wherePart = null);

        /// <summary>
        /// Bu method kendisine verilecek Guid valueType'ına sahip Id değişkeni ile sorgulama yapacak ve geriye interface e verilen tipte dönüş yapacak
        /// </summary>
        /// <param name="Id">Aranan kaydın Guid tipinde Id bilgisi</param>
        /// <returns></returns>
        T Find(int Id);

        /// <summary>
        /// Kendisine gönderilen tipteki sınıfı veritabanına eklemek için kullanılacak
        /// </summary>
        /// <param name="entity">Hangi sınıf eklenecek ise onun bir örneği verilmeli</param>
        T Add(T entity);

        /// <summary>
        /// Kendisine gönderilen tipteki sınıfı veritabanında güncellemek için kullanılacak
        /// </summary>
        /// <param name="entityToUpdate">Güncellenmesi istenen sınıfın bir örneği gönderilmeli</param>
        T Update(T entityToUpdate);

        /// <summary>
        /// Kendisine gelen Guid ValueType'ına sahip Id bilgisi ile veritabanında silme işlemi yapacak
        /// </summary>
        /// <param name="Id">Silinmesi istenen kaydın Guid tipinde Id bilgisi</param>
        void Delete(int Id);

        /// <summary>
        /// Kendisine gelen sınıf ile veritabanında silme işlemi yapacak
        /// </summary>
        /// <param name="entityToDelete">Silinmesi istenen kayda ait sınıfın örneği</param>
        void Delete(T entityToDelete);
    }
}