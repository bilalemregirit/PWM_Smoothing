  //KULLANIMI 
  int analog_input; 
  int analog_yumusatilmis;
  int hassasiyet deger = 2;
  int olubolge_deger = 1;
  int index;
  
  //ÖRNEK
  analog_yumusatilmis= yumusatma(analog_input, hassasiyet_deger, olubolge_deger, index);
   
             // Bu fonksiyonun kullanımı için giriş için ve 
             //çıkış sinyalleri için 2 ayrı değişken kullanmalısınız 
             //ve fonksiyonun çağırıldığı yer tekrar içinde bulunmalı.
             //deger ----------- giris sinyali(yumuşatılmak istenen)
             //hassasiyet ------ sinyalin anlık arttırlıp azaltılışı
             //(0dan büyük bütün int degerlerini alabilir)
             //olu_bolge -------- sinyalin tepki aralığı (0,1,2,3,4 düzeyi arttırmak için)
             // her bir yumusatılan sinyal için ayrı index degeri veriniz.

public int[] degisen_deger = new int[20];
        private int yumusatma(int deger, int hassasiyet, int olu_bolge, int yeni_deger)
        {
            int z = yeni_deger;

            if (deger > degisen_deger[z])
            {
                for (int i = 0; i < 1; i++)
                { degisen_deger[z] = degisen_deger[z] + hassasiyet; }
            }

            if (deger < degisen_deger[z])
            {
                for (int i = 0; i < 1; i++)
                { degisen_deger[z] = degisen_deger[z] - hassasiyet; }
            }
            switch (olu_bolge)
            {
                case 0:
                    if (deger == degisen_deger[z])
                    { }
                    break;
                case 1:
                    if (deger == degisen_deger[z] ||
                        deger == degisen_deger[z] + 1 ||
                        deger == degisen_deger[z] - 1)
                    { }
                    break;
                case 2:
                    if (deger == degisen_deger[z] ||
                      deger == degisen_deger[z] + 1 ||
                      deger == degisen_deger[z] - 1 ||
                      deger == degisen_deger[z] + 2 ||
                      deger == degisen_deger[z] - 2)
                    { }
                    break;
                case 3:
                    if (deger == degisen_deger[z] ||
                      deger == degisen_deger[z] + 1 ||
                      deger == degisen_deger[z] - 1 ||
                      deger == degisen_deger[z] + 2 ||
                      deger == degisen_deger[z] - 2 ||
                      deger == degisen_deger[z] + 3 ||
                      deger == degisen_deger[z] - 3)
                    { }
                    break;
                case 4:
                    if (deger == degisen_deger[z] ||
                      deger == degisen_deger[z] + 1 ||
                      deger == degisen_deger[z] - 1 ||
                      deger == degisen_deger[z] + 2 ||
                      deger == degisen_deger[z] - 2 ||
                      deger == degisen_deger[z] + 3 ||
                      deger == degisen_deger[z] - 3 ||
                      deger == degisen_deger[z] + 4 ||
                      deger == degisen_deger[z] - 4)
                    { }
                    break;
            }
            return degisen_deger[z];
        }

