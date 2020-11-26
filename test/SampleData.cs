using System.Linq;
using test.Models;

namespace test
{
    public static class SampleData
    {
        public static void Initialize(ClientContext context)
        {
            if (!context.Clients.Any())
            {
                context.Clients.AddRange(
                    new Client
                    {
                        INN_client = 12345678,
                        Name_client = "Ромашка",
                        Type_client = "ЮЛ",
                        Date_added_client = "сейчас это тест",
                        Date_update_client = "И это"
                    },
                    new Client
                    {
                        INN_client = 12345678,
                        Name_client = "Одуванчик",
                        Type_client = "ИП",
                        Date_added_client = "сейчас это тест",
                        Date_update_client = "И это"
                    },
                    new Client
                    {
                        INN_client = 12345678,
                        Name_client = "Полынь",
                        Type_client = "ИП",
                        Date_added_client = "сейчас это тест",
                        Date_update_client = "И это"
                    }); ;
                context.SaveChanges();
            }
        }
    }
}
