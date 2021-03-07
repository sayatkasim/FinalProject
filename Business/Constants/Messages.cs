using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductListed = "Ürünler Listelendi";
        public static string UnitPriceInvalid = "Ürün fiyatı 0'dan yüksek olmalı";
        public static string ProductCountOfCategoryError = "Kategori dolu";
        public static string ProductNameAlreadyExists = "Aynı adda ürün mevcut";
        public static string CategoryFull = "Kategori limiti doldu";
        public static string AuthorizationDenied = "Bu işlemi yapmak için yetkiniz bulunmamaktadır";
        public static string UserRegistered = "Kayıt olundu";
        public static string UserNotFound = "Kullanıcı bulunmadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Giriş Başarılı";
        public static string UserAlreadyExists = "Bu Kullanıcı Kayıtlı";
        public static string AccessTokenCreated = "Token Oluşturuldu";
    }
}
