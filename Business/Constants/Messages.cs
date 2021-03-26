using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi!";
        public static string ProductDeleted = "Ürün Silindi!";
        public static string ProductUpdated = "Ürün Güncellendi!";
        public static string CategoryAdded = "Kategori Eklendi!";
        public static string CategoryDeleted = "Kategori Silindi!";
        public static string CategoryUpdated = "Kategori Güncellendi!";
        public static string UserNotFound = "Kullanıcı Bulunamadı!";
        public static string PasswordError = "Parola Hatalı!";
        public static string SuccessfulLogin = "Giriş Başarılı!";
        public static string UserAlreadyExists = "Bu Kullanıc Zaten Mevcut";
        public static string UserRegistered = "Kullanıcı Kaydedildi!";
        public static string AccessTokenCreated = "Access Token Üretildi!";
    }
}
