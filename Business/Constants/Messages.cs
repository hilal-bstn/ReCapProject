﻿using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
   public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarDeleted = "Araba silindi";
        public static string CarUpdated = "Araba güncellendi";
        public static string CarsDetailListed = "Arabaların detayları listelendi";
        public static string CarNameInvalid = "Araba ismi geçersiz";
        public static string CarsListed = "Arabalar listelendi";
        public static string CarDailyPriceInvalid="Günlük fiyat sıfırdan yüksek olmalı!!";
        public static string BrandAdded = "Marka eklendi";
        public static string BrandsListed = "Markalar listelendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandNameInvalid = "Marka ismi geçersiz";
        public static string ColorUpdated = "Renk güncellendi";
        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorsListed = "Renkler listelendi";
        public static string UserAdded = "Kullanıcı Eklendi";
        public static string UserDeleted = "Kullanıcı Silindi";
        public static string UserUpdated="Kullanıcı bilgileri güncellendi";
        public static string CustomerAdded="Eklendi";
        public static string RentalError="Araç henüz teslim edilmemiş. Aracı kiralayamazsınız.";
        public static string BrandUpdated="Marka güncellendi";
        public static string RentalUpdated="Bilgiler güncellendi";
        public static string AuthorizationDenied = "yetkiniz yok";
        public static string RegisterSuccess="Kullanıcı kaydı başarıyla tamamlanmıştır.";
        public static string UserAvailable="Girdiğiniz Email adresi daha önceden kullanılmıştır.";
        public static string SuccessLogin="Giriş başarılı. Hoşgeldiniz..";
        public static string ErrorPassword="Hatalı şifre girişi.";
        public static string UserNotFound="Girdiğiniz email adresine kayıtlı bir kullanıcı bulunamamıştır!!";
        public static string TokenCreated="Token oluşturulmuştur.";
        public static string Successupdated="Başarıyla güncellenmiştir.";
        public static string CarImageDeleted="Resim silinmiştir.";
        public static string CarImageAdded="Resim sisteme eklenmiştir.";
        public static string LimitError= "Bir araç için 5 adet resim yüklenebilmektedir";
        public static string CustomersListed="Müşteriler Listelendi";
        public static string RentalDetailsListed="Araç Kiralamaları Listelendi";
        public static string CustomerFindeksScoreAdded="Findeks Puanı Eklendi";
        public static string CustomerFindeksScoreUpdated="Findeks Puanı Güncellendi";
        public static string PasswordUpdate="Şifreniz Güncellendi..";
        public static string OldPasswordWrong="Eski şifrenizi yanlış girdiniz.";
        public static string CarRegistrationNotFound = "Araç kaydı bulunamadı..";
        public static string CarRented="Araç kiralandı.";
        public static string InvalidDates= "Araç girdiğiniz tarihlerde uygun değil.";
        public static string CredidCardAdd="Kart bilgileriniz kayıt edildi.";
    }
}
