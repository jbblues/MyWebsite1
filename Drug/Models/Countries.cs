using System.Collections.Generic;

namespace Drug.Models
{
    public class Service
    {
        public string Header { get; set; }
        public List<Columns> Columns { get; set; }
    }
    public class Columns
    {
        public List<string> Body { get; set; }
    }
    public class Country
    {
        public string Name { get; set; }
        public string Flag { get; set; }
        public List<Service> Services { get; set; }
    }
    public class CountryList
    {
        public List<Country> Countries { get; set; }
        public CountryList()
        {
            this.Countries = new List<Country>() {
               new Country(){
                   Name = "Benin",
                    Flag = "https://res.cloudinary.com/fzany-inc/image/upload/v1556201312/flag-of-Benin_azyo6t.png",
                     Services = new List<Service>()
                     {
                          new Service()
                          {
                              Header ="Mobile Money",
                              Columns = new List<Columns>(){
                                 new Columns(){ Body = new List<string>{"MOOV", "EU Mobile" } },
                                  new Columns(){ Body = new List<string>{ "MTN", "YUP" } },
                              }
                          },
                           new Service()
                           {
                               Header = "Banks",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "Diamond Bank Bénin", "Ecobank Bénin" } },
                                  new Columns(){ Body = new List<string>{ "Bank of Africa Bénin", "BGFIBank Benin" } },
                                  }
                              },
                           new Service()
                           {
                               Header = "Customers",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "MNOs (MTN Group, MOOV, BBcom)"} },
                                    new Columns(){ Body = new List<string>{ "Cable Tv (DStv, StarTimes)" } },
                                  }
                              },
                           }
               },
               new Country(){
                   Name = "Burkina Faso",
                    Flag = "https://res.cloudinary.com/fzany-inc/image/upload/v1556201336/flag-of-Burkina-Faso_e0qwky.png",
                     Services = new List<Service>()
                     {
                          new Service()
                          {
                              Header ="Mobile Money",
                              Columns = new List<Columns>(){
                                 new Columns(){ Body = new List<string>{ "Onatel", "Airtel" } },
                                  new Columns(){ Body = new List<string>{ "Waricel", } },
                              }
                          },
                           new Service()
                           {
                               Header = "Banks",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "United Bank for Africa", "Ecobank Burkina" } },
                                  new Columns(){ Body = new List<string>{ "Bank of Africa", "Banque Atlantique Burkina Faso" } },
                                  }
                              },
                           new Service()
                           {
                               Header = "Customers",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "MNOs (Onatel, Orange, Moov)"} },
                                    new Columns(){ Body = new List<string>{"Cable Tv (DStv)" } },
                                 new Columns(){ Body = new List<string>{ "Power (Orange Smart Metering Solution)" } },

                                  }
                              },
                           }
               },
                 new Country(){
                   Name = "Burundi",
                    Flag = "https://res.cloudinary.com/fzany-inc/image/upload/v1556201360/flag-of-Burundi_sdouj5.png",
                     Services = new List<Service>()
                     {
                          new Service()
                          {
                              Header ="Mobile Money",
                              Columns = new List<Columns>(){
                                 new Columns(){ Body = new List<string>{ "EcoCash" } },
                              }
                          },
                           new Service()
                           {
                               Header = "Banks",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "Ecobank Burundi", "Diamond Trust Bank Burundi" } },
                                  new Columns(){ Body = new List<string>{ "Interbank Burundi", "FinBank Burundi" } },
                                  }
                              },
                           new Service()
                           {
                               Header = "Customers",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "MNOs (Onatel, Econet Wireless, U-Com)"} },
                                    new Columns(){ Body = new List<string>{"Cable Tv (DStv, StarTimes)" } }
                                  }
                              },
                           }
               }, //end of country
                  new Country(){
                   Name = "Cameroon",
                    Flag = "https://res.cloudinary.com/fzany-inc/image/upload/v1556201382/flag-of-Cameroon_mhub9p.png",
                     Services = new List<Service>()
                     {
                          new Service()
                          {
                              Header ="Mobile Money",
                              Columns = new List<Columns>(){
                                 new Columns(){ Body = new List<string>{ "Orange", "EU Mobile" } },
                                 new Columns(){ Body = new List<string>{ "MTN", "YUP" } },
                              }
                          },
                           new Service()
                           {
                               Header = "Banks",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "United Bank for Africa", "Union Bank of Cameroon" } },
                                  new Columns(){ Body = new List<string>{ "Ecobank Cameroon", "Citibank" } },
                                  }
                              },
                           new Service()
                           {
                               Header = "Customers",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "MNOs (MTN, Orange, Camtel, Pastel)"} },
                                    new Columns(){ Body = new List<string>{ "Cable Tv (DStv, KWESÉ TV)" } }
                                  }
                              },
                           }
               }, //end of country
                   new Country(){
                   Name = "Cape Verde",
                    Flag = "https://res.cloudinary.com/fzany-inc/image/upload/v1556201412/flag-of-Cabo-Verde_rsiif9.png",
                     Services = new List<Service>()
                     {
                          new Service()
                          {
                              Header ="Mobile Money",
                              Columns = new List<Columns>(){
                                 new Columns(){ Body = new List<string>{ "GMT Mobile"} },
                              }
                          },
                           new Service()
                           {
                               Header = "Banks",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "Ecobank", "Banco Africano de Investimentos" } },
                                  new Columns(){ Body = new List<string>{ "Banco Inter-Atlântico", "Bank of Cape Verde" } },
                                  }
                              },
                           new Service()
                           {
                               Header = "Customers",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "MNOs (T+ Mobile, Cabo Verde Telecom)"} }, new Columns(){ Body = new List<string>{"Cable Tv (DStv)" } }
                                  }
                              },
                           }
               }, //end of country
                    new Country(){
                   Name = "Central African Republic",
                    Flag = "https://res.cloudinary.com/fzany-inc/image/upload/v1556201436/flag-of-Central-African-Republic_vihmxi.png",
                     Services = new List<Service>()
                     {
                          new Service()
                          {
                              Header ="Mobile Money",
                              Columns = new List<Columns>(){
                                 new Columns(){ Body = new List<string>{ "Orange", "EU Mobile" } },
                                  new Columns(){ Body = new List<string>{ "Telecel" } },
                              }
                          },
                           new Service()
                           {
                               Header = "Banks",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "Banque Internationale pour le Centrafrique ", "Ecobank" } },
                                  new Columns(){ Body = new List<string>{ "Banque Populaire Maroco-Centrafricaine ", "Commercial Bank Centrafrique" } },
                                  }
                              },
                           new Service()
                           {
                               Header = "Customers",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "MNOs (Moov, NationLink Telecom RCA, Orange, Telecel Centrafrique)"} },
                                    new Columns(){ Body = new List<string>{ "Cable Tv (DStv, StarTimes)" } }
                                  }
                              },
                           }
               }, //end of country
                     new Country(){
                   Name = "Chad",
                    Flag = "https://res.cloudinary.com/fzany-inc/image/upload/v1556201459/flag-of-Chad_mz85mw.png",
                     Services = new List<Service>()
                     {
                          new Service()
                          {
                              Header ="Mobile Money",
                              Columns = new List<Columns>(){
                                 new Columns(){ Body = new List<string>{ "Tigo", "EU Mobile" } },
                                  new Columns(){ Body = new List<string>{ "Airtel", "YUP" } },
                              }
                          },
                           new Service()
                           {
                               Header = "Banks",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "UBA Tchad", "Ecobank" } },
                                  new Columns(){ Body = new List<string>{ "Commercial Bank of Tchad", "Commercial Bank Tchad" } },
                                  }
                              },
                           new Service()
                           {
                               Header = "Customers",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "MNOs (Airtel, Sotel Chad, Millicom, Salam)"} }, new Columns(){ Body = new List<string>{"Cable Tv (DStv)" } }
                                  }
                              },
                           }
               }, //end of country
                      new Country(){
                   Name = "Congo Brazzaville",
                    Flag = "https://res.cloudinary.com/fzany-inc/image/upload/v1556201482/flag-of-Congo_jwmi0m.png",
                     Services = new List<Service>()
                     {
                          new Service()
                          {
                              Header ="Mobile Money",
                              Columns = new List<Columns>(){
                                 new Columns(){ Body = new List<string>{ "MTN", "EU Mobile" } },
                                  new Columns(){ Body = new List<string>{ "Airtel", "YUP" } },
                              }
                          },
                           new Service()
                           {
                               Header = "Banks",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "Afriland First Bank", "Ecobank" } },
                                  new Columns(){ Body = new List<string>{ "Crédit du Congo", "BGFIBank Congo" } },
                                  }
                              },
                           new Service()
                           {
                               Header = "Customers",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "MNOs (Airtel, Azur, MTN, Warid)"} }, new Columns(){ Body = new List<string>{"Cable Tv (DStv)" } }
                                  }
                              },
                           }
               }, //end of country
                       new Country(){
                   Name = "Democratic Republic Of Congo",
                    Flag = "https://res.cloudinary.com/fzany-inc/image/upload/v1556201507/flag-of-Congo-Democratic-Republic-of_t78riy.png",
                     Services = new List<Service>()
                     {
                          new Service()
                          {
                              Header ="Mobile Money",
                              Columns = new List<Columns>(){
                                 new Columns(){ Body = new List<string>{ "M-PESA", "Tigo","Africell" } },
                                  new Columns(){ Body = new List<string>{ "Orange", "Airtel", "EU Mobile" } },
                              }
                          },
                           new Service()
                           {
                               Header = "Banks",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "Access Bank", "Ecobank" } },
                                  new Columns(){ Body = new List<string>{ "Stanbic Bank", "United Bank for Africa" } },
                                  }
                              },
                           new Service()
                           {
                               Header = "Customers",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "MNOs (Airtel, Vodacom, Orange, Tatem)"} },
                                    new Columns(){ Body = new List<string>{ "Cable Tv (DStv, KWESÉ TV, StarTimes)" } }
                                  }
                              },
                           }
               }, //end of country
                         new Country(){
                   Name = "Equatorial Guinea",
                    Flag = "https://res.cloudinary.com/fzany-inc/image/upload/v1556201535/flag-of-Equatorial-Guinea_n5xpig.png",
                     Services = new List<Service>()
                     {
                          new Service()
                          {
                              Header ="Mobile Money",
                              Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "Orange"} },
                              }
                          },
                           new Service()
                           {
                               Header = "Banks",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "BGFIBank Equatorial Guinea", "Commercial Bank Guinee Equatoriale" } },
                                  new Columns(){ Body = new List<string>{ "Caisse Commune d’Epargne et d’Investissement Guinée Equatoriale (CCEI)" } },
                                  }
                              },
                           new Service()
                           {
                               Header = "Customers",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "MNOs ( Orange, HiTs)"} },
                                    new Columns(){ Body = new List<string>{ "Cable Tv (DStv, StarTimes)" } }
                                  }
                              },
                           }
               }, //end of country
                            new Country(){
                   Name = "Gabon",
                    Flag = "https://res.cloudinary.com/fzany-inc/image/upload/v1556201561/flag-of-Gabon_vzeosa.png",
                     Services = new List<Service>()
                     {
                          new Service()
                          {
                              Header ="Mobile Money",
                              Columns = new List<Columns>(){
                                new Columns(){ Body = new List<string>{ "Airtel", "MobiCash" } },
                                  new Columns(){ Body = new List<string>{ "MOOV", "EU Mobile" } },                              }
                          },
                           new Service()
                           {
                               Header = "Banks",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "Ecobank", "United Bank for Africa" } },
                                  new Columns(){ Body = new List<string>{ "Citibank", "BGFI Bank" } },
                                  }
                              },
                           new Service()
                           {
                               Header = "Customers",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "MNOs ( Azur, Airtel, Moov, Libertis S.A)"} }, new Columns(){ Body = new List<string>{"Cable Tv (DStv)" } }
                                  }
                              },
                           }
               }, //end of country
                               new Country(){
                   Name = "Gambia",
                    Flag = "https://res.cloudinary.com/fzany-inc/image/upload/v1556201535/flag-of-Equatorial-Guinea_n5xpig.png",
                     Services = new List<Service>()
                     {
                          new Service()
                          {
                              Header ="Mobile Money",
                              Columns = new List<Columns>(){
                                new Columns(){ Body = new List<string>{ "Africall" } },
                              }
                          },
                           new Service()
                           {
                               Header = "Banks",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "Access Bank Gambia", "Guaranty Trust Bank Gambia" } },
                                  new Columns(){ Body = new List<string>{ "Zenith Bank Gambia Limited", "First Bank Nigeria (Gambia) Limited" } },
                                  }
                              },
                           new Service()
                           {
                               Header = "Customers",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "MNOs ( Africell Gambia Ltd, Comium, Qcell)"} },
                                    new Columns(){ Body = new List<string>{ "Cable Tv (DStv, KWESÉ TV)" } }
                                  }
                              },
                           }
               }, //end of country
                                 new Country(){
                   Name = "Ghana",
                    Flag = "https://res.cloudinary.com/fzany-inc/image/upload/v1556201561/flag-of-Gabon_vzeosa.png",
                     Services = new List<Service>()
                     {
                          new Service()
                          {
                              Header ="Mobile Money",
                              Columns = new List<Columns>(){
                                new Columns(){ Body = new List<string>{ "MTN", "Airtel" ,"YUP"} },
                                new Columns(){ Body = new List<string>{ "Tigo", "Vodafone" } },
                              }
                          },
                           new Service()
                           {
                               Header = "Banks",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "Access Bank", "Guaranty Trust Bank" } },
                                  new Columns(){ Body = new List<string>{ "Fidelity Bank Ghana Limited", "Zenith Bank Ghana" } },
                                  }
                              },
                           new Service()
                           {
                               Header = "Customers",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "MNOs ( MTN, Gateway, Mobile Choice)"} },
                                    new Columns(){ Body = new List<string>{ "Cable Tv (DStv, KWESÉ TV, StarTimes)" } }
                                  }
                              },
                           }
               }, //end of country
                                    new Country(){
                   Name = "Guinea",
                    Flag = "https://res.cloudinary.com/fzany-inc/image/upload/v1556201535/flag-of-Equatorial-Guinea_n5xpig.png",
                     Services = new List<Service>()
                     {
                          new Service()
                          {
                              Header ="Mobile Money",
                              Columns = new List<Columns>(){
                                new Columns(){ Body = new List<string>{ "Orange"} },
                                new Columns(){ Body = new List<string>{ "MTN" } },
                              }
                          },
                           new Service()
                           {
                               Header = "Banks",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "First Bank of Nigeria", "Ecobank Guinée" } },
                                  new Columns(){ Body = new List<string>{ "Skye Bank Guinée", "UBA Guinée" } },
                                  }
                              },
                           new Service()
                           {
                               Header = "Customers",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "MNOs ( Cellcom, Intercel, MTN)"} }, new Columns(){ Body = new List<string>{"Cable Tv (DStv)" } }
                                  }
                              },
                           }
               }, //end of country
                                       new Country(){
                   Name = "Guinea Bissau",
                    Flag = "https://res.cloudinary.com/fzany-inc/image/upload/v1556201561/flag-of-Gabon_vzeosa.png",
                     Services = new List<Service>()
                     {
                          new Service()
                          {
                              Header ="Mobile Money",
                              Columns = new List<Columns>(){
                                new Columns(){ Body = new List<string>{ "Orange"} },
                                new Columns(){ Body = new List<string>{ "MTN" } },
                              }
                          },
                           new Service()
                           {
                               Header = "Banks",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "Banco Da Uniao", "Ecobank" } },
                                  new Columns(){ Body = new List<string>{ "Banco Da Africa Ocidental", "Banque Régionale de Solidarité" } },
                                  }
                              },
                           new Service()
                           {
                               Header = "Customers",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "MNOs ( Guinetel, Orange Bissau, MTN)"} }, new Columns(){ Body = new List<string>{"Cable Tv (DStv)" } }
                                  }
                              },
                           }
               }, //end of country
                    new Country(){
                   Name = "Ivory Coast",
                    Flag = "https://res.cloudinary.com/fzany-inc/image/upload/v1556201535/flag-of-Equatorial-Guinea_n5xpig.png",
                     Services = new List<Service>()
                     {
                          new Service()
                          {
                              Header ="Mobile Money",
                              Columns = new List<Columns>(){
                                new Columns(){ Body = new List<string>{ "Orange", "MOOV", "YUP"} },
                                new Columns(){ Body = new List<string>{ "MTN", "EU Mobile" } },
                              }
                          },
                           new Service()
                           {
                               Header = "Banks",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "Standard Chartered Bank", "Ecobank" } },
                                  new Columns(){ Body = new List<string>{ "Stanbic Bank", "Bank of Africa" } },
                                  }
                              },
                           new Service()
                           {
                               Header = "Customers",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "MNOs ( Comium, Moov, MTN)"} }, new Columns(){ Body = new List<string>{"Cable Tv (DStv)" } }
                                  }
                              },
                           }
               }, //end of country
                     new Country(){
                   Name = "Kenya",
                    Flag = "https://res.cloudinary.com/fzany-inc/image/upload/v1556201757/flag-of-Kenya_w3gqpq.png",
                     Services = new List<Service>()
                     {
                          new Service()
                          {
                              Header ="Mobile Money",
                              Columns = new List<Columns>(){
                                new Columns(){ Body = new List<string>{ "M-PESA"} },
                                new Columns(){ Body = new List<string>{ "Airtel" } },
                              }
                          },
                           new Service()
                           {
                               Header = "Banks",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "Equity Bank", "Standard Chartered" } },
                                  new Columns(){ Body = new List<string>{ "Barclays Bank", "Kenya Commercial Bank" } },
                                  }
                              },
                           new Service()
                           {
                               Header = "Customers",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "MNOs ( Airtel, Safaricom, Orange)"} },
                                    new Columns(){ Body = new List<string>{ "Cable Tv (DStv, KWESÉ TV, StarTimes)" } }
                                  }
                              },
                           }
               }, //end of country

                      new Country(){
                   Name = "Liberia",
                    Flag = "https://res.cloudinary.com/fzany-inc/image/upload/v1556201795/flag-of-Liberia_sgaggx.png",
                     Services = new List<Service>()
                     {
                          new Service()
                          {
                              Header ="Mobile Money",
                              Columns = new List<Columns>(){
                                new Columns(){ Body = new List<string>{ "Orange" } },
                                new Columns(){ Body = new List<string>{ "MTN" } },
                              }
                          },
                           new Service()
                           {
                               Header = "Banks",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "Guaranty Trust Bank", "UBA" } },
                                  new Columns(){ Body = new List<string>{ "Ecobank", "AccessBank" } },
                                  }
                              },
                           new Service()
                           {
                               Header = "Customers",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "MNOs ( Atlantic Wireless, Novafone, Orange)"} },
                                    new Columns(){ Body = new List<string>{ "Cable Tv (DStv, KWESÉ TV)" } }
                                  }
                              },
                           }
               }, //end of country
                        new Country(){
                   Name = "Madagascar",
                    Flag = "https://res.cloudinary.com/fzany-inc/image/upload/v1556201831/flag-of-Madagascar_n9ctic.png",
                     Services = new List<Service>()
                     {
                          new Service()
                          {
                              Header ="Mobile Money",
                              Columns = new List<Columns>(){
                                new Columns(){ Body = new List<string>{ "Orange", "Airtel" } },
                                new Columns(){ Body = new List<string>{ "Telma" } },
                              }
                          },
                           new Service()
                           {
                               Header = "Banks",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "AccèsBanque", "Bank of Africa" } },
                                  new Columns(){ Body = new List<string>{ "BGFI Bank", "First National Bank" } },
                                  }
                              },
                           new Service()
                           {
                               Header = "Customers",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "MNOs ( Airtel, Orange)"} }, new Columns(){ Body = new List<string>{"Cable Tv (DStv)" } }
                                  }
                              },
                           }
               }, //end of country
                           new Country(){
                   Name = "Malawi",
                    Flag = "https://res.cloudinary.com/fzany-inc/image/upload/v1556201865/flag-of-Malawi_p4ndhm.png",
                     Services = new List<Service>()
                     {
                          new Service()
                          {
                              Header ="Mobile Money",
                              Columns = new List<Columns>(){
                                new Columns(){ Body = new List<string>{ "Airtel" } },
                              }
                          },
                           new Service()
                           {
                               Header = "Banks",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "Ecobank", "Standard Bank" } },
                                  new Columns(){ Body = new List<string>{ "National Bank", "NBS Bank" } },
                                  }
                              },
                           new Service()
                           {
                               Header = "Customers",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "MNOs ( Airtel, Telekom Networks)"} },
                                    new Columns(){ Body = new List<string>{ "Cable Tv (DStv, KWESÉ TV)" } }
                                  }
                              },
                           }
               }, //end of country
                            new Country(){
                   Name = "Mali",
                    Flag = "https://res.cloudinary.com/fzany-inc/image/upload/v1556201908/flag-of-Mali_wxwop4.png",
                     Services = new List<Service>()
                     {
                          new Service()
                          {
                              Header ="Mobile Money",
                              Columns = new List<Columns>(){
                                new Columns(){ Body = new List<string>{ "Orange", "EU Mobile" } },
                                new Columns(){ Body = new List<string>{ "MobiCash", "YUP" } },
                              }
                          },
                           new Service()
                           {
                               Header = "Banks",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "Ecobank", "UBA Mali" } },
                                  new Columns(){ Body = new List<string>{ "Bank of Africa", "Banque" } },
                                  }
                              },
                           new Service()
                           {
                               Header = "Customers",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "MNOs ( Ikatel, Sotel, Malitel S.A)"} }, new Columns(){ Body = new List<string>{"Cable Tv (DStv)" } }
                                  }
                              },
                           }
               }, //end of country
                              new Country(){
                   Name = "Mauritania",
                    Flag = "https://res.cloudinary.com/fzany-inc/image/upload/v1556201945/flag-of-Mauritania_mpdhlz.png",
                     Services = new List<Service>()
                     {
                          new Service()
                          {
                              Header ="Mobile Money",
                              Columns = new List<Columns>(){
                                new Columns(){ Body = new List<string>{ "Mauritel" } },
                              }
                          },
                           new Service()
                           {
                               Header = "Banks",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "BNP Paribas", "Société Générale" } },
                                  new Columns(){ Body = new List<string>{ "Chinguitty Bank", "Banque El Amana" } },
                                  }
                              },
                           new Service()
                           {
                               Header = "Customers",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "MNOs ( Mattel, Chinguitel, Societe Mauritanienne des Telecommunications)"} }, new Columns(){ Body = new List<string>{"Cable Tv (DStv)" } }
                                  }
                              },
                           }
               }, //end of country
                                new Country(){
                   Name = "Mauritius",
                    Flag = "https://res.cloudinary.com/fzany-inc/image/upload/v1556201985/flag-of-Mauritius_tlc7nq.png",
                     Services = new List<Service>()
                     {
                          new Service()
                          {
                              Header ="Mobile Money",
                              Columns = new List<Columns>(){
                                new Columns(){ Body = new List<string>{ "EMTEL" } },
                                 new Columns(){ Body = new List<string>{ "Orange" } },
                              }
                          },
                           new Service()
                           {
                               Header = "Banks",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "Standard Bank", "Bank One" } },
                                  new Columns(){ Body = new List<string>{ "Bank of Baroda", "MauBank" } },
                                  }
                              },
                           new Service()
                           {
                               Header = "Customers",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "MNOs ( Mauritius Telecom, Orange, Emtel)"} }, new Columns(){ Body = new List<string>{"Cable Tv (DStv)" } }
                                  }
                              },
                           }
               }, //end of country
                                 new Country(){
                   Name = "Mozambique",
                    Flag = "https://res.cloudinary.com/fzany-inc/image/upload/v1556202025/flag-of-Mozambique_xvveho.png",
                     Services = new List<Service>()
                     {
                          new Service()
                          {
                              Header ="Mobile Money",
                              Columns = new List<Columns>(){
                                new Columns(){ Body = new List<string>{ "M-PESA" } },
                              }
                          },
                           new Service()
                           {
                               Header = "Banks",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "United Bank for Africa", "Barclays Bank" } },
                                  new Columns(){ Body = new List<string>{ "Standard Bank", "BancABC" } },
                                  }
                              },
                           new Service()
                           {
                               Header = "Customers",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "MNOs ( VM SARL, Vodacom, Telecomunicacoes Moveis de Mocambique, Lda.)"} },
                                    new Columns(){ Body = new List<string>{ "Cable Tv (DStv, StarTimes)" } }
                                  }
                              },
                           }
               }, //end of country
                                   new Country(){
                   Name = "Niger",
                    Flag = "https://res.cloudinary.com/fzany-inc/image/upload/v1556202067/flag-of-Niger_wukt9c.png",
                     Services = new List<Service>()
                     {
                          new Service()
                          {
                              Header ="Mobile Money",
                              Columns = new List<Columns>(){
                                new Columns(){ Body = new List<string>{ "Airtel", "Sonitel", "Orange" } },
                                new Columns(){ Body = new List<string>{ "MOOV", "EU Mobile", "YUP" } },
                              }
                          },
                           new Service()
                           {
                               Header = "Banks",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "Bank of Africa", "Ecobank" } },
                                  new Columns(){ Body = new List<string>{ "Banque Atlantique", "Banque Sahélo-Saharienne" } },
                                  }
                              },
                           new Service()
                           {
                               Header = "Customers",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "MNOs ( Sontel, Airtel, Orange, SahelCom, Moov.)"} },
                                    new Columns(){ Body = new List<string>{ "Cable Tv (DStv, KWESÉ TV)" } }
                                  }
                              },
                           }
               }, //end of country
                                      new Country(){
                   Name = "Nigeria",
                    Flag = "https://res.cloudinary.com/fzany-inc/image/upload/v1556202109/flag-of-Nigeria_rswpyv.png",
                     Services = new List<Service>()
                     {
                          new Service()
                          {
                              Header ="Mobile Money",
                              Columns = new List<Columns>(){
                                new Columns(){ Body = new List<string>{ "Airtel", "ETISALAT", "GLO" } },
                                new Columns(){ Body = new List<string>{ "MTN" } },
                              }
                          },
                           new Service()
                           {
                               Header = "Banks",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "GTB", "Ecobank" } },
                                  new Columns(){ Body = new List<string>{ "FBN", "Zenith Bank" } },
                                  }
                              },
                           new Service()
                           {
                               Header = "Customers",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "MNOs ( MTN, Airtel, GLO, 9 Mobile)"} }, new Columns(){ Body = new List<string>{"Cable Tv (DStv)" } }
                                  }
                              },
                           }
               }, //end of country
                                      new Country(){
                   Name = "Rwanda",
                    Flag = "https://res.cloudinary.com/fzany-inc/image/upload/v1556202153/flag-of-Rwanda_c7e5nb.png",
                     Services = new List<Service>()
                     {
                          new Service()
                          {
                              Header ="Mobile Money",
                              Columns = new List<Columns>(){
                                new Columns(){ Body = new List<string>{ "Airtel", "Tigo", "EU Mobile" } },
                                new Columns(){ Body = new List<string>{ "MTN" } },
                              }
                          },
                           new Service()
                           {
                               Header = "Banks",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "Guaranty Trust Bank", "Access Bank" } },
                                  new Columns(){ Body = new List<string>{ "Ecobank", "Bank of Kigali" } },
                                  }
                              },
                           new Service()
                           {
                               Header = "Customers",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "MNOs ( MTN RwandaCell, Airtel/Tigo)"} },
                                    new Columns(){ Body = new List<string>{ "Cable Tv (DStv, KWESÉ TV, StarTimes)" } }
                                  }
                              },
                           }
               }, //end of country
                                        new Country(){
                   Name = "Senegal",
                    Flag = "https://res.cloudinary.com/fzany-inc/image/upload/v1556202199/flag-of-Senegal_fvb6af.png",
                     Services = new List<Service>()
                     {
                          new Service()
                          {
                              Header ="Mobile Money",
                              Columns = new List<Columns>(){
                                new Columns(){ Body = new List<string>{ "Orange", "Tigo" } },
                                new Columns(){ Body = new List<string>{ "Yup", "EU Mobile" } },
                              }
                          },
                           new Service()
                           {
                               Header = "Banks",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "United Bank for Africa", "Attijariwafa Bank" } },
                                  new Columns(){ Body = new List<string>{ "Ecobank Sénégal", "Citibank Sénégal" } },
                                  }
                              },
                           new Service()
                           {
                               Header = "Customers",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "MNOs ( Expresso, Orange Mobile, Tigo, Sonatel)"} },
                                    new Columns(){ Body = new List<string>{ "Cable Tv (DStv, StarTimes)" } }
                                  }
                              },
                           }
               }, //end of country
                                         new Country(){
                   Name = "Seychelles",
                    Flag = "https://res.cloudinary.com/fzany-inc/image/upload/v1556202243/flag-of-Seychelles_fmja6o.png",
                     Services = new List<Service>()
                     {
                          new Service()
                          {
                              Header ="Mobile Money",
                              Columns = new List<Columns>(){
                                new Columns(){ Body = new List<string>{ "Airtel" } },
                              }
                          },
                           new Service()
                           {
                               Header = "Banks",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "Bank AL Habib", "Bank of Baroda" } },
                                  new Columns(){ Body = new List<string>{ "Bank of Ceylon", "Barclays Bank" } },
                                  }
                              },
                           new Service()
                           {
                               Header = "Customers",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "MNOs ( Airtel, Cable & Wireless (Seychelles) Ltd.)"} }, new Columns(){ Body = new List<string>{"Cable Tv (DStv)" } }
                                  }
                              },
                           }
               }, //end of country
                                           new Country(){
                   Name = "Sierra Leone",
                    Flag = "https://res.cloudinary.com/fzany-inc/image/upload/v1556202293/flag-of-Sierra-Leone_dro66q.png",
                     Services = new List<Service>()
                     {
                          new Service()
                          {
                              Header ="Mobile Money",
                              Columns = new List<Columns>(){
                                new Columns(){ Body = new List<string>{ "Orange" } },
                                new Columns(){ Body = new List<string>{ "Africall" } },
                              }
                          },
                           new Service()
                           {
                               Header = "Banks",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "Ecobank", "United Bank for Africa" } },
                                  new Columns(){ Body = new List<string>{ "Zenith Bank", "First Bank of Nigeria" } },
                                  }
                              },
                           new Service()
                           {
                               Header = "Customers",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "MNOs ( Africell SL, Orange, Comium Sierra Leone)"} },
                                    new Columns(){ Body = new List<string>{ "Cable Tv (DStv, KWESÉ TV, StarTimes)" } }
                                  }
                              },
                           }
               }, //end of country
                     new Country(){
                   Name = "South Sudan",
                    Flag = "https://res.cloudinary.com/fzany-inc/image/upload/v1556202398/flag-of-South-Sudan_ymrjvc.png",
                     Services = new List<Service>()
                     {
                          new Service()
                          {
                              Header ="Mobile Money",
                              Columns = new List<Columns>(){
                                new Columns(){ Body = new List<string>{ "MTN" } },
                              }
                          },
                           new Service()
                           {
                               Header = "Banks",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "Ecobank South Sudan Limited", "Qatar National Bank" } },
                                  new Columns(){ Body = new List<string>{ "Afriland First Bank", "CFC Stanbic Bank" } },
                                  }
                              },
                           new Service()
                           {
                               Header = "Customers",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "MNOs ( MTN, Sudatel, Zain ,Vivacell)"} },
                                    new Columns(){ Body = new List<string>{ "Cable Tv (DStv, KWESÉ TV)" } }
                                  }
                              },
                           }
               }, //end of country
                        new Country(){
                   Name = "Tanzania",
                    Flag = "https://res.cloudinary.com/fzany-inc/image/upload/v1556202456/flag-of-Tanzania_fqgjvy.png",
                     Services = new List<Service>()
                     {
                          new Service()
                          {
                              Header ="Mobile Money",
                              Columns = new List<Columns>(){
                                new Columns(){ Body = new List<string>{ "M-PESA", "Tigo" } },
                                new Columns(){ Body = new List<string>{ "Airtel", } },
                              }
                          },
                           new Service()
                           {
                               Header = "Banks",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "Ecobank", "Diamond Trust Bank" } },
                                  new Columns(){ Body = new List<string>{ "Stanbic Bank", "United Bank for Africa" } },
                                  }
                              },
                           new Service()
                           {
                               Header = "Customers",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "MNOs ( Airtel, Tigo, Benson Infomatics, ZanTel)"} },
                                    new Columns(){ Body = new List<string>{ "Cable Tv (DStv, KWESÉ TV, StarTimes)" } }
                                  }
                              },
                           }
               }, //end of country
                           new Country(){
                   Name = "Togo",
                    Flag = "https://res.cloudinary.com/fzany-inc/image/upload/v1556202505/flag-of-Togo_zuimyy.png",
                     Services = new List<Service>()
                     {
                          new Service()
                          {
                              Header ="Mobile Money",
                              Columns = new List<Columns>(){
                                new Columns(){ Body = new List<string>{ "Togocel", "MOOV" } },
                                new Columns(){ Body = new List<string>{ "EU Mobile","YUP" } },
                              }
                          },
                           new Service()
                           {
                               Header = "Banks",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "Ecobank Togo", "Banque Atlantique Togo" } },
                                  new Columns(){ Body = new List<string>{ "Banque Sahélo-Saharienne pour l'Investissement et le Commerce" } },
                                  }
                              },
                           new Service()
                           {
                               Header = "Customers",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "MNOs ( Moov, Togo Cellulaire)"} }, new Columns(){ Body = new List<string>{"Cable Tv (DStv)" } },
                                  new Columns(){ Body = new List<string>{ "Power (The Electric Power Company duTogo (CEET) Smart Meter)" } },
                                  }
                              },
                           }
               }, //end of country
                              new Country(){
                   Name = "Uganda",
                    Flag = "https://res.cloudinary.com/fzany-inc/image/upload/v1556202555/flag-of-Uganda_jxzfj9.png",
                     Services = new List<Service>()
                     {
                          new Service()
                          {
                              Header ="Mobile Money",
                              Columns = new List<Columns>(){
                                new Columns(){ Body = new List<string>{ "Africall", "Airtel" } },
                                new Columns(){ Body = new List<string>{ "MTN" } },
                              }
                          },
                           new Service()
                           {
                               Header = "Banks",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "Stanbic Bank", "Guaranty Trust Bank" } },
                                  new Columns(){ Body = new List<string>{ "United Bank for Africa" } },
                                  }
                              },
                           new Service()
                           {
                               Header = "Customers",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "MNOs ( MTN, Airtel, Africall)"} },
                                    new Columns(){ Body = new List<string>{ "Cable Tv (DStv, KWESÉ TV, StarTimes)" } },
                                  }
                              },
                           }
               }, //end of country
                                new Country(){
                   Name = "Zambia",
                    Flag = "https://res.cloudinary.com/fzany-inc/image/upload/v1556202609/flag-of-Zambia_cjir9u.png",
                     Services = new List<Service>()
                     {
                          new Service()
                          {
                              Header ="Mobile Money",
                              Columns = new List<Columns>(){
                                new Columns(){ Body = new List<string>{ "Airtel" } },
                                new Columns(){ Body = new List<string>{ "MTN" } },
                              }
                          },
                           new Service()
                           {
                               Header = "Banks",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "Access Bank", "Ecobank" } },
                                  new Columns(){ Body = new List<string>{ "United Bank for Africa" } },
                                  }
                              },
                           new Service()
                           {
                               Header = "Customers",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "MNOs ( MTN, Airtel, Zamtel)"} },
                                    new Columns(){ Body = new List<string>{ "Cable Tv (DStv, KWESÉ TV)" } },
                                  }
                              },
                           }
               }, //end of country
                                    new Country(){
                   Name = "Zimbabwe",
                    Flag = "https://res.cloudinary.com/fzany-inc/image/upload/v1556202662/flag-of-Zimbabwe_pk0uhy.png",
                     Services = new List<Service>()
                     {
                          new Service()
                          {
                              Header ="Mobile Money",
                              Columns = new List<Columns>(){
                                new Columns(){ Body = new List<string>{ "EcoCash" } },
                                new Columns(){ Body = new List<string>{ "NetOne" } },
                              }
                          },
                           new Service()
                           {
                               Header = "Banks",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "Standard Chartered", "Ecobank" } },
                                  new Columns(){ Body = new List<string>{ "Barclays Bank of Zimbabwe" } },
                                  }
                              },
                           new Service()
                           {
                               Header = "Customers",
                                Columns = new List<Columns>(){
                                  new Columns(){ Body = new List<string>{ "MNOs ( Net.One, Telcel, econet Wireless)"} },
                                    new Columns(){ Body = new List<string>{ "Cable Tv (DStv, KWESÉ TV)" } },
                                  }
                              },
                           }
               }, //end of country
            };
        }

    }

}