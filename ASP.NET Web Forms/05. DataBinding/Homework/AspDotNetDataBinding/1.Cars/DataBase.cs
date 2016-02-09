using System.Collections.Generic;

namespace Cars
{
    public class DataBase
    {
        public static Producer[] cars = new[]
        {
            new Producer
            {
                Name = "BMW",
                Models = new List<Model>
                {
                    new Model
                    {
                        Name = "320",
                        TypeOfEngine = EnumEngine.Gas,
                        Extras = new List<EnumExtra> {
                            EnumExtra.ABS,
                            EnumExtra.ESP
                        }
                    },
                    new Model
                    {
                        Name = "750",
                        TypeOfEngine = EnumEngine.Benzin,
                        Extras = new List<EnumExtra> {
                            EnumExtra.DVDTV,
                            EnumExtra.ESP
                        }
                    },
                    new Model
                    {
                        Name = "M3",
                        TypeOfEngine = EnumEngine.Benzin,
                        Extras = new List<EnumExtra> {
                            EnumExtra.ABS,
                            EnumExtra.ESP
                        }
                    }
                }
            },
            new Producer
            {
                Name = "Audi",
                Models = new List<Model>
                {
                    new Model
                    {
                        Name = "A4",
                        TypeOfEngine = EnumEngine.Diesel,
                        Extras = new List<EnumExtra> {
                            EnumExtra.ABS,
                            EnumExtra.ESP,
                            EnumExtra.DVDTV
                        }
                    },
                    new Model
                    {
                        Name = "RS5" ,
                        TypeOfEngine = EnumEngine.Benzin,
                        Extras = new List<EnumExtra> {
                            EnumExtra.ABS,
                            EnumExtra.ESP,
                            EnumExtra.FourXFour,
                            EnumExtra.DVDTV
                        }
                    },
                    new Model
                    {
                        Name = "Q7",
                        TypeOfEngine = EnumEngine.Diesel,
                        Extras = new List<EnumExtra> {
                            EnumExtra.ABS,
                            EnumExtra.ESP,
                            EnumExtra.DVDTV,
                            EnumExtra.FourXFour
                        }
                    }
                }
            },
            new Producer
            {
                Name = "VW",
                Models = new List<Model>
                {
                    new Model
                    {
                        Name = "Golf",
                        TypeOfEngine = EnumEngine.Diesel
                    },
                    new Model
                    {
                        Name = "Passat",
                        TypeOfEngine = EnumEngine.Diesel
                    },
                    new Model
                    {
                        Name = "Sharan",
                        TypeOfEngine = EnumEngine.Diesel
                    }
                }
            },
            new Producer
            {
                Name = "Opel",
                Models = new List<Model>
                {
                    new Model
                    {
                        Name = "Vectra",
                        TypeOfEngine = EnumEngine.Diesel
                    },
                    new Model
                    {
                        Name = "Astra",
                        TypeOfEngine = EnumEngine.Diesel
                    },
                    new Model
                    {
                        Name = "Zafira",
                        TypeOfEngine = EnumEngine.Diesel
                    }
                }
            }
        };
    }
}
