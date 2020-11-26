namespace test.Models
{
    public class Founder
    {
        public int FounderId { get; set; }
        public int INN_founder { get; set; } //ИНН учередителя
        public string Full_name_founder { get; set; } //ФИО учередителя
        public string Date_added_founder { get; set; } //Дата добавления
        public string Date_update_founder { get; set; } //Дата обновления
        public int ClientId { get; set; } //ссылка на организацию
        public Client Client { get; set; }
    }
}
