using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace VeriErisimKatmani
{
    public class VeriModeli
    {
        SqlConnection baglanti; SqlCommand komut;

        public VeriModeli()
        {
            baglanti = new SqlConnection(BaglantiYollari.baglantiyolu);
            komut = baglanti.CreateCommand();
        }

        #region Yönetici Metotları

        public Yonetici YoneticiGiris(string eposta, string sifre)
        {
            try
            {
                komut.CommandText = "SELECT COUNT(*) FROM Yoneticiler WHERE Eposta  = @eposta  AND Sifre = @sifre";
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@eposta", eposta);
                komut.Parameters.AddWithValue("@sifre", sifre);
                baglanti.Open();

                int sayi = Convert.ToInt32(komut.ExecuteScalar());
                if (sayi == 1)
                {
                    komut.CommandText = "SELECT Y.ID, Y.YoneticiTurID, YT.Isim, Y.Isim, Y.Soyisim, Y.KullaniciAdi, Y.Eposta, Y.Sifre, Y.Durum, Y.Silinmis FROM Yoneticiler AS Y JOIN YoneticiTurleri AS YT ON Y.YoneticiTurID = YT.ID WHERE Y.Eposta = @eposta AND Y.Sifre = @sifre";
                    komut.Parameters.Clear();
                    komut.Parameters.AddWithValue("@eposta", eposta);
                    komut.Parameters.AddWithValue("@sifre", sifre);
                    SqlDataReader okuyucu = komut.ExecuteReader();
                    Yonetici y = new Yonetici();
                    while (okuyucu.Read())
                    {
                        y.ID = okuyucu.GetInt32(0);
                        y.YoneticiTurID = okuyucu.GetInt32(1);
                        y.YoneticiTur = okuyucu.GetString(2);
                        y.Isim = okuyucu.GetString(3);
                        y.Soyisim = okuyucu.GetString(4);
                        y.KullaniciAdi = okuyucu.GetString(5);
                        y.Eposta = okuyucu.GetString(6);
                        y.Sifre = okuyucu.GetString(7);
                        y.Durum = okuyucu.GetBoolean(8);
                        y.Silinmis = okuyucu.GetBoolean(9);
                    }
                    return y;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
            finally
            {
                baglanti.Close();
            }
        }

        #endregion

        #region Üye Giriş

        public bool UyeKayit(Uyeler u)
        {
            try
            {
                komut.CommandText = "INSERT INTO Uyeler(Isim,Soyisim,KullaniciAdi,Eposta,Sifre,Silinmis) VALUES (@isim,@soyisim,@kullaniciadi,@eposta,@sifre,@silinmis)";
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@isim", u.Isim);
                komut.Parameters.AddWithValue("@soyisim", u.Soyisim);
                komut.Parameters.AddWithValue("@kullaniciadi", u.KullaniciAdi);
                komut.Parameters.AddWithValue("@eposta", u.Eposta);
                komut.Parameters.AddWithValue("@sifre", u.Sifre);
                komut.Parameters.AddWithValue("@silinmis", false);
                baglanti.Open();
                komut.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                baglanti.Close();
            }
        }

        #endregion

        #region Kullanıcılar Metotları

        public List<Uyeler> KullaniciListe()
        {
            List<Uyeler> listeleme = new List<Uyeler>();

            try
            {
                komut.CommandText = "SELECT UyeID, Isim, Soyisim ,Eposta, Silinmis FROM Uyeler ";
                komut.Parameters.Clear();
                baglanti.Open();
                SqlDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    Uyeler kullanici = new Uyeler();
                    kullanici.UyeID = reader.GetInt32(0);
                    kullanici.Isim = reader.GetString(1);
                    kullanici.Soyisim = reader.GetString(2);
                    kullanici.Eposta = reader.GetString(3);
                    kullanici.Silinmis = reader.GetBoolean(4);
                    listeleme.Add(kullanici);
                }
                return listeleme;
            }
            catch
            {
                return null;
            }
            finally
            {
                baglanti.Close();
            }
        }

        public List<Uyeler> KullaniciListe(bool silinmis)
        {
            List<Uyeler> listeleme = new List<Uyeler>();

            try
            {
                komut.CommandText = "SELECT UyeID, Isim, Soyisim ,Eposta, Silinmis FROM Uyeler WHERE Silinmis=@silinmis";
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@silinmis", silinmis);
                baglanti.Open();
                SqlDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    Uyeler kullanici = new Uyeler();
                    kullanici.UyeID = reader.GetInt32(0);
                    kullanici.Isim = reader.GetString(1);
                    kullanici.Soyisim = reader.GetString(2);
                    kullanici.Eposta = reader.GetString(3);
                    kullanici.Silinmis = reader.GetBoolean(4);
                    listeleme.Add(kullanici);
                }
                return listeleme;
            }
            catch
            {
                return null;
            }
            finally
            {
                baglanti.Close();
            }
        }

        public void KullaniciSilHardDelete(int id)
        {
            try
            {
                komut.CommandText = "DELETE FROM Uyeler WHERE ID=@id";
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@id", id);
                baglanti.Open();
                komut.ExecuteNonQuery();
            }
            finally
            {
                baglanti.Close();
            }
        }

        public Uyeler UyeGetir(int id)
        {
            try
            {
                komut.CommandText = "SELECT UyeID,Isim,Soyisim,Eposta,Silinmis FROM Uyeler WHERE ID=@id";
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@id", id);
                baglanti.Open();
                SqlDataReader okuyucu = komut.ExecuteReader();
                Uyeler u = new Uyeler();
                while (okuyucu.Read())
                {
                    u.UyeID = okuyucu.GetInt32(0);
                    u.Isim = okuyucu.GetString(1);
                    u.Soyisim = okuyucu.GetString(2);
                    u.Eposta = okuyucu.GetString(3);
                    u.Silinmis = okuyucu.GetBoolean(4);
                }
                return u;
            }
            catch
            {
                return null;
            }
            finally
            {
                baglanti.Close();
            }
        }


        #endregion

        #region  Kategori Metotlar

        public bool KategoriEkle(Kategori ka)
        {
            try
            {
                komut.CommandText = "INSERT INTO Kategoriler (Isim,Aciklama,Durum,Silinmis) VALUES (@isim,@aciklama,@durum,@silinmis)";
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@isim", ka.Isim);
                komut.Parameters.AddWithValue("@aciklama", ka.Aciklama);
                komut.Parameters.AddWithValue("@durum", ka.Durum);
                komut.Parameters.AddWithValue("@silinmis", false);
                baglanti.Open();
                komut.ExecuteNonQuery();
                return true;


            }
            catch
            {
                return false;
            }
            finally
            {
                baglanti.Close();
            }
        }

        public List<Kategori> KategoriListeleme()
        {
            List<Kategori> listeleme = new List<Kategori>();

            try
            {
                komut.CommandText = "SELECT ID, Isim, Aciklama, Durum, Silinmis FROM Kategoriler ";
                komut.Parameters.Clear();
                baglanti.Open();
                SqlDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    Kategori ka = new Kategori();
                    ka.ID = reader.GetInt32(0);
                    ka.Isim = reader.GetString(1);
                    ka.Aciklama = reader.GetString(2);
                    ka.Durum = reader.GetBoolean(3);
                    ka.Silinmis = reader.GetBoolean(4);
                    listeleme.Add(ka);
                }
                return listeleme;
            }
            catch
            {
                return null;
            }
            finally
            {
                baglanti.Close();
            }

        }
        public List<Kategori> KategoriListeleme(bool silinmis)
        {
            List<Kategori> listeleme = new List<Kategori>();

            try
            {
                komut.CommandText = "SELECT ID, Isim, Aciklama, Durum, Silinmis FROM Kategoriler WHERE Silinmis=@silinmis";
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@silinmis", silinmis);
                baglanti.Open();
                SqlDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    Kategori kat = new Kategori();
                    kat.ID = reader.GetInt32(0);
                    kat.Isim = reader.GetString(1);
                    kat.Aciklama = reader.GetString(2);
                    kat.Durum = reader.GetBoolean(3);
                    kat.Silinmis = reader.GetBoolean(4);
                    listeleme.Add(kat);
                }
                return listeleme;
            }
            catch
            {
                return null;
            }
            finally
            {
                baglanti.Close();
            }

        }

        public List<Kategori> KategoriListele(bool silinmis, bool durum)
        {
            List<Kategori> kategoriler = new List<Kategori>();

            try
            {
                komut.CommandText = "SELECT ID, Isim, Aciklama, Durum, Silinmis FROM Kategoriler WHERE Silinmis=@silinmis AND Durum =@durum";
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@silinmis", silinmis);
                komut.Parameters.AddWithValue("@durum", durum);
                baglanti.Open();
                SqlDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    Kategori kat = new Kategori();
                    kat.ID = reader.GetInt32(0);
                    kat.Isim = reader.GetString(1);
                    kat.Aciklama = reader.GetString(2);
                    kat.Durum = reader.GetBoolean(3);
                    kat.Silinmis = reader.GetBoolean(4);
                    kategoriler.Add(kat);
                }
                return kategoriler;
            }
            catch
            {
                return null;
            }
            finally
            {
                baglanti.Close();
            }
        }

        public void KategoriSilHardDelete(int id)
        {
            try
            {
                komut.CommandText = "DELETE FROM Kategoriler WHERE ID=@id";
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@id", id);
                baglanti.Open();
                komut.ExecuteNonQuery();
            }
            finally
            {
                baglanti.Close();
            }
        }

        public void KategoriSil(int id)
        {
            try
            {
                komut.CommandText = "UPDATE Kategoriler SET Silinmis = 1 WHERE ID=@id";
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@id", id);
                baglanti.Open();
                komut.ExecuteNonQuery();
            }
            finally
            {
                baglanti.Close();
            }
        }

        public void KategoriDurumDegistir(int id)
        {
            try
            {
                komut.CommandText = "SELECT Durum FROM Kategoriler WHERE ID = @id";
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@id", id);
                baglanti.Open();
                bool durum = Convert.ToBoolean(komut.ExecuteScalar());
                komut.CommandText = "UPDATE Kategoriler SET Durum=@durum WHERE ID = @id";
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@durum", !durum);
                komut.Parameters.AddWithValue("@id", id);
                komut.ExecuteNonQuery();
            }
            finally
            {
                baglanti.Close();
            }
        }

        public Kategori KategoriGetir(int id)
        {
            try
            {
                komut.CommandText = "SELECT ID, Isim, Aciklama, Durum, Silinmis FROM Kategoriler WHERE ID=@id";
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@id", id);
                baglanti.Open();
                SqlDataReader okuyucu = komut.ExecuteReader();
                Kategori kat = new Kategori();

                while (okuyucu.Read())
                {
                    kat.ID = okuyucu.GetInt32(0);
                    kat.Isim = okuyucu.GetString(1);
                    kat.Aciklama = okuyucu.GetString(2);
                    kat.Durum = okuyucu.GetBoolean(3);
                    kat.Silinmis = okuyucu.GetBoolean(4);
                }
                return kat;
            }
            catch
            {
                return null;
            }
            finally
            {
                baglanti.Close();
            }
        }

        public bool KategoriGuncelle(Kategori k)
        {
            try
            {
                komut.CommandText = "UPDATE Kategoriler SET Isim=@isim, Aciklama=@aciklama, Durum=@durum WHERE ID=@id";
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@id", k.ID);
                komut.Parameters.AddWithValue("@isim", k.Isim);
                komut.Parameters.AddWithValue("@aciklama", k.Aciklama);
                komut.Parameters.AddWithValue("@durum", k.Durum);
                baglanti.Open();
                komut.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                baglanti.Close();
            }
        }


        #endregion

        #region Makale Metotları

        public bool MakaleEkle(Makale mak)
        {
            try
            {
                komut.CommandText = "INSERT INTO Makaleler(KategoriID, YazarID, Baslik, Ozet, Icerik, EklemeTarihi, GoruntulemeSayisi, KapakResim, Durum) VALUES(@kategoriID, @yazarID, @baslik, @ozet, @icerik, @eklemeTarihi, @goruntulemeSayisi, @kapakResim, @durum)";
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@kategoriID", mak.KategoriID);
                komut.Parameters.AddWithValue("@yazarID", mak.YazarID);
                komut.Parameters.AddWithValue("@baslik", mak.Baslik);
                komut.Parameters.AddWithValue("@ozet", mak.Ozet);
                komut.Parameters.AddWithValue("@icerik", mak.Icerik);
                komut.Parameters.AddWithValue("@eklemeTarihi", mak.EklemeTarihi);
                komut.Parameters.AddWithValue("@goruntulemeSayisi", mak.GoruntulemeSayisi);
                komut.Parameters.AddWithValue("@kapakResim", mak.KapakResim);
                komut.Parameters.AddWithValue("@durum", mak.Durum);
                baglanti.Open();
                komut.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                baglanti.Close();
            }
        }

        public List<Makale> MakaleListele()
        {
            List<Makale> makaleler = new List<Makale>();
            try
            {
                komut.CommandText = "SELECT M.ID, M.KategoriID, K.Isim, M.YazarID, Y.KullaniciAdi, M.Ozet, M.Icerik, M.Baslik, M.EklemeTarihi, M.GoruntulemeSayisi, M.KapakResim, M.Durum FROM Makaleler AS M JOIN Kategoriler AS K ON M.KategoriID = K.ID JOIN Yoneticiler AS Y ON M.YazarID = Y.ID";
                komut.Parameters.Clear();

                baglanti.Open();
                SqlDataReader okuyucu = komut.ExecuteReader();
                while (okuyucu.Read())
                {
                    Makale mak = new Makale();
                    mak.ID = okuyucu.GetInt32(0);
                    mak.KategoriID = okuyucu.GetInt32(1);
                    mak.Kategori = okuyucu.GetString(2);
                    mak.YazarID = okuyucu.GetInt32(3);
                    mak.Yazar = okuyucu.GetString(4);
                    mak.Ozet = okuyucu.GetString(5);
                    mak.Icerik = okuyucu.GetString(6);
                    mak.Baslik = okuyucu.GetString(7);
                    mak.EklemeTarihi = okuyucu.GetDateTime(8);
                    mak.GoruntulemeSayisi = okuyucu.GetInt64(9);
                    mak.KapakResim = okuyucu.GetString(10);
                    mak.Durum = okuyucu.GetBoolean(11);
                    makaleler.Add(mak);
                }
                return makaleler;
            }
            catch
            {
                return null;
            }
            finally
            {
                baglanti.Close();
            }
        }

        public List<Makale> MakaleListele(int kid)
        {
            List<Makale> makaleler = new List<Makale>();
            try
            {
                komut.CommandText = "SELECT M.ID, M.KategoriID, K.Isim, M.YazarID, Y.KullaniciAdi, M.Ozet, M.Icerik, M.Baslik, M.EklemeTarihi, M.GoruntulemeSayisi, M.KapakResim, M.Durum FROM Makaleler AS M JOIN Kategoriler AS K ON M.KategoriID = K.ID JOIN Yoneticiler AS Y ON M.YazarID = Y.ID WHERE M.KategoriID = @kid";
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@kid", kid);

                baglanti.Open();
                SqlDataReader okuyucu = komut.ExecuteReader();
                while (okuyucu.Read())
                {
                    Makale mak = new Makale();
                    mak.ID = okuyucu.GetInt32(0);
                    mak.KategoriID = okuyucu.GetInt32(1);
                    mak.Kategori = okuyucu.GetString(2);
                    mak.YazarID = okuyucu.GetInt32(3);
                    mak.Yazar = okuyucu.GetString(4);
                    mak.Ozet = okuyucu.GetString(5);
                    mak.Icerik = okuyucu.GetString(6);
                    mak.Baslik = okuyucu.GetString(7);
                    mak.EklemeTarihi = okuyucu.GetDateTime(8);
                    mak.GoruntulemeSayisi = okuyucu.GetInt64(9);
                    mak.KapakResim = okuyucu.GetString(10);
                    mak.Durum = okuyucu.GetBoolean(11);
                    makaleler.Add(mak);
                }
                return makaleler;
            }
            catch
            {
                return null;
            }
            finally
            {
                baglanti.Close();
            }
        }

        public Makale MakaleGetir(int id)
        {
            try
            {
                komut.CommandText = "SELECT M.ID, M.KategoriID, K.Isim, M.YazarID, Y.KullaniciAdi, M.Ozet, M.Icerik, M.Baslik, M.EklemeTarihi, M.GoruntulemeSayisi, M.KapakResim, M.Durum FROM Makaleler AS M JOIN Kategoriler AS K ON M.KategoriID = K.ID JOIN Yoneticiler AS Y ON M.YazarID = Y.ID WHERE M.ID = @id";
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@id", id);
                baglanti.Open();

                SqlDataReader okuyucu = komut.ExecuteReader();
                Makale mak = new Makale();
                while (okuyucu.Read())
                {
                    mak.ID = okuyucu.GetInt32(0);
                    mak.KategoriID = okuyucu.GetInt32(1);
                    mak.Kategori = okuyucu.GetString(2);
                    mak.YazarID = okuyucu.GetInt32(3);
                    mak.Yazar = okuyucu.GetString(4);
                    mak.Ozet = okuyucu.GetString(5);
                    mak.Icerik = okuyucu.GetString(6);
                    mak.Baslik = okuyucu.GetString(7);
                    mak.EklemeTarihi = okuyucu.GetDateTime(8);
                    mak.GoruntulemeSayisi = okuyucu.GetInt64(9);
                    mak.KapakResim = okuyucu.GetString(10);
                    mak.Durum = okuyucu.GetBoolean(11);
                }
                return mak;
            }
            catch
            {
                return null;
            }
            finally
            {
                baglanti.Close();
            }
        }

        public bool MakaleDuzenle(Makale mak)
        {
            try
            {
                komut.CommandText = "UPDATE Makaleler SET KategoriID=@kategoriId, Baslik=@baslik, Icerik=@icerik, Ozet=@ozet, KapakResim=@kapakresim, Durum=@durum WHERE ID=@id";
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@kategoriId", mak.KategoriID);
                komut.Parameters.AddWithValue("@baslik", mak.Baslik);
                komut.Parameters.AddWithValue("@icerik", mak.Icerik);
                komut.Parameters.AddWithValue("@ozet", mak.Ozet);
                komut.Parameters.AddWithValue("@kapakresim", mak.KapakResim);
                komut.Parameters.AddWithValue("@durum", mak.Durum);
                komut.Parameters.AddWithValue("@id", mak.ID);
                baglanti.Open();
                komut.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                baglanti.Close();
            }
        }

        public void MakaleSil(int id)
        {
            try
            {
                komut.CommandText = "DELETE FROM Yorumlar WHERE MakaleID=@id";
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@id", id);
                baglanti.Open();
                komut.ExecuteNonQuery();
                komut.CommandText = "DELETE FROM Makaleler WHERE ID=@id";
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@id", id);
                komut.ExecuteNonQuery();
            }
            finally
            {
                baglanti.Close();
            }
        }
        public void MakaleDurumDegistir(int id)
        {
            try
            {
                komut.CommandText = "SELECT Durum FROM Makaleler WHERE ID = @id";
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@id", id);
                baglanti.Open();
                bool durum = Convert.ToBoolean(komut.ExecuteScalar());
                komut.CommandText = "UPDATE Makaleler SET Durum=@durum WHERE ID = @id";
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@durum", !durum);
                komut.Parameters.AddWithValue("@id", id);
                komut.ExecuteNonQuery();
            }
            finally
            {
                baglanti.Close();
            }
        }


        public void MakaleGoruntulemeArttir(int id)
        {
            try
            {
                komut.CommandText = "SELECT GoruntulemeSayisi FROM Makaleler WHERE ID=@id";
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@id", id);
                baglanti.Open();
                int sayi = Convert.ToInt32(komut.ExecuteScalar());
                komut.CommandText = "UPDATE Makaleler SET GoruntulemeSayisi=@gs WHERE ID=@id";
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@id", id);
                komut.Parameters.AddWithValue("@gs", sayi + 1);
                komut.ExecuteNonQuery();
            }
            finally
            {
                baglanti.Close();
            }
        }

        #endregion

        #region Test Metotları

        public bool SoruEkle(Soru soru)
        {
            try
            {
                komut.CommandText = "INSERT INTO Soru(TestID, Soru, Acevabi, Bcevabi, Ccevabi, Dcevabi) VALUES (@testid, @soru, @acevabi, @bcevabi, @ccevabi, @dcevabi)";
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@testid", 1);
                komut.Parameters.AddWithValue("@soru", soru.SoruMetni);
                komut.Parameters.AddWithValue("@acevabi", soru.A);
                komut.Parameters.AddWithValue("@bcevabi", soru.B);
                komut.Parameters.AddWithValue("@ccevabi", soru.C);
                komut.Parameters.AddWithValue("@dcevabi", soru.D);
                baglanti.Open();
                komut.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                baglanti.Close();
            }
        }

        public List<Test> TestListeleme()
        {
            List<Test> teslist = new List<Test>();

            try
            {
                komut.CommandText = "SELECT YoneticiID, Durum, Silinmis FROM Test ";
                komut.Parameters.Clear();
                baglanti.Open();
                SqlDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    Test s = new Test();
                    s.YoneticiID = reader.GetInt32(0);
                    s.Durum = reader.GetBoolean(1);
                    s.Silinmis = reader.GetBoolean(2);
                    teslist.Add(s);
                }
                return teslist;
            }
            catch
            {
                return null;
            }
            finally
            {
                baglanti.Close();
            }
          
        }

        public List<Test> Testlisteleme(bool silinmis, bool durum)
        {
            List<Test> tesliste = new List<Test>();

            try
            {
                komut.CommandText = "SELECT YoneticiID, Durum, Silinmis FROM Test WHERE Silinmis=@silinmis AND Durum =@durum";
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@silinmis", silinmis);
                komut.Parameters.AddWithValue("@durum", durum);
                baglanti.Open();
                SqlDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    Test so = new Test();
                    so.YoneticiID = reader.GetInt32(0);
                    so.Durum = reader.GetBoolean(1);
                    so.Silinmis = reader.GetBoolean(2);
                    tesliste.Add(so);
                }
                return tesliste;
            }
            catch
            {
                return null;
            }
            finally
            {
                baglanti.Close();
            }

        }

        public void TestSilHardDelete(int id)
        {
            try
            {
                komut.CommandText = "DELETE FROM Test WHERE ID=@id";
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@id", id);
                baglanti.Open();
                komut.ExecuteNonQuery();
            }
            finally
            {
                baglanti.Close();
            }
        }

        public void TestDurumDegistir(int id)
        {
            try
            {
                komut.CommandText = "SELECT Durum FROM Test WHERE ID = @id";
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@id", id);
                baglanti.Open();
                bool durum = Convert.ToBoolean(komut.ExecuteScalar());
                komut.CommandText = "UPDATE Test SET Durum=@durum WHERE ID = @id";
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@durum", !durum);
                komut.Parameters.AddWithValue("@id", id);
                komut.ExecuteNonQuery();
            }
            finally
            {
                baglanti.Close();
            }
        }

        public Test TestGetir(int id)
        {
            try
            {
                komut.CommandText = "SELECT ID, YoneticiID, Baslik, Aciklama, EklemeTarihi, Durum, Silinmis, Cevap FROM Test WHERE ID=@id";
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@id", id);
                baglanti.Open();
                SqlDataReader okuyucu = komut.ExecuteReader();
                Test test = new Test();

                while (okuyucu.Read())
                {
                    test.ID = okuyucu.GetInt32(0);
                    test.YoneticiID = okuyucu.GetInt32(1);
                    test.Baslik = okuyucu.GetString(2);
                    test.Aciklama = okuyucu.GetString(3);
                    test.EklemeTarihi = okuyucu.GetDateTime(4);
                    test.Durum = okuyucu.GetBoolean(5);
                    test.Silinmis = okuyucu.GetBoolean(6);
                    test.Cevap = okuyucu.GetString(7);
                }
                return test;
            }
            catch
            {
                return null;
            }
            finally
            {
                baglanti.Close();
            }
        }


        #endregion


    }
}
