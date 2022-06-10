USE [OBS]
/*Öðrencileri bölümlerine göre grupla ve sayýlarýný listele*/
CREATE PROC sp_ogrenci_bolum_grupla
AS
BEGIN
SELECT b.bolum_adi, COUNT(b.bolum_id) AS "Öðrenci Sayýsý"  
FROM Bolumler b, Ogrenciler o
WHERE b.bolum_id=o.bolum_id
GROUP BY bolum_adi 
END

EXEC sp_ogrenci_bolum_grupla

/*Bölümü "BÖTE" olan öðrencileri listele*/
CREATE PROC sp_ogrenci_bolum_bote
AS
BEGIN
SELECT bolum_adi,ogrenci_no,ogrenci_adi,ogrenci_soyadi
FROM Bolumler b inner join Ogrenciler o on b.bolum_id=o.bolum_id
WHERE o.bolum_id=1
END
EXEC sp_ogrenci_bolum_bote

/*"Programlama Dilleri 1" dersini veren öðretmenin bilgileri*/
CREATE PROC sp_ogretmen_ders
AS
BEGIN
SELECT ders_adi,ogretmen_adi,ogretmen_soyadi,ogretmen_brans
FROM Dersler d inner join Ogretmenler o on d.ogretmen_id=o.ogretmen_id
WHERE d.ders_id=2
END
EXEC sp_ogretmen_ders

/*Branþý "Bilgisayar" olan öðretmenlerin verdiði dersleri listele*/
CREATE PROC sp_ogretmen_brans
AS
BEGIN
SELECT ders_adi,ogretmen_adi,ogretmen_soyadi,ogretmen_brans
FROM Dersler d inner join Ogretmenler o on d.ogretmen_id=o.ogretmen_id
WHERE o.ogretmen_brans='Bilgisayar'
END
EXEC sp_ogretmen_brans

/*Branþý "Matematik" olan öðretmenleri listele*/
CREATE PROC sp_ogretmen_brans_matematik
AS
BEGIN
SELECT ogretmen_adi,ogretmen_soyadi,ogretmen_brans
FROM Ogretmenler
WHERE ogretmen_brans='Matematik'
END
EXEC sp_ogretmen_brans_matematik

/*Öðrenci sayýsý 30'un altýnda olan bölümleri listele*/
CREATE PROC sp_ogrenci_sayisi_bolum
AS
BEGIN
SELECT bolum_adi,ogrencisayisi
FROM Bolumler
WHERE ogrencisayisi<30
END
EXEC sp_ogrenci_sayisi_bolum

/*Durumu "kaldý" olan öðrencilerin bölüm,ders ve not bilgilerini listele*/
CREATE PROC sp_ogrenci_durum_kaldi
AS
BEGIN
SELECT ogrenci_adi,ogrenci_soyadi,bolum_adi,ders_adi,vize,final,ortalama,durum
FROM Ogrenciler o inner join Bolumler b on o.bolum_id=b.bolum_id
inner join Notlar n on o.ogrenci_no=n.ogrenci_no
inner join Dersler d on d.ders_id=n.ders_id
WHERE durum='kaldý'
END
EXEC sp_ogrenci_durum_kaldi

/*"Ayþe Çetin" adlý öðrencinin bölüm,ders ve not bilgilerini listele*/
CREATE PROC sp_ogrenci_bolum_ders_not
AS
BEGIN
SELECT ogrenci_adi,ogrenci_soyadi,bolum_adi,ders_adi,vize,final,ortalama,durum
FROM Ogrenciler o inner join Bolumler b on o.bolum_id=b.bolum_id
inner join Notlar n on o.ogrenci_no=n.ogrenci_no
inner join Dersler d on d.ders_id=n.ders_id
WHERE o.ogrenci_no=2
END
EXEC sp_ogrenci_bolum_ders_not

/*Ortalamasý 65'in altýnda olan öðrencilerin ders,bölüm ve not bilgilerini listele*/
CREATE PROC sp_ogrenci_ortalama
AS
BEGIN
SELECT ogrenci_adi,ogrenci_soyadi,bolum_adi,ders_adi,vize,final,ortalama,durum
FROM Ogrenciler o inner join Bolumler b on o.bolum_id=b.bolum_id
inner join Notlar n on o.ogrenci_no=n.ogrenci_no
inner join Dersler d on d.ders_id=n.ders_id
WHERE ortalama<65
END
EXEC sp_ogrenci_ortalama

/*Dersin vize sýnavýna girip final sýnavýna girmeyen öðrencilerin bölüm, ders ve not bilgileri*/
CREATE PROC sp_vize_final
AS
BEGIN
SELECT ogrenci_adi,ogrenci_soyadi,bolum_adi,ders_adi,vize,final,ortalama,durum
FROM Ogrenciler o inner join Bolumler b on o.bolum_id=b.bolum_id
inner join Notlar n on o.ogrenci_no=n.ogrenci_no
inner join Dersler d on d.ders_id=n.ders_id
WHERE vize is not null and final=0
END
EXEC sp_vize_final