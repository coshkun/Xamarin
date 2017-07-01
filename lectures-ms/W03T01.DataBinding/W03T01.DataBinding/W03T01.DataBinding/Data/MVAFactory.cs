using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03T01.DataBinding.Data
{
    public class MVA
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public string PublishDate { get; set; }
    }

    public class MVAFactory
    {
        public static IList<MVA> MVAData { get; set; }

        static MVAFactory()
        {
            MVAData = new ObservableCollection<MVA>
            {
                new MVA
                {
                        Title = "Arduinonun kullanım alanları",
                        Description = "Detayları Görmek için makale sayfasını ziyaret edin.",
                        PublishDate = "27.02.2017",
                        ImageUrl = "engin.jpg"
                },

                new MVA
                {
                        Title = "Robotik Programlama",
                        Description = "Detayları Görmek için makale sayfasını ziyaret edin.",
                        PublishDate = "29.01.2015",
                        ImageUrl = "iryna.jpg"
                },

                new MVA
                {
                        Title = "Sanal Sınıf Ders notları",
                        Description = "Detayları Görmek için makale sayfasını ziyaret edin.",
                        PublishDate = "1.04.2015",
                        ImageUrl = "eda.jpg"
                },

                new MVA
                {
                        Title = "Robotik Programlama",
                        Description = "Detayları Görmek için makale sayfasını ziyaret edin.",
                        PublishDate = "10.05.2015",
                        ImageUrl = "iryna.jpg"
                },

                new MVA
                {
                        Title = "Arduinonun kullanım alanları",
                        Description = "Detayları Görmek için makale sayfasını ziyaret edin.",
                        PublishDate = "25.06.2015",
                        ImageUrl = "feyyaz.jpg"
                },

                new MVA
                {
                        Title = "Evrenin Sırları",
                        Description = "Detayları Görmek için makale sayfasını ziyaret edin.",
                        PublishDate = "13.02.2017",
                        ImageUrl = "eda.jpg"
                },

                new MVA
                {
                        Title = "Robotik Programlama",
                        Description = "Detayları Görmek için makale sayfasını ziyaret edin.",
                        PublishDate = "16.08.2014",
                        ImageUrl = "feyyaz.jpg"
                },

                new MVA
                {
                        Title = "Arduinonun kullanım alanları",
                        Description = "Detayları Görmek için makale sayfasını ziyaret edin.",
                        PublishDate = "17.04.2015",
                        ImageUrl = "eda.jpg"
                },

                new MVA
                {
                        Title = "Mobil Programlama",
                        Description = "Detayları Görmek için makale sayfasını ziyaret edin.",
                        PublishDate = "18.11.2013",
                        ImageUrl = "feride.jpg"
                },

                new MVA
                {
                        Title = "Sanal Sınıf Ders notları",
                        Description = "Detayları Görmek için makale sayfasını ziyaret edin.",
                        PublishDate = "17.05.2014",
                        ImageUrl = "engin.jpg"
                },

                new MVA
                {
                        Title = "Mobil Programlama",
                        Description = "Detayları Görmek için makale sayfasını ziyaret edin.",
                        PublishDate = "11.02.2017",
                        ImageUrl = "feride.jpg"
                },

                new MVA
                {
                        Title = "Mobil Programlama",
                        Description = "Detayları Görmek için makale sayfasını ziyaret edin.",
                        PublishDate = "11.02.2017",
                        ImageUrl = "coskun.jpg"
                },

                new MVA
                {
                        Title = "Evrenin Sırları",
                        Description = "Detayları Görmek için makale sayfasını ziyaret edin.",
                        PublishDate = "14.06.2016",
                        ImageUrl = "iryna.jpg"
                },

                new MVA
                {
                        Title = "Mobil Programlama",
                        Description = "Detayları Görmek için makale sayfasını ziyaret edin.",
                        PublishDate = "3.04.2014",
                        ImageUrl = "eda.jpg"
                },

                new MVA
                {
                        Title = "Fasulyenin faydaları",
                        Description = "Detayları Görmek için makale sayfasını ziyaret edin.",
                        PublishDate = "16.02.2017",
                        ImageUrl = "feyyaz.jpg"
                },

                new MVA
                {
                        Title = "Mobil Programlama",
                        Description = "Detayları Görmek için makale sayfasını ziyaret edin.",
                        PublishDate = "25.05.2015",
                        ImageUrl = "engin.jpg"
                },

                new MVA
                {
                        Title = "Arduinonun kullanım alanları",
                        Description = "Detayları Görmek için makale sayfasını ziyaret edin.",
                        PublishDate = "23.05.2016",
                        ImageUrl = "iryna.jpg"
                },

                new MVA
                {
                        Title = "Fasulyenin faydaları",
                        Description = "Detayları Görmek için makale sayfasını ziyaret edin.",
                        PublishDate = "5.09.2016",
                        ImageUrl = "iryna.jpg"
                },

                new MVA
                {
                        Title = "Evrenin Sırları",
                        Description = "Detayları Görmek için makale sayfasını ziyaret edin.",
                        PublishDate = "22.04.2017",
                        ImageUrl = "engin.jpg"
                },

                new MVA
                {
                        Title = "Fasulyenin faydaları",
                        Description = "Detayları Görmek için makale sayfasını ziyaret edin.",
                        PublishDate = "17.03.2016",
                        ImageUrl = "eda.jpg"
                },

                new MVA
                {
                        Title = "Robotik Programlama",
                        Description = "Detayları Görmek için makale sayfasını ziyaret edin.",
                        PublishDate = "11.05.2015",
                        ImageUrl = "eda.jpg"
                },

                new MVA
                {
                        Title = "Mobil Programlama",
                        Description = "Detayları Görmek için makale sayfasını ziyaret edin.",
                        PublishDate = "12.01.2016",
                        ImageUrl = "feyyaz.jpg"
                },

                new MVA
                {
                        Title = "Fasulyenin faydaları",
                        Description = "Detayları Görmek için makale sayfasını ziyaret edin.",
                        PublishDate = "6.04.2015",
                        ImageUrl = "feyyaz.jpg"
                },

                new MVA
                {
                        Title = "Mobil Programlama",
                        Description = "Detayları Görmek için makale sayfasını ziyaret edin.",
                        PublishDate = "14.03.2014",
                        ImageUrl = "feyyaz.jpg"
                },

                new MVA
                {
                        Title = "Fasulyenin faydaları",
                        Description = "Detayları Görmek için makale sayfasını ziyaret edin.",
                        PublishDate = "16.01.2015",
                        ImageUrl = "engin.jpg"
                },

                new MVA
                {
                        Title = "Robotik Programlama",
                        Description = "Detayları Görmek için makale sayfasını ziyaret edin.",
                        PublishDate = "6.05.2014",
                        ImageUrl = "iryna.jpg"
                },

                new MVA
                {
                        Title = "Mobil Programlama",
                        Description = "Detayları Görmek için makale sayfasını ziyaret edin.",
                        PublishDate = "6.02.2015",
                        ImageUrl = "iryna.jpg"
                },

                new MVA
                {
                        Title = "Evrenin Sırları",
                        Description = "Detayları Görmek için makale sayfasını ziyaret edin.",
                        PublishDate = "6.07.2016",
                        ImageUrl = "coskun.jpg"
                },

                new MVA
                {
                        Title = "Robotik Programlama",
                        Description = "Detayları Görmek için makale sayfasını ziyaret edin.",
                        PublishDate = "29.11.2014",
                        ImageUrl = "feride.jpg"
                },

                new MVA
                {
                        Title = "Evrenin Sırları",
                        Description = "Detayları Görmek için makale sayfasını ziyaret edin.",
                        PublishDate = "2.08.2015",
                        ImageUrl = "coskun.jpg"
                },

                new MVA
                {
                        Title = "Arduinonun kullanım alanları",
                        Description = "Detayları Görmek için makale sayfasını ziyaret edin.",
                        PublishDate = "28.03.2015",
                        ImageUrl = "feyyaz.jpg"
                },

                new MVA
                {
                        Title = "Mobil Programlama",
                        Description = "Detayları Görmek için makale sayfasını ziyaret edin.",
                        PublishDate = "7.01.2015",
                        ImageUrl = "feride.jpg"
                },

                new MVA
                {
                        Title = "Fasulyenin faydaları",
                        Description = "Detayları Görmek için makale sayfasını ziyaret edin.",
                        PublishDate = "4.09.2016",
                        ImageUrl = "engin.jpg"
                },

                new MVA
                {
                        Title = "Robotik Programlama",
                        Description = "Detayları Görmek için makale sayfasını ziyaret edin.",
                        PublishDate = "11.03.2016",
                        ImageUrl = "feyyaz.jpg"
                },

                new MVA
                {
                        Title = "Evrenin Sırları",
                        Description = "Detayları Görmek için makale sayfasını ziyaret edin.",
                        PublishDate = "4.11.2014",
                        ImageUrl = "feride.jpg"
                },

                new MVA
                {
                        Title = "Mobil Programlama",
                        Description = "Detayları Görmek için makale sayfasını ziyaret edin.",
                        PublishDate = "23.10.2016",
                        ImageUrl = "engin.jpg"
                },

                new MVA
                {
                        Title = "Arduinonun kullanım alanları",
                        Description = "Detayları Görmek için makale sayfasını ziyaret edin.",
                        PublishDate = "13.07.2015",
                        ImageUrl = "engin.jpg"
                },

                new MVA
                {
                        Title = "Mobil Programlama",
                        Description = "Detayları Görmek için makale sayfasını ziyaret edin.",
                        PublishDate = "27.03.2017",
                        ImageUrl = "iryna.jpg"
                },

                new MVA
                {
                        Title = "Robotik Programlama",
                        Description = "Detayları Görmek için makale sayfasını ziyaret edin.",
                        PublishDate = "2.02.2016",
                        ImageUrl = "feyyaz.jpg"
                },

                new MVA
                {
                        Title = "Robotik Programlama",
                        Description = "Detayları Görmek için makale sayfasını ziyaret edin.",
                        PublishDate = "19.09.2015",
                        ImageUrl = "coskun.jpg"
                },

                new MVA
                {
                        Title = "Mobil Programlama",
                        Description = "Detayları Görmek için makale sayfasını ziyaret edin.",
                        PublishDate = "16.06.2015",
                        ImageUrl = "iryna.jpg"
                },

                new MVA
                {
                        Title = "Sanal Sınıf Ders notları",
                        Description = "Detayları Görmek için makale sayfasını ziyaret edin.",
                        PublishDate = "27.10.2014",
                        ImageUrl = "iryna.jpg"
                },

                new MVA
                {
                        Title = "Arduinonun kullanım alanları",
                        Description = "Detayları Görmek için makale sayfasını ziyaret edin.",
                        PublishDate = "12.09.2015",
                        ImageUrl = "coskun.jpg"
                },

                new MVA
                {
                        Title = "Fasulyenin faydaları",
                        Description = "Detayları Görmek için makale sayfasını ziyaret edin.",
                        PublishDate = "12.05.2016",
                        ImageUrl = "coskun.jpg"
                },

                new MVA
                {
                        Title = "Evrenin Sırları",
                        Description = "Detayları Görmek için makale sayfasını ziyaret edin.",
                        PublishDate = "11.06.2015",
                        ImageUrl = "feride.jpg"
                },

                new MVA
                {
                        Title = "Arduinonun kullanım alanları",
                        Description = "Detayları Görmek için makale sayfasını ziyaret edin.",
                        PublishDate = "22.11.2016",
                        ImageUrl = "coskun.jpg"
                },

                new MVA
                {
                        Title = "Arduinonun kullanım alanları",
                        Description = "Detayları Görmek için makale sayfasını ziyaret edin.",
                        PublishDate = "13.06.2017",
                        ImageUrl = "feride.jpg"
                },

                new MVA
                {
                        Title = "Sanal Sınıf Ders notları",
                        Description = "Detayları Görmek için makale sayfasını ziyaret edin.",
                        PublishDate = "6.04.2017",
                        ImageUrl = "engin.jpg"
                },

                new MVA
                {
                        Title = "Evrenin Sırları",
                        Description = "Detayları Görmek için makale sayfasını ziyaret edin.",
                        PublishDate = "12.12.2015",
                        ImageUrl = "feyyaz.jpg"
                },

                new MVA
                {
                        Title = "Sanal Sınıf Ders notları",
                        Description = "Detayları Görmek için makale sayfasını ziyaret edin.",
                        PublishDate = "6.08.2014",
                        ImageUrl = "feyyaz.jpg"
                }

            };
        }
    }
}
