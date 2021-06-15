  //KULLANIMI 
  int analog_input; 
  int analog_yumusatilmis;
  int hassasiyet deger = 2;
  int olubolge_deger = 1;
  
  
  analog_yumusatilmis= yumusatma(analog_input, hassasiyet_deger, olubolge_deger);
  
  
  
  public int yeni_deger;
        public int yumusatma(int deger, int hassasiyet, int olu_bolge)
        {  
            // Bu fonksiyonun kullanımı için giriş için ve 
             //çıkış sinyalleri için 2 ayrı değişken kullanmalısınız 
             //ve fonksiyonun çağırıldığı yer tekrar içinde bulunmalı.

             //deger ----------- giris sinyali(yumuşatılmak istenen)
             //hassasiyet ------ sinyalin anlık arttırlıp azaltılışı
                             //(0dan büyük bütün int degerlerini alabilir)
             //olu_bolge -------- sinyalin tepki aralığı (0,1,2,3,4 düzeyi arttırmak için)

                if (deger > yeni_deger)
                {for (int i = 0; i < 1; i++)
                {yeni_deger = yeni_deger + hassasiyet;}}  
                                 
                if (deger < yeni_deger)
                {for (int i = 0; i < 1; i++)
                {yeni_deger = yeni_deger - hassasiyet;}    
                }
            switch (olu_bolge)
            {
                case 0 :
                    if (deger == yeni_deger)
                    {  }
                    break;
                case 1:
                    if (deger == yeni_deger ||
                        deger == yeni_deger + 1 ||
                        deger == yeni_deger - 1)
                    {  }
                    break;
                case 2:
                    if (deger == yeni_deger ||
                      deger == yeni_deger + 1 ||
                      deger == yeni_deger - 1 ||
                      deger == yeni_deger + 2 ||
                      deger == yeni_deger - 2)
                    { }
                    break;
                case 3:
                    if (deger == yeni_deger ||
                      deger == yeni_deger + 1 ||
                      deger == yeni_deger - 1 ||
                      deger == yeni_deger + 2 ||
                      deger == yeni_deger - 2 ||
                      deger == yeni_deger + 3 ||
                      deger == yeni_deger - 3)
                    {  }
                    break;
                case 4:
                    if (deger == yeni_deger ||
                      deger == yeni_deger + 1 ||
                      deger == yeni_deger - 1 ||
                      deger == yeni_deger + 2 ||
                      deger == yeni_deger - 2 ||
                      deger == yeni_deger + 3 ||
                      deger == yeni_deger - 3 ||
                      deger == yeni_deger + 4 ||
                      deger == yeni_deger - 4)
                    { }
                    break;
            }
            return yeni_deger;
        }
