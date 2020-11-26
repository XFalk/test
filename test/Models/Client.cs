namespace test.Models
{
    public class Client
    {
       
        public int ClientId { get; set; }
        public int INN_client { get; set; } //ИНН клиента(компании)
        public string Name_client { get; set; } //Наименование клиента
        public string Type_client { get; set; } //Тип клиента (ИП или ЮЛ)
        public string Date_added_client { get; set; } //Дата добавления
        public string Date_update_client { get; set; } //Дата обновления
    }
}
